Imports System.Math

Public Class F_LocaFacture
    Public leLocId As Integer
    Public laSocId As Integer
    Public lafacture As String

    Sub comptalocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim total As Double = 0

        Try
            sSql = "SELECT ecrId,numPiece, numfacture,  ecrLib, ecrMontantHT, journal FROM ComptaGene" _
            & " where rubrique='LOCATAIRE' and locId= " & Me.leLocId & " and numfacture ='" & Me.lafacture & "' order by ecrDate desc, ecrid desc"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrMontantHT") < 0, -lers("ecrMontantHT"), 0)
                credit = IIf(lers("ecrMontantHT") >= 0, lers("ecrMontantHT"), 0)
                total += -lers("ecrmontantHT")
                Me.gCompta.Rows.Add(lers("ecrId"), lers("NumPiece").ToString, lers("Journal").ToString, lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()
            Me.tTotal.Text = num2txt(round(total, 2))
            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click

        If F_LocaAppLoyer.ShowDialog = Windows.Forms.DialogResult.OK Then Call comptalocat()

        F_LocaAppLoyer.Dispose()
    End Sub

    Sub afficheLocat()
        Call FormRempli(Me.gBail, "SELECT locid, loyerSOumisTVA, DGSoumisTVA, tauxTVA, dateEntree, dateSortiePrev" _
        & ", dateSortie, loyerInit, LoyerActu,  ChargeActu, socid, NbMoisDG, daterevision, SurfaceBail, TPerNom, TBailNom, TRgtNom" _
        & " , indice, indice.trimestrenom ,indice.annee,trimestreNum" _
        & " FROM Locataire INNER JOIN TypeBail ON Locataire.TBailId = TypeBail.TBailId" _
        & " INNER JOIN TypeReglement ON Locataire.TRgtId = TypeReglement.TRgtId" _
        & " INNER JOIN TypePeriode ON Locataire.TPerId = TypePeriode.TPerId" _
        & " INNER JOIN Indice ON Locataire.IndId = Indice.IndId " _
        & " where  locid = " & Me.leLocId, conSql)

        Me.dEntree.Enabled = False
        Me.dRevision.Enabled = False
        Me.tindice.Text = Me.tIndiceNom.Text & " " & Me.tIndiceAnnee.Text
    End Sub

    Private Sub F_LocaFacture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Call afficheLocat()

            lafacture = "T" & Me.leLocId
            Call comptalocat()

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        sqlDo("delete from comptagene where numfacture='" & Me.lafacture & "'", conSql)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim numfacture As String
        numfacture = nextFactInterne(Me.tSocId.Text, Me.dFacture.Value.Year, "SOCIETE")

        sqlDo("update comptagene set numfacture = '" & numfacture & "', ecrDAte=" & sqlDate(Me.dFacture) & " where numfacture = 'T" & leLocId & "'", conSql)

        'mise a jour locataire
        sqlDo("update locataire set loyerActu=" & num2sql(Me.tLoyerActu.Text) & ", dateRevision=" & sqlDate(Me.dRevision) & " where locid=" & leLocId, conSql)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("numpiece").Value)
            Call comptalocat()
        End If
    End Sub

    Private Sub bChargeExterne_Click(sender As System.Object, e As System.EventArgs) Handles bChargeExterne.Click
        If Me.leLocId = 0 Then Exit Sub
        F_LocaCharge.laSocId = Me.tSocId.Text
        F_LocaCharge.leLocId = Me.leLocId
        F_LocaCharge.factInterne = False
        If F_LocaCharge.ShowDialog = Windows.Forms.DialogResult.OK Then comptalocat()
        F_LocaCharge.Dispose()
    End Sub

    Private Sub gBail_Enter(sender As System.Object, e As System.EventArgs) Handles gBail.Enter

    End Sub

    Private Sub bFactInterne_Click(sender As System.Object, e As System.EventArgs) Handles bFactInterne.Click
        If Me.leLocId = 0 Then Exit Sub
        F_LocaCharge.laSocId = Me.tSocId.Text
        F_LocaCharge.leLocId = Me.leLocId
        F_LocaCharge.factInterne = True
        If F_LocaCharge.ShowDialog = Windows.Forms.DialogResult.OK Then comptalocat()
        F_LocaCharge.Dispose()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        F_LocaDGAppel.leLocId = leLocId
        F_LocaDGAppel.laSocId = Me.tSocId.Text
        F_LocaDGAppel.tLoyer.Text = Me.tLoyerActu.Text
        F_LocaDGAppel.tNbMois.Text = Me.tNbMoisDG.Text
        F_LocaDGAppel.tLib.Text = "Appel Dépôt Garantie " & F_LocaSuivi.lLocat.Text
        If F_LocaDGAppel.ShowDialog = Windows.Forms.DialogResult.OK Then Call comptalocat()
        F_LocaDGAppel.Dispose()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        F_LocaDGReprise.leLocId = Me.leLocId
        F_LocaDGReprise.laSocId = Me.tSocId.Text
        If Me.cDGTVA.Checked Then F_LocaDGReprise.tTVA.Text = Me.tTauxTVA.Text
        F_LocaDGReprise.tLib.Text = "Reprise Dépôt Garantie " & F_LocaSuivi.lLocat.Text
        If F_LocaDGReprise.ShowDialog = Windows.Forms.DialogResult.OK Then Call comptalocat()
        F_LocaDGReprise.Dispose()
    End Sub
End Class