Public Class F_coproliste
    Private Change As Boolean


    Sub typeListe()
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gListe.Rows.Clear()
        ssql = "select coproid,copronom from copro order by copronom"
        lers = sqlLit(ssql, conSql)
        While lers.Read
            Me.gListe.Rows.Add(lers(0), lers(1).ToString)
        End While
        lers.Close()
    End Sub


    Private Sub F_TypeListe_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = IIf(Change, Windows.Forms.DialogResult.OK, Windows.Forms.DialogResult.Cancel)
    End Sub

    Private Sub F_TypeListe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Call typeListe()
            Change = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Supprime_Click(sender As System.Object, e As System.EventArgs) Handles bSupprime.Click
        If Me.gListe.SelectedRows.Count < 1 Then Exit Sub
        '   If Not SuppressionPossible(Me.latable, Me.gListe.SelectedRows(0).Cells(1).Value) Then Exit Sub

        If MessageBox.Show("Supprimer '" & Me.gListe.SelectedRows(0).Cells(1).Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            sqlDo("Delete from copro where coproid = " & Me.gListe.SelectedRows(0).Cells(0).Value, conSql)
            Call typeListe()
            Change = True
        End If
    End Sub


    Private Sub NOuveau_Click(sender As System.Object, e As System.EventArgs) Handles bNouveau.Click
        F_Copro.lacoproID = 0
        If F_Copro.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call typeListe()
            Change = True
        End If
    End Sub

    Private Sub bModif_Click(sender As System.Object, e As System.EventArgs) Handles bModif.Click, gListe.CellDoubleClick
        If Me.gListe.SelectedRows.Count < 1 Then Exit Sub
        F_Copro.lacoproID = Me.gListe.SelectedRows(0).Cells(0).Value
        If F_Copro.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call typeListe()
            Change = True
        End If
    End Sub


End Class