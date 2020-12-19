Public Class F_IndiceListe
    Public laSelId As Integer
    Private change As Boolean

    Sub IndiceListe()
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gIndice.Rows.Clear()
        ssql = "select indId,TypeIndice, annee, trimestreNum, indice,dateparution from indice order by annee desc, trimestreNUm desc,typeIndice"
        lers = sqlLit(ssql, conSql)
        While lers.Read
            Me.gIndice.Rows.Add(lers("IndId"), lers("TypeIndice").ToString, lers("annee").ToString, lers("trimestreNum").ToString, lers("DatePArution"), lers("indice").ToString)
        End While
        lers.Close()
    End Sub

    Private Sub F_IndiceListe_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.DialogResult = IIf(change, Windows.Forms.DialogResult.OK, Windows.Forms.DialogResult.Cancel)
    End Sub



    Private Sub F_TypeListe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call IndiceListe()
        change = False
    End Sub

    Private Sub Supprime_Click(sender As System.Object, e As System.EventArgs) Handles bSupprime.Click
        If Me.gIndice.SelectedRows.Count < 1 Then Exit Sub
        If MessageBox.Show("Supprimer ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            sqlDo("Delete from indice where indid = " & Me.gIndice.SelectedRows(0).Cells(0).Value, conSql)
            Call IndiceListe()
            change = True
        End If
    End Sub


    Private Sub NOuveau_Click(sender As System.Object, e As System.EventArgs) Handles bNouveau.Click
        F_Indice.lId = 0
        If F_Indice.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call IndiceListe()
            F_Indice.Dispose()
            change = True
        End If
    End Sub

    Private Sub bModif_Click(sender As System.Object, e As System.EventArgs) Handles bModif.Click
        If Me.gIndice.SelectedRows.Count < 1 Then Exit Sub
        F_Indice.lId = Me.gIndice.SelectedRows(0).Cells(0).Value
        If F_Indice.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call IndiceListe()
            F_Indice.Dispose()
            change = True
        End If
    End Sub

    Private Sub gIndice_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gIndice.CellContentClick

    End Sub

    Private Sub gIndice_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gIndice.CellDoubleClick
        Me.laSelId = Me.gIndice.Rows(e.RowIndex).Cells("id").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class