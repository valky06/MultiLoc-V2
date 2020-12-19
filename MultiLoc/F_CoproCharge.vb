Public Class F_CoproCharge
    Public lacoproId As Integer
    Public laChargeId As Integer
    Public lebudgetId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call ComboRempli("SELECT cleId, cleNom from cleRepart where coproId= " & lacoproId, Me.lCleRepart, conSql)
        Call ComboRempli("SELECT distinct 0, chlib FROM coprocharge  wHERE coproId =" & Me.lacoproId, Me.lRubrique, conSql)
        Call ComboRempli("Select tChcatId,tchCatLib from typeChargeCat", Me.lCat, conSql)
        Call ComboRempli("SELECT budId, budAnnee  from budget where coproId= " & Me.lacoproId, Me.lBudget, conSql)
        Me.tTauxTVA.Text = My.Settings.TVADefaut
        Me.tCoproId.Text = Me.lacoproId

        If Me.lebudgetId <> 0 Then Call ComboSelectValue(Me.lebudgetId, Me.lBudget)

        If Me.laChargeId <> 0 Then Call FormRempli(Me, "SELECT * FROM CoproCharge where chid=" & Me.laChargeId, conSql)
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Me.tMontantTVA.Text = txt2num(Me.tMontantTTC.Text) - txt2num(Me.tMontantHT.Text)

        If FormVerif(Me, Me.ErrorProvider1) Then

            Call FormEnreg(Me, "CoproCharge", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, tTauxTVA.Text)
    End Sub

    Private Sub tTauxTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub


    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class