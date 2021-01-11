Imports System.Security.Principal
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop


'select locid, sum(chmontantHtLoc),chargeHT,sum(chmontantHtLoc) - chargeHT  from temprepartcharge
'group by locid,chargeht
'order by locid

'SELECT    ComptaGene.ecrDate, ComptaGene.Journal, ComptaGene.categorie,  
'                         ComptaGene.ecrLib, ComptaGene.ecrMontantHT, ComptaGene.ecrMontantTVA, ComptaGene.ecrMontantTTC, ComptaGene.NumFacture, 
'						 ComptaGene.numfactureInterne, locataire.CptSuffixe, ComptaPlan.CptNum, 
'						 ComptaPlan.CptNom
'FROM            ComptaGene INNER JOIN
'                         locataire ON ComptaGene.LocId = locataire.LocId LEFT OUTER JOIN
'                         ComptaPlan ON ComptaGene.RubId = ComptaPlan.RubId AND ComptaGene.LocId = ComptaPlan.LocId
'WHERE        (ComptaGene.Rubrique = 'Locataire') AND (ComptaGene.LocId = 111)
'ORDER BY ComptaGene.ecrDate, ComptaGene.ecrid

Public Module Common
    Public conSql As New OleDb.OleDbConnection
    Public debug As Boolean
    Public debugAppel As Boolean
    Public appXL As New Microsoft.Office.Interop.Excel.Application
    Public lIndexPiece As Integer = 0
    Dim sepDec As String = System.Globalization.CultureInfo.InstalledUICulture.NumberFormat.NumberDecimalSeparator


    'Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=LVTEST;Data Source=bisrv;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=LAUVAL-PORT;Use Encryption for Data=False;Tag with column collation when possible=False
    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Develop\Siano\LocBdD.accdb
    'Provider=SQLOLEDB.1;Server=tcp:valky57.database.windows.net;Database=MULTILOC;User ID=V@lca5ara@valky57;Password=V@lky*03;Trusted_Connection=False;Encrypt=True;
    'Driver={SQL Server Native Client 11.0};Server=tcp:valky57.database.windows.net,1433;Database=MULTILOC;Uid=V@lca5ara@valky57;Pwd={your_password_here};Encrypt=yes;TrustServerCertificate=no;Connection Timeout=30;
#Region "Divers"

    Public Sub StatutBar(s As String)
        F_main.sLabel.Text = s
        F_main.StatusStrip.Refresh()
    End Sub


    Function Max(ByVal a As Integer, ByVal b As Integer) As Integer
        If a > b Then Return a Else Return b
    End Function

    Function Min(ByVal a As Integer, ByVal b As Integer) As Integer
        If a < b Then Return a Else Return b
    End Function

    Function MinDate(ByVal a As Date, ByVal b As Date) As Date
        If a < b Then Return a Else Return b
    End Function

    Function MaxDate(ByVal a As Date, ByVal b As Date) As Date
        If a < b Then Return b Else Return a
    End Function

    Public Function nz(ByVal o As Object, ByVal valeurNull As Object) As String
        Try
            If IsDBNull(o) Or IsNothing(o) Then Return valeurNull Else Return o
        Catch ex As Exception
            Return valeurNull
        End Try
    End Function



    Public Function testnum(mini As Integer, i As Integer, chaine As String) As Integer
        'si les mini% caractères à partir de i% sont numériques, alors mini%=0
        'if the mini% characters from i% are numeric, then mini%=0
        mini = mini - 1
        If i + mini <= Len(chaine) Then
            Do While mini >= 0
                If Asc(Mid$(chaine, i + mini, 1)) < 48 Or Asc(Mid$(chaine, i + mini, 1)) > 57 Then Exit Do
                mini = mini - 1
            Loop
        End If
        Return mini
    End Function

    Public Function code128(chaine As String)
        'Cette fonction est régie par la Licence Générale Publique Amoindrie GNU (GNU LGPL)
        'This function is governed by the GNU Lesser General Public License (GNU LGPL)
        'V 2.0.0
        'Paramètres : une chaine
        'Parameters : a string
        'Retour : * une chaine qui, affichée avec la police CODE128.TTF, donne le code barre
        '         * une chaine vide si paramètre fourni incorrect
        'Return : * a string which give the bar code when it is dispayed with CODE128.TTF font
        '         * an empty string if the supplied parameter is no good
        Dim lecode As String
        Dim i As Integer, checksum As Integer, mini As Integer, dummy As Integer, tableB As Boolean
        lecode = ""
        If Len(chaine) > 0 Then
            'Vérifier si caractères valides
            'Check for valid characters
            For i = 1 To Len(chaine)
                Select Case Asc(Mid$(chaine, i, 1))
                    Case 32 To 126, 203
                    Case Else
                        i = 0
                        Exit For
                End Select
            Next
            'Calculer la chaine de code en optimisant l'usage des tables B et C
            'Calculation of the code string with optimized use of tables B and C
            lecode = ""
            tableB = True
            If i > 0 Then
                i = 1 'i% devient l'index sur la chaine / i% become the string index
                Do While i <= Len(chaine)
                    If tableB Then
                        'Voir si intéressant de passer en table C / See if interesting to switch to table C
                        'Oui pour 4 chiffres au début ou à la fin, sinon pour 6 chiffres / yes for 4 digits at start or end, else if 6 digits
                        mini = IIf(i = 1 Or i + 3 = Len(chaine), 4, 6)
                        mini = testnum(mini, i, chaine)
                        If mini < 0 Then 'Choix table C / Choice of table C
                            If i = 1 Then 'Débuter sur table C / Starting with table C
                                lecode = Chr(210)
                            Else 'Commuter sur table C / Switch to table C
                                lecode = lecode & Chr(204)
                            End If
                            tableB = False
                        Else
                            If i = 1 Then lecode = Chr(209) 'Débuter sur table B / Starting with table B
                        End If
                    End If
                    If Not tableB Then
                        'On est sur la table C, essayer de traiter 2 chiffres / We are on table C, try to process 2 digits
                        mini = 2
                        mini = testnum(mini, i, chaine)
                        If mini < 0 Then 'OK pour 2 chiffres, les traiter / OK for 2 digits, process it
                            dummy = Val(Mid$(chaine, i, 2))
                            dummy = IIf(dummy < 95, dummy + 32, dummy + 105)
                            lecode = lecode & Chr(dummy)
                            i = i + 2
                        Else 'On n'a pas 2 chiffres, repasser en table B / We haven't 2 digits, switch to table B
                            lecode = lecode & Chr(205)
                            tableB = True
                        End If
                    End If
                    If tableB Then
                        'Traiter 1 caractère en table B / Process 1 digit with table B
                        lecode = lecode & Mid$(chaine, i, 1)
                        i = i + 1
                    End If
                Loop
                'Calcul de la clé de contrôle / Calculation of the checksum
                For i = 1 To Len(lecode)
                    dummy = Asc(Mid$(lecode, i, 1))
                    dummy = IIf(dummy < 127, dummy - 32, dummy - 105)
                    If i = 1 Then checksum = dummy
                    checksum = (checksum + (i% - 1) * dummy) Mod 103
                Next
                'Calcul du code ASCII de la clé / Calculation of the checksum ASCII code
                checksum = IIf(checksum < 95, checksum + 32, checksum + 105)
                'Ajout de la clé et du STOP / Add the checksum and the STOP
                lecode = lecode & Chr(checksum) & Chr(211)
            End If
        End If
        Return lecode
    End Function

    Function num2sql(t As String) As String
        If nz(t, "") = "" Then
            Return "0"
        Else
            Return Val(t.Replace(",", ".")).ToString.Replace(",", ".")
        End If
    End Function

    Function num2txt(b As Double) As String
        Return b.ToString.Replace(".", ",")
    End Function

    Function txt2num(t As String) As Decimal
        If t = "" Then
            Return 0
        Else
            Return Val(t.Replace(",", "."))
        End If
    End Function

    Function sql2num(o As Object) As Decimal
        Dim a As Decimal
        a = nz(o, 0)
        Return a
    End Function

    Function txt2sql(s As String) As String
        Return s.Replace("'", "''").Replace(",", ".")
    End Function

    Function Date2sql(d As Date) As String
        If IsDBNull(d) Then
            Return "NULL"
        Else
            Return "'" & d.ToString("yyyy-MM-dd") & "'"
        End If

    End Function

    Function SqlDate(d As DateTimePicker) As String
        Return "'" & d.Value.ToString("yyyy-MM-dd") & "'"
    End Function

    Function date2Grid(d As Object) As String
        Dim s As String = ""

        If Not IsDBNull(d) Then
            Dim laDate As Date = d
            If laDate.Year < 2099 Then s = laDate.ToString("dd/MM/yyyy")
        End If
        Return s
    End Function

    Function date2Xl(d As Object) As String
        Dim s As String = ""

        If Not IsDBNull(d) Then
            Dim laDate As Date = d
            If laDate.Year < 2099 Then s = "'" & laDate.ToString("dd/MM/yyyy")
        End If
        Return s
    End Function

    Function FindeMois(d As Date) As Date
        Return d.AddDays(-d.Day + 1).AddMonths(1).AddDays(-1)
    End Function

    Function repNom(s As String) As String
        If s.Substring(s.Length - 1, 1) <> "\" Then s &= "\"
        Return s
    End Function


