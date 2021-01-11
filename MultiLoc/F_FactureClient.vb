Public Class F_FactureClient
    Public leTiersid As Integer
    Public laSocId As Integer

    Sub Numfact()
        Me.tNum.Text = nextFactInterne(Me.laSocId, Year(Me.dDate.Value))
        Me.tNumFacture.Text = nextFacture(Me.laSocId, Year(Me.dDate.Value))
    End Sub

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tTauxTVA.Text = My.Settings.TVADefaut
        Call ComboRempli("select rubid,rubnom from comptarubrique where rubid>4", Me.lRubrique, conSql)
        Call ComboRempli("SELECT socid, nom FROM societe INNER JOIN Annuaire ON societe.PersId = Annuaire.PersId", Me.lSociete, conSql)
        If laSocId <> 0 Then
            Call ComboSelectValue(laSocId, lSociete)
            Me.lSociete.Enabled = False
        Else
            Me.lSociete.SelectedIndex = 0
            laSocId = Me.lSociete.SelectedItem.value
        End If

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim lapiece As Integer

        If FormVerif(Me, Me.ErrorProvider1) Then
            lapiece = NextNumPiece()
            Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dEcheance.Value, lapiece, leTiersid, 0, 0, 0, Me.laSocId, 0, 0, 0, Me.tLibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), 100, Me.tNumFacture.Text, Now, Now, 0, Me.tNum.Text, Me.dDate.Value.Year, Me.lRubrique.SelectedItem.value)
            lecr.NumFacture = Me.tNumFacture.Text
            Call EnregCompta(lecr, ecrType.ClientFacture)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged, tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub

    Private Sub dDate_ValueChanged(sender As Object, e As EventArgs) Handles dDate.ValueChanged
        Call Numfact()
    End Sub

    Private Sub lSociete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lSociete.SelectedIndexChanged
        laSocId = Me.lSociete.SelectedItem.value
        Call Numfact()

    End Sub
End Class