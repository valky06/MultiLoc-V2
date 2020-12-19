Public Class F_societe
    Public laSocId As Integer

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tPersId.Text = F_AnnuRech.lePersId
            Me.tPersNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub

    Private Sub F_societe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String

        Me.ErrorProvider1.Clear()
        Call formVide(Me)

        If Me.laSocId <> 0 Then
            ssql = "select socid,persid,datecrea,capital,siren,codenaf,registrecommerce,gerant1,gerant2,pouvoir from societe" _
                & " where socid=" & Me.laSocId
            Call FormRempli(Me, ssql, conSql)
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            laSocId = FormEnreg(Me, "societe", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class