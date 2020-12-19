Imports System.Math

Public Class F_LocaAvoirLoyer
    Public LindiceActu As Decimal
    Public LindiceActuId As Integer

    Function Montant2Dates(leMontant As Decimal, debut As Date, fin As Date, Letexte As Windows.Forms.Label) As Decimal
        Dim montant As Decimal = 0
        Dim NbjoursAvant As Integer = 0, nbjoursApres As Integer = 0
        Dim nbMoisEntier As Integer = 0
        Dim d1 As Date
        Dim nbjourTxt As String = ""

        If debut <= fin Then
            If debut.Month = fin.Month And debut.Year = fin.Year Then
                If DateDiff(DateInterval.Day, debut, fin) + 1 = FindeMois(debut).Day Then
                    NbjoursAvant = 0
                    montant = leMontant
                    nbMoisEntier = 1
                    nbjourTxt &= "1 mois"
                Else
                    NbjoursAvant = DateDiff(DateInterval.Day, debut, fin) + 1
                    montant = leMontant * NbjoursAvant / FindeMois(debut).Day
                    If NbjoursAvant > 0 Then nbjourTxt &= NbjoursAvant & "/" & FindeMois(debut).Day
                End If
            Else
                d1 = debut
                'calcul le nombre de jours jusqu'à la fin du mois
                If d1.Day = 1 Then
                    NbjoursAvant = 0
                    nbMoisEntier = 1
                Else
                    NbjoursAvant = DateDiff(DateInterval.Day, d1, FindeMois(d1)) + 1
                End If
                If NbjoursAvant > 0 Then nbjourTxt &= NbjoursAvant & "/" & FindeMois(d1).Day
                montant = NbjoursAvant * leMontant / FindeMois(d1).Day

                d1 = FindeMois(d1).AddDays(1)

                'calcul le nombre de mois entiers
                While FindeMois(d1) <= fin
                    nbMoisEntier += 1
                    d1 = FindeMois(d1).AddDays(1)
                End While

                If nbMoisEntier > 0 Then nbjourTxt &= IIf(nbjourTxt <> "", " + ", "") & nbMoisEntier & " mois"

                'calcul le nb jours du dernier mois non entier
                If d1 <= fin Then
                    nbjoursApres = DateDiff(DateInterval.Day, d1, fin) + 1
                    montant += leMontant * nbjoursApres / FindeMois(fin).Day
                End If
                If nbjoursApres > 0 Then nbjourTxt &= IIf(nbjourTxt <> "", " + ", "") & nbjoursApres & "/" & FindeMois(fin).Day

                montant += nbMoisEntier * leMontant
            End If

            If Not IsNothing(Letexte) Then Letexte.Text = nbjourTxt

            Return Round(montant, 2)
        Else
            Return 0
        End If

    End Function



    Private Sub calculAppel()

        Try
   
            Me.tLoyerAppHT2.Text = -txt2num(Montant2Dates(txt2num(Me.tLoyerActu.Text) / 12, Me.dDeb.Value, Me.dFin.Value, Me.tJour1))
            Me.tChargeAppHT.Text = -txt2num(Montant2Dates(txt2num(Me.tChargeActu.Text) / 12, Me.dDeb.Value, Me.dFin.Value, Me.tJour2))

        Catch ex As Exception
            If debug Then MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()



        Me.tLoyerActu.Text = F_LocaSuivi.tLoyerActu.Text
        Me.tChargeActu.Text = F_LocaSuivi.tChargeActu.Text
        If F_LocaSuivi.cLoyerTVA.Checked Then Me.tTauxTVA.Text = F_LocaSuivi.tTauxTVA.Text Else Me.tTauxTVA.Text = 0

        Me.dDeb.Value = F_LocaAppel.dDeb.Value
        Me.dFin.Value = F_LocaAppel.dFin.Value
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim lapiece As Integer


        If FormVerif(Me, Me.ErrorProvider1) Then
            lapiece = NextNumPiece()
            'loyer 
            If txt2num(Me.tLoyerAppHT2.Text) <> 0 Then
                Dim lecrLoyer As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, lapiece, F_LocaAvoir.leLocId, 0, 0, 0, F_LocaAvoir.laSocId, 0, 0, 0, "Avoir Loyer : " & Me.tLib.Text, txt2num(Me.tLoyerAppHT2.Text), txt2num(Me.tLoyerAppTTC2.Text), 100, F_LocaAvoir.lafacture, Me.dDeb.Value, Me.dFin.Value, 0, "", Me.dDeb.Value.Year, 1)
                Call EnregCompta(lecrLoyer, ecrType.locAvoirLoyer)
            End If

            'charges
            If txt2num(Me.tChargeAppTTC.Text) <> 0 Then
                Dim lecrCharge As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, lapiece, F_LocaAvoir.leLocId, 0, 0, 0, F_LocaAvoir.laSocId, 0, 0, 0, "Avoir Charges : " & Me.tLib.Text, txt2num(Me.tChargeAppHT.Text), txt2num(Me.tChargeAppTTC.Text), 100, F_LocaAvoir.lafacture, Me.dDeb.Value, Me.dFin.Value, 0, "", Me.dDeb.Value.Year, 2)
                Call EnregCompta(lecrCharge, ecrType.locAvoirCharge)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub tChargeAppHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tChargeAppHT.TextChanged
        Me.tChargeAppTTC.Text = Round(txt2num(Me.tChargeAppHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
    End Sub

    Private Sub tTauxTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTauxTVA.TextChanged
        Me.tChargeAppTTC.Text = Round(txt2num(Me.tChargeAppHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
        Me.tLoyerAppTTC2.Text = Round(txt2num(Me.tLoyerAppHT2.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
    End Sub

    Private Sub dFin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dFin.ValueChanged
        Call calculAppel()
    End Sub

    Private Sub tChargeActu_TextChanged(sender As System.Object, e As System.EventArgs) Handles tChargeActu.TextChanged, tLoyerActu.TextChanged
        Call calculAppel()
    End Sub


    Private Sub tLoyerAppHT2_TextChanged(sender As System.Object, e As System.EventArgs) Handles tLoyerAppHT2.TextChanged
        Me.tLoyerAppTTC2.Text = Round(txt2num(Me.tLoyerAppHT2.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
    End Sub


    Private Sub dDeb_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDeb.ValueChanged
        Call calculAppel()
    End Sub
End Class