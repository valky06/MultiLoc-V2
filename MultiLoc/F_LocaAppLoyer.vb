Imports System.Math

Public Class F_LocaAppLoyer
    Dim Nbmois As Integer


    Sub calculNouveauLoyer()
        Dim IndActu As Decimal = txt2num(Me.tIndiceDepart.Text)
        Dim IndNew As Decimal = txt2num(Me.tIndiceActu.Text)
        Dim LoyerDepart As Decimal = txt2num(Me.tLoyerDepart.Text)
        If LoyerDepart <> 0 And IndActu <> 0 And IndNew <> 0 And IndActu < IndNew Then
            Me.tLoyerNew.Text = num2txt(Round(LoyerDepart / IndActu * IndNew, 2))
        Else
            Me.tLoyerNew.Text = Me.tLoyerActu.Text
        End If
    End Sub


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader

        Me.ErrorProvider1.Clear()
        If F_LocaFacture.cLoyerTVA.Checked Then Me.tTauxTVA.Text = F_LocaFacture.tTauxTVA.Text Else Me.tTauxTVA.Text = 0
        If F_LocaFacture.tperiode.Text.ToUpper.Contains("TRIM") Then
            Dim leMois As Integer = 4
            Nbmois = 3
            If Now.Month > 3 Then leMois += 3
            If Now.Month > 6 Then leMois += 3
            If Now.Month > 9 Then leMois = 1
            Me.dDeb.Value = CDate("01/" & leMois & "/" & Now.AddMonths(1).Year)
            Me.dFin.Value = Me.dDeb.Value.AddMonths(3).AddDays(-1)


        Else
            Nbmois = 1
            Me.dDeb.Value = CDate("01/" & Now.AddMonths(1).Month & "/" & Now.AddMonths(1).Year)
            Me.dFin.Value = Me.dDeb.Value.AddMonths(1).AddDays(-1)

        End If
        Me.tLoyerActu.Text = F_LocaFacture.tLoyerActu.Text
        Me.tChargeActu.Text = F_LocaFacture.tChargeActu.Text
        Me.tLoyerNew.Text = F_LocaFacture.tLoyerActu.Text

        If F_LocaFacture.dRevision.Value < Me.dDeb.Value Then
            Me.tIndiceDepart.Text = F_LocaFacture.tIndiceValeur.Text
            Me.tLoyerDepart.Text = F_LocaFacture.tLoyer.Text
            sSql = "select top 1 indice from indice where trimestrenum = " & F_LocaFacture.tIndiceNum.Text
            lers = sqlLit(sSql, conSql)
            While lers.Read
                Me.tIndiceActu.Text = num2txt(lers(0))
            End While
            lers.Close()
            Me.gRevision.Enabled = True
        Else
            Me.gRevision.Enabled = False
        End If

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim NumPiece As Integer

        NumPiece = NextNumPiece()
        If FormVerif(Me, Me.ErrorProvider1) Then

            Dim lecrLoyer As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, NumPiece, F_LocaFacture.leLocId, 0, 0, 0, F_LocaFacture.laSocId, 0, 0, 0, "Loyer " & Me.dDeb.Value.ToString("dd/MM/yy") & "-" & Me.dFin.Value.ToString("dd/MM/yy"), txt2num(Me.tLoyerAppHT.Text), txt2num(Me.tLoyerAppTTC.Text), 100, F_LocaFacture.lafacture)
            Call EnregCompta(lecrLoyer, ecrType.LocAppelLoyer)

            Dim lecrCharge As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, NumPiece, F_LocaFacture.leLocId, 0, 0, 0, F_LocaFacture.laSocId, 0, 0, 0, "Prov. Charges " & Me.dDeb.Value.ToString("dd/MM/yy") & "-" & Me.dFin.Value.ToString("dd/MM/yy"), txt2num(Me.tChargeAppHT.Text), txt2num(Me.tChargeAppTTC.Text), 100, F_LocaFacture.lafacture)
            Call EnregCompta(lecrCharge, ecrType.LocAppelCharge)

            If Me.gRevision.Enabled = True And txt2num(Me.tLoyerNew.Text) <> txt2num(Me.tLoyerActu.Text) Then
                Dim lecrRevision As New EcritureCompta(Me.dDeb.Value, Me.dDeb.Value, NumPiece, F_LocaFacture.leLocId, 0, 0, 0, F_LocaFacture.laSocId, 0, 0, 0, "Révision de loyer annuel : " & Me.tLoyerNew.Text & " (nouvel indice = " & Me.tIndiceActu.Text & ")", 0, 0, 100, F_LocaFacture.lafacture)
                Call EnregCompta(lecrRevision, ecrType.LocAppelLoyer)
                F_LocaFacture.tLoyerActu.Text = Me.tLoyerNew.Text
                F_LocaFacture.dRevision.Value = F_LocaFacture.dRevision.Value.AddYears(Now.Year - F_LocaFacture.dRevision.Value.Year + 1)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub


    Private Sub calculLoyer(sender As System.Object, e As System.EventArgs) Handles tChargeActu.TextChanged, _
         tLoyerActu.TextChanged, dDeb.ValueChanged, dFin.ValueChanged, tLoyerNew.TextChanged
        Dim Fin As Date
        Dim deb As Date
        Dim nbJourAvant, NbjourApres As Integer
        Dim nbMoisEntier As Integer = 0
        Dim totaljour As String = ""

        If Me.dDeb.Value > Me.dFin.Value Or Nbmois = 0 Then
            Me.tLoyerAppHT.Text = 0
            Me.tLoyerAppTTC.Text = 0
            Me.tChargeAppHT.Text = 0
            Me.tChargeAppTTC.Text = 0
            Me.lJour.Text = "0 jours"
            Exit Sub
        End If

        nbJourAvant = 0
        NbjourApres = 0
        deb = Me.dDeb.Value
        Fin = CDate("01/" & deb.AddMonths(1).Month & "/" & deb.AddMonths(1).Year).AddDays(-1)
        If Fin > Me.dFin.Value Then Fin = Me.dFin.Value

        'calcul le Nb jour avant le 1er mois complet
        If Me.dDeb.Value.Day <> 1 Then
            nbJourAvant = DateDiff(DateInterval.Day, deb, Fin) + 1
            deb = Fin.AddDays(1)
        End If

        'calcul le NB de mois complets
        Fin = CDate("01/" & deb.AddMonths(1).Month & "/" & deb.AddMonths(1).Year).AddDays(-1)
        While Fin <= Me.dFin.Value
            nbMoisEntier += 1
            deb = Fin.AddDays(1)
            Fin = CDate("01/" & deb.AddMonths(1).Month & "/" & deb.AddMonths(1).Year).AddDays(-1)
        End While

        'calcul le nb jours du dernier mois non entier
        If deb <= Me.dFin.Value Then
            NbjourApres = Me.dFin.Value.Day
        End If

        If nbMoisEntier > 0 Then totaljour = nbMoisEntier & " mois "
        If (NbjourApres + nbJourAvant) > 0 Then totaljour &= (NbjourApres + nbJourAvant) & " jours"

        Me.lJour.Text = totaljour

        Me.tChargeAppHT.Text = txt2num(Me.tChargeActu.Text) / 365 * (NbjourApres + nbJourAvant) + txt2num(Me.tChargeActu.Text) / 12 * nbMoisEntier
        Me.tLoyerAppHT.Text = txt2num(Me.tLoyerNew.Text) / 365 * (NbjourApres + nbJourAvant) + txt2num(Me.tLoyerNew.Text) / 12 * nbMoisEntier

        Me.tChargeAppHT.Text = Round(txt2num(Me.tChargeAppHT.Text), 2)
        Me.tLoyerAppHT.Text = Round(txt2num(Me.tLoyerAppHT.Text), 2)

        Me.tChargeAppTTC.Text = Round(txt2num(Me.tChargeAppHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
        Me.tLoyerAppTTC.Text = Round(txt2num(Me.tLoyerAppHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
    End Sub


    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub tIndiceDepart_TextChanged(sender As System.Object, e As System.EventArgs) Handles tIndiceDepart.TextChanged
        calculNouveauLoyer()
    End Sub

    Private Sub tIndiceActu_TextChanged(sender As System.Object, e As System.EventArgs) Handles tIndiceActu.TextChanged
        calculNouveauLoyer()
    End Sub


    Private Sub tChargeAppHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tChargeAppHT.TextChanged
        Me.tChargeAppTTC.Text = Round(txt2num(Me.tChargeAppHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
    End Sub

    Private Sub tTauxTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTauxTVA.TextChanged
        Me.tChargeAppTTC.Text = Round(txt2num(Me.tChargeAppHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
        Me.tLoyerAppTTC.Text = Round(txt2num(Me.tLoyerAppHT.Text) * (1 + txt2num(Me.tTauxTVA.Text) / 100), 2)
    End Sub
End Class