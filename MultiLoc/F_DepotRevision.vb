Imports System.Math
Imports System.IO

Public Class F_DepotRevision

    Private Sub F_Revision_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call listeLocat()
    End Sub

    Sub listeLocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim tauxTVA As Decimal
        Dim depotHT As Decimal, depotTTC As Decimal, ecartHT As Decimal, ecartTTC As Decimal

        Try
            Me.gRevision.Rows.Clear()

            sSql = "SELECT Locataire.LocId, socid, Nom, localite, adr1, depotTTC, depotHT, LoyerActu, NBMoisDG, DGsoumisTVA, tauxTVA" _
            & " FROM Annuaire INNER JOIN (Locataire LEFT JOIN (" _
            & " select locid,sum(ecrMontantHT ) as depotHT,sum(ecrMontantTTC ) as depotTTC FROM  ComptaGene where  rubrique='LOCATAIRE' and  journal='DEPOT' group by locid)" _
            & " AS Solde ON Locataire.locid = Solde.lociD) ON Annuaire.PersId = Locataire.PersId"

            lers = sqlLit(sSql, conSql)
            While lers.Read
                tauxTVA = IIf(lers("DGSoumisTVA") = True, lers("tauxTVA"), 0)
                depotHT = lers("LOyerActu") / 12 * lers("NbMoisDG")
                depotTTC = depotHT * (1 + tauxTVA / 100)
                ecartHT = (nz(lers("depotHT"), 0) + depotHT)
                ecartTTC = (nz(lers("depotTTC"), 0) + depotTTC)
                Me.gRevision.Rows.Add(lers("locId"), lers("socId"), lers("nom"), lers("Adr1").ToString & " - " & lers("localite").ToString _
                , -nz(lers("depotHT"), 0), -nz(lers("depotTTC"), 0), lers("LoyerActu") / 12, lers("NbMoisDG"), tauxTVA, depotHT, depotTTC, ecartHT, ecartTTC)
            End While
            lers.Close()
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub tXL_Click(sender As System.Object, e As System.EventArgs) Handles tXL.Click
        Call XLexport(Me.gRevision, "Revision Dépôt Garantie")
    End Sub

    Private Sub gRevision_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gRevision.CellEndEdit
        If e.ColumnIndex = Me.gRevision.Columns("DepotHT").Index Or e.ColumnIndex = Me.gRevision.Columns("tauxTVA").Index Then
            Try

                With Me.gRevision.CurrentRow
                    .Cells("depotTTC").Value = Math.Round(.Cells("DepotHT").Value * (1 + .Cells("TauxTVA").Value / 100), 2)
                    .Cells("ecartHT").Value = (-.Cells("depotActuHT").Value + .Cells("depotHT").Value)
                    .Cells("ecartTTC").Value = (-.Cells("depotActuTTC").Value + .Cells("depotTTC").Value)
                End With
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub bCalcul_Click(sender As System.Object, e As System.EventArgs) Handles bCalcul.Click
        Call listeLocat()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click

        Dim lapiece As Integer
        Dim laFacture As String
        Dim editFacture As Boolean = False

        Try
            Me.gRevision.EndEdit()

            If MessageBox.Show("Enregistrer ? ", "Attention", MessageBoxButtons.OKCancel) <> Windows.Forms.DialogResult.OK Then Exit Sub

            If MessageBox.Show("Editer la facture ?", "Attention", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then editFacture = True


            For i = 0 To Me.gRevision.RowCount - 1
                With Me.gRevision.Rows(i)
                    If .Cells("ecartTTC").Value <> 0 Or .Cells("ecartHT").Value <> 0 Then

                        lapiece = NextNumPiece()
                        laFacture = nextFactInterne(.Cells("socId").Value, Me.dEntre.Value.Year)

                        If .Cells("DepotActuHT").Value <> 0 Then
                            Dim lecrAnnul As New EcritureCompta(Me.dEntre.Value, Me.dEntre.Value, lapiece, .Cells("locId").Value, 0, 0, 0, .Cells("SocId").Value, 0, 0, 0, "Reprise Dépôt Garantie", txt2num(.Cells("depotActuHT").Value), txt2num(.Cells("depotActuTTC").Value), 100, laFacture, Now, Now, 0, laFacture, Me.dEntre.Value.Year, 3)
                            Call EnregCompta(lecrAnnul, ecrType.LocRepriseDG)
                        End If

                        Dim lecrNouveau As New EcritureCompta(Me.dEntre.Value, Me.dEntre.Value, lapiece, .Cells("locId").Value, 0, 0, 0, .Cells("SocId").Value, 0, 0, 0, "Dépôt Garantie", txt2num(.Cells("depotHT").Value), txt2num(.Cells("depotTTC").Value), 100, laFacture, Now, Now, 0, laFacture, Me.dEntre.Value.Year, 3)
                        Call EnregCompta(lecrNouveau, ecrType.LocAppelDG)

                     End If
                End With
            Next
 
        Catch ex As Exception

        End Try

        Me.Dispose()
    End Sub
End Class