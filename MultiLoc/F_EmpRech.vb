Public Class F_EmpRech
    Public lEmpId As Integer
    Public lEmpNom As String

    Sub listeEmp()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gLot.Rows.Clear()
        sSql = "SELECT empId, Emplacement  FROM emplacement where emplacement like '%" & Me.trech.Text & "%'"

        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gLot.Rows.Add(lers("EmpId"), lers("Emplacement").ToString)
        End While
        lers.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call listeEmp()
    End Sub

    Private Sub trech_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles trech.KeyUp
        If e.KeyCode = Keys.Enter Then Call listeEmp()
    End Sub

    Private Sub gLot_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLot.CellDoubleClick
        Me.lEmpId = Me.gLot.Rows(e.RowIndex).Cells("Empid").Value
        Me.lEmpNom = Me.gLot.Rows(e.RowIndex).Cells("Emplacement").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class