Imports System.Math

Public Class F_LocaAppelLoyer
    Public LindiceActu As Decimal
    Public LindiceActuId As Integer

    Function Montant2Dates(leMontant As Decimal, debut As Date, fin As Date, Letexte As Windows.Forms.Label) As Decimal
        Dim montant As Decimal = 0
        Dim NbjoursAvant As Integer = 0, nbjoursApres As Integer = 0
        Dim nbMoisEntier As Integer = 0
        Dim d1 As Date
        Dim nbjourTxt As String = ""

        If debut < fin Then
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


    Sub calculNouveauLoyer()
        Dim IndDepart As Decimal = txt2num(Me.tIndiceDepart.Text)
        Dim LoyerDepart As Decimal = txt2num(Me.tLoyerDepart.Text)
        Dim nouveauLoyer As Decimal
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader

        'recherche de l'indice
        LindiceActu = 0
        LindiceActuId = 0

        'decalAnnee = (F_LocaSuivi.dEntree.Value.Year - txt2num(F_LocaAppel.tIndiceDepartAnnee.Text))

        'If decalAnnee < 0 Then
        '    ssql = "select top 1 indice,indId from indice where trimestrenum = " & F_LocaAppel.tIndiceDepartTrimNum.Text _
        '    & " and typeindice='" & F_LocaAppel.tIndiceDepartType.Text & "'" _
        '    & " and annee <=  " & F_LocaSuivi.dRevision.Value.Year _
        '    & " order by annee desc"
        'Else
        '    ssql = "select top 1 indice,indId from indice where trimestrenum = " & F_LocaAppel.tIndiceDepartTrimNum.Text _
        '    & " and typeindice='" & F_LocaAppel.tIndiceDepartType.Text & "'" _
        '    & " and annee = " & F_LocaSuivi.dRevision.Value.Year - decalAnnee _
        '    & " order by annee desc"
        'End If

        ssql = "select top 1 indice,indId from indice where trimestrenum = " & F_LocaAppel.tIndiceDepartTrimNum.Text _
        & " and typeindice='" & F_LocaAppel.tIndiceDepartType.Text & "'" _
        & " and annee > " & F_LocaAppel.tindiceActuAnnee.Text _
        & " and annee <=" & F_LocaSuivi.dRevision.Value.Year _
        & " order by annee desc"

        lers = sqlLit(ssql, conSql)
        While lers.Read
            LindiceActu = lers("indice")
            LindiceActuId = lers("indId")
        End While
        lers.Close()

        'Rempli le cadre Revision
        Me.gRevision.Enabled = False
        Me.tLoyerNew.Text = ""
        Me.tNouvelIndice.Text = ""

        If F_LocaSuivi.dRevision.Value <= Me.dFin.Value Then
            Me.gRevision.Enabled = True
            Me.tNouvelIndice.Text = "????"
            If Me.LindiceActu <> 0 Then
                Me.tNouvelIndice.Text = num2txt(Me.LindiceActu)
                If LoyerDepart <> 0 And IndDepart <> 0 Then
                    nouveauLoyer = num2txt(Round(LoyerDepart / IndDepart * LindiceActu, 2))
                    If (F_LocaSuivi.cLoyerReduc.Checked = True Or nouveauLoyer > txt2num(Me.tLoyerActu.Text)) And (nouveauLoyer <> txt2num(Me.tLoyerActu.Text)) Then

                        Me.tLoyerNew.Text = num2txt(num2txt(Round(LoyerDepart / IndDepart * LindiceActu, 2)))
                    End If
                End If
            End If
        End If
    End Sub

    Sub calculRegul()
        If Me.dRegulDeb.Value < Me.dDeb.Value And Me.tLoyerNew.Text <> "" Then
            Me.gRegul.Enabled = True
            Me.tRegulAppPro.Text = txt2num(Montant2Dates(txt2num(Me.tLoyerActu.Text) / 12, Me.dRegulDeb.Value, Me.dRegulFin.Value, Me.lRegul))
            Me.tRegulNouvPro.Text = txt2num(Montant2Dates(txt2num(Me.tLoyerNew.Text) / 12, Me.dRegulDeb.Value, Me.dRegulFin.Value, Nothing))
            Me.tRegulHT.Text = txt2num(Me.tRegulNouvPro.Text) - txt2num(Me.tRegulAppPro.Text)
            Me.tRegulTTC.Text = Round(txt2num(Me.tRegulHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)

        Else
            Me.gRegul.Enabled = False
            Me.tRegulAppPro.Text = ""
            Me.tRegulNouvPro.Text = ""
            Me.tRegulHT.Text = ""
            Me.tRegulTTC.Text = ""
        End If

    End Sub

    Private Sub calculAppel()

        Try
            tJour1.Text = ""
            tJour2.Text = ""
            tJour3.Text = ""

            If Me.dDeb.Value > Me.dFin.Value Then
                Me.tLoyerAppHT1.Text = 0
                Me.tLoyerAppTTC1.Text = 0
                Me.tChargeAppHT.Text = 0
                Me.tChargeAppTTC.Text = 0
                Exit Sub
            End If


            If F_LocaSuivi.dRevision.Value <= Me.dFin.Value And Me.tLoyerNew.Text <> "" Then
                If Me.dDeb.Value <= F_LocaSuivi.dRevision.Value Then
                    Me.tLoyerAppHT1.Text = txt2num(Montant2Dates(txt2num(Me.tLoyerActu.Text) / 12, Me.dDeb.Value, F_LocaSuivi.dRevision.Value.AddDays(-1), Me.tJour1))
                    Me.tLoyerAppHT2.Text = txt2num(Montant2Dates(txt2num(Me.tLoyerNew.Text) / 12, F_LocaSuivi.dRevision.Value, Me.dFin.Value, Me.tJour2))
                    Me.dFIn1.Value = F_LocaSuivi.dRevision.Value.AddDays(-1)
                    Me.dDeb2.Value = F_LocaSuivi.dRevision.Value
                Else
                    Me.tLoyerAppHT1.Text = "0"
                    Me.tLoyerAppHT2.Text = txt2num(Montant2Dates(txt2num(Me.tLoyerNew.Text) / 12, Me.dDeb.Value, Me.dFin.Value, Me.tJour2))
                    Me.dDeb2.Value = Me.dDeb.Value
                End If
                'End If
            Else
                Me.dFIn1.Value = Me.dFin.Value
                Me.tLoyerAppHT1.Text = txt2num(Montant2Dates(txt2num(Me.tLoyerActu.Text) / 12, Me.dDeb.Value, Me.dFin.Value, Me.tJour1))
                Me.tLoyerAppHT2.Text = "0"
            End If
            Me.tChargeAppHT.Text = txt2num(Montant2Dates(txt2num(Me.tChargeActu.Text) / 12, Me.dDeb.Value, Me.dFin.Value, Me.tJour3))

        Catch ex As Exception
            If debug Then MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()

        tJour1.Text = ""
        tJour2.Text = ""


        Me.tLoyerActu.Text = F_LocaSuivi.tLoyerActu.Text
        Me.tChargeActu.Text = F_LocaSuivi.tChargeActu.Text
        Me.tIndiceDepart.Text = F_LocaAppel.tIndiceDepartValeur.Text
        Me.tLoyerDepart.Text = F_LocaSuivi.tLoyer.Text
        Me.tLoyerNew.Text = ""

        If F_LocaSuivi.cLoyerTVA.Checked Then Me.tTauxTVA.Text = F_LocaSuivi.tTauxTVA.Text Else Me.tTauxTVA.Text = 0

        Me.dDeb.Value = F_LocaAppel.dDeb.Value
        Me.dFin.Value = F_LocaAppel.dFin.Value
        Me.dRegulDeb.Value = F_LocaSuivi.dRevision.Value
        Me.dRegulFin.Value = Me.dDeb.Value.AddDays(-1)
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim lapiece As Integer
        Dim lindiceid As Integer
        Dim i As Integer = 0


        If FormVerif(Me, Me.ErrorProvider1) Then
            'calcul nouvel indice si révision
            If Me.tLoyerAppTTC2.Text <> "" Then lindiceid = Me.LindiceActuId

            lapiece = NextNumPiece()
            'loyer avant révision
            If txt2num(Me.tLoyerAppHT1.Text) > 0 Then
                i += 1
                Dim lecrLoyer As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, lapiece, F_LocaAppel.leLocId, 0, 0, 0, F_LocaAppel.laSocId, 0, 0, 0, "Loyer du " & Me.dDeb.Value.ToString("dd/MM/yy") & " au " & Me.dFIn1.Value.ToString("dd/MM/yy"), txt2num(Me.tLoyerAppHT1.Text), txt2num(Me.tLoyerAppTTC1.Text), 100, F_LocaAppel.lafacture, Me.dDeb.Value, Me.dFin.Value, 0, "", Me.dDeb.Value.Year, 1)
                Call EnregCompta(lecrLoyer, ecrType.LocAppelLoyer)
            End If

            'loyer après révision
            If txt2num(Me.tLoyerAppHT2.Text) > 0 Then
                i += 1
                Dim lecrLoyer As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, lapiece, F_LocaAppel.leLocId, 0, 0, 0, F_LocaAppel.laSocId, 0, 0, 0, "Loyer du " & Me.dDeb2.Value.ToString("dd/MM/yy") & " au " & Me.dFin.Value.ToString("dd/MM/yy"), txt2num(Me.tLoyerAppHT2.Text), txt2num(Me.tLoyerAppTTC2.Text), 100, F_LocaAppel.lafacture, Me.dDeb.Value, Me.dFin.Value, lindiceid, "", Me.dDeb.Value.Year, 1)
                Call EnregCompta(lecrLoyer, ecrType.LocAppelLoyer)
            End If

            'charges
            If txt2num(Me.tChargeAppTTC.Text) <> 0 Then
                i += 1
                Dim lecrCharge As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, lapiece, F_LocaAppel.leLocId, 0, 0, 0, F_LocaAppel.laSocId, 0, 0, 0, "Prov. Charges du " & Me.dDeb.Value.ToString("dd/MM/yy") & " au " & Me.dFin.Value.ToString("dd/MM/yy"), txt2num(Me.tChargeAppHT.Text), txt2num(Me.tChargeAppTTC.Text), 100, F_LocaAppel.lafacture, Me.dDeb.Value, Me.dFin.Value, 0, "", Me.dDeb.Value.Year, 2)
                Call EnregCompta(lecrCharge, ecrType.LocAppelCharge)
            End If

            'Régul de loyer
            If txt2num(Me.tRegulTTC.Text) > 0 Then
                i += 1
                Dim lecrLoyer As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, lapiece, F_LocaAppel.leLocId, 0, 0, 0, F_LocaAppel.laSocId, 0, 0, 0, "Régul de loyer du " & Me.dRegulDeb.Value.ToString("dd/MM/yy") & " au " & Me.dRegulFin.Value.ToString("dd/MM/yy"), txt2num(Me.tRegulHT.Text), txt2num(Me.tRegulTTC.Text), 100, F_LocaAppel.lafacture, Me.dDeb.Value, Me.dFin.Value, 0, "", Me.dDeb.Value.Year, 1)
                Call EnregCompta(lecrLoyer, ecrType.LocAppelLoyer)
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
        Me.tLoyerAppTTC1.Text = Round(txt2num(Me.tLoyerAppHT1.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
        Me.tLoyerAppTTC2.Text = Round(txt2num(Me.tLoyerAppHT2.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
    End Sub


    Private Sub dFin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dFin.ValueChanged
        Call calculNouveauLoyer()
        Call calculRegul()
        Call calculAppel()
    End Sub

    Private Sub tChargeActu_TextChanged(sender As System.Object, e As System.EventArgs) Handles tChargeActu.TextChanged, tLoyerActu.TextChanged, tLoyerNew.TextChanged
        Call calculAppel()
    End Sub

    Private Sub Regul_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dRegulDeb.ValueChanged, dRegulFin.ValueChanged
        Call calculRegul()
    End Sub




    Private Sub tLoyerAppHT1_TextChanged(sender As System.Object, e As System.EventArgs) Handles tLoyerAppHT1.TextChanged
        Me.tLoyerAppTTC1.Text = Round(txt2num(Me.tLoyerAppHT1.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)

    End Sub

    Private Sub tLoyerAppHT2_TextChanged(sender As System.Object, e As System.EventArgs) Handles tLoyerAppHT2.TextChanged
        Me.tLoyerAppTTC2.Text = Round(txt2num(Me.tLoyerAppHT2.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)

    End Sub


    Private Sub dDeb_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDeb.ValueChanged
        Call calculNouveauLoyer()
        Call calculRegul()
        Call calculAppel()
    End Sub
End Class