#End Region

#Region "SQL"

    Public Class SQLchamp
        Public champNom As String
        Public champVal As String
        Public champTyp As Char
        Public champObl As Boolean

        Public Sub New(ByVal champ As Object, ByVal valeur As String, type As Char)
            champNom = champ
            champVal = valeur
            champTyp = type
        End Sub
    End Class

    Sub ConnexionInit(ByVal strCon As String, ByRef consql As OleDb.OleDbConnection)
        Try
            consql.ConnectionString = strCon
        Catch ex As Exception
            Throw New Exception("Erreur d'initialisation de connexion")
        End Try
    End Sub

    Sub ConnexionFerme(ByRef consql As OleDb.OleDbConnection)
        Try
            If consql.State = ConnectionState.Open Then consql.Close()
        Catch ex As Exception
            Throw New Exception("Erreur fermeture connexion")
        End Try
    End Sub

    Public Function ConnexionTest(ByVal strCon As String) As Boolean
        Dim conSql As New OleDb.OleDbConnection
        Try
            If conSql.State = ConnectionState.Open Then conSql.Close()
            conSql.ConnectionString = strCon
            conSql.Open()
            conSql.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function sqlDo(ByVal s As String, ByVal consql As OleDb.OleDbConnection, Optional ByVal b As Boolean = True) As Integer
        Dim lareq As New OleDb.OleDbCommand

        lareq.CommandText = s
        lareq.Connection = consql
        lareq.CommandType = CommandType.Text

        Try
            If consql.State <> ConnectionState.Open Then consql.Open()
            lareq.ExecuteNonQuery()
            Return 0
        Catch ex As Exception
            If b Then MsgBox(ex.Message & s)
            'Throw New Exception("Erreur Execution requête")
        End Try
    End Function

    Function sqlLit(ByVal s As String, ByVal consql As OleDb.OleDbConnection) As OleDb.OleDbDataReader
        Dim lareq As New OleDb.OleDbCommand

        lareq.CommandText = s
        lareq.Connection = consql
        lareq.CommandType = CommandType.Text

        Try
            If consql.State <> ConnectionState.Open Then consql.Open()
            Return lareq.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message & s)
            Throw New Exception("Erreur Requête Lecture")
            Return Nothing
        End Try
    End Function




#End Region

#Region "Liste Combo"



    Public Class ListItem
        Public Value As Object
        Public Text As String

        Public Sub New(ByVal NewValue As Object, ByVal NewText As String)
            Value = NewValue
            Text = NewText
        End Sub

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Public Sub ComboRempli(ByVal leSql As String, ByVal laCombo As Object, ByVal consql As OleDb.OleDbConnection, Optional ByVal AcceptVide As Boolean = True)
        Dim ligne As Boolean = False
        Dim lers As OleDb.OleDbDataReader
        Dim laValeur As Integer = 0

        If laCombo.SelectedIndex >= 0 Then laValeur = laCombo.SelectedItem.value
        lers = sqlLit(leSql, consql)
        laCombo.Items.Clear()
        While lers.Read
            ligne = True
            If lers.FieldCount > 1 Then
                laCombo.Items.Add(New ListItem(lers(0), nz(lers(1).ToString, "")))
            Else
                laCombo.Items.Add(lers(0))
            End If
        End While
        lers.Close()
        If Not AcceptVide Then laCombo.Enabled = ligne
        If laValeur <> 0 Then Call ComboSelectValue(laValeur, laCombo)
    End Sub

    Public Sub ComboSelectTxt(ByVal laValeur As String, ByVal laCombo As Windows.Forms.ComboBox)
        laCombo.SelectedIndex = -1
        laCombo.Text = ""
        For i = 0 To laCombo.Items.Count - 1
            If laCombo.Items(i).text = laValeur Then laCombo.SelectedIndex = i
        Next
    End Sub

    Public Sub ComboSelectValue(ByVal laValeur As String, ByVal laCombo As Windows.Forms.ComboBox)
        laCombo.SelectedIndex = -1
        laCombo.Text = ""
        For i = 0 To laCombo.Items.Count - 1
            If laCombo.Items(i).value = laValeur Then laCombo.SelectedIndex = i
        Next
    End Sub
#End Region

#Region "Lots"

    Sub LotLib(leLotid As Integer)
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader

        'Recherche liste des locataire concernés
        sSql = "select locid from location where lotid=" & leLotid
        leRs = sqlLit(sSql, conSql)
        While leRs.Read
            'mise a jour du locataire
            Call locLotLibMAJ(leRs("locid"))
        End While
        leRs.Close()
    End Sub
#End Region

