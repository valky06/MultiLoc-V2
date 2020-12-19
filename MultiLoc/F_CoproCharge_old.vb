Public Class F_CoproCharge_old
    Public lacoproId As Integer
    Public laSocId As Integer
    Public FactInterne As Boolean = False
    Public laPiece As String

    'Sub listeFournisseur()
    '    Call ComboRempli("SELECT FourId, nom FROM Fournisseur INNER JOIN Annuaire ON Fournisseur.PersId = Annuaire.PersId", Me.lFour, conSql)
    'End Sub

    Sub rubriqueBUdget()
        Dim ssql As String
        ssql = "SELECT    BudgetLigne.bliId, bliText FROM BudgetLigne " _
            & " INNER JOIN Budget ON BudgetLigne.budId = Budget.budId" _
            & " WHERE coproId = " & Me.lacoproId & " AND budAnnee = " & Me.dDate.Value.Year
        Call ComboRempli(ssql, Me.lBudget, conSql)

    End Sub

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String

        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call ComboRempli("SELECT cleId, cleNom from cleRepart where coproId= " & lacoproId, Me.lCleRepart, conSql)
        Call ComboRempli("SELECT CptId, CptNum + ' - ' + cptNom AS COmpte FROM PlanComptable wHERE CptNum Like '6%'", Me.lCompte, conSql)
        Me.tTauxTVA.Text = My.Settings.TVADefaut
        Call rubriqueBUdget()

        If Me.laPiece <> "" Then
            ssql = "SELECT ecrId, numpiece,numfacture, numfactureInterne, ecrDate,ecrEcheance, ecrLib,-ecrMontantHT as ecrMontantHT, -ecrMontantTTC as ecrMontantTTC,cptid,cleid FROM ComptaGene" _
            & " where rubrique='COPRO' and coproId= " & Me.lacoproId & " and numpiece ='" & laPiece & "'"
            Call FormRempli(Me, ssql, conSql)
            If Me.tNUmFactureINterne.Text <> "" Then FactInterne = True
        End If

        'Me.liFour.Enabled = Not FactInterne
        'Me.tFourId.Tag = IIf(FactInterne, "", "fourId,no")
        'tNumFacture.Tag = IIf(FactInterne, "", "numFactureFour,to")
        tNumFacture.Enabled = Not FactInterne

    End Sub


    'Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
    '    Me.ErrorProvider1.Clear()
    '    Dim laFactInterne As String = ""

    '    If FormVerif(Me, Me.ErrorProvider1) Then
    '        If laPiece <> "" Then
    '            SupprEcr(laPiece)
    '            laFactInterne = Me.tNumFacture.Text
    '        Else
    '            If FactInterne Then laFactInterne = nextFactInterne(Me.laSocId, Me.dDate.Value.Year)
    '            laPiece = NextNumPiece()
    '        End If

    '        Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dEcheance.Value, laPiece, 0, Me.lacoproId, 0, 0, Me.laSocId, 0, Me.lCleRepart.SelectedItem.value, Me.lCompte.SelectedItem.value, Me.tlibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), IIf(Me.rLocataire.Checked, 100, 0), Me.tNumFacture.Text, Now, Now, 0, laFactInterne)
    '        If FactInterne Then
    '            lecr.NumFacture = nextFactInterne(Me.laSocId, Me.dDate.Value.Year)
    '            Call EnregCompta(lecr, ecrType.CoprochargeInt)
    '        Else
    '            '                lecr.FourId = Me.tFourId.Text
    '            lecr.NumFacture = Me.tNumFacture.Text
    '            Call EnregCompta(lecr, ecrType.CoprochargeExt)
    '        End If

    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Me.Close()
    '    End If
    'End Sub

    'Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles kFour.LinkClicked
    '    Dim leFour As Integer = 0
    '    If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        leFour = FournisseurAjoutPers(F_AnnuRech.lePersId)
    '        Call listeFournisseur()
    '        Call ComboSelectValue(leFour, Me.lFour)
    '    End If
    'End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.lCleRepart.SelectedIndex < 0 Then Exit Sub

        F_CleRepart.laCleId = Me.lCleRepart.SelectedItem.value
        If F_CleRepart.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call ComboRempli("SELECT cleId, cleNom from cleRepart where coproId= " & Me.lacoproId, Me.lCleRepart, conSql)
        End If
    End Sub


    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, tTauxTVA.Text)
    End Sub

    Private Sub tTauxTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles liFour.LinkClicked
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tFourId.Text = F_AnnuRech.lePersId
            Me.tFourNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub

    Private Sub dDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDate.ValueChanged
        Call rubriqueBUdget()
    End Sub

    Private Sub lBudget_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lBudget.SelectedIndexChanged
        Dim ssql As String
        Dim leRs As OleDb.OleDbDataReader

        ssql = "SELECT cleId, cptId FROM BudgetLigne where bliid = " & Me.lBudget.SelectedItem.value
        leRs = sqlLit(ssql, conSql)
        While leRs.Read
            Call ComboSelectValue(leRs(0), Me.lCleRepart)
            Call ComboSelectValue(leRs(1), Me.lCompte)
        End While
        leRs.Close()
        Me.tlibelle.Text = Me.lBudget.Text
    End Sub

End Class