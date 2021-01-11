Public Class F_ClientNew
    Public leCliId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tTypeLoc.Text = "2"
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            leCliId = FormEnreg(Me, "Locataire", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tPersId.Text = F_AnnuRech.lePersId
            Me.tPersNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub
End Class