#Region "locataire"
    Public Class LocStatut
        Public Function occupe() As String
            Return "Occupé"
        End Function

        Public Function preavis() As String
            Return "Préavis"
        End Function

        Public Function sorti() As String
            Return "Libre"
        End Function
    End Class

    Function loclotlib(lelocat As Integer, ladateDeb As Date, laDateFin As Date) As String
        Dim sSql As String
        Dim leRs As OleDb.OleDbDataReader


        'Recherche liste des biens
        sSql = "select tlocalnom,lotnom,batiment, coproNom,copro.Adr1,copro.codePostal, Copro.localite,location.surface,datefin" _
            & " from location" _
            & " inner join lot on location.lotid = lot.lotId" _
            & " left join typelocal on typelocal.[TlocalId]=lot.[TLocalId]" _
            & " left join copro on lot.coproid = copro.coproid" _
            & " where locId = " & lelocat _
            & " and (datefin is null or datefin >=" & Date2sql(laDateFin) & " ) " _
            & " and (datedebut<=" & Date2sql(ladateDeb) & ")  order by location.surface desc"

        leRs = sqlLit(sSql, conSql)
        Dim lesBiens As String = ""
        While leRs.Read
            If lesBiens = "" Then
                lesBiens = leRs(0).ToString & " N°" & leRs(1).ToString
            Else
                If nz(leRs("surface"), 0) <> 0 And Not lesBiens.Contains(leRs(0).ToString & " N°" & leRs(1).ToString) Then
                    lesBiens &= ", " & leRs(0).ToString & " N°" & leRs(1).ToString
                End If
            End If
        End While
        leRs.Close()

        Return lesBiens
    End Function

    Sub locLotLibMAJ(leLocat As Integer)
        Dim sSql As String
        Dim lesBiens As String = loclotlib(leLocat, Now, Now)

        'Mise à jour locataire
        If lesBiens.Length > 200 Then lesBiens = lesBiens.Substring(0, 200)
        If lesBiens <> "" Then
            sSql = "Update locataire set lotlib = '" & lesBiens & "' where locid=" & leLocat
            sqlDo(sSql, conSql)
        End If
    End Sub

#End Region

