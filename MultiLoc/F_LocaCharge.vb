Public Class F_LocaCharge
    Public laSocId As Integer
    Public leLocId As Integer
    Public factInterne As Boolean
    Public laFacture As String

    '    Sub listeFournisseur()
    '        Call ComboRempli("SELECT FourId, nom FROM Fournisseur INNER JOIN Annuaire ON Fournisseur.PersId = Annuaire.PersId", Me.lFour, conSql)
    '    End Sub


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tTauxTVA.Text = My.Settings.TVADefaut
        Call ComboRempli("select rubid,rubnom from comptarubrique where rubid>4", Me.lRubrique, conSql)
        If factInterne Then
            Me.liFour.Enabled = False
            Me.tFourId.Tag = ""
            '    Else
            ' Call listeFournisseur()
        End If
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim lapiece As Integer

        If FormVerif(Me, Me.ErrorProvider1) Then
            lapiece = NextNumPiece()
            If factInterne Then
                Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dEcheance.Value, lapiece, leLocId, 0, 0, 0, Me.laSocId, 0, 0, 0, Me.tLibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), 100, "", Now, Now, 0, "", Me.dDate.Value.Year, Me.lRubrique.SelectedItem.value)
                lecr.NumFacture = Me.laFacture
                Call EnregCompta(lecr, ecrType.LocChargeInt)
            Else
                Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dEcheance.Value, lapiece, leLocId, 0, Me.tFourId.Text, 0, Me.laSocId, 0, 0, 0, Me.tLibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), 100, "", Now, Now, 0, "", Me.dDate.Value.Year, Me.lRubrique.SelectedItem.value)
                lecr.NumFacture = Me.laFacture
                Call EnregCompta(lecr, ecrType.LocChargeExt)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged, tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles liFour.LinkClicked
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tFourId.Text = F_AnnuRech.lePersId
            Me.tFourNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub

    Private Sub tFourId_TextChanged(sender As System.Object, e As System.EventArgs) Handles tFourId.TextChanged

    End Sub

    Private Sub tFourNom_TextChanged(sender As System.Object, e As System.EventArgs) Handles tFourNom.TextChanged

    End Sub
End Class