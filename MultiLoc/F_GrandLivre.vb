Imports System.IO
Imports Microsoft.Office.Interop

Public Class F_GrandLivre
    Public GL As String = ""

    Sub ComptaBanque()
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date
        Dim lEch As Date

        Try
            Select Case GL
                Case "Locataire"
                    sSql = "select * from (SELECT l.nom as tiers,numfacture,AnneeEffet,'411' + cptsuffixe as cpt,  ecrLib, ecrMontantHT,ecrdate,ecrmontantTVA,ecrMontantTTC,lotlib,s.nom as societe,ecrecheance,categorie,ecrid" _
                    & " FROM ComptaGene " _
                    & " inner join locataire on ComptaGene.locId = locataire.locId " _
                    & " left join annuaire as l on locataire.persId= l.persId " _
                    & " left join societe on locataire.socid=societe.socid" _
                    & " left join annuaire as s on societe.persid=s.persid" _
                    & " WHERE ComptaGene.Rubrique='LOCATAIRE' " _
                    & " and ecrdate>=" & SqlDate(Me.dDebut) & " and ecrdate<=" & SqlDate(Me.dFin) _
                    & " UNION" _
                    & " SELECT l.nom as tiers,'' as numfacture ,'" & Me.dDebut.Value.Year & "'  as AnneeEffet, '411' + cptsuffixe as cpt,  'Solde au " & Me.dDebut.Value.ToString("dd/MM/yy") & "' as ecrlib " _
                    & " ,SUM( ecrMontantHT) as MontantHT," & SqlDate(Me.dDebut) & " ,sum(ecrmontantTVA) as MontantTVA,sum(ecrMontantTTC) as MontantTTC,lotlib,s.nom as societe, " & SqlDate(Me.dDebut) & ",'Solde Antérieur' as categorie,0" _
                    & " FROM ComptaGene " _
                    & " inner join locataire on ComptaGene.locId = locataire.locId " _
                    & " left join annuaire as l on locataire.persId= l.persId " _
                    & " left join societe on locataire.socid=societe.socid" _
                    & " left join annuaire as s on societe.persid=s.persid" _
                    & " WHERE ComptaGene.Rubrique='LOCATAIRE' " _
                    & " and ecrdate<" & SqlDate(Me.dDebut) _
                    & " group by  l.nom , cptsuffixe , lotlib,s.nom ) t " _
                    & " order by  tiers,cpt,societe,ecrdate,numfacture,ecrlib"
            End Select

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                ladate = lers("ecrdate")
                lEch = lers("ecrecheance")
                Me.gCompta.Rows.Add(lers("societe").ToString, ladate.ToString("dd/MM/yyyy"), lEch.ToString("dd/MM/yyyy"), IIf(lers("AnneeEffet") = 0, "", lers("AnneeEffet")), lers("cpt").ToString, lers("tiers").ToString, lers("lotlib").ToString, lers("numfacture").ToString, lers("categorie").ToString, lers("ecrLIb").ToString, lers("ecrmontantHT"), lers("ecrMontantTVA"), lers("ecrMontantTTC"), lers("ecrid"))
            End While
            lers.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Grand Livre " & GL
        Me.WindowState = FormWindowState.Maximized

        Me.dFin.Value = CDate("01/01/1900")
        Me.dDebut.Value = CDate("01/" & Now.Month & "/" & Now.Year)
        Me.dFin.Value = Me.dDebut.Value.AddMonths(1).AddDays(-1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.bSousTotal.Checked Then Call ComptaBanque()
        Call XLexport(Me.gCompta, "Grand Livre " & GL & " - " & Now.ToString("dd/MM/yyyy"), IIf(Me.bSousTotal.Checked, "GLTIERS", ""))
    End Sub

    Private Sub dDebut_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDebut.ValueChanged, dFin.ValueChanged
        If Me.dDebut.Value <= Me.dFin.Value Then
            Call ComptaBanque()
        Else
            Me.gCompta.Rows.Clear()
        End If
    End Sub

    Private Sub bSousTotal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles bSousTotal.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call XLexport(Me.gCompta, "Grand Livre " & GL & " - " & Now.ToString("dd/MM/yyyy"), "", True)

        'appxl.Sheets.Add()
        'SHDest = appXL.ActiveSheet
        'SHDest.Name = "Synthèse"
        'appXL.ActiveWorkbook.PivotCaches.Create(Excel.XlPivotTableSourceType.xlDatabase, ShSource.Range("A3:M9999"), Version:=Excel.XlPivotTableVersionList.xlPivotTableVersion12).CreatePivotTable( _
        '    SHDest.Range("A1"), "TC1", Excel.XlPivotTableVersionList.xlPivotTableVersion12)
        'SHDest.PivotTableWizard(Excel.XlPivotTableSourceType.xlDatabase, ShSource.Range("A3:M9999"), SHDest.Cells(1, 1), "TC1")
        'SHDest.Cells(1, 1).select()
        'With SHDest.PivotTables("TC1").PivotFields("Société")
        '    .Orientation = Excel.XlPivotFieldOrientation.xlPageField
        '    .Position = 1
        'End With
        'With SHDest.PivotTables("TC1").PivotFields("An Eff.")
        '    .Orientation = Excel.XlPivotFieldOrientation.xlPageField
        '    .Position = 1
        'End With
        'With SHDest.PivotTables("TC1").PivotFields("Compte")
        '    .Orientation = Excel.XlPivotFieldOrientation.xlRowField
        '    .Position = 1
        'End With
        'With SHDest.PivotTables("TC1").PivotFields("Tiers")
        '    .Orientation = Excel.XlPivotFieldOrientation.xlRowField
        '    .Position = 2
        'End With
        'With SHDest.PivotTables("TC1").PivotFields("Catégorie")
        '    .Orientation = Excel.XlPivotFieldOrientation.xlColumnField
        '    .Position = 1
        'End With

        'SHDest.PivotTables("TC1").AddDataField(SHDest.PivotTables("TC1").PivotFields("Montant HT"), "Total Montant HT", Excel.XlConsolidationFunction.xlSum)


    End Sub

    Private Sub gCompta_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCompta.CellDoubleClick
        If e.RowIndex >= 0 Then
            If Me.gCompta.Rows(e.RowIndex).Cells("ecrid").Value > 0 Then
                Dim f As New F_ComptaModif
                f.lEcrId = Me.gCompta.Rows(e.RowIndex).Cells("ecrid").Value
                If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Call ComptaBanque()
                End If
                f.Dispose()
            End If
        End If

    End Sub

    Private Sub gCompta_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCompta.CellContentClick

    End Sub
End Class