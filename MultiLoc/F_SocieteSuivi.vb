Imports System.IO
Public Class F_SocieteSuivi

    Public laSocId As Integer
    Public lePersId As Integer

    Sub ListeSociete()
        Dim sSql As String
        sSql = "SELECT societe.socid, Annuaire.nom" _
            & " FROM societe INNER JOIN Annuaire ON societe.PersId = Annuaire.PersId"
        Call ComboRempli(sSql, Me.lSociete, conSql)

    End Sub

    Sub listeBien()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        sSql = "SELECT lotId, copro.coproId, CoproNom, Batiment, tlocalnom, LotNom, Niveau, Statut,0, locActuId, nom" _
        & " FROM (copro left JOIN lot ON Lot.CoproId = Copro.CoproId) " _
        & "  LEFT JOIN (Locataire LEFT JOIN Annuaire ON Locataire.PersId = Annuaire.PersId) ON Lot.LocActuId = Locataire.LocId" _
        & " left join typelocal on lot.tlocalid = typelocal.tlocalid" _
        & " where copro.socid= " & laSocId _
        & " order by lotnom"

        Me.gLot.Rows.Clear()
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gLot.Rows.Add(lers(0), nz(lers(1), ""), nz(lers(2), ""), nz(lers(3), ""), nz(lers(4), ""), nz(lers(5), ""), nz(lers(6), ""), nz(lers(7), ""), nz(lers(8), ""), nz(lers(9), ""), nz(lers(10), ""))
        End While
    End Sub

    'Sub comptaSociete_Old()
    '    Dim sSql As String
    '    Dim lers As OleDb.OleDbDataReader
    '    Dim debit As Double
    '    Dim credit As Double
    '    Dim ladate As Date

    '    Try
    '        sSql = "SELECT  numpiece,journal, numfacture, journal,ecrDate, ecrLib, ecrMontantTTC FROM ComptaGene" _
    '        & " wheretiers='SOCIETE' and  socId= " & Me.lSociete.SelectedItem.value & " order by ecrDate desc"

    '        Me.gCompta.Rows.Clear()
    '        lers = sqlLit(sSql, conSql)
    '        While lers.Read
    '            debit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
    '            credit = IIf(lers("ecrmontantTTC") >= 0, lers("ecrmontantTTC"), 0)
    '            ladate = lers("ecrDate")
    '            Me.gCompta.Rows.Add(lers("numpiece"), lers("journal").ToString, ladate.ToString("yyyy-MM-dd"), lers("numFacture").ToString, lers("ecrLib").ToString, debit, credit)
    '        End While
    '        lers.Close()

    '        If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
    '    Catch ex As Exception
    '        If debug Then MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Sub affichePlanC()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        sSql = "select pcid, r.RubNom,A.Nom, cptnum,cptnom from ComptaPlan C " _
            & " inner Join locataire L on C.locid=L.LocId " _
            & " inner Join Annuaire A on A.PersId = L.PersId" _
            & " inner Join ComptaRubrique r on r.RubId = c.rubid" _
            & " where c.socid = " & laSocId & " order by cptnum"

        Me.gPlanC.Rows.Clear()
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gPlanC.Rows.Add(lers("pcid"), lers("RubNom").ToString, lers("Nom").ToString, lers("cptnum").ToString, lers("cptnom").ToString)
        End While
    End Sub

    Sub afficheonglet()
        Select Case oOnglet.SelectedIndex
            Case 0 : Call GrandLivreSoc()
            Case 1 : Call listeBien()
            Case 2 : Call DocListe(docType.Societe, laSocId, Me.gDoc)
            Case 3
            Case 4 : Call affichePlanC()
        End Select

    End Sub

    Sub afficheSociete()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        laSocId = Me.lSociete.SelectedItem.value

        sSql = "SELECT persId from societe where socid=" & laSocId
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.lePersId = lers("persId")
        End While
        lers.Close()

        sSql = "select modelefacture,modeleAppel from societe where socid=" & Me.laSocId
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.tModeleFacture.Text = nz(lers("Modelefacture"), "")
            Me.tModeleAppel.Text = nz(lers("modeleAppel"), "")
        End While
        lers.Close()

        sSql = "select socid,persid,datecrea,capital,siren,codenaf,registrecommerce,gerant1,gerant2,pouvoir,cptClient,SocCode from societe" _
            & " where socid=" & Me.laSocId
        Call FormRempli(Me.gSociete, sSql, conSql)
        Me.oOnglet.Enabled = True

        Call afficheonglet()
    End Sub

    Private Sub F_Societe_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.tRechCat.Text = ""
        Me.lAnnee.Items.Clear()
        For i = Now.Year - 2 To Now.Year + 2
            Me.lAnnee.Items.Add(New ListItem(i, i))
        Next
        Call ComboSelectTxt(Now.Year, Me.lAnnee)
        Me.gCompta.Rows.Clear()

        Call ListeSociete()
        If Me.laSocId <> 0 Then
            Call ComboSelectValue(laSocId, Me.lSociete)
        End If
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        If Me.lSociete.SelectedIndex < 0 Then Exit Sub
        Select Case oOnglet.SelectedTab.Text
            Case "Biens" : Call XLexport(Me.gLot, "Biens : " & Me.lSociete.Text)
            Case "Ecritures" : Call XLexport(Me.gCompta, "Ecritures : " & Me.lSociete.Text)

        End Select
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bWord.Click
        Dim ssql As String
        ssql = "SELECT nom, Adr1, CodePostal, Localite, telbureau, fax FROM Annuaire where persId=" & Me.lePersId
        Call wordFusionSQL("Proprio.docx", ssql)
    End Sub


    Private Sub gLot_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLot.CellContentClick
        If e.RowIndex > 0 Then
            Select Case e.ColumnIndex
                Case Me.gLot.Columns("copro").Index
                    F_CoproSuivi.lacoproId = Me.gLot.SelectedRows(0).Cells("CoproId").Value
                    Call F_main.mnuCopro_Click(Nothing, Nothing)
                    Me.Dispose()
                Case Me.gLot.Columns("lot").Index
                    F_LotSuivi.lelotId = Me.gLot.SelectedRows(0).Cells("lotId").Value
                    Call F_main.mnuLot_Click(Nothing, Nothing)
                    Me.Dispose()
                Case Me.gLot.Columns("locataire").Index
                    F_LocaSuivi.leLocId = Me.gLot.SelectedRows(0).Cells("locId").Value
                    Call F_main.Locataire_Click(Nothing, Nothing)
                    Me.Dispose()
            End Select
        End If
    End Sub

    Private Sub lproprio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lSociete.SelectedIndexChanged
        Call afficheSociete()
    End Sub

    Private Sub gLot_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLot.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        F_Document.leDocType = docType.Societe
        F_Document.lId = laSocId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Societe, laSocId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Societe, laSocId, Me.gDoc)

    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub


    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub


        If MessageBox.Show("Supprimer la facture '" & Me.gCompta.SelectedRows(0).Cells("numfacture").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            sqlDo("delete from comptagene where numfactureinterne='" & gCompta.SelectedRows(0).Cells("numfact").Value & "' and socid=" & laSocId, conSql)
            Call GrandLivreSoc()
            End If


    End Sub

    Private Sub kSociete_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles kSociete.LinkClicked
        If Me.lePersId <> 0 Then
            F_pers.lID = Me.lePersId
            If F_pers.ShowDialog() = Windows.Forms.DialogResult.OK Then Call ListeSociete()
        End If
    End Sub

    Private Sub bEditFActure_Click(sender As System.Object, e As System.EventArgs) Handles bEditFActure.Click
        'If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub
        'If Me.gCompta.SelectedRows(0).Cells("numFacture").Value = "" Then Exit Sub
        'If MessageBox.Show("Editer la Facture '" & Me.gCompta.SelectedRows(0).Cells("numFacture").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
        '    Call FactureEdition(Me.gCompta.SelectedRows(0).Cells("numpiece").Value, docType.Societe, "VENTES", Me.laSocId)
        'End If
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub
        If Me.gCompta.SelectedRows(0).Cells("numFacture").Value = "" Then Exit Sub
        If MessageBox.Show("Editer la Facture '" & Me.gCompta.SelectedRows(0).Cells("numFacture").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call FactureEdition(Me.gCompta.SelectedRows(0).Cells("numfacture").Value, Me.laSocId)
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.oDial.FileName = Me.tModeleFacture.Text
        If Me.oDial.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tModeleFacture.Text = Me.oDial.FileName.ToString
            sqlDo("update societe set modelefacture='" & Me.tModeleFacture.Text & "' where socId=" & Me.laSocId, conSql)
        End If
    End Sub

    Private Sub oDial_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles oDial.FileOk

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        F_societe.laSocId = 0
        If F_societe.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call ListeSociete()
            Call ComboSelectValue(F_societe.laSocId, Me.lSociete)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        laSocId = FormEnreg(Me.gSociete, "societe", conSql)
        MessageBox.Show("Enregistrement effectué")
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        F_Copro.lacoproID = 0
        F_Copro.laSocId = Me.laSocId
        If F_Copro.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeBien()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.oDial.FileName = Me.tModeleAppel.Text
        If Me.oDial.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tModeleAppel.Text = Me.oDial.FileName.ToString
            sqlDo("update societe set modeleAppel='" & Me.tModeleAppel.Text & "' where socId=" & Me.laSocId, conSql)
        End If
    End Sub

    Sub GrandLivreSoc()
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date
        Dim lEch As Date

        Try
            sSql = "SELECT l.nom as tiers,numfacture,'411' + cptsuffixe as cpt,  ecrLib, ecrMontantHT,ecrdate,ecrmontantTVA,ecrMontantTTC,lotlib,categorie,ecrecheance,numfactureinterne" _
            & " FROM ComptaGene " _
            & " left join locataire on ComptaGene.locId = locataire.locId " _
            & " left join annuaire as l on locataire.persId= l.persId " _
            & " WHERE ComptaGene.tiers='SOCIETE' " _
            & " and comptagene.socid=" & laSocId _
            & " and year(ecrecheance)=" & Me.lAnnee.Text

            If Me.tRechCat.Text <> "" Then sSql &= " and categorie like '%" & Me.tRechCat.Text & "%'"

            sSql &= " order by  ecrdate,numfacture,cptsuffixe,l.nom,ecrlib"


            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                ladate = lers("ecrdate")
                lEch = lers("ecrEcheance")
                Me.gCompta.Rows.Add(ladate.ToString("dd/MM/yyyy"), lEch.ToString("dd/MM/yyyy"), lers("cpt").ToString, lers("tiers").ToString, lers("Categorie").ToString, lers("lotlib").ToString, lers("numfacture").ToString, lers("ecrLIb").ToString, lers("ecrmontantHT"), lers("numfactureinterne"))
            End While
            lers.Close()

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tRechCat_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tRechCat.KeyUp
        If e.KeyCode = Keys.Enter Then Call GrandLivreSoc()
    End Sub

    Private Sub gPlanC_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gPlanC.CellDoubleClick
        If e.RowIndex >= 0 Then
            f_ComptaPlan.leSocId = Me.laSocId
            f_ComptaPlan.lePcId = Me.gPlanC.Rows(e.RowIndex).Cells("pcid").Value
            If f_ComptaPlan.ShowDialog = DialogResult.OK Then affichePlanC()
            f_ComptaPlan.Dispose()
        End If
    End Sub

    Private Sub gPlanC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gPlanC.CellContentClick

    End Sub

    Private Sub bAddCpt_Click(sender As Object, e As EventArgs) Handles bAddCpt.Click
        f_ComptaPlan.leSocId = Me.laSocId
        f_ComptaPlan.lePcId = 0
        If f_ComptaPlan.ShowDialog = DialogResult.OK Then affichePlanC()
        f_ComptaPlan.Dispose()
    End Sub

    Private Sub bDelCpt_Click(sender As Object, e As EventArgs) Handles bDelCpt.Click
        If Me.gPlanC.SelectedRows(0).Index >= 0 Then
            If MsgBox("Supprimer le compte " & Me.gPlanC.SelectedRows(0).Cells("cptnum").Value.ToString & " ?", MsgBoxStyle.OkCancel, "Attention") = DialogResult.OK Then
                sqlDo("Delete from ComptaPlan where pcid=" & Me.gPlanC.SelectedRows(0).Cells("pcid").Value.ToString, conSql)
                affichePlanC()
            End If
        End If
    End Sub

    Private Sub TabPage1_TabIndexChanged(sender As Object, e As EventArgs) Handles oOnglet.SelectedIndexChanged
        Call afficheonglet()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Me.laSocId = 0 Then Exit Sub
        'F_FactureLigne.laSocId = Me.laSocId
        'If F_FactureLigne.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    GrandLivreSoc()
        'End If
        'F_FactureLigne.Dispose()

        F_FactureEntete.laSocId = Me.laSocId
        If F_FactureEntete.ShowDialog = Windows.Forms.DialogResult.OK Then
            GrandLivreSoc()
        End If
        F_FactureEntete.Dispose()
    End Sub

    Private Sub PlanCompta_Click(sender As Object, e As EventArgs) Handles PlanCompta.Click

    End Sub

    Private Sub lAnnee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lAnnee.SelectedIndexChanged
        GrandLivreSoc()
    End Sub

    Private Sub gCompta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gCompta.CellContentClick

    End Sub

    Private Sub gCompta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gCompta.CellDoubleClick
        If Me.gCompta.Rows(e.RowIndex).Cells("Cat").Value = "VENTE" Then
            F_FactureEntete.laSocId = Me.laSocId
            F_FactureEntete.laFactNum = Me.gCompta.Rows(e.RowIndex).Cells("numfacture").Value
            If F_FactureEntete.ShowDialog = Windows.Forms.DialogResult.OK Then
                GrandLivreSoc()
            End If
            F_FactureEntete.Dispose()
        End If
    End Sub

    Private Sub Compta_Click(sender As Object, e As EventArgs) Handles Compta.Click

    End Sub
End Class