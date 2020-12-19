Imports System.Math
Imports System.IO

Public Class F_AppelMensuel
    Sub listeLocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim NbJour As Integer
        Dim dDeb As Date, dFInSortie As Date, dFinMois As Date, dFIn As Date
        Dim MontantHT As Decimal
        Dim MontantTTC As Decimal
        Dim nbjourMois As Integer
        Dim dENtre As Date

        Try

            dDeb = CDate("01/" & Me.tMois.Text & "/" & Me.tAn.Text)
            dFinMois = dDeb.AddMonths(1).AddDays(-1)
            nbjourMois = DateDiff(DateInterval.Day, dDeb, dFinMois) + 1
            Me.gAppel.Rows.Clear()

            sSql = "SELECT Client.cliId, Annuaire.Nom, ContratId, MontantHT, DateDebut, DateFin, contrat.TauxTVA" _
            & " FROM (Annuaire INNER JOIN Client ON Annuaire.PersId = Client.PersId) " _
            & " INNER JOIN Contrat ON Client.cliId = Contrat.cliId" _
            & "  where (dateFIN is null or dateFin>'" & dDeb.ToString("MM/dd/yyyy") & "')"

            lers = sqlLit(sSql, conSql)
            While lers.Read
                dFInSortie = nz(lers("dateFin"), dFinMois)
                dFIn = IIf(dFinMois < dFInSortie, dFinMois, dFInSortie)
                NbJour = DateDiff(DateInterval.Day, dDeb, dFIn) + 1
                MontantHT = nz(lers("MontantHT"), 0) / nbjourMois * NbJour
                MontantTTC = MontantHT * (1 + nz(lers("tauxtva"), 0) / 100)
                dENtre = lers("DateDebut")
                Me.gAppel.Rows.Add(lers("cliid"), lers("nom").ToString, "E" & lers("ContratId").ToString.PadLeft(5, "0"), lers("MontantHT").ToString, dENtre.ToString("yyyy-MM-dd"), lers("DateFin").ToString, NbJour, MontantHT, lers("tauxtva"), MontantTTC)
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
        Call listeLocat()
    End Sub


    Private Sub gAppel_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gAppel.CellEndEdit
        If e.ColumnIndex = Me.gAppel.Columns("nbjour").Index Then
            Try
                Dim dDeb As Date, dFinMois As Date
                Dim nbjourMois As Integer

                dDeb = CDate("01/" & Me.tMois.Text & "/" & Me.tAn.Text)
                dFinMois = dDeb.AddMonths(1).AddDays(-1)
                nbjourMois = DateDiff(DateInterval.Day, dDeb, dFinMois) + 1

                With Me.gAppel.CurrentRow
                    .Cells("MontantAppHT").Value = .Cells("MontantInit").Value / nbjourMois * .Cells("nbjour").Value
                    .Cells("MontantAppTTC").Value = .Cells("MontantInit").Value / nbjourMois * .Cells("nbjour").Value * (1 + nz(.Cells("TauxTVA").Value, 0) / 100)

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

                If .Cells("montantAppTTC").Value > 0 Then

                    numFacture = nextFactInterne(0, dDeb.Year, "SOCIETE")

                    Dim lecrLoyer As New EcritureCompta(dDeb, dDeb, numPiece, 0, 0, 0, .Cells("cliId").Value, 0, 0, 0, 0, "Contrat " & .Cells("Contrat").Value & " " & dDeb.Month & "/" & dDeb.Year, txt2num(.Cells("MontantAPPHT").Value), txt2num(.Cells("montantAppTTC").Value), 100, numFacture)
                    Call EnregCompta(lecrLoyer, ecrType.ClientStockage)

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

    Private Sub gAppel_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gAppel.CellContentClick

    End Sub
End Class