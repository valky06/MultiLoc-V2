Imports System.IO
Public Class F_LocaBalance


    Sub ComptaLocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim leType As String

        Try
            sSql = "SELECT Locataire.LocId, Client.cliid, Annuaire_1.Nom as client, Annuaire.nom as locataire, Sum(comptaGene.ecrMontantTTC) AS solde" _
            & " FROM ((comptaGene LEFT JOIN (Annuaire RIGHT JOIN Locataire ON Annuaire.PersId = Locataire.PersId) ON comptaGene.LocId = Locataire.LocId)" _
            & " LEFT JOIN Client ON comptaGene.CliId = Client.cliId) LEFT JOIN Annuaire AS Annuaire_1 ON Client.PersId = Annuaire_1.PersId" _
            & " WHERE comptaGene.tiers='LOCATAIRE' OR comptaGene.tiers='CLIENT'" _
            & " GROUP BY Locataire.LocId, Client.cliId, Annuaire_1.Nom, Annuaire.nom"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                leType = IIf(nz(lers("locId"), "") = "", "Client", "Locataire")
                credit = IIf(lers("solde") > 0, lers("solde"), 0)
                debit = IIf(lers("solde") < 0, -lers("solde"), 0)
                Me.gCompta.Rows.Add(lers("LocId"), lers("cliId"), leType, lers("client").ToString & lers("locataire").ToString, debit, credit)
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ComptaLocat()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        Call XLexport(Me.gCompta, "Balance Locataires")
    End Sub



    Private Sub gCompta_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCompta.CellClick
        If e.ColumnIndex = Me.gCompta.Columns("nom").Index Then
            If Me.gCompta.Rows(e.RowIndex).Cells("typePers").Value = "Locataire" Then
                F_LocaSuivi.leLocId = Me.gCompta.Rows(e.RowIndex).Cells("locid").Value
                Call F_main.Locataire_Click(Nothing, Nothing)
                Me.Dispose()
            Else
                F_ClientSuivi.leTiersId = Me.gCompta.Rows(e.RowIndex).Cells("cliId").Value
                Call F_main.mnuClient(Nothing, Nothing)
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub bWord_Click(sender As System.Object, e As System.EventArgs) Handles bWord.Click

    End Sub
End Class