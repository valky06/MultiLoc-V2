Public Class F_CoproHono
    Private Sub F_locPreavis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = "5"
    End Sub

    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cRepartLoc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cRepartLoc.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cBudget.CheckedChanged
        Me.grCloture.Enabled = Not Me.cBudget.Checked
    End Sub
End Class