Public Class F_BudgetLigne
    Public lacoproId As Integer
    Public leBUdgetId As Integer
    Public laLigneId As Integer


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tBudId.Text = leBUdgetId
        Call ComboRempli("select tchcatid,tchcatlib from typeChargeCat", Me.cCat, conSql)
        If laLigneId > 0 Then
            Call FormRempli(Me, "select bliId, budid, tchcatid, bliText, montantHT from budgetligne where bliid=" & Me.laLigneId, conSql)
        End If

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()

        If FormVerif(Me, Me.ErrorProvider1) Then
            FormEnreg(Me, "BudgetLigne", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

End Class