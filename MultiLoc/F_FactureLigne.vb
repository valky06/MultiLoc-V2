Public Class F_FactureLigne
    Public laPiece As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Dim leRs As OleDb.OleDbDataReader

        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tTauxTVA.Text = My.Settings.TVADefaut
        Call ComboRempli("select rubid,rubnom from comptarubrique where rubid>4", Me.lRubrique, conSql)

        If laPiece > 0 Then
            sSql = "select ecrlib,ecrmontantHT,ecrmontantTTC,rubid from comptagene where numpiece=" & laPiece
            leRs = sqlLit(sSql, conSql)
            While leRs.Read
                Me.tLibelle.Text = leRs("ecrlib")
                Me.tMontantHT.Text = sql2num(-leRs("ecrmontantHT"))
                Me.tMontantTTC.Text = sql2num(-leRs("ecrmontantTTC"))
                ComboSelectValue(leRs("rubid"), Me.lRubrique)
            End While
            leRs.Close()
        Else
            laPiece = NextNumPiece()
        End If
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()


        If FormVerif(Me, Me.ErrorProvider1) Then
            If laPiece = 0 Then
                laPiece = NextNumPiece()
            Else
                Call SupprEcr(laPiece)
            End If

            Dim lecr As New EcritureCompta(F_FactureEntete.dDate.Value, F_FactureEntete.dEcheance.Value, laPiece, 0, 0, 0, 0, F_FactureEntete.laSocId, 0, 0, 0, Me.tLibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), 100, F_FactureEntete.lafact, Now, Now, 0, 0, F_FactureEntete.dDate.Value.Year, Me.lRubrique.SelectedItem.value)

            Call EnregCompta(lecr, ecrType.ClientFacture)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged, tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub

End Class