#Region "Compta"
    Public Enum ecrType As Integer
        LocAppelLoyer = 1
        LocAppelCharge = 2
        LocAppelDG = 3
        LocRepriseDG = 4
        SocChargeExt = 5
        LocChargeInt = 6
        CoprochargeExt = 7
        CoprochargeInt = 8
        LocEncaisse = 9
        FourPaiement = 14
        LocChargeExt = 15
        LocRemboursement = 16
        locRevLoyer = 17
        locAvoirLoyer = 18
        locAvoirCharge = 19
        ChargeReprise = 20
        ChargeReel = 21
        locAvoirDG = 22
        ClientFacture = 23
        ClientEncaisse = 24
    End Enum

    Class EcritureCompta
        Public DateEcr As Date
        Public Echeance As Date
        Public Piece As Integer
        Public LocId As Integer
        Public CoproId As Integer
        Public FourId As Integer
        Public CliId As Integer
        Public SocId As Integer
        Public cleId As Integer
        Public CompteId As Integer
        Public Libelle As String
        Public MontantHT As Decimal
        Public MontantTTC As Decimal
        Public PartLoc As Decimal
        Public NumFacture As String
        Public CptBkid As Integer
        Public DateDeb As Date
        Public DateFin As Date
        Public IndiceRevision As Integer
        Public NumFactInterne As String
        Public AnneeEffet As Integer
        Public rubId As Integer

        Sub New(laDate As Date, lEcheance As Date, laPiece As Integer, leLoc As Integer, laCopro As Integer, leFour As Integer, leCli As Integer, laSocId As Integer, leCptBkId As Integer, lacleId As Integer, LeCompteId As Integer, LeLibelle As String, LeMontantHT As Decimal, leMontantTTC As Decimal, LaPartLoc As Decimal, LaFacture As String, LadateDeb As Date, laDateFin As Date, lindiceRevisionId As Integer, LaFactInt As String, lAnneeEffet As Integer, Larubid As Integer)
            DateEcr = laDate
            Echeance = lEcheance
            Piece = laPiece
            SocId = laSocId
            cleId = lacleId
            CompteId = LeCompteId
            Libelle = LeLibelle
            MontantHT = LeMontantHT
            MontantTTC = leMontantTTC
            PartLoc = LaPartLoc
            NumFacture = LaFacture
            LocId = leLoc
            CoproId = laCopro
            FourId = leFour
            CliId = leCli
            CptBkid = leCptBkId
            DateDeb = LadateDeb
            DateFin = laDateFin
            IndiceRevision = lindiceRevisionId
            NumFactInterne = LaFactInt
            AnneeEffet = lAnneeEffet
            rubid = larubid
        End Sub

        Public Function montantTVA() As Decimal
            Return MontantTTC - MontantHT
        End Function

        Public Function PartProprio() As Decimal
            Return (100 - PartLoc)
        End Function
    End Class

    Public Function NextNumPiece() As Integer
        Dim lers As OleDb.OleDbDataReader
        Dim LapieceLoc As Integer = 0
        Dim LapieceSociete As Integer = 0

        lIndexPiece = 0
        'cherche le prochain numero de piece
        lers = sqlLit("select max(numpiece) as numpiece from ComptaGene", conSql)
        If lers.HasRows Then
            lers.Read()
            LapieceSociete = nz(lers(0), 0) + 1
        Else
            LapieceSociete = 1
        End If
        lers.Close()
        Return Max(LapieceLoc, LapieceSociete)
    End Function

    Function nextFactInterne(laSocId As Integer, lAnnee As Integer) As String
        'Dim ssql As String
        'Dim lers As OleDb.OleDbDataReader
        'Dim NumFact As Integer
        'ssql = "select max(numFactureInterne) as numfact from ComptaGene where Tiers='SOCIETE' and socid= " & laSocId & " and numfactureInterne like '" & lAnnee & "%'"
        'lers = sqlLit(ssql, conSql)
        'NumFact = 0
        'While lers.Read
        '    If nz(lers("numfact").ToString, "") <> "" Then
        '        NumFact = Val(lers("numfact").ToString.Substring(5, 5))
        '    End If
        'End While
        'lers.Close()
        'NumFact += 1
        'Return lAnnee & "-" & NumFact.ToString.PadLeft(5, "0")

        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader
        Dim NumFact As Integer
        ssql = "select max(numFactureInterne) as numfact from ComptaGene where Tiers='SOCIETE' and socid= " & laSocId & " and year(ecrdate)=" & lAnnee
        lers = sqlLit(ssql, conSql)
        NumFact = lAnnee * 10000
        While lers.Read
            If nz(lers("numfact").ToString, "") <> "" Then NumFact = lers("numfact")
        End While
        lers.Close()
        NumFact += 1
        Return NumFact.ToString
    End Function

    Function nextFacture(laSocId As Integer, lAnnee As Integer) As String
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader
        Dim NumFact As Integer
        ssql = "select max(numFacture) as numfact from ComptaGene where Tiers='SOCIETE' and socid= " & laSocId & " and numfacture like 'FA" & lAnnee & "%'"
        lers = sqlLit(ssql, conSql)
        NumFact = lAnnee * 10000
        While lers.Read
            If nz(lers("numfact").ToString, "") <> "" Then
                NumFact = Val(lers("numfact").ToString.Substring(2, 8))
            End If
        End While
        lers.Close()
        NumFact += 1
        Return "FA" & NumFact.ToString.PadLeft(3, "0")

    End Function


    Sub Gridcalculsolde(laGrid As Windows.Forms.DataGridView)
        Dim leSolde As Double = 0
        For i = laGrid.Rows.Count - 1 To 0 Step -1
            leSolde += laGrid.Rows(i).Cells("credit").Value - laGrid.Rows(i).Cells("debit").Value
            laGrid.Rows(i).Cells("Solde").Value = leSolde
        Next
    End Sub

    Function GridTotalColonne(laGrid As Windows.Forms.DataGridView, laColonne As String) As Decimal
        Dim leSolde As Double = 0
        For i = laGrid.Rows.Count - 1 To 0 Step -1
            leSolde += laGrid.Rows(i).Cells(laColonne).Value
        Next
        Return leSolde
    End Function

    Sub EnregCompta(lEcr As EcritureCompta, leType As ecrType)
        Dim sSql1 As String = "", sSql2 As String
        Dim leJournal As String = ""
        Dim leTiers As String = ""
        Dim laCategorie As String = ""

        Select Case leType
            Case ecrType.LocAppelLoyer : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "LOYER"
            Case ecrType.locAvoirLoyer : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "LOYER"
            Case ecrType.LocAppelCharge : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "PROVCHARGE"
            Case ecrType.locAvoirCharge : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "PROVCHARGE"
            Case ecrType.LocAppelDG : leJournal = "DEPOT" : leTiers = "SOCIETE" : laCategorie = "APPELDG"
            Case ecrType.LocRepriseDG : leJournal = "DEPOT" : leTiers = "LOCATAIRE" : laCategorie = "REPRISEDG"
            Case ecrType.locAvoirDG : leJournal = "DEPOT" : leTiers = "LOCATAIRE" : laCategorie = "AVOIRDG"
            Case ecrType.LocRemboursement : leJournal = "BANQUE" : leTiers = "BANQUE" : laCategorie = "DECAISSEMENT"
            Case ecrType.LocEncaisse : leJournal = "BANQUE" : leTiers = "LOCATAIRE" : laCategorie = "ENCAISSEMENT"
            Case ecrType.LocChargeExt : leJournal = "ACHATS" : leTiers = "FOURNISSEUR" : laCategorie = "CHARGE"
            Case ecrType.LocChargeInt : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "CHARGE"
            Case ecrType.SocChargeExt : leJournal = "ACHATS" : leTiers = "FOURNISSEUR" : laCategorie = "CHARGE"
            Case ecrType.CoprochargeExt : leJournal = "ACHATS" : leTiers = "FOURNISSEUR" : laCategorie = "CHARGE"
            Case ecrType.CoprochargeInt : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "CHARGE"
            Case ecrType.FourPaiement : leJournal = "BANQUE" : leTiers = "BANQUE" : laCategorie = "DECAISSEMENT"
            Case ecrType.locRevLoyer : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "LOYER"
            Case ecrType.ChargeReprise : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "REGULPROV"
            Case ecrType.ChargeReel : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "REGULREEL"
            Case ecrType.ClientFacture : leJournal = "VENTES" : leTiers = "SOCIETE" : laCategorie = "VENTE"
            Case ecrType.ClientEncaisse : leJournal = "BANQUE" : leTiers = "CLIENT" : laCategorie = "ENCAISSEMENT"
        End Select

        lIndexPiece += 1

        sSql1 = "insert into comptagene (ecrDate, ecrEcheance, numpiece, socId, locId, coproId, fourId, cliId, cptBkid " _
        & " , cleId, cptId, numFacture, partLocataire, partProprio, indRevisionId, DateDebut, dateFin,NumFactureInterne,AnneeEffet,IndexPiece,journal, Tiers, categorie, ecrlib, ecrmontantHt, ecrMontantTVA, ecrMontantTTC,rubId) " _
        & " values (" & Date2sql(lEcr.DateEcr) & "," & Date2sql(lEcr.Echeance) & "," & lEcr.Piece & "," & lEcr.SocId & "," & lEcr.LocId & "," & lEcr.CoproId & "," & lEcr.FourId & "," & lEcr.CliId & "," & lEcr.CptBkid _
        & "," & lEcr.cleId & "," & lEcr.CompteId & ",'" & txt2sql(lEcr.NumFacture) & "'," & num2sql(lEcr.PartLoc) & "," & num2sql(lEcr.PartProprio) & "," & num2sql(lEcr.IndiceRevision) & "," & Date2sql(lEcr.DateDeb) _
        & "," & Date2sql(lEcr.DateFin) & ",'" & lEcr.NumFactInterne & "'," & lEcr.AnneeEffet & "," & lIndexPiece

        sSql2 = ",'" & leJournal & "','" & leTiers & "','" & laCategorie & "','" & txt2sql(lEcr.Libelle) _
        & "','" & num2sql(lEcr.MontantHT) & "','" & num2sql(lEcr.montantTVA) & "','" & num2sql(lEcr.MontantTTC) & "'," & lEcr.rubId & ")"

        sqlDo(sSql1 & sSql2, conSql)


        'ON ecrit la contrepartie negative
        leTiers = "LOCATAIRE" ' par defaut
        Select Case leType
            Case ecrType.LocRepriseDG : leTiers = "SOCIETE"
            Case ecrType.LocEncaisse : leTiers = "BANQUE"
            Case ecrType.SocChargeExt : leTiers = "SOCIETE"
            Case ecrType.CoprochargeExt : leTiers = "COPRO"
            Case ecrType.CoprochargeInt : leTiers = "COPRO"
            Case ecrType.FourPaiement : leTiers = "FOURNISSEUR"
            Case ecrType.locAvoirDG : leTiers = "SOCIETE"
            Case ecrType.ClientFacture : leTiers = "CLIENT"
            Case ecrType.ClientEncaisse : leTiers = "BANQUE"
        End Select

        sSql2 = ",'" & leJournal & "','" & leTiers & "','" & laCategorie & "','" & txt2sql(lEcr.Libelle) _
        & "','" & num2sql(-lEcr.MontantHT) & "','" & num2sql(-lEcr.montantTVA) & "','" & num2sql(-lEcr.MontantTTC) & "'," & lEcr.rubId & ")"

        sqlDo(sSql1 & sSql2, conSql)

    End Sub

    Public Sub SupprEcr(lapiece As Integer)
        Try
            Dim ssql As String
            ssql = "delete from ComptaGene where numpiece = " & lapiece
            sqlDo(ssql, conSql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub FactureEdition(laFacture As String)
        Dim ssql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date
        Dim lEcheance As Date
        Dim colArticle As Integer
        Dim colHT As Integer
        Dim colTVA As Integer
        Dim colTTC As Integer
        Dim laLigne As Integer
        Dim leModele As String = ""
        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim laSocid As Integer = 0
        Dim leTiersId As Integer = 0


        Try

            lers = sqlLit("select distinct locid, socid from comptagene where tiers='CLIENT' and categorie='VENTE' and numfacture='" & laFacture & "'", conSql)
            While lers.Read
                leTiersId = lers("locid")
                laSocid = lers("socid")
            End While
            lers.Close()

            If laSocid <> 0 Then
                'Recherche le modele de la societe
                If laSocId <> 0 Then
                    ssql = "Select modeleFacture from societe where socid=" & laSocId
                    lers = sqlLit(ssql, conSql)
                    While lers.Read
                        leModele = nz(lers(0).ToString, "")
                    End While
                    lers.Close()
                End If

                If leModele = "" Then leModele = My.Settings.ChemModeleOffice & "Facture.xlsx"

                appXL.Workbooks.Add(leModele)
                appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
                appXL.Visible = True

                'Recherche les données à facturer
                ssql = "select locid,numFacture,ecrMontantHT,ecrMontantTVA,ecrMontantTTC, ecrLIb, ecrdate,ecrecheance from comptaGene where  numfacture='" & laFacture & "' and Tiers='SOCIETE' and categorie='VENTE'"

                'recherche la cellule Article1
                colArticle = appXL.Range("Article1").Column
                colHT = appXL.Range("montantHT1").Column
                colTVA = appXL.Range("montanttva1").Column
                colTTC = appXL.Range("montantTTC1").Column

                laLigne = appXL.Range("Article1").Row

                lers = sqlLit(ssql, conSql)
                While lers.Read
                    ladate = lers("ecrdate")
                    lEcheance = lers("ecrecheance")
                    appXL.Cells(laLigne, colArticle).value = "'" & lers("ecrlib").ToString

                    appXL.Cells(laLigne, colHT).value = num2sql(lers("ecrMontantHT").ToString)
                    appXL.Cells(laLigne, colTVA).value = num2sql(lers("ecrMontantTVA").ToString)
                    appXL.Cells(laLigne, colTTC).value = num2sql(lers("ecrMontantTTC").ToString)

                    laLigne += 1
                End While
                lers.Close()

                appXL.Range("NumFacture").Value = "'" & laFacture
                appXL.Range("DateFacture").Value = "'" & ladate.ToString("dd/MM/yyyy")
                appXL.Range("ecrEcheance").Value = "'" & lEcheance.ToString("dd/MM/yyyy")


                'recherche les coordonnées du bénéficiaire
                ssql = "SELECT  Nom, Adr1, CodePostal, Localite FROM Annuaire INNER JOIN locataire ON Annuaire.PersId = locataire.PersId where locid=" & leTiersId
                lers = sqlLit(ssql, conSql)
                While lers.Read
                    appXL.Range("Nom").Value = "'" & lers("Nom")
                    appXL.Range("Adresse").Value = "'" & lers("Adr1")
                    appXL.Range("CP").Value = lers("CodePostal").ToString & " " & lers("localite").ToString
                End While
                lers.Close()

                'Facture Excel
                appXL.Range("A1").Select()
                appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic
                appXL.UserControl = True

                ' Make sure that you release object references.

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub EditionAppel(laFacture As String, lafactureinterne As String, laSocId As Integer, lid As Integer, enreg As String)
        Dim ssql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date
        Dim colArticle As Integer
        Dim colHT As Integer
        Dim colTVA As Integer
        Dim colTTC As Integer
        Dim laLigne As Integer
        Dim leModele As String = ""
        Dim ladateFact As Date = Now


        Try
            'Recherche le modele de la societe
            If laSocId <> 0 Then
                ssql = "Select modeleAppel from societe where socid=" & laSocId
                lers = sqlLit(ssql, conSql)
                While lers.Read
                    leModele = nz(lers(0).ToString, "")
                End While
                lers.Close()
            End If

            If debugAppel Then leModele = "C:\Develop\Siano\Courrier\AppelDerketo.xlsx"
            'leModele = "C:\Develop\Siano\Courrier\AppelDerketo.xlsx"

            If leModele = "" Then
                MessageBox.Show("Aucun modèle n'est renseigné")
                Exit Sub
            End If

            appXL.Workbooks.Add(leModele)
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            If enreg = "" Then appXL.Visible = True

            'Recherche les données à facturer
            ssql = "select locId as id,socid, datedebut, datefin"
            ssql &= " ,numFacture,ecrMontantHT,ecrMontantTVA,ecrMontantTTC, ecrLIb, ecrdate,ecrEcheance from comptaGene where locid=" & lid & " and  numfactureInterne='" & lafactureinterne & "'"
            ssql &= " and Tiers='LOCATAIRE'"

            'recherche la cellule Article1
            colArticle = appXL.Range("Article1").Column
            colHT = appXL.Range("montantHT1").Column
            colTVA = appXL.Range("montanttva1").Column
            colTTC = appXL.Range("montantTTC1").Column

            laLigne = appXL.Range("Article1").Row

            lers = sqlLit(ssql, conSql)
            While lers.Read
                lid = lers(0)
                laSocId = lers("socid")
                ladate = lers("EcrEcheance")
                ladateFact = lers("ecrDate")
                appXL.Range("EcrEcheance").Value = "'" & ladate.ToString("dd MMMM yyyy")
                appXL.Cells(laLigne, colArticle).value = "'" & lers("ecrlib").ToString
                appXL.Cells(laLigne, colHT).value = num2sql(-lers("ecrMontantHT").ToString)
                appXL.Cells(laLigne, colTVA).value = num2sql(-lers("ecrMontantTVA").ToString)
                appXL.Cells(laLigne, colTTC).value = num2sql(-lers("ecrMontantTTC").ToString)
                ladate = lers("dateDebut")
                appXL.Range("PeriodeDebut").Value = "'" & ladate.ToString("dd MMMM yyyy")
                ladate = lers("dateFin")
                appXL.Range("PeriodeFin").Value = "'" & ladate.ToString("dd MMMM yyyy")
                laLigne += 1
            End While
            lers.Close()

            appXL.Range("NumAppel").Value = "'" & laFacture
            appXL.Range("DateAppel").Value = "'Le " & ladateFact.ToString("dd MMMM yyyy")


            'recherche les coordonnées du locataire
            ssql = " SELECT  Nom, Adr1, CodePostal, Localite,LoyerInit ,i1.trimestrenum as trim1,i1.annee as an1,i1.indice as ind1,cptsuffixe,i1.typeindice as type1" _
                & ",i2.trimestrenum as trim2,i2.annee as an2,i2.indice as ind2,i2.typeindice as type2" _
                & " FROM Annuaire" _
                & " INNER JOIN locataire ON Annuaire.PersId = locataire.PersId" _
                & " left join indice as i1 on i1.indid = locataire.indid" _
                & " left join indice as i2 on i2.indid = locataire.indActuId" _
                & " where locId=" & lid

            lers = sqlLit(ssql, conSql)
            While lers.Read
                appXL.Range("Nom").Value = "'" & lers("Nom")
                appXL.Range("Adresse").Value = "'" & nz(lers("Adr1"), "")
                appXL.Range("CP").Value = nz(lers("CodePostal"), "") & " " & nz(lers("localite"), "")
                appXL.Range("LoyerDepartAn").Value = num2txt(lers("LoyerInit"))
                appXL.Range("IndiceDepartPeriode").Value = num2txt(lers("trim1")) & "T" & num2txt(lers("an1")) & " (" & lers("type1") & ")"
                appXL.Range("IndiceDepartValeur").Value = num2txt(lers("ind1"))
                appXL.Range("NUmCompte").Value = "'411" & nz(lers("cptsuffixe"), "")
                If nz(lers("ind2"), "") <> "" Then
                    appXL.Range("IndiceActuPeriode").Value = "'" & num2txt(lers("trim2")) & "T" & num2txt(lers("an2")) & " (" & lers("type2") & ")"
                    appXL.Range("IndiceActuValeur").Value = "'" & num2txt(lers("ind2"))
                Else
                    appXL.Range("IndiceActuPeriode").Value = ""
                    appXL.Range("IndiceActuValeur").Value = ""
                End If
            End While
            lers.Close()

            'Recherche liste des biens
            ssql = "select tlocalnom,lotnom,batiment, coproNom,copro.Adr1,copro.codePostal, Copro.localite,location.surface" _
                & " from location" _
                & " inner join lot on location.lotid = lot.lotId" _
                & " left join typelocal on typelocal.[TlocalId]=lot.[TLocalId]" _
                & " left join copro on lot.coproid = copro.coproid" _
                & " where locId = " & lid _
                & " and location.datedebut <=" & Date2sql(ladateFact) _
                & " and (location.datefin >= " & Date2sql(ladateFact) & " or location.datefin is null)" _
                & " order by location.surface desc"

            lers = sqlLit(ssql, conSql)
            Dim lesBiens As String = ""
            While lers.Read
                'premier bien = on ecrit les données immeuble
                If lesBiens = "" Then
                    appXL.Range("BienNom").Value = "'" & nz(lers("CoproNom"), "")
                    appXL.Range("BienAdr").Value = "'" & nz(lers("Adr1"), "")
                    appXL.Range("BienCP").Value = "'" & nz(lers("codePostal"), "") & " " & nz(lers("localite"), "")
                End If
                If nz(lers("surface"), 0) <> 0 And Not lesBiens.Contains(lers(0).ToString & " N°" & lers(1).ToString) Then
                    lesBiens &= ", " & lers(0).ToString & " N°" & lers(1).ToString
                End If
            End While

            lers.Close()

            If lesBiens.Length > 0 Then
                lesBiens = lesBiens.Substring(2, lesBiens.Length - 2)
            Else
                ssql = "select tlocalnom,lotnom,batiment, coproNom,copro.Adr1,copro.codePostal, Copro.localite,location.surface" _
                & " from location" _
                & " inner join lot on location.lotid = lot.lotId" _
                & " left join typelocal on typelocal.[TlocalId]=lot.[TLocalId]" _
                & " left join copro on lot.coproid = copro.coproid" _
                & " where locId = " & lid _
                & " order by location.surface desc,datedebut desc"
                lers = sqlLit(ssql, conSql)
                lers.Read()
                appXL.Range("BienNom").Value = "'" & nz(lers("CoproNom"), "")
                appXL.Range("BienAdr").Value = "'" & nz(lers("Adr1"), "")
                appXL.Range("BienCP").Value = "'" & nz(lers("codePostal"), "") & " " & nz(lers("localite"), "")
                lesBiens = lers(0).ToString & " N°" & lers(1).ToString
                lers.Close()
            End If

            appXL.Range("BienType").Value = "'" & lesBiens


            'Facture Excel
            appXL.Range("A1").Select()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            If enreg = "" Then
                appXL.UserControl = True
                appXL.WindowState = Excel.XlWindowState.xlMaximized
            Else
                Try

                    appXL.DisplayAlerts = False
                    appXL.ActiveSheet.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, enreg, Excel.XlFixedFormatQuality.xlQualityStandard)
                    appXL.ActiveWorkbook.Close()
                    appXL.DisplayAlerts = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function MontantTTC(MontantHT As String, TauxTVA As String) As Decimal
        Return Math.Round(txt2num(MontantHT) * (1 + (txt2num(TauxTVA) / 100)), 2)
    End Function

