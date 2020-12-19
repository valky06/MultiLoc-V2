Public Class F_annuaire

    Private Sub F_annuaire_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ComboRempli("Select tContactid,tContactlib from typeContact", Me.cTypeAdr, conSql)
    End Sub

    Sub listeAnnuaire()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gAnnuaire.Rows.Clear()
        sSql = "SELECT contact.PersId, nom,NomPrenom, contact.TelBureau, contact.TelMobile, contact.Fax, contact.Email" _
        & " FROM Contact " _
        & " left join annuaire on contact.persid=annuaire.persid " _
        & " left join typeContact on annuaire.tContactid = typeContact.tContactid" _
        & " where (nom like '%" & Me.tRech.Text & "%' or NomPrenom like '%" & Me.tRech.Text & "%')"

        If Me.cTypeAdr.Text <> "" Then sSql &= " and tContactLib like '%" & Me.cTypeAdr.Text & "%'"
        sSql &= " order by nom,NomPrenom"

        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gAnnuaire.Rows.Add(lers(0), lers(1).ToString, lers(2).ToString, lers(3).ToString, lers(4).ToString, lers(5).ToString, lers(6).ToString)
        End While
        lers.Close()
    End Sub

    Private Sub bRech_Click(sender As System.Object, e As System.EventArgs) Handles bRech.Click
        Call listeAnnuaire()
    End Sub



    Private Sub tRech_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tRech.KeyUp
        If e.KeyCode = Keys.Enter Then Call listeAnnuaire()
    End Sub

    Private Sub gAnnuaire_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gAnnuaire.CellContentClick

    End Sub



    Private Sub gAnnuaire_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gAnnuaire.CellDoubleClick
        If e.ColumnIndex = 6 Then
            If Me.gAnnuaire.SelectedRows(0).Cells(6).Value <> "" Then
                Process.Start("mailto:" & Me.gAnnuaire.SelectedRows(0).Cells(6).Value)
            End If
        Else
            F_pers.lID = Me.gAnnuaire.SelectedRows(0).Cells(0).Value
            If F_pers.ShowDialog = Windows.Forms.DialogResult.OK Then
                Call listeAnnuaire()
            End If
            F_pers.Dispose()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        F_pers.lID = 0
        If F_pers.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeAnnuaire()
            For i = 0 To Me.gAnnuaire.RowCount - 1
                If Me.gAnnuaire.Rows(i).Cells("persid").Value = F_pers.lID Then
                    Me.gAnnuaire.Rows(i).Selected = True
                End If
            Next
        End If
        F_pers.Dispose()
    End Sub

    Private Sub tXL_Click(sender As System.Object, e As System.EventArgs) Handles tXL.Click
        Call XLexport(Me.gAnnuaire, "Annuaire", False)
    End Sub

    Private Sub tWord_Click(sender As System.Object, e As System.EventArgs) Handles tWord.Click
        If Me.gAnnuaire.SelectedRows.Count > 0 Then
            Call wordFusionSQL("courrier.docx", "SELECT nom, Adr1, CodePostal, Localite FROM Annuaire WHERE PersId=" & Me.gAnnuaire.SelectedRows(0).Cells("PersId").Value)

        End If
    End Sub

End Class