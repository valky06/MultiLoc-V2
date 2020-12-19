Imports System.Math

Public Class F_LocaAvoir
    Public leLocId As Integer
    Public laSocId As Integer
    Public lafacture As String

    Sub comptalocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim total As Double = 0
        Dim AvecRevision As Boolean = False

        Try
            sSql = "SELECT ecrId,numPiece, numfacture,  ecrLib, ecrMontantHT, journal,indRevisionId FROM ComptaGene" _
            & " where rubrique='LOCATAIRE' and locId= " & Me.leLocId & " and numfacture ='" & Me.lafacture & "' order by ecrDate asc, ecrid asc"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrMontantHT") < 0, -lers("ecrMontantHT"), 0)
                credit = IIf(lers("ecrMontantHT") >= 0, lers("ecrMontantHT"), 0)
                total += -lers("ecrmontantHT")
                If nz(lers("indRevisionId"), "0") <> "0" Then AvecRevision = True
                Me.gCompta.Rows.Add(lers("ecrId"), lers("NumPiece").ToString, lers("Journal").ToString, lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()
            Me.tTotal.Text = num2txt(Round(total, 2))
            '   If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If F_LocaAvoirLoyer.ShowDialog = Windows.Forms.DialogResult.OK Then Call comptalocat()
        F_LocaAvoirLoyer.Dispose()
    End Sub

    Sub afficheLocat()
        Call FormRempli(Me.gBail, "SELECT locid, LoyerActu,  ChargeActu, socid" _
         & " FROM Locataire " _
          & " where  locid = " & Me.leLocId, conSql)
    End Sub

    Private Sub F_LocaFacture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Call afficheLocat()
            Dim nbmoisAppel As Integer = 1
            If F_LocaSuivi.lTypePer.Text.ToUpper.Contains("TRIM") Then nbmoisAppel = 3
            Me.dDeb.Value = CDate("01/" & Now.AddMonths(1).Month & "/" & Now.AddMonths(1).Year)
            Me.dFin.Value = Me.dDeb.Value.AddMonths(NbmoisAppel).AddDays(-1)

            lafacture = "T" & Me.leLocId
            Call comptalocat()

            If F_LocaSuivi.lTypePer.Text.ToUpper.Contains("TRIM") Then
                Me.tNumpiece.Text = "Avoir " & Int((Me.dDeb.Value.Month - 1) / 3) + 1 & "T" & Me.dDeb.Value.Year.ToString
            Else
                Me.tNumpiece.Text = "Avoir " & Me.dDeb.Value.Month.ToString("00") & Me.dDeb.Value.Year.ToString
            End If

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
        Dim laFactInterne As String = nextFactInterne(Me.laSocId, Me.dFacture.Value.Year)
        'Mise a jour de l'ecriture
        sqlDo("update comptagene set numfacture = '" & Me.tNumpiece.Text & "', ecrDate=" & SqlDate(Me.dFacture) & ",ecrEcheance=" & SqlDate(Me.dEcheance) & ",datedebut=" & SqlDate(Me.dDeb) & ",datefin=" & SqlDate(Me.dFin) & ",NumFactureInterne='" & laFactInterne & "' where numfacture = 'T" & leLocId & "'", conSql)

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
        F_LocaCharge.laFacture = Me.lafacture
        If F_LocaCharge.ShowDialog = Windows.Forms.DialogResult.OK Then comptalocat()
        F_LocaCharge.Dispose()
    End Sub


    Private Sub bFactInterne_Click(sender As System.Object, e As System.EventArgs) Handles bFactInterne.Click
        If Me.leLocId = 0 Then Exit Sub
        F_LocaCharge.laSocId = Me.tSocId.Text
        F_LocaCharge.leLocId = Me.leLocId
        F_LocaCharge.factInterne = True
        F_LocaCharge.laFacture = Me.lafacture
        If F_LocaCharge.ShowDialog = Windows.Forms.DialogResult.OK Then comptalocat()
        F_LocaCharge.Dispose()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        F_LocaDGAvoir.leLocId = leLocId
        F_LocaDGAvoir.laSocId = Me.tSocId.Text
        F_LocaDGAvoir.tNbMois.Text = F_LocaSuivi.tNbMoisDG.Text
        F_LocaDGAvoir.tLib.Text = "Avoir Dépôt Garantie " & F_LocaSuivi.lLocat.Text
        If F_LocaDGAvoir.ShowDialog = Windows.Forms.DialogResult.OK Then Call comptalocat()
        F_LocaDGAvoir.Dispose()
    End Sub

    Private Sub dDeb_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDeb.ValueChanged
        Me.dEcheance.Value = Me.dDeb.Value

        If F_LocaSuivi.lTypePer.Text.ToUpper.Contains("TRIM") Then
            Me.tNumpiece.Text = "Avoir " & Int((Me.dDeb.Value.Month - 1) / 3) + 1 & "T" & Me.dDeb.Value.Year.ToString
        Else
            Me.tNumpiece.Text = "Avoir " & Me.dDeb.Value.Month.ToString("00") & Me.dDeb.Value.Year.ToString
        End If
    End Sub


    Private Sub gBail_Enter(sender As System.Object, e As System.EventArgs) Handles gBail.Enter

    End Sub
End Class