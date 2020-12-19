Public Class F_ClientCharge
    Public lecliid As Integer
    Public FactInterne As Boolean = False



    Sub listeTypeCharge()

        Me.lTypeCharge.Items.Clear()
        Me.lTypeCharge.Items.Add(New ListItem(ecrType.ClientFourniture, "Fourniture"))
        Me.lTypeCharge.Items.Add(New ListItem(ecrType.ClientArchivage, "Archivage"))
        Me.lTypeCharge.Items.Add(New ListItem(ecrType.ClientStockage, "Stockage"))
    End Sub

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call listeTypeCharge()
        Me.tTauxTVA.Text = My.Settings.TVADefaut
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim NumPiece As Integer

        If FormVerif(Me, Me.ErrorProvider1) Then
            NumPiece = NextNumPiece()
            lIndexPiece = 0
            Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dEcheance.Value, NumPiece, 0, 0, 0, lecliid, 0, 0, 0, 0, Me.tLibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), 100, "", Now, Now, 0, "", Me.dDate.Value.Year, Me.lTypeCharge.SelectedItem.value)
            lecr.NumFacture = nextFactInterne(0, Me.dDate.Value.Year)
            If Me.lTypeCharge.SelectedItem.value = ecrType.ClientStockage Then Call EnregCompta(lecr, ecrType.ClientStockage)
            If Me.lTypeCharge.SelectedItem.value = ecrType.ClientArchivage Then Call EnregCompta(lecr, ecrType.ClientArchivage)
            If Me.lTypeCharge.SelectedItem.value = ecrType.ClientFourniture Then Call EnregCompta(lecr, ecrType.ClientFourniture)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub

    Private Sub tTauxTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub
End Class