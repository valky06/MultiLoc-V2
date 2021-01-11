Public Class F_FactureSociete
    Public laSocId As Integer



    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tTauxTVA.Text = My.Settings.TVADefaut
        Call ComboRempli("select rubid,rubnom from comptarubrique where rubid>4", Me.lRubrique, conSql)
        Call ComboRempli("SELECT locid, nom FROM locataire INNER JOIN Annuaire ON locataire.PersId = Annuaire.PersId where typeloc=2", Me.lClient, conSql)
        Me.lClient.SelectedIndex = 0
        Me.tNum.Text = nextFactInterne(Me.laSocId, Year(Me.dDate.Value))
        Me.tNumFacture.Text = nextFacture(Me.laSocId, Year(Me.dDate.Value))
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim lapiece As Integer

        If FormVerif(Me, Me.ErrorProvider1) Then
            lapiece = NextNumPiece()
            Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dEcheance.Value, lapiece, Me.lClient.SelectedItem.value, 0, 0, 0, Me.laSocId, 0, 0, 0, Me.tLibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), 100, Me.tNumFacture.Text, Now, Now, 0, Me.tNum.Text, Me.dDate.Value.Year, Me.lRubrique.SelectedItem.value)
            lecr.NumFacture = Me.tNumFacture.Text
            Call EnregCompta(lecr, ecrType.ClientFacture)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged, tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub

End Class