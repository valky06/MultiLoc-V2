Imports System.IO
Public Class F_FourBalance


    Sub ComptaFour()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double

        Try
            sSql = "SELECT comptaGene.FourId, Annuaire.nom, Sum(comptaGene.ecrMontantTTC) AS solde" _
            & " FROM comptaGene LEFT JOIN annuaire " _
            & " ON Annuaire.PersId = comptagene.fourid" _
            & " WHERE comptaGene.tiers='FOURNISSEUR'" _
            & " GROUP BY comptaGene.FourId, Annuaire.nom"


            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("solde") > 0, lers("solde"), 0)
                credit = IIf(lers("solde") <= 0, -lers("solde"), 0)

                Me.gCompta.Rows.Add(lers("FourId"), lers("nom").ToString, debit, credit)
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ComptaFour()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        Call XLexport(Me.gCompta, "Balance Fournisseur")
    End Sub


    Private Sub gCompta_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCompta.CellContentClick
        If e.ColumnIndex = Me.gCompta.Columns("fournisseur").Index Then
            F_FourSuivi.leFourId = Me.gCompta.Rows(e.RowIndex).Cells("fourid").Value
            F_FourSuivi.MdiParent = F_main
            F_FourSuivi.Show()
            Me.Dispose()

        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class