Imports System.IO
Imports Microsoft.Office.Interop

Public Class F_LocaSuivi

    Public leLocId As Integer = 0
    Private modif As Boolean = False

    Dim sSql As String = ""
    Dim lers As OleDb.OleDbDataReader
    Dim ladate As Date



    Sub AffPlanCpt()
        Try
            sSql = "SELECT  ComptaPlan.PcId, ComptaRubrique.RubId, ComptaRubrique.RubNom, ComptaPlan.CptNum, ComptaPlan.CptNom" _
            & " FROM ComptaRubrique LEFT OUTER JOIN ComptaPlan ON ComptaRubrique.RubId = ComptaPlan.RubId and locid=" & Me.leLocId & " order by RubNom"

            Me.gPlanCpt.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                Me.gPlanCpt.Rows.Add(lers("PcId").ToString, lers("RubId").ToString, lers("RubNom").ToString, lers("CptNum").ToString, lers("CptNom").ToString)
            End While
            lers.Close()

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub AffGrandLivreLoc()
        Try
            sSql = "SELECT ecrid, numfacture,'411' + cptsuffixe as cpt,categorie,  ecrLib, ecrMontantHT,ecrdate,ecrecheance,ecrmontantTVA,ecrMontantTTC,lotlib,s.nom as societe,anneeEffet" _
            & " FROM ComptaGene " _
            & " inner join locataire on ComptaGene.locId = locataire.locId " _
            & " left join societe on locataire.socid=societe.socid" _
            & " left join annuaire as s on societe.persid=s.persid" _
            & " WHERE Tiers in  ('LOCATAIRE','CLIENT')  " _
            & " and locataire.locid=" & Me.leLocId _
            & " and year(ecrEcheance)=" & Me.lAnnee.Text
            If Me.tRechCat.Text <> "" Then sSql &= " and categorie like '%" & Me.tRechCat.Text & "%'"
            sSql &= " order by ecrdate"

            Me.gGrandLivre.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                Me.gGrandLivre.Rows.Add(lers("ecrid").ToString, lers("societe").ToString, date2Grid(lers("ecrdate")), date2Grid(lers("ecrEcheance")), lers("anneeEffet").ToString, lers("cpt").ToString, lers("categorie").ToString, lers("lotlib").ToString, lers("numfacture").ToString, lers("ecrLIb").ToString, lers("ecrmontantHT"), lers("ecrMontantTVA"), lers("ecrMontantTTC"))
            End While
            lers.Close()

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub affListeLocat()
        Dim sSql As String
        sSql = "SELECT locId, nom" _
        & " FROM locataire INNER JOIN Annuaire ON locataire.PersId = Annuaire.PersId" _
        & " where nom like '%" & Me.tRech.Text & "%' and typeLoc=1"
        If Me.cAncien.Checked = False Then
            sSql &= "  and (datesortie is null or datesortie >= getdate() )"
        Else
            sSql &= " and datesortie < getdate() "
        End If

        Call ComboRempli(sSql, Me.lLocat, conSql)
        '        Me.leLocId = 0
        '       If Me.lLocat.Items.Count = 1 Then Me.lLocat.SelectedIndex = 0
        If Me.leLocId > 0 Then ComboSelectValue(Me.leLocId, Me.lLocat)
        Call afficheLocat()
    End Sub

    Function quitteModif() As Boolean
        Dim b As Boolean = False
        If MessageBox.Show("Enregistrer les modifications ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            b = True
            Button2_Click_1(Nothing, Nothing)
        End If
        modif = False
        Return b
    End Function

    Sub afflisteLot()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim surface As Double = 0

        sSql = "SELECT bailid,Nom,location.lotId,lot.coproId,  CoproNom,Batiment, tlocalnom, LotNom, location.surface,dateDebut,DateFin" _
        & " FROM Lot INNER JOIN location ON Lot.lotid = location.lotId" _
        & " left join typelocal on typelocal.tlocalid = lot.tlocalid" _
        & " INNER JOIN Copro ON Lot.Coproid = Copro.CoproId" _
        & " inner join societe on lot.socid=societe.socid " _
        & " inner join annuaire on annuaire.persid=societe.persid" _
        & " where locId= " & Me.leLocId

        Try
            Me.gLot.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                If nz(lers("datefin"), Now.AddDays(1)) > Now Then surface += txt2num(lers("surface").ToString)
                Me.gLot.Rows.Add(lers("lotid"), lers("coproid").ToString, lers("copronom").ToString, lers("nom").ToString, lers("batiment").ToString, lers("tlocalnom").ToString, lers("lotnom").ToString, date2Grid(lers("dateDebut")), date2Grid(lers("dateFin")), lers("surface").ToString, lers("BailId").ToString)
            End While
            lers.Close()
            Me.tSurfaceTotale.Text = num2txt(surface)

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub affcomptalocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Try
            '           sSql = "SELECT ecrId,numPiece, numfacture,ecrEcheance, ecrDate, ecrLib, ecrMontantTTC, journal FROM ComptaGene" _
            '          & " where rubrique='LOCATAIRE' and locId= " & Me.leLocId & " order by ecrDate desc, ecrid desc"

            sSql = "select ecrEcheance, ecrdate, min(ecrlib) as ecrlib, sum(ecrMontantHT) as ecrMontantHT, sum(ecrMontantTTC) as ecrMontantTTC" _
                & ",numfacture,max(numpiece) as numpiece, numFactureInterne" _
                & " from comptagene where Tiers='LOCATAIRE' and locId= " & Me.leLocId _
                & " group by ecrecheance,ecrdate,numfacture, numFactureInterne" _
                & " order by ecrecheance desc,ecrDate desc,numfacture desc "


            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrMontantTTC") < 0, -lers("ecrMontantTTC"), 0)
                credit = IIf(lers("ecrMontantTTC") >= 0, lers("ecrMontantTTC"), 0)
                'ladate = lers("ecrDate")
                'lEch = lers("ecrEcheance")
                If nz(lers("numfacture"), "") <> "" Then
                    Me.gCompta.Rows.Add("", lers("numfacture").ToString, date2Grid(lers("ecrEcheance")), date2Grid(lers("ecrDate")), lers("NumFacture").ToString, debit, credit, 0, lers("numfactureInterne").ToString)
                Else
                    Me.gCompta.Rows.Add(lers("NumPiece").ToString, lers("numfacture").ToString, date2Grid(lers("ecrEcheance")), date2Grid(lers("ecrDate")), lers("ecrLib").ToString, debit, credit, 0, lers("numfactureInterne").ToString)
                End If
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub afficheLocat()


        StatutBar("Locataire")
        Call FormRempli(Me.gBail, "SELECT locid,TBailId,  IndId,TRgtId, TPerId,loyerSOumisTVA,DGSoumisTVA,tauxTVA,dateEntree,dateSortiePrev,dateSortie" _
            & ",loyerInit,LoyerActu,chargeInit,ChargeActu,socid, cptSuffixe,persId,NbMoisDG,daterevision,surfacebail,loyerReduction,indActuid,DGLoyerTTC,soumisHono,cautionBanc,dureerevision FROM Locataire where locid=" & Me.leLocId, conSql)
        StatutBar("Lots")
        Call afflisteLot()
        StatutBar("Compta")
        Call affcomptalocat()
        StatutBar("Documents")
        Call DocListe(docType.Loc, Me.leLocId, Me.gDoc)
        Call AffGrandLivreLoc()
        Call AffPlanCpt()

        If Me.gLot.Rows.Count = 0 And Me.leLocId <> 0 Then MessageBox.Show("Aucun lot n'as été saisi pour ce locataire")

        Me.oOnglet.Enabled = True
        F_main.sLabel.Text = ""

        Me.tlocid2.Text = Me.leLocId
        '   Me.tlocid2.Visible = debug

        modif = False
    End Sub

    Private Sub F_LocaSuivi_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        If modif Then quitteModif()

    End Sub

    Private Sub F_Locat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.tRech.Text = ""
        Me.lAnnee.Items.Clear()
        For i = Now.Year - 2 To Now.Year + 2
            Me.lAnnee.Items.Add(New ListItem(i, i))
        Next
        Call ComboSelectTxt(Now.Year, Me.lAnnee)


        Me.gLot.Rows.Clear()
        Me.gGrandLivre.Rows.Clear()
        Me.gCompta.Rows.Clear()
        Me.gDoc.Rows.Clear()
        Me.oOnglet.Enabled = False

        Try
            StatutBar("Type Bail")
            Call ComboRempli("select tbailid,tbailNom from typeBail", Me.lTypeBail, conSql)
            StatutBar("Type Période")
            Call ComboRempli("select tperId,tperNom from typePEriode", Me.lTypePer, conSql)
            StatutBar("Type Règlement")
            Call ComboRempli("select tRgtId,tRgtNom from typeReglement", Me.lTypeRgt, conSql)
            StatutBar("Indices")
            Call ComboRempli("SELECT IndId, cast( trimestreNUm as varchar(1) ) + ' T '  + cast( annee as varchar(4)) + ' = ' + cast(indice as varchar(10))  as trimcode from indice order by annee desc, trimestrenum desc", Me.lIndice, conSql)
            Call ComboRempli("SELECT IndId, cast( trimestreNUm as varchar(1) ) + ' T '  + cast( annee as varchar(4)) + ' = ' + cast(indice as varchar(10))  as trimcode from indice order by annee desc, trimestrenum desc", Me.lindiceActu, conSql)
            StatutBar("Liste Locataires")
            Call affListeLocat()

            'If Me.leLocId > 0 Then
            '    Me.tRech.Text = ""
            '    Call ComboSelectValue(Me.leLocId, Me.lLocat)
            'End If
            F_main.sLabel.Text = ""
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        If Me.oOnglet.SelectedIndex = 1 Then Call XLexport(Me.gCompta, "Compta locataire : " & Me.lLocat.Text)
        If Me.oOnglet.SelectedIndex = 2 Then Call XLexport(Me.gGrandLivre, "Grand Livre locataire : " & Me.lLocat.Text)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bWord.Click
        Dim ssql As String
        ssql = "SELECT nom, Adr1, CodePostal, Localite, telbureau, fax FROM Annuaire where persId=" & Me.tPersId.Text
        Call wordFusionSQL("Locataire.docx", ssql)
    End Sub

    Private Sub llocat_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lLocat.SelectedIndexChanged
        If modif Then quitteModif()
        Me.leLocId = 0
        If Me.lLocat.SelectedIndex >= 0 Then Me.leLocId = Me.lLocat.SelectedItem.value
        Call afficheLocat()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call FormEnreg(Me.gBail, "locataire", conSql)
        modif = False
        If Me.dSortie.Checked Then
            sqlDo("update location set datefin =" & Date2sql(Me.dSortie.Value) & " where datefin is NULL and  locid=" & Me.leLocId, conSql)
        Else
            sqlDo("update location set datefin = NULL where datefin=" & Date2sql(Me.dSortie.Value) & " and locid=" & Me.leLocId, conSql)
        End If
        Call locLotLibMAJ(Me.leLocId)
        Call afflisteLot()
        MessageBox.Show("Enregistrement effectué")
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ssql As String
        Dim lesLot As String = ""

        If Me.tLocId.Text <> "" Then
            Try

                For i = 0 To Me.gLot.RowCount - 1
                    lesLot &= Me.gLot.Rows(i).Cells("Batiment").Value & " - " & Me.gLot.Rows(i).Cells("typeLot").Value & " " & Me.gLot.Rows(i).Cells("lot").Value & Chr(13)
                Next

                ssql = "SELECT nom, Adr1, CodePostal, Localite, TRgtNom, TPerNom, TBailNom, DateEntree, LoyerInit, chargeInit, RegimeFiscal" _
                & ", '" & lesLot & "' as lesLots, Indice, TrimestreNom, Annee, TypeIndice" _
                & " FROM Locataire LEFT JOIN Annuaire ON Locataire.PersId = Annuaire.PersId" _
                & " LEFT JOIN TypeBail ON Locataire.TBailId = TypeBail.TBailId " _
                & " LEFT JOIN TypePeriode ON Locataire.TPerId = TypePeriode.TPerId " _
                & " LEFT JOIN TypeReglement ON Locataire.TRgtId = TypeReglement.TRgtId" _
                & " LEFT JOIN Indice ON Locataire.IndId = Indice.IndId " _
                & " where locId=" & Me.tLocId.Text

                Call wordFusionSQL("LocataireBail.docx", ssql)
            Catch ex As Exception
                If debug Then MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub tRech_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tRech.KeyUp
        If e.KeyCode = Keys.Enter Then Call affListeLocat()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If F_LocaNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call affListeLocat()
            Call ComboSelectValue(F_LocaNew.leLocId, Me.lLocat)
            Me.oOnglet.SelectTab("Bail")
        End If
    End Sub



    Private Sub bTypeBail_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles bTypeBail.LinkClicked

        F_TypeListe.laForm = F_TypeBail
        F_TypeListe.MOdeEdit = False
        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT Tbailid, Tbailnom FROM TypeBail", Me.lTypeBail, conSql)

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        If F_IndiceListe.ShowDialog = Windows.Forms.DialogResult.OK Then
            '            Call ComboRempli("SELECT IndId, typeindice & "" - ""  & TrimestreNom & "" "" & annee as indice FROM Indice order by annee desc, trimestrenum desc", Me.lIndice, conSql)
            Call ComboRempli("SELECT IndId, cast( trimestreNUm as varchar(1) ) + ' T '  + cast( annee as varchar(4)) + ' = ' + cast(indice as varchar(10))  as trimcode from indice order by annee desc, trimestrenum desc", Me.lIndice, conSql)
            Call ComboRempli("SELECT IndId, cast( trimestreNUm as varchar(1) ) + ' T '  + cast( annee as varchar(4)) + ' = ' + cast(indice as varchar(10))  as trimcode from indice order by annee desc, trimestrenum desc", Me.lindiceActu, conSql)

        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        F_TypeListe.laForm = F_TypePeriode
        F_TypeListe.MOdeEdit = False
        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT TPerid, TPernom FROM TypePeriode", Me.lTypePer, conSql)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        F_TypeListe.laForm = F_TypeReglement
        F_TypeListe.MOdeEdit = False
        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT TRgtid, TRgtnom FROM TypeReglement", Me.lTypeRgt, conSql)
    End Sub

    Private Sub NouveauToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles mnuNouveau.Click
        If F_LocaNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            If modif Then quitteModif()

            Call affListeLocat()
            Call ComboSelectValue(F_LocaNew.leLocId, Me.lLocat)
            Me.oOnglet.SelectTab("Bail")
        End If
    End Sub

    Private Sub gCompta_Sorted(sender As Object, e As System.EventArgs) Handles gCompta.Sorted
        If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        F_LocaLot.tLocatID.Text = Me.leLocId
        F_LocaLot.dEntre.Value = Me.dEntree.Value
        F_LocaLot.dSortie.Value = Me.dSortie.Value
        F_LocaLot.leBailid = 0
        F_LocaLot.laSocId = txt2num(Me.tSocId.Text)
        If F_LocaLot.ShowDialog = Windows.Forms.DialogResult.OK Then
            If txt2num(Me.tSocId.Text) = 0 Then
                sSql = "update locataire set socId=" & F_LotRech.laSocId & " where locid=" & Me.leLocId
                sqlDo(sSql, conSql)
                Me.tSocId.Text = F_LotRech.laSocId
            End If
            Call locLotLibMAJ(Me.leLocId)
            Call afflisteLot()
        End If

        'Dim ssql As String
        'F_LotRech.laSocId = txt2num(Me.tSocId.Text)
        'If F_LotRech.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    ssql = "insert into location (locId, lotId) values (" & Me.leLocId & "," & F_LotRech.leLotId & ")"
        '    sqlDo(ssql, conSql)

        '    ssql = "update lot set locActuid=" & Me.leLocId & " where lotid=" & F_LotRech.leLotId
        '    sqlDo(ssql, conSql)

        '    If txt2num(Me.tSocId.Text) = 0 Then
        '        ssql = "update locataire set socId=" & F_LotRech.laSocId & " where locid=" & Me.leLocId
        '        sqlDo(ssql, conSql)
        '        Me.tSocId.Text = F_LotRech.laSocId
        '    End If
        '    Call locLotLib(Me.leLocId)
        '    Call listeLot()
        'End If
        'F_LotRech.Dispose()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        F_Document.leDocType = docType.Loc
        F_Document.lId = Me.leLocId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Loc, Me.leLocId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Loc, Me.leLocId, Me.gDoc)

    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        F_LocaDG.leLocId = Me.leLocId
        F_LocaDG.laSocId = Me.tSocId.Text
        F_LocaDG.tLoyer.Text = Me.tLoyerActu.Text
        F_LocaDG.tNbMois.Text = Me.tNbMoisDG.Text
        F_LocaDG.tLib.Text = "Dépôt Garantie " & Me.lLocat.Text
        If F_LocaDG.ShowDialog = Windows.Forms.DialogResult.OK Then Call affcomptalocat()
        F_LocaDG.Dispose()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click, Button8.Click
        If Me.leLocId = 0 Then Exit Sub

        F_LocaAppel.leLocId = Me.leLocId
        F_LocaAppel.laSocId = Val(Me.tSocId.Text)
        If F_LocaAppel.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call affcomptalocat()
            Call afficheLocat()
            Me.oOnglet.SelectTab("Compte")
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If txt2num(Me.tSocId.Text) = 0 Then Exit Sub
        F_locaEncaissement.leLocid = Me.leLocId
        F_locaEncaissement.laSocId = Me.tSocId.Text
        If F_locaEncaissement.ShowDialog = Windows.Forms.DialogResult.OK Then Call affcomptalocat()
        F_locaEncaissement.Dispose()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim sSql As String
        If Me.gLot.SelectedRows.Count > 0 Then
            sSql = "delete from location where bailid=" & Me.gLot.SelectedRows(0).Cells("BailId").Value
            sqlDo(sSql, conSql)
            Call locLotLibMAJ(Me.leLocId)
            Call afflisteLot()

            If Me.gLot.RowCount < 1 Then
                sSql = "update locataire set socId=0 where locid=" & Me.leLocId
                sqlDo(sSql, conSql)
                Me.tSocId.Text = "0"
            End If
        End If
    End Sub


    Private Sub bRech_Click(sender As System.Object, e As System.EventArgs) Handles bRech.Click
        Call affListeLocat()
    End Sub


    Private Sub gLot_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLot.CellContentClick
        Select Case e.ColumnIndex
            Case Me.gLot.Columns("copro").Index
                F_CoproSuivi.lacoproId = Me.gLot.SelectedRows(0).Cells("CoproId").Value
                Call F_main.mnuCopro_Click(Nothing, Nothing)
                Me.Dispose()
            Case Me.gLot.Columns("lot").Index
                F_LotSuivi.lelotId = Me.gLot.SelectedRows(0).Cells("lotId").Value
                Call F_main.mnuLot_Click(Nothing, Nothing)
                Me.Dispose()

        End Select
    End Sub



    Private Sub kLocataire_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles kLocataire.LinkClicked
        If Me.tPersId.Text <> "" Then
            F_pers.lID = txt2num(Me.tPersId.Text)
            If F_pers.ShowDialog() = Windows.Forms.DialogResult.OK Then Call affListeLocat()
        End If
    End Sub


    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            If nz(gCompta.SelectedRows(0).Cells("numfacture").Value, "") <> "" Then
                sqlDo("delete from comptagene where numfacture='" & gCompta.SelectedRows(0).Cells("numfacture").Value & "' and locid=" & Me.tLocId.Text, conSql)
            Else
                Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("numpiece").Value)
            End If

            Call affcomptalocat()
        End If
    End Sub




    Private Sub Button13_Click_1(sender As System.Object, e As System.EventArgs)
        F_LocaDGReprise.leLocId = Me.leLocId
        F_LocaDGReprise.laSocId = Me.tSocId.Text
        If Me.cDGTVA.Checked Then F_LocaDGReprise.tTVA.Text = Me.tTauxTVA.Text
        F_LocaDGReprise.tLib.Text = "Reprise Dépôt Garantie " & Me.lLocat.Text
        If F_LocaDGReprise.ShowDialog = Windows.Forms.DialogResult.OK Then Call affcomptalocat()
        F_LocaDGReprise.Dispose()
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If txt2num(Me.tSocId.Text) = 0 Then Exit Sub
        F_locaRembours.leLocid = Me.leLocId
        F_locaRembours.laSocId = Me.tSocId.Text
        If F_locaRembours.ShowDialog = Windows.Forms.DialogResult.OK Then Call affcomptalocat()
        F_locaRembours.Dispose()
    End Sub

    Private Sub bEditFActure_Click(sender As System.Object, e As System.EventArgs) Handles bEditFActure.Click

        If Me.gCompta.SelectedRows.Count < 1 Then Exit Sub

        With Me.gCompta.SelectedRows(0)
            If .Cells("numfacture").Value <> "" Then
                Call EditionAppel(.Cells("numfacture").Value, .Cells("numfactureInterne").Value, Me.tSocId.Text, leLocId, "")
            End If
        End With


    End Sub

    Private Sub tLoyer_Enter(sender As Object, e As System.EventArgs) Handles tLoyer.Enter, tLoyerActu.Enter, tCompte.Enter, tChargeActu.Enter, tNbMoisDG.Enter
        sender.SelectAll()
    End Sub



    Private Sub lTypeBail_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lTypeBail.SelectedIndexChanged, lIndice.SelectedIndexChanged, lTypePer.SelectedIndexChanged _
        , lTypeRgt.SelectedIndexChanged, tLoyer.TextChanged, tLoyerActu.TextChanged, tChargeActu.TextChanged, tNbMoisDG.TextChanged _
        , cDGTVA.CheckedChanged, cLoyerTVA.CheckedChanged, tTauxTVA.TextChanged, dEntree.ValueChanged, dRevision.ValueChanged _
        , dSortiePrev.ValueChanged, dSortie.ValueChanged, tCompte.TextChanged, tSurfaceBail.TextChanged, cLoyerReduc.CheckedChanged, lindiceActu.SelectedIndexChanged, cCautionBanc.CheckedChanged

        modif = True
    End Sub

    Private Sub cAncien_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cAncien.CheckedChanged
        Me.leLocId = 0
        Call affListeLocat()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If Me.leLocId = 0 Then Exit Sub

        F_LocaAvoir.leLocId = Me.leLocId
        F_LocaAvoir.laSocId = Me.tSocId.Text
        If F_LocaAvoir.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call affcomptalocat()
            Call afficheLocat()
            Me.oOnglet.SelectTab("Compte")
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If Me.leLocId = 0 Then Exit Sub

        F_LocaAvoir.leLocId = Me.leLocId
        F_LocaAvoir.laSocId = Me.tSocId.Text
        If F_LocaAvoir.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call affcomptalocat()
            Call afficheLocat()
            Me.oOnglet.SelectTab("Compte")
        End If
    End Sub

    Private Sub lAnnee_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lAnnee.SelectedIndexChanged
        Call AffGrandLivreLoc()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tRechCat.KeyUp
        If e.KeyCode = Keys.Enter Then Call AffGrandLivreLoc()
    End Sub

    Private Sub gLot_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLot.CellDoubleClick
        If e.RowIndex >= 0 Then
            F_LocaLot.laSocId = -1
            F_LocaLot.dSortie.Checked = True
            F_LocaLot.leBailid = Me.gLot.Rows(e.RowIndex).Cells("BailId").Value
            F_LocaLot.tLotId.Text = Me.gLot.Rows(e.RowIndex).Cells("lotid").Value
            F_LocaLot.tLotNom.Text = Me.gLot.Rows(e.RowIndex).Cells("Copro").Value & "-" & Me.gLot.Rows(e.RowIndex).Cells("lot").Value
            F_LocaLot.tSurface.Text = Me.gLot.Rows(e.RowIndex).Cells("Surface").Value
            If Me.gLot.Rows(e.RowIndex).Cells("dateDebut").Value <> "" Then
                F_LocaLot.dEntre.Value = Me.gLot.Rows(e.RowIndex).Cells("dateDebut").Value
            Else
                F_LocaLot.dEntre.Value = Me.dEntree.Value
            End If

            If Me.gLot.Rows(e.RowIndex).Cells("dateFin").Value <> "" Then
                F_LocaLot.dSortie.Value = Me.gLot.Rows(e.RowIndex).Cells("dateFin").Value
            Else
                F_LocaLot.dSortie.Value = CDate("31/12/2100")
            End If
            If F_LocaLot.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Call locLotLibMAJ(Me.leLocId)
                Call afflisteLot()
            End If

        End If
    End Sub

    Private Sub EditRegul(sender As System.Object, e As System.EventArgs) Handles Button15.Click, bRegul.Click
        Dim ssql As String
        Dim lan As String = Now.Year - 1
        Dim lers As OleDb.OleDbDataReader

        Try
            Dim d1 As Date = CDate("01/01/" & lan)
            Dim d2 As Date = CDate("31/12/" & lan)

            StatutBar("Lancement Excel")

            Dim appXL As New Microsoft.Office.Interop.Excel.Application
            Dim laligne As Integer = 10
            Dim laCol As Integer = 2
            Dim laCat As String = ""
            Dim laLigneCat As Integer = 0
            Dim leBailActu As Integer = 0
            Dim lelotActu As Integer = 0
            Dim lelocActu As Integer = 0
            Dim sousTotCat As Decimal = 0
            Dim totalCat As Decimal = 0
            Dim sousTotCharge As Decimal = 0
            Dim totalCharge As Decimal = 0
            Dim ligneCharge As New List(Of Integer)
            Dim nbLoc As Integer = 0

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            StatutBar("Export Excel")

            Dim locOrdre As Integer = 0
            Dim lelocactuNom As String = ""

            Call StatutBar("Export Locataire")
            ssql = " SELECT  locid,  LocNom, chlib, chmontantHT, tChCatOrdre, tChCatLIb, LoyerHT, ChargeHT, LotId, QuotePart, TotalQuotePart" _
                & ", NbJour, NbJourAn, LotNom, Batiment, TlocalNom, Pro, Loc, Tmp, NbJourLotOcc, chMontantHtLoc,CleLoc,BailId,surfaceMoyLoc,SurfaceLot,SurfaceMoyLocTot,surfaceLoc" _
                & " FROM RepartCharge WHERE locid=" & Me.leLocId & "  and tChCatOrdre <> 9999" _
                & " and lotid not in (select lotid from TempRepartCharge  group by lotid  having sum(chMontantHtLoc)=0 )"
            ssql &= " ORDER BY LocNom,locid, lotid,bailId, tChCatOrdre, tChCatLIb, chlib"

            lers = sqlLit(ssql, conSql)
            lelocActu = 0
            laCat = ""
            lelotActu = 0
            leBailActu = 0

            While lers.Read
                If leBailActu <> nz(lers("BailId"), 0) Or laCat <> lers("tChCatLib") Then

                    'Mise en forme catégorie précédente
                    If laCat <> "" Then
                        laligne += 1
                        If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                        appXL.Cells(laligne, laCol + 2).value = sousTotCat
                        sousTotCat = 0
                    End If

                    If leBailActu <> nz(lers("BailId"), 0) Then
                        'Mise en forme Lot précédent
                        If lelotActu <> 0 And laCol = 3 Then ligneCharge.Add(laligne + 2)
                        '    laligne += 2
                        '    appXL.Cells(laligne, laCol + 2).value = totalCharge
                        '    appXL.Cells(laligne, 1).value = "'Total"
                        'End If

                        If lelocActu <> lers("Locid") Then

                            'Mise en forme Nouveau Loc
                            locOrdre += 1
                            Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
                            appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")
                            appXL.Sheets.Add(, appXL.ActiveSheet)
                            Dim n As String = locOrdre & "." & lers("LocNom").ToString
                            If n.Length > 25 Then n = n.Substring(0, 25)
                            appXL.ActiveSheet.name = n
                            appXL.Columns.ColumnWidth = 15
                            appXL.Columns(1).ColumnWidth = 40
                            appXL.ActiveWindow.DisplayGridlines = False
                            appXL.Range("A1").Value = "'Répartition charges " & lan & " / " & lers("LocNom")
                            appXL.Range("A3").Value = "'Lot"
                            appXL.Range("A4").Value = "'Type Lot"

                            'initialise les variables du loc
                            ligneCharge.Clear()
                            laligne = 6
                            lelocactuNom = nz(lers("locNom"), 0)
                            lelocActu = nz(lers("Locid"), 0)
                            lelotActu = 0
                            leBailActu = nz(lers("BailId"), 0)
                            laCol = 0
                            totalCharge = 0
                            laCat = ""
                            sousTotCat = 0
                        End If

                        'Mise en forme nouveau lot
                        laligne = 5
                        laCol += 3
                        appXL.Cells(3, laCol).value = "'" & lers("LotNom") & " - " & lers("Batiment")
                        appXL.Cells(4, laCol).value = "'" & lers("TlocalNom")
                        appXL.Columns(laCol).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                        appXL.Columns(laCol + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                        appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).Merge()
                        appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                        appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).Merge()
                        appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                        appXL.Cells(laligne, laCol).value = "'Quote-Part"
                        appXL.Cells(laligne, laCol + 1).value = "'Prorata Surface"
                        appXL.Cells(laligne, laCol + 2).value = "'Montant Lot"
                        lelotActu = nz(lers("lotid"), 0)
                        leBailActu = nz(lers("BailId"), 0)
                        totalCharge = 0
                        sousTotCat = 0
                    End If

                    'Mise en forme  nouvelle catéorie
                    laligne += 2
                    laCat = lers("tChCatLib")
                    If laCol = 3 Then
                        appXL.Cells(laligne, 1).value = lers("tChCatLib")
                        appXL.Cells(laligne, 1).Font.Bold = True
                        ligneCharge.Add(laligne)
                    End If
                End If

                laligne += 1

                'ecrit la 1er colonne
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = lers("chlib")
                    appXL.Cells(laligne, 2).value = lers("chmontantHT")
                End If

                If lers("CleLoc") = 0 Then
                    appXL.Cells(laligne, laCol).value = "'" & nz(lers("QuotePart"), 0) & " / " & nz(lers("TotalQuotePart"), 0)
                    If lers("Loc") = True Then
                        appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceMoyLocTot"), 0)
                    Else
                        appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceLot"), 0)
                    End If
                End If

                appXL.Cells(laligne, laCol + 2).value = lers("chMontantHtLoc")

                totalCharge += nz(lers("chMontantHtLoc"), 0)
                sousTotCat += nz(lers("chMontantHtLoc"), 0)

            End While
            lers.Close()

            'mise en forme loc
            If lelocactuNom <> "" Then
                'Mise en forme derniere catégorie
                If laCat <> "" Then
                    laligne += 1
                    If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                    appXL.Cells(laligne, laCol + 2).value = sousTotCat
                    sousTotCat = 0
                    '               ligneCharge.Add(laligne + 2)
                End If

                'Mise en forme dernier lot
                If lelotActu <> 0 Then
                    laligne += 2
                    appXL.Cells(laligne, laCol + 2).value = totalCharge
                    appXL.Cells(laligne, 1).value = "'Total Lot"

                    With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 3))
                        .Interior.Color = RGB(155, 194, 230)
                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                    End With

                    appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 3)).Interior.Color = RGB(155, 194, 230)

                End If

                'Mise en forme dernier loc
                appXL.Columns(laCol + 3).NumberFormat = "#,##0.00"
                'Colonne total
                appXL.Cells(4, laCol + 3).value = "Total"
                Dim tligne As Decimal = 0
                For tc = 6 To laligne
                    tligne = 0
                    If appXL.Cells(tc, 1).Font.Bold = False And appXL.Cells(tc, 1).value <> "" Then
                        For td = 3 To laCol Step 3
                            tligne += appXL.Cells(tc, td + 2).value
                        Next
                        appXL.Cells(tc, laCol + 3).value = tligne
                    End If
                Next

                For i = 0 To ligneCharge.Count - 2
                    With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 3))
                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                    End With
                    appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 3)).Interior.Color = RGB(155, 194, 230)
                Next

                ssql = "select tchCatOrdre, loyerht,chargeht as prov, sum(chmontantHTLoc) as charge from repartcharge" _
                    & " where locid = " & Me.leLocId _
                    & " group by locid,loyerht,chargeht, tchCatOrdre"

                Dim LesLoyers As Decimal = 0
                Dim lesProv As Decimal = 0
                Dim lesCharges As Decimal = 0
                Dim lesHono As Decimal = 0
                lers = sqlLit(ssql, conSql)
                While lers.Read
                    If lers("tchCatOrdre") = 9999 Then
                        lesHono += nz(lers("charge"), 0)
                    Else
                        LesLoyers = nz(lers("loyerht"), 0)
                        lesProv = nz(lers("prov"), 0)
                        lesCharges += nz(lers("charge"), 0)
                    End If
                End While
                lers.Close()

                'affiche global

                appXL.Cells(laligne + 2, laCol + 2).value = "Loyers"
                appXL.Cells(laligne + 3, laCol + 2).value = "Honoraires"
                appXL.Cells(laligne + 5, laCol + 2).value = "Total Charges"
                appXL.Cells(laligne + 6, laCol + 2).value = "Provisions"
                appXL.Cells(laligne + 7, laCol + 2).value = "Solde"
                appXL.Cells(laligne + 2, laCol + 3).value = LesLoyers
                appXL.Cells(laligne + 3, laCol + 3).value = lesHono
                appXL.Cells(laligne + 5, laCol + 3).value = lesCharges + lesHono
                appXL.Cells(laligne + 6, laCol + 3).value = -lesProv
                appXL.Cells(laligne + 7, laCol + 3).value = lesCharges + lesHono - lesProv

                appXL.Cells(laligne + 3, laCol + 2).Interior.Color = RGB(155, 194, 230)
                appXL.Cells(laligne + 5, laCol + 2).Interior.Color = RGB(155, 194, 230)
                appXL.Cells(laligne + 7, laCol + 2).Interior.Color = RGB(155, 194, 230)
                appXL.Cells(laligne + 3, laCol + 3).Interior.Color = RGB(155, 194, 230)
                appXL.Cells(laligne + 5, laCol + 3).Interior.Color = RGB(155, 194, 230)
                appXL.Cells(laligne + 7, laCol + 3).Interior.Color = RGB(155, 194, 230)

            End If

            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            StatutBar("")
            appXL.StatusBar = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Button16_Click_1(sender As System.Object, e As System.EventArgs) Handles Button16.Click

        If Me.gCompta.SelectedRows.Count < 1 Then Exit Sub
        StatutBar("Génération appel")

        Dim lefichier As String
        lefichier = My.Settings.ChemTemp & "Appel-" & Me.gCompta.SelectedRows(0).Cells("numfacture").Value & " " & Now.ToString("yyyyMMdd HHmmss") & ".pdf"

        With Me.gCompta.SelectedRows(0)
            If .Cells("numfacture").Value <> "" Then Call EditionAppel(.Cells("numfacture").Value, .Cells("numfactureInterne").Value, Me.tSocId.Text, leLocId, lefichier)
        End With

        StatutBar("Préparation email")
        F_Email.leLoc = Me.leLocId
        F_Email.leSujet = Me.lLocat.Text & " - Appel de loyer " & Me.gCompta.SelectedRows(0).Cells("numfacture").Value
        F_Email.laPiece = lefichier
        Call F_Email.ShowDialog()

        StatutBar("")


    End Sub


    Private Sub gGrandLivre_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gGrandLivre.CellDoubleClick
        Dim f As New F_ComptaModif
        If e.RowIndex >= 0 Then
            f.lEcrId = Me.gGrandLivre.Rows(e.RowIndex).Cells("ecrid").Value
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Call affcomptalocat()
                Call AffGrandLivreLoc()
            End If
            f.Dispose()
        End If
    End Sub



    Private Sub gPlanCpt_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gPlanCpt.CellContentClick
    End Sub

    Private Sub gPlanCpt_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gPlanCpt.CellDoubleClick, Button18.Click
        F_LocaPlanC.leLocId = Me.leLocId
        F_LocaPlanC.lePCId = Val(Me.gPlanCpt.Rows(e.RowIndex).Cells("pcid").Value)
        F_LocaPlanC.larubid = Val(Me.gPlanCpt.Rows(e.RowIndex).Cells("rubid").Value)

        If F_LocaPlanC.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call AffPlanCpt()
        End If
    End Sub

    Private Sub bFacture_Click(sender As Object, e As EventArgs) Handles bFacture.Click

        If Me.leLocId = 0 Then Exit Sub

        F_FactureClient.leTiersid = Me.leLocId
        F_FactureClient.laSocId = Me.tSocId.Text
        If F_FactureClient.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call affcomptalocat()
            Call afficheLocat()
            Me.oOnglet.SelectTab("Compte")
        End If
    End Sub

    Private Sub gCompta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gCompta.CellContentClick

    End Sub
End Class