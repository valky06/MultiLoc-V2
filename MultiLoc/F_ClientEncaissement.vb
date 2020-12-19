Public Class F_ClientEncaissement
    Public leCliId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.dReglt.Value = Now
        Me.tMontant.Text = ""
        Call ComboRempli("select cptbkid,cptbknom from comptebancaire", Me.lCptBk, conSql)
        Me.lCptBk.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Dim NumPiece As Integer
        NumPiece = NextNumPiece()
        Dim lecr As New EcritureCompta(Me.dReglt.Value, Me.dReglt.Value, NumPiece, 0, 0, 0, Me.leCliId, 0, Me.lCptBk.SelectedItem.value, 0, 0, Me.tLib.Text, txt2num(Me.tMontant.Text), txt2num(Me.tMontant.Text), 100, "", Now, Now, 0, "", Me.dReglt.Value.Year, 0)
        Call EnregCompta(lecr, ecrType.ClientEncaisse)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub






End Class