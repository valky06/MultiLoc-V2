Imports System.IO
Public Class F_BanqueSuivi
    Public leCptBkId As Integer

    Sub listeCptBk()
        Dim sSql As String
        sSql = " select cptbkid,cptBknom from comptebancaire"
        Call ComboRempli(sSql, Me.lCptBk, conSql)
    End Sub

    Sub ComptaBanque()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim ladate As Date
        Dim vEchance As String = ""
        Dim leTiers As String
        Dim leTypeTiers As String = ""

        Try
            sSql = "SELECT ecrId, NumPIece, ecrDate, ecrEcheance, ecrLib, ecrMontantTTC, NumFacture, Annuaire_1.Nom AS Client, Annuaire_2.Nom AS Locataire, Annuaire.Nom AS Fournisseur, Tiers" _
            & " FROM ComptaGene " _
            & " LEFT JOIN Annuaire ON comptagene.fourid = Annuaire.PersId " _
            & " left join Client on ComptaGene.CliId = Client.cliId " _
            & " left join Annuaire AS Annuaire_1 ON Client.PersId = Annuaire_1.PersId" _
            & " left join locataire on ComptaGene.LocId = Locataire.LocId" _
            & " LEFT JOIN Annuaire AS Annuaire_2  ON Annuaire_2.PersId = Locataire.PersId " _
            & " WHERE  Tiers <> 'BANQUE' AND JOURNAL = 'BANQUE' " _
            & " and cptBkId = " & Me.leCptBkId _
            & " and ecrDate>=" & Date2sql(Me.dDate.Value) & " and ecrDate<=" & Date2sql(Me.dEcheance.Value) _
            & " ORDER BY ecrDate DESC"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                leTiers = ""
                If lers("Tiers").ToString = "CLIENT" Then leTiers = nz(lers("client"), "")
                If lers("Tiers").ToString = "LOCATAIRE" Then leTiers = nz(lers("locataire"), "")
                If lers("Tiers").ToString = "FOURNISSEUR" Then leTiers = nz(lers("fournisseur"), "")

                debit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
                credit = IIf(lers("ecrmontantTTC") > 0, lers("ecrmontantTTC"), 0)
                ladate = lers("ecrDate")
                Me.gCompta.Rows.Add(lers("ecrId"), lers("NumPIece").ToString, lers("Tiers").ToString, leTiers, ladate.ToString("yyyy-MM-dd"), lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub AfficheCptBk()
        Me.leCptBkId = Me.lCptBk.SelectedItem.value
        FormRempli(Me.gRIB, "Select cptbkID,persid, cptbkiban, cptbketab,cptbkguichet,cptbkCOmpte,cptbkcle,cptbkswift from comptebancaire where cptbkid= " & Me.leCptBkId, conSql)
        Call FormRempli(Me.gCoord, "SELECT nom, Adr1, CodePostal, Localite, telbureau, fax FROM Annuaire where persId=" & tPersId.Text, conSql)
        Call listecontact(Me.gContact, Me.tPersId.Text)
        Call ComptaBanque()
    End Sub

    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.dDate.Value = CDate("01/01/" & Now.Year)
        Me.dEcheance.Value = Now
        Call listeCptBk()
    End Sub


    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("numpiece").Value)
            Call ComptaBanque()
        End If
    End Sub

    Private Sub bXL_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        Call XLexport(Me.gCompta, "Compte Bancaire - " & Me.lCptBk.Text & " " & Now.ToString("dd/MM/yyyy"), False)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub dDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDate.ValueChanged
        Call ComptaBanque()
    End Sub

    Private Sub dEcheance_ValueChanged(sender As Object, e As System.EventArgs) Handles dEcheance.ValueChanged
        Call ComptaBanque()
    End Sub

    Private Sub lCptBk_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lCptBk.SelectedIndexChanged
        Call AfficheCptBk()
    End Sub

    Private Sub tNouveau_Click(sender As System.Object, e As System.EventArgs) Handles tNouveau.Click
        '  F_BanqueNew.leCptBkId = 0
        ' If F_BanqueNew.ShowDialog = Windows.Forms.DialogResult.OK Then Call listeCptBk()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'If Me.leCptBkId = 0 Then Exit Sub
        'F_BanqueNew.leCptBkId = Me.leCptBkId
        'If F_BanqueNew.ShowDialog = Windows.Forms.DialogResult.OK Then Call listeCptBk()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Call FormEnreg(Me.gRIB, "compteBancaire", conSql)
    End Sub

    Private Sub gRIB_Enter(sender As System.Object, e As System.EventArgs)

    End Sub
End Class