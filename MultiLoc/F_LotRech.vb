Public Class F_LotRech
    Public leLotId As String
    Public leLotNom As String
    Public laSurface As Decimal
    Public laSocId As Integer

    Sub listelot()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gLot.Rows.Clear()

        sSql = "SELECT lotId, CoproNom, Batiment, tlocalNom, LotNom, Niveau, Surface, lot.SocId" _
            & " FROM Lot INNER JOIN Copro ON Lot.CoproId = Copro.CoproId" _
            & " left join typelocal on typelocal.tlocalid = lot.tlocalid" _
            & " where (copronom like '%" & Me.trech.Text & "%'" _
            & " or batiment like '%" & Me.trech.Text & "%'" _
            & " or lotnom like '%" & Me.trech.Text & "%' )"

        If laSocId <> 0 Then sSql &= " and lot.Socid=" & laSocId

        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gLot.Rows.Add(lers("lotId"), lers("CoproNom").ToString, lers("Batiment").ToString, lers("tlocalnom").ToString, lers("LotNom").ToString, lers("Niveau").ToString, lers("Surface"), lers("SOcId").ToString)
        End While
        lers.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call listelot()
    End Sub

    Private Sub trech_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles trech.KeyUp
        If e.KeyCode = Keys.Enter Then Call listelot()
    End Sub

    Private Sub gLot_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLot.CellDoubleClick
        Me.leLotId = Me.gLot.Rows(e.RowIndex).Cells("Lotid").Value
        Me.leLotNom = Me.gLot.Rows(e.RowIndex).Cells("Batiment").Value & "-" & Me.gLot.Rows(e.RowIndex).Cells("Lotnom").Value
        Me.laSocId = Me.gLot.Rows(e.RowIndex).Cells("SOcId").Value
        Me.laSurface = nz(Me.gLot.Rows(e.RowIndex).Cells("Surface").Value, 0)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub F_LotRech_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gLot_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLot.CellContentClick

    End Sub
End Class