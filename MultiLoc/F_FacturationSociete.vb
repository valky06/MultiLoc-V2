Imports System.IO
Imports Microsoft.Office.Interop


Public Class F_FacturationSociete

    Sub ComptaBanque()
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date

        Try

            sSql = "select annuaire2.nom as societe,annuaire.nom as tiers,locataire.CptSuffixe,ecrDate,numfacture, ecrlib" _
            & " ,ecrmontantHT, ecrmontantTVA, ecrmontantTTC, c.CptNum, R.rubnom " _
            & " from comptagene " _
            & " left join locataire on locataire.locid=comptagene.locid" _
            & " left join annuaire on annuaire.persid=locataire.persId" _
            & " left join societe on societe.socId=comptagene.socid" _
            & " left join annuaire as annuaire2 on annuaire2.persid=societe.persid" _
            & " Left join ComptaPlan C on C.LocId=ComptaGene.LocId and c.RubId= ComptaGene.rubid and c.SocId = ComptaGene.SocId" _
            & " left join ComptaRubrique R on R.RubId = ComptaGene.RubId" _
            & " where tiers='SOCIETE' and categorie='VENTE'" _
            & " And ecrdate>=" & SqlDate(Me.dDebut) & " And ecrdate<=" & SqlDate(Me.dFin) _
            & " order by annuaire2.nom,Annuaire.nom,ecrdate"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                ladate = lers("ecrdate")
                Me.gCompta.Rows.Add(lers("societe").ToString, lers("tiers").ToString, lers("CptSuffixe").ToString, ladate.ToString("dd/MM/yyyy"), lers("numfacture").ToString _
                , lers("ecrlib"), lers("rubnom"), lers("CptNum"), lers("ecrmontantHT"), lers("ecrmontantTVA"), lers("ecrmontantTTC"))
            End While
            lers.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.dFin.Value = CDate("01/01/1900")
        Me.dDebut.Value = CDate("01/" & Now.Month & "/" & Now.Year)
        Me.dFin.Value = Me.dDebut.Value.AddMonths(1).AddDays(-1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call XLexport(Me.gCompta, "Facturation Société - " & Now.ToString("dd/MM/yyyy"), False, False)
    End Sub

    Private Sub dDebut_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDebut.ValueChanged, dFin.ValueChanged
        If Me.dDebut.Value < Me.dFin.Value Then
            Call ComptaBanque()
        Else
            Me.gCompta.Rows.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Dim lId As String
        Dim laLigne As Integer
        Dim leLocCode As String = ""
        Dim leLocNom As String = ""
        Dim laPiece As String = ""
        Dim lesLots As String = ""
        Dim leCptClient As String = ""



        Try

            '--------------------------------------------------
            'Factures
            '--------------------------------------------------

            appXL.Workbooks.Add()
            appXL.ActiveSheet.Name = "Factures"
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual

            'données
            laLigne = 1
            appXL.Cells(laLigne, 1).value = "Société"
            appXL.Cells(laLigne, 2).value = "Date"
            appXL.Cells(laLigne, 3).value = "CodeJournal"
            appXL.Cells(laLigne, 4).value = "NumeroPiece"
            appXL.Cells(laLigne, 5).value = "NumeroCompte"
            appXL.Cells(laLigne, 6).value = "LibelleCompte"
            appXL.Cells(laLigne, 7).value = "NumeroTiers"
            appXL.Cells(laLigne, 8).value = "Libellé Tiers"
            appXL.Cells(laLigne, 9).value = "Libellé écriture"
            appXL.Cells(laLigne, 10).value = "Mvt Débit"
            appXL.Cells(laLigne, 11).value = "Mvt Crédit"
            appXL.Cells(laLigne, 12).value = "Libellé"
            laLigne += 1

            sSql = "select annuaire.nom as tiers,locataire.CptSuffixe,ecrDate,numfacture, ecrlib" _
            & " ,ecrmontantHT, ecrmontantTVA, ecrmontantTTC, c.CptNum,c.CptNom, R.rubnom, LotLib, SocCode, comptagene.locid, numpiece, LotLib, categorie" _
            & " from comptagene " _
            & " inner join Societe S on S.SocId = ComptaGene.SocId" _
            & " left join locataire on locataire.locid=comptagene.locid" _
            & " left join annuaire on annuaire.persid=locataire.persId" _
            & " Left join ComptaPlan C on C.LocId=ComptaGene.LocId and c.RubId= ComptaGene.rubid and c.SocId = ComptaGene.SocId" _
            & " left join ComptaRubrique R on R.RubId = ComptaGene.RubId" _
            & " where tiers='SOCIETE' and categorie='VENTE'" _
            & " And ecrdate>=" & SqlDate(Me.dDebut) & " And ecrdate<=" & SqlDate(Me.dFin) _
            & " order by SocCode,Annuaire.nom,numfacture,ecrdate"

            lers = sqlLit(sSql, conSql)

            lId = ""
            While lers.Read

                If lers("categorie") = "VENTE" Then
                    appXL.Cells(laLigne, 1).value = lers("SocCode")
                    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
                    appXL.Cells(laLigne, 3).value = "VT"
                    appXL.Cells(laLigne, 4).value = lers("numpiece")
                    appXL.Cells(laLigne, 5).value = nz(lers("CptNum"), "")
                    appXL.Cells(laLigne, 6).value = nz(lers("CptNom"), "")
                    appXL.Cells(laLigne, 9).value = nz(lers("numfacture"), "")
                    appXL.Cells(laLigne, 11).value = lers("ecrMontantHT")
                    laLigne += 1

                    appXL.Cells(laLigne, 1).value = lers("SocCode")
                    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
                    appXL.Cells(laLigne, 3).value = "VT"
                    appXL.Cells(laLigne, 4).value = lers("numpiece")
                    appXL.Cells(laLigne, 5).value = "411000"
                    appXL.Cells(laLigne, 6).value = "Client Divers"
                    appXL.Cells(laLigne, 7).value = nz(lers("CptSuffixe"), "")
                    appXL.Cells(laLigne, 8).value = lers("tiers")
                    appXL.Cells(laLigne, 9).value = nz(lers("numfacture"), "")
                    appXL.Cells(laLigne, 10).value = lers("ecrMontantTTC")
                    '                appXL.Cells(laLigne, 12).value = lers("Leslots")
                    laLigne += 1

                    appXL.Cells(laLigne, 1).value = lers("SocCode")
                    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
                    appXL.Cells(laLigne, 3).value = "VT"
                    appXL.Cells(laLigne, 4).value = lers("numpiece")
                    appXL.Cells(laLigne, 5).value = "445715"
                    appXL.Cells(laLigne, 6).value = "TVA collectée"
                    appXL.Cells(laLigne, 9).value = nz(lers("numfacture"), "")
                    appXL.Cells(laLigne, 11).value = lers("ecrmontantTVA")
                    laLigne += 1

                Else

                End If
            End While
            lers.Close()

            '--------------------------------------------------
            'Versements
            '--------------------------------------------------

            'appXL.Workbooks.Add()
            'appXL.ActiveSheet.Name = "Encaissements"
            'appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual

            ''données
            'laLigne = 1
            'appXL.Cells(laLigne, 1).value = "Société"
            'appXL.Cells(laLigne, 2).value = "Date"
            'appXL.Cells(laLigne, 3).value = "CodeJournal"
            'appXL.Cells(laLigne, 4).value = "NumeroPiece"
            'appXL.Cells(laLigne, 5).value = "NumeroCompte"
            'appXL.Cells(laLigne, 6).value = "LibelleCompte"
            'appXL.Cells(laLigne, 7).value = "NumeroTiers"
            'appXL.Cells(laLigne, 8).value = "Libellé Tiers"
            'appXL.Cells(laLigne, 9).value = "Libellé écriture"
            'appXL.Cells(laLigne, 10).value = "Mvt Débit"
            'appXL.Cells(laLigne, 11).value = "Mvt Crédit"

            'sSql = "Select Annuaire.Nom, ComptaGene.ecrDate, locataire.CptSuffixe, ComptaGene.ecrLib, ComptaGene.ecrMontantHT, ComptaGene.ecrMontantTVA" _
            '& " , ComptaGene.ecrMontantTTC, ComptaGene.NumPIece, locataire.LotLib,  Annuaire_1.Nom AS LocNom ,  ComptaGene.LocId,societe.cptClient" _
            '& " FROM ComptaGene INNER JOIN locataire ON ComptaGene.LocId = locataire.LocId " _
            '& " LEFT JOIN Societe ON locataire.SocId = Societe.SocId" _
            '& " LEFT JOIN Annuaire ON Societe.PersId = Annuaire.PersId " _
            '& " LEFT JOIN Annuaire AS Annuaire_1 ON locataire.PersId = Annuaire_1.PersId" _
            '& " LEFT OUTER JOIN ComptaPlan ON ComptaGene.RubId = ComptaPlan.RubId AND ComptaGene.LocId = ComptaPlan.LocId " _
            '& " WHERE   Journal in ('BANQUE')  and tiers='LOCATAIRE' " _
            '& " And ecrdate >= " & SqlDate(Me.dDebut) & " And ecrdate <= " & SqlDate(Me.dFin) _
            '& " and comptagene.socid=" & lersSoc(0) _
            '& " ORDER BY Annuaire.Nom,ComptaGene.ecrDate, comptagene.locid,CptSuffixe,numfacture"

            'lers = sqlLit(sSql, conSql)
            'While lers.Read
            '    leLocCode = nz(lers("CptSuffixe"), "")
            '    leLocNom = lers("LocNom")
            '    laPiece = "P" & lers("NumPIece").ToString
            '    leCptClient = nz(lers("cptclient"), "")

            '    laLigne += 1
            '    appXL.Cells(laLigne, 1).value = lers("Nom")
            '    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
            '    appXL.Cells(laLigne, 3).value = "BQ"
            '    appXL.Cells(laLigne, 4).value = laPiece
            '    appXL.Cells(laLigne, 5).value = "512110"
            '    appXL.Cells(laLigne, 6).value = "CA PCA"
            '    appXL.Cells(laLigne, 9).value = nz(lers("ecrLib"), "")
            '    appXL.Cells(laLigne, 10).value = lers("ecrMontantTTC")

            '    laLigne += 1
            '    appXL.Cells(laLigne, 1).value = lers("Nom")
            '    appXL.Cells(laLigne, 2).value = date2Xl(lers("ecrDate"))
            '    appXL.Cells(laLigne, 3).value = "BQ"
            '    appXL.Cells(laLigne, 4).value = laPiece
            '    appXL.Cells(laLigne, 5).value = leCptClient
            '    appXL.Cells(laLigne, 6).value = ""
            '    appXL.Cells(laLigne, 7).value = leLocCode
            '    appXL.Cells(laLigne, 8).value = leLocNom
            '    appXL.Cells(laLigne, 9).value = nz(lers("ecrLib"), "")
            '    appXL.Cells(laLigne, 11).value = lers("ecrMontantTTC")

            'End While
            'lers.Close()


            'End While
            'lersSoc.Close()

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
            Throw New Exception(ex.Message)
        End Try

        appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic
        appXL.Cells.Select()
        '        appXL.Cells.EntireColumn.AutoFit()
        '        appXL.Cells(1, 1).value = "Export Facturation"
        '        appXL.Cells(1, 1).select()


        StatutBar("")
        appXL.Visible = True
    End Sub
End Class