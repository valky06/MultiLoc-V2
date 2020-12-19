Imports System.Math

Public Class F_LocaDGAvoir
    Public leLocId As Integer
    Public laSocId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Me.tLoyerHTTTC.Text = "HT"
        If F_LocaSuivi.cDGTVA.Checked Then Me.tTVA.Text = F_LocaSuivi.tTauxTVA.Text Else Me.tTVA.Text = "0"

        'calcul loyer
        Me.tLoyer.Text = F_LocaAvoir.tLoyerActu.Text
        If F_LocaAppel.tLoyerNew.Text <> "" Then Me.tLoyer.Text = F_LocaAvoir.tLoyerActu.Text

        If F_LocaSuivi.cDGLoyerTTC.Checked Then
            Me.tLoyerHTTTC.Text = "TTC"
            Me.tLoyer.Text = Math.Round(txt2num(Me.tLoyer.Text) * (1 + txt2num(F_LocaSuivi.tTauxTVA.Text) / 100), 2)
        End If

        'calcul DG
        If txt2num(Me.tNbMois.Text) <> 0 Then calculMontant(Nothing, Nothing)

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()

        Dim lapiece As Integer
        If FormVerif(Me, Me.ErrorProvider1) Then
            lapiece = NextNumPiece()

            Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dDate.Value, lapiece, leLocId, 0, 0, 0, Me.laSocId, 0, 0, 0, Me.tLib.Text, txt2num(Me.tDGHT.Text), txt2num(Me.tDGTTC.Text), 100, F_LocaAvoir.lafacture, Now, Now, 0, "", Me.dDate.Value.Year, 3)

            Call EnregCompta(lecr, ecrType.locAvoirDG)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub calculMontant(sender As System.Object, e As System.EventArgs) Handles tLoyer.TextChanged, tNbMois.TextChanged
        Me.tDGHT.Text = Math.Round(txt2num(Me.tLoyer.Text) / 12 * txt2num(Me.tNbMois.Text), 2)

    End Sub


    Private Sub tDGHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tDGHT.TextChanged, tTVA.TextChanged
        Me.tDGTTC.Text = Math.Round(txt2num(Me.tDGHT.Text) * (1 + txt2num(Me.tTVA.Text) / 100), 2)
    End Sub
End Class