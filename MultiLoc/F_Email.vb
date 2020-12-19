Imports System.Net.Mail
Imports System.Net


Public Class F_Email

    Public leLoc As Integer = 0
    Public laPiece As String = ""
    Public leSujet As String = ""

    Private Sub F_Email_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.tCorps.Text = My.Settings.EmailTxt
        Me.lkPiece.Text = laPiece


        sSql = "select distinct contact.email from contact" _
            & " inner join annuaire on annuaire.persid=contact.persid" _
            & " inner join locataire on locataire.persid=annuaire.persid" _
            & " where contact.email<>'' and locid = " & leLoc
        Call ComboRempli(sSql, Me.cDest, conSql)

        Me.cDest.SelectedIndex = 0

    End Sub

    Private Sub bEnvoi_Click(sender As System.Object, e As System.EventArgs) Handles bEnvoi.Click



        Dim objMessage As System.Net.Mail.MailMessage
        Dim objSMTPClient As System.Net.Mail.SmtpClient

        Try
            objMessage = New System.Net.Mail.MailMessage()
            objMessage.From = New System.Net.Mail.MailAddress(My.Settings.EmailAdr)
            objMessage.To.Add(New System.Net.Mail.MailAddress(Me.cDest.Text))
            objMessage.CC.Add(New System.Net.Mail.MailAddress(My.Settings.EmailAdr))
            objMessage.Subject = leSujet
            objMessage.IsBodyHtml = False
            objMessage.Body = Me.tCorps.Text
            objMessage.Attachments.Add(New System.Net.Mail.Attachment(laPiece))
            objSMTPClient = New System.Net.Mail.SmtpClient(My.Settings.SrvSMTP, My.Settings.SrvSMTPPort)
            objSMTPClient.EnableSsl = False
            objSMTPClient.Credentials = New NetworkCredential(My.Settings.EmailAdr, My.Settings.EmailPwd)
            objSMTPClient.Send(objMessage)
            objSMTPClient.Dispose()

            MessageBox.Show("Email envoyé")

            My.Settings.EmailTxt = Me.tCorps.Text
            My.Settings.Save()

            Me.Dispose()

        Catch ex As Exception
            MsgBox("Exception : " & ex.Message)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lkPiece.LinkClicked
        System.Diagnostics.Process.Start(Me.lkPiece.Text)
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.Dispose()
    End Sub
End Class