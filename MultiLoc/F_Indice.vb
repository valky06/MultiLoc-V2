Public Class F_Indice
    Public lId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call formVide(Me)
        Me.ErrorProvider1.Clear()
        If Me.lId <> 0 Then
            Call FormRempli(Me, "SELECT IndId, typeindice ,TrimestreNom ,annee,indice,TrimestreNUm,dateparution FROM Indice where indid=" & Me.lId, conSql)

        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tId.Text = F_AnnuRech.lePersId
            Me.tNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()

        If FormVerif(Me, Me.ErrorProvider1) Then
            Me.lId = FormEnreg(Me, "indice", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTrimNum.TextChanged
        Select Case Me.tTrimNum.Text
            Case "1" : Me.tNom.Text = "1er trimestre"
            Case "2" : Me.tNom.Text = "2ème trimestre"
            Case "3" : Me.tNom.Text = "3ème trimestre"
            Case "4" : Me.tNom.Text = "4ème trimestre"
        End Select
    End Sub
End Class