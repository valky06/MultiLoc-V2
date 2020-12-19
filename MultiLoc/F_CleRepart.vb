Public Class F_CleRepart
    Public laCleId As Integer
    Public lacoproId As Integer


    Private Sub F_locPreavis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call formVide(Me)
        Me.CheckBox1.Enabled = True
        Me.CheckBox1.Checked = False
        Me.tCoproId.Text = lacoproId
        If laCleId <> 0 Then
            Call FormRempli(Me, "select cleid,coproid,clenom,cleloc from cleRepart where cleid=" & Me.laCleId, conSql)
            Me.CheckBox1.Enabled = False
        Else

            Me.tCoproId.Text = lacoproId
        End If
    End Sub


    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.laCleId = FormEnreg(Me, "CleRepart", conSql)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class