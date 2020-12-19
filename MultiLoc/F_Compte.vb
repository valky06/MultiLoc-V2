Public Class F_Compte

    Public laRubId As Integer


    Public leCptId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        If leCptId > 0 Then Call FormRempli(Me, "select cptid,cptnum,cptnom from planComptable where cptid=" & leCptId, conSql)
    End Sub

    Private Sub Enreg_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            leCptId = FormEnreg(Me, "PlanComptable", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class