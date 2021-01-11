Public Class F_AnnuRech
    Public lePersId As Integer
    Public lePersNom As String

    Sub listeAnnuaire()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gAnnuaire.Rows.Clear()
        sSql = "SELECT PersId, nom, Adr1, CodePostal, Localite" _
            & " FROM Annuaire where nom like '%" & Me.trech.Text & "%'"
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gAnnuaire.Rows.Add(lers(0), lers(1), lers(2).ToString, lers(3).ToString, lers(4).ToString)
        End While
        lers.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call listeAnnuaire()
    End Sub

    Private Sub trech_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles trech.KeyUp
        If e.KeyCode = Keys.Enter Then Call listeAnnuaire()
    End Sub

    Private Sub gAnnuaire_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gAnnuaire.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.lePersId = Me.gAnnuaire.Rows(e.RowIndex).Cells("id").Value
            Me.lePersNom = Me.gAnnuaire.Rows(e.RowIndex).Cells("nom").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        F_pers.lID = 0
        If F_pers.ShowDialog = Windows.Forms.DialogResult.OK Then
            listeAnnuaire()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.gAnnuaire.SelectedRows.Count > 0 Then
            F_pers.lID = Me.gAnnuaire.SelectedRows(0).Cells(0).Value
            If F_pers.ShowDialog = Windows.Forms.DialogResult.OK Then Call listeAnnuaire()
            F_pers.Dispose()
        End If
    End Sub

    Private Sub gAnnuaire_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gAnnuaire.CellContentClick

    End Sub

    Private Sub F_AnnuRech_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class