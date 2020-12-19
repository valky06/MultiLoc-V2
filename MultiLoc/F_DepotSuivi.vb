Imports System.IO
Public Class F_DepotSuivi

    Sub ComptaBanque()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim ladate As Date
        Dim vEchance As String = ""

        Try
            sSql = "SELECT ecrId, nom, numPiece, ecrDate, ecrLib, ecrMontantTTC" _
            & " FROM ComptaGene " _
            & " inner join locataire on ComptaGene.locId = locataire.locId " _
            & " left join annuaire on locataire.persId= annuaire.persId" _
            & " WHERE ComptaGene.Rubrique='SOCIETE' AND ComptaGene.Journal='DEPOT'" _
            & " order by ecrdate desc, ecrid desc"


            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
                credit = IIf(lers("ecrmontantTTC") > 0, lers("ecrmontantTTC"), 0)
                ladate = lers("ecrDate")
                Me.gCompta.Rows.Add(lers("ecrId"), lers("NumPIece").ToString, lers("Nom").ToString, ladate.ToString("yyyy-MM-dd"), lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ComptaBanque()
    End Sub


    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs)
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("numpiece").Value)
            Call ComptaBanque()
        End If
    End Sub

    Private Sub bXL_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        Call XLexport(Me.gCompta, "Grand Livre Dépôt - " & Now.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class