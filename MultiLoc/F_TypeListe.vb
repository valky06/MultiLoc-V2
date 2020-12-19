Public Class F_TypeListe
    Public laSelId As Integer
    Public laSelNom As String
    Public laForm As Windows.Forms.Form
    Public MOdeEdit As Boolean

    Private latable As String = ""
    Private lechampId As String = ""
    Private lechampNom As String = ""
    Private Change As Boolean


    Sub typeListe()
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gListe.Rows.Clear()
        ssql = "select " & Me.leChampId & "," & Me.lechampNom & " from " & laForm.Tag & " order by " & Me.lechampNom
        lers = sqlLit(ssql, conSql)
        While lers.Read
            Me.gListe.Rows.Add(lers(0), lers(1).ToString)
        End While
        lers.Close()
    End Sub

    Private Sub gAnnuaire_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gListe.CellDoubleClick
        If MOdeEdit Then
            Me.laSelId = Me.gListe.Rows(e.RowIndex).Cells(0).Value
            If laForm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Call typeListe()
                Change = True
            End If
        Else


            Me.laSelId = Me.gListe.Rows(e.RowIndex).Cells("id").Value
            Me.laSelNom = Me.gListe.Rows(e.RowIndex).Cells("nom").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub F_TypeListe_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = IIf(Change, Windows.Forms.DialogResult.OK, Windows.Forms.DialogResult.Cancel)
    End Sub

    Private Sub F_TypeListe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Me.Text = laForm.Text
            Me.gListe.Columns(1).HeaderText = laForm.Text
            Me.latable = laForm.Tag
            Me.lechampId = laForm.Controls("tId").Tag.split(",")(0)
            Me.lechampNom = laForm.Controls("tNom").Tag.split(",")(0)
            Call typeListe()
            Change = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Supprime_Click(sender As System.Object, e As System.EventArgs) Handles bSupprime.Click
        If Me.gListe.SelectedRows.Count < 1 Then Exit Sub
        '      If Not SuppressionPossible(Me.latable, Me.gListe.SelectedRows(0).Cells(1).Value) Then Exit Sub

        If MessageBox.Show("Supprimer '" & Me.gListe.SelectedRows(0).Cells(1).Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            sqlDo("Delete from " & Me.latable & " where  " & Me.lechampId & " = " & Me.gListe.SelectedRows(0).Cells(0).Value, conSql)
            Call typeListe()
            Change = True
        End If
    End Sub


    Private Sub NOuveau_Click(sender As System.Object, e As System.EventArgs) Handles bNouveau.Click
        Me.laSelId = 0
        If laForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call typeListe()
            Change = True
        End If
    End Sub

    Private Sub bModif_Click(sender As System.Object, e As System.EventArgs) Handles bModif.Click
        If Me.gListe.SelectedRows.Count < 1 Then Exit Sub
        Me.laSelId = Me.gListe.SelectedRows(0).Cells(0).Value
        If laForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call typeListe()
            Change = True
        End If
    End Sub


    Private Sub gListe_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gListe.CellContentClick

    End Sub
End Class