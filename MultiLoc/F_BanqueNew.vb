Public Class F_BanqueNew
    Public leCptBkId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader


        Me.ErrorProvider1.Clear()


        Call formVide(Me)
        If Me.leCptBkId > 0 Then
            FormRempli(Me, "Select cptbkID, cptbkNom,cptbkiban, persId,cptbketab,cptbkguichet,cptbkCOmpte,cptbkcle,cptbkswift from comptebancaire where cptbkid= " & Me.leCptBkId, conSql)
            ssql = "select nom from annuaire where persid=" & Me.tPersId.Text
            lers = sqlLit(ssql, conSql)
            While lers.Read
                Me.tPersNom.Text = lers(0).ToString
            End While
            lers.Close()
        End If
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            leCptBkId = FormEnreg(Me, "CompteBancaire", conSql)
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