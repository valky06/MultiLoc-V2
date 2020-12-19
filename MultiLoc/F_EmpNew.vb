Public Class F_EmpNew
    Public lEmplacement As String
    Public lEmpId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        If Me.lEmpId <> 0 Then
            Call FormRempli(Me, "select empid, emplacement from emplacement where empid=" & Me.lEmpId, conSql)
        End If
    End Sub

    Private Sub bEnreg_Click_1(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Call FormEnreg(Me, "Emplacement", conSql)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = False
        Me.Close()
    End Sub
End Class