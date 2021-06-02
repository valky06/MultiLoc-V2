Imports System.IO
Imports Microsoft.Office.Interop


Public Class F_FacturationLoc
    'update comptagene set rubid=1 where Journal='VENTES' and categorie='LOYER'
    'update comptagene set rubid=2 where Journal='VENTES' and categorie='PROVCHARGE'
    'update comptagene set rubid=3 where Journal='DEPOT'
    'update comptagene set rubid=4 where Journal='BANQUE' 

    Sub ComptaBanque()
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date
        Dim lEch As Date

        Try

            sSql = "select annuaire2.nom as societe,'411'+cptsuffixe as cpt,annuaire.nom as tiers,ecrDate,ecrecheance,numfacture" _
            & " ,sum( case when categorie='LOYER' then  ecrmontantHT  else 0 end) as loyerHT" _
            & " ,sum( case when categorie='PROVCHARGE' then  ecrmontantHT  else 0 end) as ChargeHT" _
            & " ,sum( case when categorie<>'LOYER' and categorie<>'PROVCHARGE' then  ecrmontantHT  else 0 end) as AutreHT" _
            & " ,sum( ecrmontantTVA) as totalTVA " _
            & " ,sum( ecrmontantTTC) as totalTTC " _
            & " from comptagene" _
            & " left join locataire on locataire.locid=comptagene.locid" _
            & " left join annuaire on annuaire.persid=locataire.persId" _
            & " left join societe on societe.socId=comptagene.socid" _
            & " left join annuaire as annuaire2 on annuaire2.persid=societe.persid" _
            & " where tiers='LOCATAIRE' " _
            & " and ecrdate>=" & SqlDate(Me.dDebut) & " and ecrdate<=" & SqlDate(Me.dFin) _
            & " and comptagene.numfacture not like 'T%' " _
            & " group by annuaire2.nom,cptsuffixe,annuaire.nom,comptagene.locid,comptagene.socid,ecrDATE,ecrEcheance,numfacture" _
            & " order by annuaire2.nom,cptsuffixe,annuaire.nom,ecrdate"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                ladate = lers("ecrdate")
                lEch = lers("ecrecheance")
                Me.gCompta.Rows.Add(lers("societe").ToString, lers("cpt").ToString, lers("tiers").ToString, ladate.ToString("dd/MM/yyyy"), lers("numfacture").ToString, lers("LoyerHT"), lers("ChargeHT"), lers("AUtreHT"), lers("totalTVA"), lers("TotalTTC"))
            End While
            lers.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.dFin.Value = CDate("01/01/1900")
        Me.dDebut.Value = CDate("01/" & Now.Month & "/" & Now.Year)
        Me.dFin.Value = Me.dDebut.Value.AddMonths(1).AddDays(-1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call XLexport(Me.gCompta, "Facturation Locataire - " & Now.ToString("dd/MM/yyyy"), False, False)
    End Sub

    Private Sub dDebut_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDebut.ValueChanged, dFin.ValueChanged
        If Me.dDebut.Value < Me.dFin.Value Then
            Call ComptaBanque()
        Else
            Me.gCompta.Rows.Clear()
        End If
    End Sub


    Private Sub ExportCompta_old()
        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim lers As OleDb.OleDbDataReader
        Dim lersSoc As OleDb.OleDbDataReader
        Dim sSql As String
        Dim MontTVA As Decimal
        Dim MontTot As Decimal
        Dim lId As String
        Dim laLigne As Integer
        Dim leLocCode As String = ""
        Dim leLocNom As String = ""
        Dim laPiece As String = ""
        Dim lesLots As String = ""
        Dim leCptClient As String = ""

        'appXL.Workbooks.Add()
        'appXL.ActiveSheet.Name = "Factures"
        'appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual


        Try
            lersSoc = sqlLit("SELECT distinct SocId FROM ComptaGene WHERE  tiers='LOCATAIRE' " _
                 & " And ecrdate >= " & SqlDate(Me.dDebut) & " And ecrdate <= " & SqlDate(Me.dFin), conSql)

            While lersSoc.Read

                '--------------------------------------------------
                'Factures
                '--------------------------------------------------

                appXL.Workbooks.Add()
                appXL.ActiveSheet.Name = "Factures"
                appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual

                'données
                laLigne = 1
                appXL.Cells(laLigne, 1).value = "Société"
                appXL.Cells(laLigne, 2).value = "Date"
                appXL.Cells(laLigne, 3).value = "CodeJournal"
                appXL.Cells(laLigne, 4).value = "NumeroPiece"
                appXL.Cells(laLigne, 5).value = "NumeroCompte"
                appXL.Cells(laLigne, 6).value = "LibelleCompte"
                appXL.Cells(laLigne, 7).value = "NumeroTiers"
                appXL.Cells(laLigne, 8).value = "Libellé Tiers"
                appXL.Cells(laLigne, 9).value = "Libellé écriture"
                appXL.Cells(laLigne, 10).value = "Mvt Débit"
                appXL.Cells(laLigne, 11).value = "Mvt Crédit"
                appXL.Cells(laLigne, 12).value = "Lots"

                sSql = "SELECT Annuaire.Nom, ComptaGene.ecrDate, locataire.CptSuffixe, ComptaGene.ecrLib, ComptaGene.ecrMontantHT, ComptaGene.ecrMontantTVA, ComptaGene.ecrMontantTTC, " _
                & " ComptaGene.NumFacture, ComptaPlan.CptNum, ComptaPlan.CptNom, locataire.LotLib,  Annuaire_1.Nom AS LocNom ,  ComptaGene.LocId,societe.CptClient" _
                & " ,P2.cptnum,P2.cptnom" _
                & " FROM ComptaGene INNER JOIN locataire ON ComptaGene.LocId = locataire.LocId " _
                & " LEFT JOIN Societe ON locataire.SocId = Societe.SocId" _
                & " LEFT JOIN Annuaire ON Societe.PersId = Annuaire.PersId " _
                & " LEFT JOIN Annuaire AS Annuaire_1 ON locataire.PersId = Annuaire_1.PersId" _
                & " LEFT OUTER JOIN ComptaPlan ON ComptaGene.RubId = ComptaPlan.RubId AND ComptaGene.LocId = ComptaPlan.LocId " _
                & " Left Join comptaplan P2 on P2.locid=comptagene.locId And P2.socid=comptagene.socid And P2.rubid=0" _
                & " WHERE   Journal in ('VENTES','DEPOT')  and tiers='LOCATAIRE' " _
                & " And ecrdate >= " & SqlDate(Me.dDebut) & " And ecrdate <= " & SqlDate(Me.dFin) _
                & " and comptagene.numfacture not like 'T%' " _
                & " and comptagene.socid=" & lersSoc(0) _
                & " ORDER BY Annuaire.Nom,ComptaGene.ecrDate, comptagene.locid,CptSuffixe,numfacture"

                lers = sqlLit(sSql, conSql)

                MontTVA = 0
                MontTot = 0
                lId = ""
                While lers.Read
                    If lers("LocId") & lers("NumFacture") <> lId Then
                        If lId <> "" Then
                            laLigne += 1
                            For j = 1 To 4 : appXL.Cells(laLigne, j).value = appXL.Cells(laLigne - 1, j).value : Next j
                            appXL.Cells(laLigne, 5).value = "445715"
                            appXL.Cells(laLigne, 6).value = "TVA collectée"
                            appXL.Cells(laLigne, 9).value = "TVA " & laPiece
                            appXL.Cells(laLigne, 11).value = -MontTVA
                            appXL.Cells(laLigne, 12).value = lesLots

                            laLigne += 1
                            For j = 1 To 4 : appXL.Cells(laLigne, j).value = appXL.Cells(laLigne - 1, j).value : Next j
                            appXL.Cells(laLigne, 5).value = leCptClient
                            appXL.Cells(laLigne, 6).value = "Client Divers"
                            appXL.Cells(laLigne, 7).value = leLocCode
                            appXL.Cells(laLigne, 8).value = leLocNom
                            appXL.Cells(laLigne, 9).value = laPiece
                            appXL.Cells(laLigne, 10).value = -MontTot
                            appXL.Cells(laLigne, 12).value = lesLots
                        End If
                        MontTVA = 0
                        MontTot = 0
                        lId = lers("LocId") & lers("NumFacture")
                    End If
                    leLocCode = nz(lers("CptSuffixe"), "")
                    leLocNom = lers("LocNom")
                    laPiece = nz(lers("CptSuffixe"), "") + lers("NumFacture")
                    lesLots = nz(lers("LotLib"), "")
                    leCptClient = nz(lers("CptClient"), "")

                    laLigne += 1
                    appXL.Cells(laLigne, 1).value = lers("Nom")
                    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
                    appXL.Cells(laLigne, 3).value = "VT"
                    appXL.Cells(laLigne, 4).value = laPiece
                    appXL.Cells(laLigne, 5).value = nz(lers("CptNum"), "")
                    appXL.Cells(laLigne, 6).value = nz(lers("CptNom"), "")
                    appXL.Cells(laLigne, 9).value = nz(lers("ecrLib"), "")
                    appXL.Cells(laLigne, 11).value = -lers("ecrMontantHT")
                    appXL.Cells(laLigne, 12).value = lesLots

                    MontTVA += lers("ecrMontantTVA")
                    MontTot += lers("ecrMontantTTC")
                End While


                If lId <> "" Then
                    laLigne += 1
                    For j = 1 To 4 : appXL.Cells(laLigne, j).value = appXL.Cells(laLigne - 1, j).value : Next j
                    appXL.Cells(laLigne, 5).value = "445715"
                    appXL.Cells(laLigne, 6).value = "TVA collectée"
                    appXL.Cells(laLigne, 9).value = "TVA " & laPiece
                    appXL.Cells(laLigne, 11).value = -MontTVA
                    appXL.Cells(laLigne, 12).value = lesLots

                    laLigne += 1
                    For j = 1 To 4 : appXL.Cells(laLigne, j).value = appXL.Cells(laLigne - 1, j).value : Next j
                    appXL.Cells(laLigne, 5).value = leCptClient
                    appXL.Cells(laLigne, 6).value = "Client Divers"
                    appXL.Cells(laLigne, 7).value = leLocCode
                    appXL.Cells(laLigne, 8).value = leLocNom
                    appXL.Cells(laLigne, 9).value = laPiece
                    appXL.Cells(laLigne, 10).value = -MontTot
                    appXL.Cells(laLigne, 12).value = lesLots
                End If
                lers.Close()

                '--------------------------------------------------
                'Versements
                '--------------------------------------------------

                appXL.Workbooks.Add()
                appXL.ActiveSheet.Name = "Encaissements"
                appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual

                'données
                laLigne = 1
                appXL.Cells(laLigne, 1).value = "Société"
                appXL.Cells(laLigne, 2).value = "Date"
                appXL.Cells(laLigne, 3).value = "CodeJournal"
                appXL.Cells(laLigne, 4).value = "NumeroPiece"
                appXL.Cells(laLigne, 5).value = "NumeroCompte"
                appXL.Cells(laLigne, 6).value = "LibelleCompte"
                appXL.Cells(laLigne, 7).value = "NumeroTiers"
                appXL.Cells(laLigne, 8).value = "Libellé Tiers"
                appXL.Cells(laLigne, 9).value = "Libellé écriture"
                appXL.Cells(laLigne, 10).value = "Mvt Débit"
                appXL.Cells(laLigne, 11).value = "Mvt Crédit"

                sSql = "Select Annuaire.Nom, ComptaGene.ecrDate, locataire.CptSuffixe, ComptaGene.ecrLib, ComptaGene.ecrMontantHT, ComptaGene.ecrMontantTVA" _
                & " , ComptaGene.ecrMontantTTC, ComptaGene.NumPIece, locataire.LotLib,  Annuaire_1.Nom AS LocNom ,  ComptaGene.LocId,societe.cptClient" _
                & " FROM ComptaGene INNER JOIN locataire ON ComptaGene.LocId = locataire.LocId " _
                & " LEFT JOIN Societe ON locataire.SocId = Societe.SocId" _
                & " LEFT JOIN Annuaire ON Societe.PersId = Annuaire.PersId " _
                & " LEFT JOIN Annuaire AS Annuaire_1 ON locataire.PersId = Annuaire_1.PersId" _
                & " LEFT OUTER JOIN ComptaPlan ON ComptaGene.RubId = ComptaPlan.RubId AND ComptaGene.LocId = ComptaPlan.LocId " _
                & " WHERE   Journal in ('BANQUE')  and tiers='LOCATAIRE' " _
                & " And ecrdate >= " & SqlDate(Me.dDebut) & " And ecrdate <= " & SqlDate(Me.dFin) _
                & " and comptagene.socid=" & lersSoc(0) _
                & " ORDER BY Annuaire.Nom,ComptaGene.ecrDate, comptagene.locid,CptSuffixe,numfacture"

                lers = sqlLit(sSql, conSql)
                While lers.Read
                    leLocCode = nz(lers("CptSuffixe"), "")
                    leLocNom = lers("LocNom")
                    laPiece = "P" & lers("NumPIece").ToString
                    leCptClient = nz(lers("cptclient"), "")

                    laLigne += 1
                    appXL.Cells(laLigne, 1).value = lers("Nom")
                    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
                    appXL.Cells(laLigne, 3).value = "BQ"
                    appXL.Cells(laLigne, 4).value = laPiece
                    appXL.Cells(laLigne, 5).value = "512110"
                    appXL.Cells(laLigne, 6).value = "CA PCA"
                    appXL.Cells(laLigne, 9).value = nz(lers("ecrLib"), "")
                    appXL.Cells(laLigne, 10).value = lers("ecrMontantTTC")

                    laLigne += 1
                    appXL.Cells(laLigne, 1).value = lers("Nom")
                    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
                    appXL.Cells(laLigne, 3).value = "BQ"
                    appXL.Cells(laLigne, 4).value = laPiece
                    appXL.Cells(laLigne, 5).value = leCptClient
                    appXL.Cells(laLigne, 6).value = ""
                    appXL.Cells(laLigne, 7).value = leLocCode
                    appXL.Cells(laLigne, 8).value = leLocNom
                    appXL.Cells(laLigne, 9).value = nz(lers("ecrLib"), "")
                    appXL.Cells(laLigne, 11).value = lers("ecrMontantTTC")

                End While
                lers.Close()


            End While
            lersSoc.Close()

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
            Throw New Exception(ex.Message)
        End Try

        appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic
        appXL.Cells.Select()
        '        appXL.Cells.EntireColumn.AutoFit()
        '        appXL.Cells(1, 1).value = "Export Facturation"
        '        appXL.Cells(1, 1).select()


        StatutBar("")
        appXL.Visible = True
    End Sub


    Private Sub button_click2(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call ExportCompta(Me.dDebut.Value, Me.dFin.Value)

    End Sub
End Class