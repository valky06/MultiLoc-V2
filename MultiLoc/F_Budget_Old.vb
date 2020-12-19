Public Class F_Budget_Old
    Public leBudId As Integer
    Public lacoproId As Integer


    Private Sub F_locPreavis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tCoproId.Text = lacoproId
        If leBudId <> 0 Then
            Call FormRempli(Me, "select budid,budNOm,budDateDebut,budDateFin,coproId from budget where budid=" & Me.leBudId, conSql)
        Else
            Me.tCoproId.Text = lacoproId
        End If
    End Sub


    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        If Not FormVerif(Me, ErrorProvider1) Then Exit Sub

        Call FormEnreg(Me, "Budget", conSql)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub dEntre_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDebut.ValueChanged
        Me.dFin.Value = Me.dDebut.Value.AddYears(1)
    End Sub
End Class