#End Region

#Region "Formulaire"

    Sub formVide(b As Windows.Forms.Control)
        For Each c In b.Controls
            If c.tag <> "" Then
                Try
                    If TypeOf (c) Is Windows.Forms.TextBox Then c.text = ""
                    If TypeOf (c) Is Windows.Forms.ComboBox Then
                        c.items.clear()
                        c.selectedIndex = -1

                    End If

                    If TypeOf (c) Is Windows.Forms.GroupBox Then Call formVide(c)
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Sub FormRempli(b As Windows.Forms.Control, sSql As String, ByVal consql As OleDb.OleDbConnection)
        Dim lers As OleDb.OleDbDataReader

        lers = sqlLit(sSql, consql)
        While lers.Read

            For Each c In b.Controls
                If c.tag <> "" Then
                    Try
                        If TypeOf (c) Is Windows.Forms.TextBox Then
                            c.text = nz(lers(c.tag.split(",")(0)), "")
                        End If
                        If TypeOf (c) Is Windows.Forms.ComboBox Then
                            If c.tag.ToString.Contains(",t") Then
                                c.text = nz(lers(c.tag.split(",")(0)), "")
                            Else
                                Call ComboSelectValue(nz(lers(c.tag.split(",")(0)), 0), c)
                            End If

                        End If
                        If TypeOf (c) Is Windows.Forms.CheckBox Then
                            c.checked = nz(lers(c.tag.split(",")(0)), False)
                        End If

                        If TypeOf (c) Is Windows.Forms.DateTimePicker Then
                            If nz(lers(c.tag), "") = "" Then
                                c.value = CDate("31/12/2100")
                                If c.showcheckbox Then c.checked = False
                            Else
                                c.value = lers(c.tag)
                                c.enabled = True
                                If c.showcheckbox Then c.checked = True
                            End If
                        End If

                    Catch ex As Exception
                        If debug Then MessageBox.Show(c.name & "-" & ex.Message)
                    End Try


                End If
            Next
        End While
        lers.Close()
    End Sub

    Function FormRecupereChamp(b As Windows.Forms.Control) As List(Of SQLchamp)
        Dim lesChamps As New List(Of SQLchamp)
        For Each c In b.Controls
            Try
                If TypeOf (c) Is Windows.Forms.TextBox Then
                    If c.tag.ToString.Split(",").Count > 1 Then
                        If c.tag.ToString.Split(",")(1).ToUpper.Contains("N") Then
                            lesChamps.Add(New SQLchamp(c.tag.ToString.Split(",")(0), "'" & num2sql(c.text) & "'", c.tag.ToString.Split(",")(1)))
                        Else
                            lesChamps.Add(New SQLchamp(c.tag.ToString.Split(",")(0), "'" & txt2sql(c.text) & "'", c.tag.ToString.Split(",")(1)))
                        End If
                    End If
                End If

                If TypeOf (c) Is Windows.Forms.ComboBox Then
                    If c.tag.ToString.Split(",").Count > 1 Then
                        If c.tag.ToString.Contains(",t") Then
                            lesChamps.Add(New SQLchamp(c.tag.ToString.Split(",")(0), "'" & c.text & "'", c.tag.ToString.Split(",")(1)))

                        Else
                            If c.selectedindex >= 0 Then
                                lesChamps.Add(New SQLchamp(c.tag.ToString.Split(",")(0), "'" & c.selecteditem.value & "'", c.tag.ToString.Split(",")(1)))
                            End If
                        End If

                    End If
                End If

                If TypeOf (c) Is Windows.Forms.CheckBox Then
                    If c.tag.ToString.Split(",").Count > 1 Then

                        lesChamps.Add(New SQLchamp(c.tag.ToString.Split(",")(0), IIf(c.checked, 1, 0), c.tag.ToString.Split(",")(1)))
                    End If
                End If

                If TypeOf (c) Is Windows.Forms.DateTimePicker Then
                    If c.enabled = False Or c.checked = False Then
                        lesChamps.Add(New SQLchamp(c.tag, "NULL", "d"))
                    Else
                        lesChamps.Add(New SQLchamp(c.tag, SqlDate(c), "d"))
                    End If
                End If

                If TypeOf (c) Is Windows.Forms.GroupBox Then lesChamps.AddRange(FormRecupereChamp(c))

            Catch ex As Exception
            End Try
        Next
        Return lesChamps
    End Function

    Function FormVerif(f As Windows.Forms.Control, erp As ErrorProvider) As Boolean
        Dim b As Boolean = True
        For Each c In f.Controls
            Try
                If TypeOf (c) Is Windows.Forms.GroupBox Then
                    If Not FormVerif(c, erp) Then b = False
                End If
                If c.tag <> "" Then
                    If c.tag.ToString.Contains(",") Then
                        If c.tag.ToString.Split(",")(1).Contains("o") Then
                            If TypeOf (c) Is Windows.Forms.TextBox Then
                                If c.text = "" Then
                                    erp.SetError(c, "Obligatoire")
                                    b = False
                                End If
                            End If
                            If TypeOf (c) Is Windows.Forms.ComboBox Then
                                If c.tag.ToString.Contains(",t") Then
                                    If c.text = "" Then
                                        erp.SetError(c, "Obligatoire")
                                        b = False
                                    End If
                                Else
                                    If c.selectedindex < 0 Then
                                        erp.SetError(c, "Obligatoire")
                                        b = False
                                    End If
                                End If

                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                If debug Then MessageBox.Show(ex.Message)
                Throw New Exception(ex.Message)
            End Try
        Next
        Return b
    End Function

    Function FormEnreg(b As Windows.Forms.Control, table As String, ByVal consql As OleDb.OleDbConnection) As Integer
        Dim sSqlAjoutChp As String = ""
        Dim sSqlAjoutVal As String = ""
        Dim sSqlModif As String = ""
        Dim sSql As String
        Dim lesChamps As New List(Of SQLchamp)
        Dim lidchamp As String = ""
        Dim lidval As Integer = 0
        Dim lers As OleDb.OleDbDataReader

        'vérifie les champs obligatoires

        'recupere les champs
        lesChamps = FormRecupereChamp(b)

        'créer les chaines sql en ajout et modif en meme temps et mémorise l'ID
        For Each c In lesChamps
            If c.champTyp = "k" Then
                lidchamp = c.champNom
                If c.champVal <> "" Then lidval = Val(c.champVal.Replace("'", ""))
            Else
                If c.champVal <> "" Then
                    sSqlAjoutChp &= c.champNom & ","
                    sSqlAjoutVal &= c.champVal & ","
                End If
                sSqlModif &= c.champNom & "=" & c.champVal & ","
            End If
        Next

        'supprime la derniere virgule de chaque chaine SQL
        sSqlModif = sSqlModif.Remove(sSqlModif.Length - 1, 1)
        sSqlAjoutChp = sSqlAjoutChp.Remove(sSqlAjoutChp.Length - 1, 1)
        sSqlAjoutVal = sSqlAjoutVal.Remove(sSqlAjoutVal.Length - 1, 1)

        'execute la requete
        If lidval <> 0 Then
            sSql = " update " & table & " set " & sSqlModif & " where " & lidchamp & "=" & lidval
        Else
            sSql = "insert into " & table & " (" & sSqlAjoutChp & ") values (" & sSqlAjoutVal & ")"
        End If
        sqlDo(sSql, consql)

        'recupere l'id du nouvel enreg
        If lidval = 0 Then
            sSql = "select max(" & lidchamp & ") from " & table
            lers = sqlLit(sSql, consql)
            While lers.Read
                lidval = lers(0)
            End While
            lers.Close()
        End If

        Return lidval


    End Function
