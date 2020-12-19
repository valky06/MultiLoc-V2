Public Class F_Copro

    Public lacoproID As Integer = 0
    Public laSocId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        If Me.lacoproID <> 0 Then
            Call FormRempli(Me, "select coproid,copronom,adr1,codepostal, localite,socid from copro where coproid=" & F_TypeListe.laSelId, conSql)
        Else
            Me.tSocId.Text = Me.laSocId
        End If
    End Sub

    Private Sub Enreg_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            lacoproID = FormEnreg(Me, "copro", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class