Imports System.Math

Public Class F_LocaAppel
    Public leLocId As Integer
    Public laSocId As Integer
    Public lafacture As String
    Public laFactInterne As String
    Public Lindex As Integer = 0

    Sub comptalocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim total As Double = 0
        Dim AvecRevision As Boolean = False

        Try
            sSql = "SELECT ecrId,numPiece, numfacture,  ecrLib, ecrMontantHT, journal,indRevisionId FROM ComptaGene" _
            & " where Tiers='LOCATAIRE' and locId= " & Me.leLocId & " and numfacture ='" & Me.lafacture & "' order by ecrDate asc, ecrid asc"

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
            If AvecRevision = False Then
                Me.tIndActuid.Text = ""
                Me.tLoyerNew.Text = ""
            End If
            '   If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click

        If F_LocaAppelLoyer.ShowDialog = Windows.Forms.DialogResult.OK Then
            If F_LocaAppelLoyer.tLoyerNew.Text <> "" Then
                Me.tLoyerNew.Text = F_LocaAppelLoyer.tLoyerNew.Text
                Me.tIndActuid.Text = F_LocaAppelLoyer.LindiceActuId
            End If
            Call comptalocat()
        End If

        F_LocaAppelLoyer.Dispose()
    End Sub

    Sub afficheLocat()
        Call FormRempli(Me.gBail, "SELECT locataire.LocId, locataire.LoyerActu, locataire.ChargeActu, locataire.SocId, locataire.SurfaceBail, Indice.Indice, Indice.TrimestreNom, Indice.Annee" _
        & " , Indice.TrimestreNum, Indice.TypeIndice, locataire.DateSortie, locataire.DateSortiePrev, Indice_1.Annee AS AnneeActu" _
        & " FROM locataire " _
        & " INNER JOIN Indice ON locataire.IndId = Indice.IndId " _
        & " left JOIN Indice AS Indice_1 ON locataire.indActuId = Indice_1.IndId" _
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
                Me.tNumpiece.Text = Int((Me.dDeb.Value.Month - 1) / 3) + 1 & "T" & Me.dDeb.Value.Year.ToString
            Else
                Me.tNumpiece.Text = Me.dDeb.Value.Month.ToString("00") & Me.dDeb.Value.Year.ToString
            End If

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        sqlDo("delete from comptagene where numfacture='" & Me.lafacture & "' and cptid<>9", conSql)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim laFactInterne As String = nextFactInterne(laSocId, Me.dFacture.Value.Year)
        'Mise a jour de l'ecriture
        sqlDo("update comptagene set numfacture = '" & Me.tNumpiece.Text & "', ecrDate=" & SqlDate(Me.dFacture) & ",ecrEcheance=" & SqlDate(Me.dEcheance) & ",datedebut=" & SqlDate(Me.dDeb) & ",datefin=" & SqlDate(Me.dFin) & ", NumFactureInterne ='" & laFactInterne & "' where numfacture = 'T" & leLocId & "'", conSql)

        'revision de loyer
        If Me.tLoyerNew.Text <> "" Then
            sqlDo("update locataire set loyerActu=" & num2sql(Me.tLoyerNew.Text) & ",daterevision=dateadd(yy,1,daterevision),indactuid=" & Me.tIndActuid.Text & " where locid=" & leLocId, conSql)
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            If Me.gCompta.SelectedRows(0).Cells("numpiece").Value <> 0 Then
                Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("numpiece").Value)
                Call comptalocat()
            End If
        End If
    End Sub

    'TODO : V3
    'Private Sub bChargeExterne_Click(sender As System.Object, e As System.EventArgs) Handles bChargeExterne.Click
    '    If Me.leLocId = 0 Then Exit Sub
    '    F_Facture.laSocId = Me.tSocId.Text
    '    F_Facture.leLocId = Me.leLocId
    '    F_Facture.factInterne = False
    '    F_Facture.laFacture = Me.lafacture
    '    If F_Facture.ShowDialog = Windows.Forms.DialogResult.OK Then comptalocat()
    '    F_Facture.Dispose()
    'End Sub

    'Private Sub bFactInterne_Click(sender As System.Object, e As System.EventArgs) Handles bFactInterne.Click
    '    If Me.leLocId = 0 Then Exit Sub
    '    F_Facture.laSocId = Me.tSocId.Text
    '    F_Facture.leLocId = Me.leLocId
    '    F_Facture.factInterne = True
    '    F_Facture.laFacture = Me.lafacture
    '    If F_Facture.ShowDialog = Windows.Forms.DialogResult.OK Then comptalocat()
    '    F_Facture.Dispose()
    'End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        F_LocaDGAppel.leLocId = leLocId
        F_LocaDGAppel.laSocId = Me.tSocId.Text
        F_LocaDGAppel.tNbMois.Text = F_LocaSuivi.tNbMoisDG.Text
        F_LocaDGAppel.tLib.Text = "Appel Dépôt Garantie " & F_LocaSuivi.lLocat.Text
        If F_LocaDGAppel.ShowDialog = Windows.Forms.DialogResult.OK Then Call comptalocat()
        F_LocaDGAppel.Dispose()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        F_LocaDGReprise.leLocId = Me.leLocId
        F_LocaDGReprise.laSocId = Me.tSocId.Text
        If F_LocaSuivi.cDGTVA.Checked Then F_LocaDGReprise.tTVA.Text = F_LocaSuivi.tTauxTVA.Text
        F_LocaDGReprise.tLib.Text = "Reprise Dépôt Garantie " & F_LocaSuivi.lLocat.Text
        If F_LocaDGReprise.ShowDialog = Windows.Forms.DialogResult.OK Then Call comptalocat()
        F_LocaDGReprise.Dispose()
    End Sub

    Private Sub dDeb_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDeb.ValueChanged
        Me.dEcheance.Value = Me.dDeb.Value

        If F_LocaSuivi.lTypePer.Text.ToUpper.Contains("TRIM") Then
            Me.tNumpiece.Text = Int((Me.dDeb.Value.Month - 1) / 3) + 1 & "T" & Me.dDeb.Value.Year.ToString
        Else
            Me.tNumpiece.Text = Me.dDeb.Value.Month.ToString("00") & Me.dDeb.Value.Year.ToString
        End If
    End Sub

    Private Sub bRegul_Click(sender As System.Object, e As System.EventArgs) Handles bRegul.Click
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim lapiece As Integer
        Dim i As Integer = 0

        sSql = "delete  from  comptagene where numfacture like 'T" & Me.leLocId & "'"
        sqlDo(sSql, conSql)

        sSql = "select locid, sum(chmontantHtLoc) as montantHT ,chargeHT  from repartcharge" _
          & " where locid=" & Me.leLocId _
            & " and annee=" & Now.Year - 1 _
            & " group by locid,chargeht"
        lers = sqlLit(sSql, conSql)
        While lers.Read
            i += 1
            Call StatutBar("Ecriture sur Loc " & lers("locid"))
            lapiece = NextNumPiece()
            Dim lecr As New EcritureCompta(Now, Now, lapiece, lers("locid"), 0, 0, 0, Me.tSocId.Text, 0, 0, 9, "Reprise Prov. Charges " & Now.Year - 1, -lers("ChargeHT"), -Math.Round(lers("ChargeHT") * 1.2, 2), 100, "T" & lers("locid").ToString, Now, Now, 0, "", Now.Year, 2)
            Call EnregCompta(lecr, ecrType.ChargeReprise)
            Call StatutBar("Loc " & lers("locid"))
            lecr.MontantHT = lers("montantHT")
            lecr.MontantTTC = Math.Round(lers("montantHT") * 1.2, 2)
            lecr.Libelle = "Charge réelles " & Now.Year - 1
            Call EnregCompta(lecr, ecrType.ChargeReel)
        End While
        lers.Close()
        Call comptalocat()
    End Sub

    Private Sub bFactInterne_Click(sender As Object, e As EventArgs) Handles bFactInterne.Click

    End Sub


End Class