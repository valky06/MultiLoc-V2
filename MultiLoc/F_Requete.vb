Public Class F_Requete
    Public laReq As String
    Public leNOm As String

    Private Sub F_Requete_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim leRs As OleDb.OleDbDataReader
        Dim lEntete As Boolean = True
        Me.WindowState = FormWindowState.Maximized
        leRs = sqlLit(laReq, conSql)
        While leRs.Read
            If lEntete Then
                Me.gReq.ColumnCount = leRs.FieldCount
                For i = 0 To leRs.FieldCount - 1
                    Me.gReq.Columns(i).HeaderText = leRs.GetName(i)
                Next i
                lEntete = False
            End If
            Me.gReq.ColumnHeadersDefaultCellStyle.BackColor = Drawing.Color.LightGray
            Me.gReq.Rows.Add()
            For i = 0 To leRs.FieldCount - 1 : Me.gReq.Rows(Me.gReq.RowCount - 1).Cells(i).Value = leRs(i) : Next i
        End While
        leRs.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call XLexport(Me.gReq, leNOm)
    End Sub
End Class