#End Region

#Region "Contact"
    Sub listecontact(Grid As DataGridView, persId As Integer)
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        sSql = "SELECT CntId, CivId , NomPrenom,  TelFixe, TelMobile, Fax, Email" _
        & " FROM Contact where persId= " & persId

        Grid.Rows.Clear()
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Grid.Rows.Add(lers(0), nz(lers(1).ToString, ""), nz(lers(2).ToString, ""), nz(lers(3).ToString, ""), nz(lers(4).ToString, ""), nz(lers(5).ToString, ""), nz(lers(6).ToString, ""))
        End While

    End Sub

#End Region

#Region "Office"

    Sub XLexport(g As Windows.Forms.DataGridView, titre As String, Optional SOUSTOT As String = "", Optional croisedyn As Boolean = False)
        '
        Dim col As Integer
        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim nbcol As Integer = 0
        Dim ShSource As Excel.Worksheet
        Dim SHDest As Excel.Worksheet

        appXL.Workbooks.Add()
        ShSource = appXL.ActiveSheet
        ShSource.Name = "Data"
        appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
        Try

            'entete de tableau
            StatutBar("En-tête")
            nbcol = 0
            For i = 0 To g.ColumnCount - 1
                If g.Columns(i).Visible Then
                    nbcol += 1
                    appXL.Cells(3, nbcol).value = g.Columns(i).HeaderText
                End If
            Next

            'données
            For i = 0 To g.Rows.Count - 1
                StatutBar("Ligne " & i)
                col = 0

                For j = 0 To g.ColumnCount - 1
                    If g.Columns(j).Visible Then
                        col += 1

                        If g.Columns(j).CellType.Name = "DataGridViewCheckBoxCell" Then
                            appXL.Cells(4 + i, col).value = IIf(g.Rows(i).Cells(j).Value.ToString = True, "x", "")
                        Else
                            If g.Columns(j).DefaultCellStyle.Format.ToUpper.Contains("N") Then
                                appXL.Cells(4 + i, col).value = Val(g.Rows(i).Cells(j).Value.ToString.Replace(",", "."))
                            Else
                                appXL.Cells(4 + i, col).value = "'" & g.Rows(i).Cells(j).Value.ToString
                            End If
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
            Throw New Exception(ex.Message)
        End Try

        appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic
        appXL.Cells.Select()
        appXL.Cells.EntireColumn.AutoFit()
        appXL.Cells(1, 1).value = titre
        appXL.Cells(1, 1).select()


        If croisedyn Then
            appXL.Sheets.Add()
            SHDest = appXL.ActiveSheet
            SHDest.Name = "Synthèse"
            appXL.ActiveWorkbook.PivotCaches.Create(Excel.XlPivotTableSourceType.xlDatabase, ShSource.Range(ShSource.Cells(3, 1), ShSource.Cells(g.Rows.Count + 3, col)), _
                Excel.XlPivotTableVersionList.xlPivotTableVersion12).CreatePivotTable(SHDest.Range("A1"), "TC1", Excel.XlPivotTableVersionList.xlPivotTableVersion12)
            SHDest.Cells(1, 1).select()

            'With SHDest.PivotTables("TC1").PivotFields("Société")
            '    .Orientation = Excel.XlPivotFieldOrientation.xlPageField
            '    .Position = 1
            'End With
            'With SHDest.PivotTables("TC1").PivotFields("An Eff.")
            '    .Orientation = Excel.XlPivotFieldOrientation.xlPageField
            '    .Position = 1
            'End With
            'With SHDest.PivotTables("TC1").PivotFields("Compte")
            '    .Orientation = Excel.XlPivotFieldOrientation.xlRowField
            '    .Position = 1
            'End With
            'With SHDest.PivotTables("TC1").PivotFields("Tiers")
            '    .Orientation = Excel.XlPivotFieldOrientation.xlRowField
            '    .Position = 2
            'End With
            'With SHDest.PivotTables("TC1").PivotFields("Catégorie")
            '    .Orientation = Excel.XlPivotFieldOrientation.xlColumnField
            '    .Position = 1
            'End With

            'SHDest.PivotTables("TC1").AddDataField(SHDest.PivotTables("TC1").PivotFields("Montant HT"), "Total Montant HT", Excel.XlConsolidationFunction.xlSum)

        Else
            Select Case SOUSTOT
                Case "GLTIERS"
                    appXL.Cells(3, 1).select()
                    appXL.Selection.Subtotal(5, Excel.XlConsolidationFunction.xlSum, New Int32() {9, 10, 11}, Replace:=True, PageBreaks:=False, SummaryBelowData:=True)
                Case "LISTEAPP"
                    appXL.Cells(3, 1).select()
                    appXL.Selection.Subtotal(4, Excel.XlConsolidationFunction.xlSum, New Int32() {7, 8, 9, 10, 11}, Replace:=True, PageBreaks:=False, SummaryBelowData:=True)
            End Select

        End If
        StatutBar("")
        appXL.Visible = True
    End Sub

    Sub wordFusionSQL(leModele As String, leSql As String)
        Dim s As String
        Dim lers As OleDb.OleDbDataReader
        Dim premier As Boolean
        Dim leCsv As String
        Try
            leCsv = My.Settings.ChemTemp & leModele.Replace(".dotx", ".csv").Replace(".dot", ".csv").Replace(".docx", ".csv")
            If leSql <> "" Then

                lers = sqlLit(leSql, conSql)
                If lers.HasRows Then

                    Dim fFichier As New StreamWriter(leCsv)
                    premier = True
                    'Lignes
                    While lers.Read
                        If premier Then
                            s = ""
                            For i = 0 To lers.FieldCount - 1
                                s &= lers.GetName(i) & ";"
                            Next
                            s = s.Remove(s.Length - 1)
                            fFichier.WriteLine(s)
                            premier = False
                        End If

                        s = ""
                        For i = 0 To lers.FieldCount - 1
                            s &= lers(i) & ";"
                        Next
                        s = s.Remove(s.Length - 1)
                        fFichier.WriteLine(s)

                    End While
                    fFichier.Close()
                    lers.Close()
                End If
            End If

            Call wordFusionFichier(leModele, leCsv)

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
            '    Throw New Exception(ex.Message)

        End Try

    End Sub

    Sub wordFusionFichier(leModele As String, leFichier As String)
        Dim appWord As New Microsoft.Office.Interop.Word.Application
        Dim leDoc As New Microsoft.Office.Interop.Word.Document
        Try
            leDoc = appWord.Documents.Add(My.Settings.ChemModeleOffice & leModele)
            appWord.Visible = True

            'leDoc = appWord.Documents.Open(FileName:=My.Settings.ChemModeleOffice & leModele, ConfirmConversions:=False, ReadOnly:=False)
            leDoc.MailMerge.MainDocumentType = Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdFormLetters
            leDoc.MailMerge.OpenDataSource(Name:=leFichier, ConfirmConversions:=False, ReadOnly:=False _
                   , LinkToSource:=False, AddToRecentFiles:=False, PasswordDocument:="", _
                   PasswordTemplate:="", Revert:=False)
            With leDoc.MailMerge
                .Destination = Microsoft.Office.Interop.Word.WdMailMergeDestination.wdSendToNewDocument
                With .DataSource
                    .FirstRecord = 1
                    .LastRecord = -16
                End With
                .Execute(Pause:=True)
            End With

            appWord.Documents(leDoc).Close(SaveChanges:=False)
            appWord.Activate()
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Function FournisseurAjoutPers(lepers As Integer) As Integer
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Dim leFour As Integer = 0


        sSql = "Select fourId from fournisseur where persId = " & lepers
        lers = sqlLit(sSql, conSql)
        If lers.HasRows Then
            lers.Read()
            leFour = lers(0)
            lers.Close()
        Else
            lers.Close()
            sSql = "Insert into fournisseur (persId) values (" & lepers & ")"
            sqlDo(sSql, conSql)
            leFour = FournisseurAjoutPers(lepers)
        End If

        Return leFour

    End Function
