Imports System.Math
Imports System.IO

Public Class F_AppelLoyer


    Sub listeLocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim NbJour As Integer
        Dim dDeb As Date, dFInSortie As Date, dFinMois As Date, dFIn As Date
        Dim loyerActu As Decimal, chargeActu As Decimal
        Dim loyerApp As Decimal, chargeApp As Decimal
        Dim loyerAppTTC As Decimal, chargeAppTTC As Decimal
        Dim nbjourMois As Integer
        Dim dENtre As Date
        Dim nbmois As Integer

        Try
            Me.tMois.Text = txt2num(Me.tMois.Text)
            Me.tAn.Text = txt2num(Me.tAn.Text)

            dDeb = CDate("01/" & txt2num(Me.tMois.Text) & "/" & txt2num(Me.tAn.Text))
            Me.gAppel.Rows.Clear()

            sSql = "SELECT LocId, nom, DateEntree, DateSortie, LoyerActu, ChargeActu, tauxTVA,socId, tpernom" _
            & " FROM Annuaire INNER JOIN Locataire ON Annuaire.PersId = Locataire.PersId" _
            & " inner join typeperiode on typeperiode.tperid = locataire.tperid" _
            & "  where (dateSortie is null or dateSortie>'" & dDeb.ToString("MM/dd/yyyy") & "')"

            If dDeb.Month <> 1 And dDeb.Month <> 4 And dDeb.Month <> 7 And dDeb.Month <> 10 Then sSql &= " and tpernom like '%mensuel%'"

            lers = sqlLit(sSql, conSql)
            While lers.Read
                nbmois = IIf(lers("tpernom").ToString.ToUpper.Contains("TRIM"), 3, 1)

                dFinMois = dDeb.AddMonths(nbmois).AddDays(-1)
                nbjourMois = DateDiff(DateInterval.Day, dDeb, dFinMois) + 1

                loyerActu = Math.Round(nz(lers("LoyerActu"), 0) / 12 * nbmois, 2)
                chargeActu = Math.Round(nz(lers("chargeActu"), 0) / 12 * nbmois, 2)
                dFInSortie = nz(lers("dateSortie"), dFinMois)
                dFIn = IIf(dFinMois < dFInSortie, dFinMois, dFInSortie)
                NbJour = DateDiff(DateInterval.Day, dDeb, dFIn) + 1
                loyerApp = Math.Round(loyerActu / nbjourMois * NbJour, 2)
                chargeApp = Math.Round(chargeActu / nbjourMois * NbJour, 2)
                loyerAppTTC = Math.Round(loyerApp * (1 + nz(lers("tauxtva"), 0) / 100), 2)
                chargeAppTTC = Math.Round(chargeApp * (1 + nz(lers("tauxtva"), 0) / 100), 2)
                dENtre = nz(lers("DateEntree"), dDeb)
                Me.gAppel.Rows.Add(lers("locid"), lers("nom").ToString, IIf(nbmois = 3, "Trim", "Mens"), loyerActu, chargeActu, dENtre, lers("DateSortie").ToString, NbJour, loyerApp, chargeApp, lers("tauxtva"), loyerAppTTC, chargeAppTTC, lers("socId"), nbmois)
            End While
            lers.Close()

        Catch ex As Exception
            If debug Then MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub F_LoyerAppel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.tAn.Text = Now.AddMonths(1).Year
        Me.tMois.Text = Now.AddMonths(1).Month
        Me.bEnreg.Text = "Enregistrer "
        Call listeLocat()
    End Sub


    Private Sub gAppel_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gAppel.CellEndEdit
        If e.ColumnIndex = Me.gAppel.Columns("nbjour").Index Then
            Try
                Dim dDeb As Date, dFinMois As Date
                Dim nbjourMois As Integer

                With Me.gAppel.CurrentRow

                    dDeb = CDate("01/" & Me.tMois.Text & "/" & Me.tAn.Text)
                    dFinMois = dDeb.AddMonths(.Cells("nbmois").Value).AddDays(-1)
                    nbjourMois = DateDiff(DateInterval.Day, dDeb, dFinMois) + 1

                    .Cells("loyerAppHT").Value = Math.Round(.Cells("loyerInit").Value / nbjourMois * .Cells("nbjour").Value, 2)
                    .Cells("chargeAppHT").Value = Math.Round(.Cells("chargeInit").Value / nbjourMois * .Cells("nbjour").Value, 2)
                    .Cells("loyerAppTTC").Value = Math.Round(.Cells("loyerInit").Value / nbjourMois * .Cells("nbjour").Value * (1 + nz(.Cells("TauxTVA").Value, 0) / 100), 2)
                    .Cells("chargeAppTTC").Value = Math.Round(.Cells("chargeInit").Value / nbjourMois * .Cells("nbjour").Value * (1 + nz(.Cells("TauxTVA").Value, 0) / 100), 2)

                End With
            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub bEnreg_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Dim numFacture As String
        Dim numPiece As Integer
        Dim EditFacture As Boolean = False

        If MessageBox.Show("Enregistrer ? ", "Attention", MessageBoxButtons.OKCancel) <> Windows.Forms.DialogResult.OK Then Exit Sub
        If MessageBox.Show("Editer les factures ?", "Attention", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then EditFacture = True

        'calcul date d'appel
        Dim dDeb As Date
        dDeb = CDate("01/" & Me.tMois.Text & "/" & Me.tAn.Text)


        numPiece = NextNumPiece()
        'enregistre les appels
        For i = 0 To Me.gAppel.Rows.Count - 1
            With Me.gAppel.Rows(i)

                If .Cells("loyerAPPTTC").Value > 0 Or .Cells("chargeAppTTC").Value > 0 Then
                    numFacture = nextFactInterne(.Cells("SocId").Value, dDeb.Year, "SOCIETE")
                    'Loyer
                    Dim lecrLoyer As New EcritureCompta(dDeb, dDeb, numPiece, .Cells("locId").Value, 0, 0, 0, .Cells("SocId").Value, 0, 0, 0, "Loyer " & dDeb.Month & "/" & dDeb.Year, txt2num(.Cells("loyerAppHT").Value), txt2num(.Cells("loyerAppTTC").Value), 100, numFacture)
                    Call EnregCompta(lecrLoyer, ecrType.LocAppelLoyer)
                    'Charge
                    Dim lecrCharge As New EcritureCompta(dDeb, dDeb, numPiece, .Cells("locId").Value, 0, 0, 0, .Cells("SocId").Value, 0, 0, 0, "Prov. Charges " & dDeb.Month & "/" & dDeb.Year, txt2num(.Cells("chargeAppHT").Value), txt2num(.Cells("chargeAppTTC").Value), 100, numFacture)
                    Call EnregCompta(lecrCharge, ecrType.LocAppelCharge)

                  End If

            End With

            numPiece += 1
        Next

        Me.gAppel.Rows.Clear()
    End Sub


    Private Sub tAn_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tAn.KeyUp, tMois.KeyUp
        If e.KeyCode = Keys.Enter Then listeLocat()
    End Sub



    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class