Imports System.IO
Public Class F_DepotBalance


    Sub ComptaDepot()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Try
            sSql = "SELECT Annuaire_1.Nom as societe, Annuaire.Nom as locataire, sum(ComptaGene.ecrMontantTTC) as DGTTC" _
            & "  FROM Annuaire AS Annuaire_1 INNER JOIN ((Annuaire  INNER JOIN (ComptaGene INNER JOIN Locataire " _
            & " ON ComptaGene.LocId = Locataire.LocId)  ON Annuaire.PersId = Locataire.PersId)  INNER JOIN Societe ON ComptaGene.SocId = Societe.SocId)" _
            & " ON Annuaire_1.PersId = Societe.PersId WHERE ComptaGene.Journal='DEPOT' " _
            & " and tiers = 'SOCIETE'" _
            & " group by Annuaire_1.Nom, Annuaire.Nom" _
            & " having(sum(ComptaGene.ecrMontantTTC) <> 0) "

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                Me.gCompta.Rows.Add(lers("societe").ToString, lers("locataire").ToString, lers("DGTTC").ToString)
            End While
            lers.Close()

            Me.tTotalDetenu.Text = GridTotalColonne(Me.gCompta, "solde").ToString

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ComptaDepot()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        Call XLexport(Me.gCompta, "Balance Dépôt Garantie")
    End Sub



    Private Sub gCompta_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCompta.CellContentClick

    End Sub
End Class