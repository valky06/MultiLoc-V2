Public Class F_Document
    Public leDocId As Integer = 0
    Public leDocType As Integer
    Public lId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tDateCrea.Text = Date2sql(Now).ToString.Replace("'", "")
        Me.tDOcId.Text = leDocId
        Me.tId.Text = lId
        Select Case leDocType
            Case docType.Four : Me.tId.Tag = "fourId,n"
            Case docType.Copro : Me.tId.Tag = "CoproId,n"
            Case docType.Loc : Me.tId.Tag = "LocId,n"
            Case docType.Lot : Me.tId.Tag = "LotId,n"
            Case docType.Societe : Me.tId.Tag = "SocId,n"
            Case docType.Client : Me.tId.Tag = "CliId,n"
            Case docType.Emplacement : Me.tId.Tag = "EmpId,n"
            Case docType.CptBank : Me.tId.Tag = "CptBkId,n"
        End Select

      End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            leDocId = FormEnreg(Me, "Document", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ldoc.LinkClicked
        If Me.OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tPath.Text = Me.OpenFile.FileName
        End If
    End Sub
End Class