#End Region

#Region "Document"
    Public Enum docType As Integer
        Four = 1
        Lot = 2
        Loc = 3
        Societe = 4
        Copro = 5
        Emplacement = 6
        Client = 7
        CptBank = 8
    End Enum

    Sub DocListe(leTypeDoc As Integer, lId As Integer, laGrid As DataGridView)
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date

        Try
            sSql = "SELECT docid,dateCrea,DOcNom,DocPath FROM document where "
            Select Case leTypeDoc
                Case docType.Four : sSql &= "Fourid"
                Case docType.Copro : sSql &= "coproid"
                Case docType.Loc : sSql &= "Locid"
                Case docType.Lot : sSql &= "Lotid"
                Case docType.Societe : sSql &= "SocId"
                Case docType.Emplacement : sSql &= "empId"
                Case docType.Client : sSql &= "CliId"
                Case docType.CptBank : sSql &= "cptBkId"
            End Select
            sSql &= " = " & lId & " order by dateCrea desc"

            laGrid.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                ladate = lers("DateCrea")
                laGrid.Rows.Add(lers("docId"), date2Grid(lers("DateCrea")), lers("docNom").ToString, lers("docPath").ToString)
            End While
            lers.Close()
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function DocSupprime(leDocId As Integer) As Boolean
        If MessageBox.Show("Supprimer le document ?") = DialogResult.OK Then
            sqlDo("delete from document where docid=" & leDocId, conSql)
            Return True
        Else
            Return False
        End If

    End Function
#End Region

End Module
