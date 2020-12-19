Imports System.IO
Public Class _F_CoproSuivi_Old
    Public lacoproId As Integer

    Sub ListeCopro()
        Dim sSql As String
        sSql = "SELECT CoproId, CoproNom FROM Copro"
        Call ComboRempli(sSql, Me.lCopro, conSql)
    End Sub

    Sub listeRepartLot()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gCle.Rows.Clear()
        'lot avec clé
        sSql = "SELECT lot.LotId, TlocalNom, LotNom, Surface, Milliemes,Pro,Loc,Tmp, QuotePart" _
        & " FROM (Lot INNER JOIN CleRepartLot ON Lot.LotId = CleRepartLot.lotID) " _
        & " INNER JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
        & " WHERE CleID=" & Me.lCle.SelectedItem.value
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gCle.Rows.Add(lers("lotId"), lers("TlocalNom").ToString, lers("LotNom").ToString, "", lers("Surface").ToString, lers("Milliemes").ToString, lers("Tmp"), lers("Pro"), lers("Loc"), lers("QuotePart").ToString, lers("QuotePart").ToString)
        End While
        lers.Close()

        'lot sans clé
        sSql = "SELECT lot.LotId, TlocalNom, LotNom, Surface, Milliemes" _
        & " from lot INNER JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
        & " where lotid not in (select lotid from clerepartlot where cleid=" & Me.lCle.SelectedItem.value & ")" _
        & " and coproid=" & Me.lacoproId
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gCle.Rows.Add(lers("lotId"), lers("TlocalNom").ToString, lers("LotNom").ToString, lers("Surface").ToString, lers("Milliemes").ToString)
        End While
        lers.Close()
    End Sub

    Sub listeLots()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gLots.Rows.Clear()
        'lot avec clé
        sSql = "SELECT LotId, Batiment, TlocalNom, LotNom, socid, Surface " _
        & " FROM TypeLocal INNER JOIN Lot ON TypeLocal.TlocalId = Lot.TLocalId " _
        & " WHERE coproId=" & Me.lacoproId _
        & " order by lotnom"
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gLots.Rows.Add(lers("lotId"), lers("batiment").ToString, lers("TlocalNom").ToString, lers("LotNom").ToString, lers("surface").ToString)
        End While
        lers.Close()

    End Sub



    Sub listeEcrCopro()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim ladate As Date

        Try
            sSql = "SELECT ecrId, numpiece,numfacture, ecrDate, ecrLib, ecrMontantTTC FROM ComptaGene" _
            & " where rubrique='COPRO' and coproId= " & Me.lCopro.SelectedItem.value & " order by ecrDate desc"

            Me.gcompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
                credit = IIf(lers("ecrmontantTTC") >= 0, lers("ecrmontantTTC"), 0)
                ladate = lers("ecrDate")
                Me.gcompta.Rows.Add(lers("ecrId"), lers("numpiece").ToString, ladate.ToString("yyyy-MM-dd"), lers("numfacture").ToString, lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()
            If Me.gcompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gcompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub BudgetListe()
        Dim sSql As String
        sSql = "SELECT budId, budAnnee  from budget where coproId= " & Me.lCopro.SelectedItem.value
        Call ComboRempli(sSql, Me.lBudget, conSql)
        Me.gBudget.Rows.Clear()
    End Sub

    Sub BudgetLignes()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gBudget.Rows.Clear()
        sSql = "SELECT bliId, CptNom, CleNom,bliText, montantHT " _
        & " FROM (PlanComptable INNER JOIN BudgetLigne ON PlanComptable.CptId = BudgetLigne.cptId) " _
        & " INNER JOIN CleRepart ON BudgetLigne.cleId = CleRepart.CleId" _
        & " where budId= " & Me.lBudget.SelectedItem.value

        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gBudget.Rows.Add(lers("bliId"), lers("CptNom").ToString, lers("clenom").ToString, lers("bliText").ToString, lers("montantHT"))
        End While
        lers.Close()

    End Sub

    Sub listeCle()
        Dim sSql As String

        sSql = "SELECT cleId, cleNom from cleRepart where coproId= " & Me.lCopro.SelectedItem.value
        Call ComboRempli(sSql, Me.lCle, conSql)
        'Me.gCle.Rows.Clear()
    End Sub

    Sub afficheCopro()
        Me.lacoproId = Me.lCopro.SelectedItem.value
        Call FormRempli(Me.gCoord, "SELECT coproid,copronom, Adr1, CodePostal, Localite,socId FROM copro where coproid=" & lacoproId, conSql)
        Call FormRempli(Me.gSyndic, "SELECT nom, persId FROM Copro LEFT JOIN Annuaire ON copro.SyndicId = annuaire.PersId where coproId=" & lacoproId, conSql)

        Call listeCle()
        Call listeLots()
        Call listeEcrCopro()
        Call BudgetListe()
        Call DocListe(docType.Copro, Me.lacoproId, Me.gDoc)

        Me.oOnglet.Enabled = True
    End Sub

    Private Sub Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ListeCopro()
        If Me.lacoproId <> 0 Then
            Call ComboSelectValue(Me.lacoproId, Me.lCopro)
            Call afficheCopro()
        End If
    End Sub


    Private Sub lproprio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lCopro.SelectedIndexChanged
        If Me.lCopro.SelectedIndex >= 0 Then Call afficheCopro()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        If Me.lacoproId > 0 Then
            Call FormEnreg(Me.gCoord, "Copro", conSql)
            Call ListeCopro()
            Call ComboSelectValue(lacoproId, Me.lCopro)
        End If
    End Sub


    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If lacoproId = 0 Then Exit Sub
        F_CleRepart.lacoproId = Me.lacoproId
        F_CleRepart.laCleId = 0
        If F_CleRepart.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeCle()
        End If
    End Sub



    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If lacoproId = 0 Then Exit Sub
    End Sub

    Private Sub lCle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lCle.SelectedIndexChanged
        Call listeRepartLot()
    End Sub


    Private Sub gCle_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCle.CellDoubleClick
        If e.ColumnIndex = Me.gCle.Columns("surface").Index Then
            For i = 0 To Me.gCle.RowCount - 1
                Me.gCle.Rows(i).Cells("quotepartnew").Value = Me.gCle.Rows(i).Cells("surface").Value
            Next
        End If
        If e.ColumnIndex = Me.gCle.Columns("tantieme").Index Then
            For i = 0 To Me.gCle.RowCount - 1
                Me.gCle.Rows(i).Cells("quotepartnew").Value = Me.gCle.Rows(i).Cells("tantieme").Value
            Next
        End If
        If e.ColumnIndex = Me.gCle.Columns("quotepartactu").Index Then
            For i = 0 To Me.gCle.RowCount - 1
                Me.gCle.Rows(i).Cells("quotepartnew").Value = Me.gCle.Rows(i).Cells("quotepartactu").Value
            Next
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If lacoproId = 0 Then Exit Sub
        If Me.lCle.SelectedIndex < 0 Then Exit Sub

        F_CleRepart.laCleId = Me.lCle.SelectedItem.value
        If F_CleRepart.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeCle()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Me.lacoproId > 0 Then
            If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.tSyndicId.Text = F_AnnuRech.lePersId
                Me.tSyndicText.Text = F_AnnuRech.lePersNom
                sqlDo("update copro set syndicId=" & Me.tSyndicId.Text & " where coproId=" & lacoproId, conSql)
            End If
        End If
    End Sub


    Private Sub bDocAjout_Click(sender As System.Object, e As System.EventArgs) Handles bDocAjout.Click
        F_Document.leDocType = docType.Copro
        F_Document.lId = Me.lacoproId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Copro, Me.lacoproId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub bDocSupp_Click(sender As System.Object, e As System.EventArgs) Handles bDocSupp.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Copro, Me.lacoproId, Me.gDoc)

    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If lacoproId = 0 Then Exit Sub
        F_Budget.lacoproId = Me.lacoproId
        If F_Budget.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call BudgetListe()
            Call BudgetLignes()
        End If
    End Sub

    Private Sub lBudget_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lBudget.SelectedIndexChanged, lBudget.SelectedValueChanged
        Call BudgetLignes()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Me.lacoproId = 0 Then Exit Sub
        F_CoproCharge.FactInterne = False
        F_CoproCharge.laPiece = ""
        F_CoproCharge.lacoproId = Me.lacoproId
        F_CoproCharge.laSocId = Me.tSocId.Text
        F_CoproCharge.laPiece = ""
        If F_CoproCharge.ShowDialog = Windows.Forms.DialogResult.OK Then listeEcrCopro()
        F_CoproCharge.Dispose()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If Me.lBudget.SelectedIndex < 0 Then Exit Sub

        F_BudgetLigne.lacoproId = Me.lacoproId
        F_BudgetLigne.leBUdgetId = Me.lBudget.SelectedItem.value
        If F_BudgetLigne.ShowDialog = Windows.Forms.DialogResult.OK Then Call BudgetLignes()
        F_BudgetLigne.Dispose()

    End Sub

    Private Sub gBudget_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gBudget.CellDoubleClick
        F_BudgetLigne.laLigneId = Me.gBudget.SelectedRows(0).Cells("bliid").Value
        F_BudgetLigne.lacoproId = Me.lacoproId
        If F_BudgetLigne.ShowDialog = Windows.Forms.DialogResult.OK Then Call BudgetLignes()
        F_BudgetLigne.Dispose()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim sSql As String
        If Me.gBudget.SelectedRows.Count < 1 Then Exit Sub
        sSql = "delete from budgetligne where bliid=" & Me.gBudget.SelectedRows(0).Cells("bliid").Value
        sqlDo(sSql, conSql)
        Call BudgetLignes()
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim sSql As String

        If MessageBox.Show("Supprimer le Budget ?", "Attention", MessageBoxButtons.OK) = Windows.Forms.DialogResult.OK Then
            sSql = "delete from budgetligne where budid=" & Me.lBudget.SelectedItem.value
            sqlDo(sSql, conSql)
            sSql = "delete from budget where budid=" & Me.lBudget.SelectedItem.value
            sqlDo(sSql, conSql)
            Call BudgetListe()
            Me.gBudget.Rows.Clear()
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sSql As String = ""
        If lacoproId = 0 Then Exit Sub
        If Me.lCle.SelectedIndex < 0 Then Exit Sub

        '      sSql = "delete from clerepartlot where cleid=" & Me.lCle.SelectedItem.value
        '       sqlDo(sSql, conSql)

        For i = 0 To Me.gCle.RowCount - 1
            If Val(Me.gCle.Rows(i).Cells("quotepartactu").Value) <> Val(Me.gCle.Rows(i).Cells("quotepartnew").Value) Then
                If IsNothing(Me.gCle.Rows(i).Cells("quotepartactu").Value) Then
                    sSql = " insert into clerepartlot (cleid,lotid,quotepart) values (" & Me.lCle.SelectedItem.value & "," & Me.gCle.Rows(i).Cells("lotid").Value & "," & Val(Me.gCle.Rows(i).Cells("quotepartnew").Value) & ")"
                Else
                    sSql = " update clerepartlot set quotepart=" & Val(Me.gCle.Rows(i).Cells("quotepartnew").Value) & " where cleid=" & Me.lCle.SelectedItem.value & " and lotid= " & Me.gCle.Rows(i).Cells("lotid").Value
                End If
                sqlDo(sSql, conSql)
            End If
        Next



        'enregistre le total dans la clé
        sSql = "update clerepart set TotalQuotePart = total from" _
        & " (select sum (quotepart) as total from clerepartlot where cleid= " & Me.lCle.SelectedItem.value & ") as t " _
        & " where cleid=" & Me.lCle.SelectedItem.value
        sqlDo(sSql, conSql)

        MessageBox.Show("Enregistrement effectué", "Attention", MessageBoxButtons.OK)

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If Me.lCopro.SelectedIndex < 0 Then Exit Sub
        Select Case oOnglet.SelectedTab.Text
            Case "Ecritures" : Call XLexport(Me.gcompta, "Ecritures Copro : " & Me.lCopro.Text)
            Case "Lots" : Call XLexport(Me.gLots, "Lots Copro : " & Me.lCopro.Text)
            Case "Clé Répartition" : Call XLexport(Me.gCle, "Clé répartition Copro : " & Me.lCopro.Text & " - " & Me.lCle.Text)
            Case "Budget" : Call XLexport(Me.gBudget, "Budget copro : " & Me.lCopro.Text & " - " & Me.lBudget.Text)
        End Select
    End Sub

    Private Sub gLots_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLots.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                F_LotSuivi.lelotId = Me.gLots.SelectedRows(0).Cells("glotId").Value
                Call F_main.mnuLot_Click(Nothing, Nothing)
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gcompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gcompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call SupprEcr(Me.gcompta.SelectedRows(0).Cells("numpiece").Value)
            Call listeEcrCopro()
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If Me.lacoproId = 0 Then Exit Sub
        F_CoproCharge.FactInterne = True
        F_CoproCharge.laSOcId = Me.tSocId.Text
        F_CoproCharge.lacoproId = Me.lacoproId
        F_CoproCharge.laPiece = ""
        If F_CoproCharge.ShowDialog = Windows.Forms.DialogResult.OK Then listeEcrCopro()
        F_CoproCharge.Dispose()
    End Sub

    Private Sub Button11_Click_1(sender As System.Object, e As System.EventArgs) Handles bEditFActure.Click
        If Me.gcompta.SelectedRows.Count < 1 Then Exit Sub
        If Me.gcompta.SelectedRows(0).Cells("numfacture").Value <> "" Then
            Call FactureEdition(Me.gcompta.SelectedRows(0).Cells("numfacture").Value, docType.Copro, Me.tSocId.Text, lacoproId)
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        F_Lot.tCoproId.Text = Me.lacoproId
        F_Lot.tSocId.Text = Me.tSocId.Text
        F_Lot.leLotId = 0
        If F_Lot.ShowDialog = Windows.Forms.DialogResult.OK Then Call listeLots()
        F_Lot.Dispose()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If Me.gLots.SelectedRows.Count < 1 Then Exit Sub
        If MessageBox.Show("Supprimer le lot " & Me.gLots.SelectedRows(0).Cells("glotNOm").Value) = Windows.Forms.DialogResult.OK Then
            sqlDo("delete from lot where lotid=" & Me.gLots.SelectedRows(0).Cells("glotID").Value, conSql)
            sqlDo("delete from location where lotid=" & Me.gLots.SelectedRows(0).Cells("glotID").Value, conSql)
            Call listeLots()
        End If
    End Sub


    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim laligne As Integer
        Dim appXL As New Microsoft.Office.Interop.Excel.Application

        If Me.lBudget.SelectedIndex < 0 Then Exit Sub

        Try
            'vide la table tempo
            sSql = "Delete from TempSuiviBudget"
            sqlDo(sSql, conSql)

            sSql = "INSERT INTO TempSuiviBudget ( Cptid, MontantHTReel ) SELECT  CptId,-sum( ComptaGene.ecrMontantHT) as MontantReel" _
            & " FROM ComptaGene" _
            & " WHERE CoproID = " & Me.lacoproId & " And Rubrique = 'COPRO' and year(ecrdate) = " & Me.lBudget.Text _
            & " group by cptid "
            sqlDo(sSql, conSql)

            sSql = "insert into tempSuiviBudget (cptid,[montantHTReel-1]) SELECT  cptId,-sum( ComptaGene.ecrMontantHT) as MontantReel" _
            & " FROM ComptaGene" _
            & " WHERE CoproID = " & Me.lacoproId & " And Rubrique = 'COPRO' and year(ecrdate) = " & Val(Me.lBudget.Text) - 1 _
            & " group by cptid  "
            sqlDo(sSql, conSql)

            sSql = "insert into tempSuiviBudget (cptId,[montantHTPrev]) " _
            & " Select Cptid,sum(BudgetLigne.montantHT) as montantBUdget" _
            & " FROM Budget INNER JOIN BudgetLigne ON Budget.budId = BudgetLigne.budId" _
            & " WHERE BudAnnee=" & Val(Me.lBudget.Text) & " and budget.coproId=" & Me.lacoproId & " group by cptid"
            sqlDo(sSql, conSql)

            sSql = "insert into tempSuiviBudget (cptId,[montantHTPrev-1]) " _
            & " Select Cptid,sum( BudgetLigne.montantHT) as montantBUdget" _
            & " FROM Budget INNER JOIN BudgetLigne ON Budget.budId = BudgetLigne.budId" _
            & " WHERE BudAnnee=" & Val(Me.lBudget.Text) - 1 & " and budget.coproId=" & Me.lacoproId & " group by cptid"
            sqlDo(sSql, conSql)

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            'Recherche les données
            sSql = "SELECT PlanComptable.CptNum, PlanComptable.CptNom, Sum(TempSuiviBudget.[MontantHTPrev-1]) AS [MontantHTPrev-1], Sum(TempSuiviBudget.[MontantHTReel-1]) AS [MontantHTReel-1], Sum(TempSuiviBudget.MontantHTPrev) AS MontantHTPrev, Sum(TempSuiviBudget.MontantHTReel) AS MontantHTReel" _
            & " FROM PlanComptable INNER JOIN TempSuiviBudget ON PlanComptable.CptId = TempSuiviBudget.Cptid" _
            & " GROUP BY PlanComptable.CptNum, PlanComptable.CptNom" _
            & " order by cptnum"
            lers = sqlLit(sSql, conSql)

            laligne = 3
            appXL.Cells(laligne, 1).value = "'Compte"
            appXL.Cells(laligne, 2).value = "'Montant Prev HT " & Val(Me.lBudget.Text) - 1
            appXL.Cells(laligne, 3).value = "'Montant Réel HT" & Val(Me.lBudget.Text) - 1
            appXL.Cells(laligne, 4).value = "'Montant Prev HT" & Val(Me.lBudget.Text)
            appXL.Cells(laligne, 5).value = "'Montant Réel HT" & Val(Me.lBudget.Text)
            laligne += 1

            While lers.Read
                appXL.Cells(laligne, 1).value = "'" & lers("CptNum").ToString & " - " & lers("CptNOM").ToString
                appXL.Cells(laligne, 2).value = lers("MontantHTPrev-1")
                appXL.Cells(laligne, 3).value = lers("MontantHTReel-1")
                appXL.Cells(laligne, 4).value = lers("MontantHTPrev")
                appXL.Cells(laligne, 5).value = lers("MontantHTReel")
                laligne += 1
            End While
            lers.Close()

            appXL.Cells.Select()
            appXL.Cells.EntireColumn.AutoFit()
            'Facture Excel
            appXL.Range("A1").Value = "'Suivi budget " & Me.lCopro.Text & " - " & Me.lBudget.Text
            appXL.Range("A1").Select()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            appXL.Visible = True
            appXL.UserControl = True
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub gLots_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLots.CellDoubleClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex <> 3 Then
                F_Lot.leLotId = Me.gLots.SelectedRows(0).Cells("glotId").Value
                If F_Lot.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim m As Integer = e.RowIndex
                    Call listeLots()
                    Me.gLots.Rows(m).Selected = True
                    Me.gLots.FirstDisplayedScrollingRowIndex = m
                End If
                F_Lot.Dispose()
            End If
        End If
    End Sub


    '    SELECT lot.lotid,lot.lotnom,loc.locid,annuaire.nom,loc.dateentree,loc.datesortie,nbjour,[1],[2]
    'FROM
    '(
    'SELECT  lotid,locid,dateentree,datesortie,cleid,montanthtloc,nbjour
    'FROM   TempRepartLoc
    ') AS TableSource
    'PIVOT
    '(
    'sum(montanthtloc)
    'FOR cleid IN ([1], [2])
    ') AS t
    'inner join lot on t.lotid=lot.lotid
    'left join locataire as loc on t.locid = loc.locid
    'left join annuaire on loc.persid=annuaire.persid

    Private Sub RepartLot2(sender As System.Object, e As System.EventArgs)
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim laligne As Integer
        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim laRepart As String = ""
        Dim lesLignes As New List(Of Integer)
        Dim nbjourAn As Integer = DateDiff(DateInterval.Day, CDate("01/01/" & Me.lBudget.Text), CDate("31/12/" & Me.lBudget.Text)) + 1

        Try
            sqlDo("Truncate table temprepartLoc", conSql)

            sSql = "insert into temprepartloc " _
                & "SELECT ComptaGene.cleid, SUM(ComptaGene.ecrMontantHT) AS MontantHT, SUM(ComptaGene.ecrMontantTVA) AS MontantTVA" _
                & " , SUM(ComptaGene.ecrMontantTTC) AS MontantTTC, CleRepart.TotalQuotePart, CleRepartLot.lotID, CleRepartLot.QuotePart" _
                & " , Location.LocId, Locataire.DateEntree, Locataire.DateSortie, 0 , 0, 0,Locataire.DateEntree, Locataire.DateSortie,0,0" _
                & " FROM comptaGene" _
                & " LEFT JOIN CleRepart  ON CleRepart.CleId = comptaGene.cleid  " _
                & " LEFT JOIN CleRepartLot ON CleRepartLot.CleId = CleRepart.CleId" _
                & " LEFT JOIN Location ON Location.LotId = CleRepartLot.lotID" _
                & " LEFT JOIN locataire ON (Locataire.LocId = Location.LocId  and year(locataire.dateentree)<=" & Me.lBudget.Text & "  and  (year(locataire.datesortie)>=" & Me.lBudget.Text & "))" _
                & " WHERE ComptaGene.coproId = " & lacoproId & "  AND ComptaGene.Rubrique = 'COPRO' AND YEAR(ComptaGene.ecrDate) = " & Me.lBudget.Text _
                & " GROUP BY Locataire.DateEntree, Locataire.DateSortie, CleRepartLot.QuotePart, ComptaGene.cleid, CleRepartLot.lotID, Location.LocId, CleRepart.TotalQuotePart"

            sqlDo(sSql, conSql)
            sqlDo("update TempRepartLoc set nbjourtotal = " & nbjourAn, conSql)
            sqlDo("update TempRepartLoc set datedebut = '01/01/" & Me.lBudget.Text & "' where datedebut is null or datedebut < '01/01/" & Me.lBudget.Text & "'", conSql)
            sqlDo("update TempRepartLoc set datefin = '31/12/" & Me.lBudget.Text & "' where datefin is null or datefin >'31/12/" & Me.lBudget.Text & "'", conSql)
            sqlDo("update TempRepartLoc set nbjour = datediff(day,datedebut,datefin)+1", conSql)
            sqlDo("update TempRepartLoc set montantHTloc = MontantHTTotal * nbjour/ nbjourtotal * QuotePartLot/QuotePartTotal", conSql)
            sqlDo("update TempRepartLoc set montantTVAloc = MontantTVATotal * nbjour/ nbjourtotal * QuotePartLot/QuotePartTotal", conSql)
            sqlDo("update TempRepartLoc set montantTTCloc = MontantTTCTotal * nbjour/ nbjourtotal * QuotePartLot/QuotePartTotal", conSql)

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            '************************
            'Onglet 1 : controle des répartition
            '************************

            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Ecritures " & Me.lBudget.Text
            appXL.ActiveSheet.name = "Ecritures"
            laligne = 3
            appXL.Cells(laligne, 1).value = "'Charges"
            appXL.Cells(laligne, 2).value = "'Compte"
            appXL.Cells(laligne, 3).value = "'Date"
            appXL.Cells(laligne, 4).value = "'Libellé"
            appXL.Cells(laligne, 5).value = "'Montant HT"
            appXL.Cells(laligne, 6).value = "'Montant TVA"
            appXL.Cells(laligne, 7).value = "'Montant TTC"

            lesLignes.Clear()
            lesLignes.Add(laligne)
            laligne += 1

            sSql = "SELECT  CleNom, CptNum, CptNom, ecrDate, ecrMontantHT, ecrMontantTVA, ecrMontantTTC, ecrLib" _
                & " FROM ComptaGene " _
                & " LEFT OUTER JOIN PlanComptable ON ComptaGene.CptId = PlanComptable.CptId" _
                & " LEFT OUTER JOIN CleRepart ON ComptaGene.cleid = CleRepart.CleId" _
                & " WHERE  ComptaGene.coproId = " & Me.lacoproId _
                & " AND ComptaGene.Rubrique = 'COPRO' AND (YEAR(ComptaGene.ecrDate)) = " & Me.lBudget.Text _
                & " ORDER BY CleNom, CptNum, ecrDate"
            lers = sqlLit(sSql, conSql)
            laRepart = ""
            While lers.Read
                laligne += 1
                'Sous-Total
                If laRepart <> lers("CleNom") Then
                    If laRepart <> "" Then
                        appXL.Cells(laligne, 1).value = "'Sous-Total"
                        appXL.Cells(laligne, 5).formula = "=SUM(E" & lesLignes(lesLignes.Count - 1) + 2 & ":E" & laligne - 1 & ")"
                        appXL.Cells(laligne, 6).formula = "=SUM(F" & lesLignes(lesLignes.Count - 1) + 2 & ":F" & laligne - 1 & ")"
                        appXL.Cells(laligne, 7).formula = "=SUM(G" & lesLignes(lesLignes.Count - 1) + 2 & ":G" & laligne - 1 & ")"
                        lesLignes.Add(laligne)
                        laligne += 2
                    End If
                    laRepart = lers("CleNom")
                    appXL.Cells(laligne, 1).value = lers("CleNom").ToString
                End If

                '       If appXL.Cells(laligne - 1, 1).value <> lers("CleNom") Then appXL.Cells(laligne, 1).value = lers("CleNom").ToString
                If appXL.Cells(laligne - 1, 2).value <> (lers("CptNum") & " - " & lers("CptNom")) Then appXL.Cells(laligne, 2).value = (lers("CptNum") & " - " & lers("CptNom")).ToString
                appXL.Cells(laligne, 3).value = date2Xl(lers("ecrdate")) ' "'" & ladate.ToString("yyyy-MM-dd")
                appXL.Cells(laligne, 4).value = lers("ecrLib")
                appXL.Cells(laligne, 5).value = -lers("ecrMontantHT")
                appXL.Cells(laligne, 6).value = -lers("ecrMontantTVA")
                appXL.Cells(laligne, 7).value = -lers("ecrMontantTTC")
            End While
            lers.Close()

            'Sous-Total
            laligne += 1
            If laRepart <> "" Then
                appXL.Cells(laligne, 1).value = "'Sous-Total"
                appXL.Cells(laligne, 5).formula = "=SUM(E" & lesLignes(lesLignes.Count - 1) + 2 & ":E" & laligne - 1 & ")"
                appXL.Cells(laligne, 6).formula = "=SUM(F" & lesLignes(lesLignes.Count - 1) + 2 & ":F" & laligne - 1 & ")"
                appXL.Cells(laligne, 7).formula = "=SUM(G" & lesLignes(lesLignes.Count - 1) + 2 & ":G" & laligne - 1 & ")"
                lesLignes.Add(laligne)
                laligne += 2

                'Total
                appXL.Cells(laligne, 1).value = "'Total"
                appXL.Cells(laligne, 5).formula = "="
                appXL.Cells(laligne, 6).formula = "="
                appXL.Cells(laligne, 7).formula = "="
                For i = 1 To lesLignes.Count - 1
                    appXL.Cells(laligne, 5).formula = appXL.Cells(laligne, 5).formula & "+E" & lesLignes(i)
                    appXL.Cells(laligne, 6).formula = appXL.Cells(laligne, 6).formula & "+F" & lesLignes(i)
                    appXL.Cells(laligne, 7).formula = appXL.Cells(laligne, 7).formula & "+G" & lesLignes(i)
                Next
            End If
            appXL.Cells.Select()
            appXL.Cells.EntireColumn.AutoFit()

            '************************
            'Onglet 2
            '************************

            appXL.Sheets.Add(After:=appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Répartition"

            Dim lelot As Integer = 0
            Dim lacle As Integer = 0
            Dim TotalNbjour As Integer = 0
            Dim lacol As Integer = 0
            Dim leloc As Integer = 0

            laligne = 4
            appXL.Cells(laligne, 1).value = "'Lot"
            appXL.Cells(laligne, 3).value = "'Locataire"
            appXL.Cells(laligne, 4).value = "'Nbjours"
            TotalNbjour = nbjourAn
            laligne += 1

            sSql = "SELECT Batiment, LotNom, TempRepartLoc.lotID, TempRepartLoc.LocId , Nom, TlocalNom, locataire.DateEntree, locataire.DateSortie, nbjour, " _
            & " TempRepartLoc.nbjourtotal, CleRepart.CleNom, TempRepartLoc.QuotePartLot, TempRepartLoc.montantHTloc, TempRepartLoc.cleid" _
            & " FROM            TempRepartLoc LEFT OUTER JOIN " _
            & " CleRepart ON TempRepartLoc.cleid = CleRepart.CleId LEFT OUTER JOIN " _
            & " Lot ON TempRepartLoc.lotID = Lot.LotId LEFT OUTER JOIN" _
            & " TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId LEFT OUTER JOIN" _
            & " Annuaire RIGHT OUTER JOIN" _
            & " locataire ON Annuaire.PersId = locataire.PersId ON TempRepartLoc.LocId = locataire.LocId" _
            & " ORDER BY TempRepartLoc.lotID, TempRepartLoc.LocId, TempRepartLoc.cleid"

            lers = sqlLit(sSql, conSql)
            While lers.Read
                If lelot <> lers("LotId") Then
                    '    If TotalNbjour < nbjourAn Then
                    '        appXL.Cells(laligne, 3).value = "Vacant"
                    '        appXL.Cells(laligne, 4).value = nbjourAn - TotalNbjour
                    '    End If
                    laligne += 1
                    lelot = lers("LotId")
                    lacol = 5
                    lacle = lers("Cleid")
                    leloc = 0
                    appXL.Cells(laligne, 1).value = lers("LotNom").ToString & " (" & lers("TlocalNom").ToString & ")"
                    If nz(lers("Batiment"), "") <> "" Then appXL.Cells(laligne, 1).value = lers("Batiment").ToString & " - " & appXL.Cells(laligne, 1).value
                    TotalNbjour = 0
                End If

                If nz(lers("locid"), "") <> "" Then
                    If leloc <> 0 Then laligne += 1
                    If leloc <> lers("locid") Then
                        appXL.Cells(laligne, 3).value = lers("Nom")
                        appXL.Cells(laligne, 4).value = lers("nbjour")
                        leloc = lers("locid")
                        '        TotalNbjour += lers("nbjour")
                    End If
                End If

                'If lacle <> lers("cleid") Then
                '    lacol += 2
                'End If

                appXL.Cells(4, lacol).value = "'Quote-Part"
                appXL.Cells(4, lacol + 1).value = "'Montant"

                appXL.Cells(laligne, lacol).value = nz(lers("QuotePartLot"), "")
                appXL.Cells(laligne, lacol + 1).value = nz(lers("montantHTloc"), "")


                'laligne = 5
                ''formule du montant
                'For i = 5 To laLigneTotal - 1
                '    If appXL.Cells(i, 2).value <> 0 Then laligne = i
                '    appXL.Cells(i, lacol + 1).formula = "= (D" & i & "/D" & laLigneTotal & ") *" _
                '        & " (" & appXL.Cells(laligne, lacol).address & "/" & appXL.Cells(laLigneTotal, lacol).address & ") * " _
                '        & appXL.Cells(laLigneTotal, lacol + 1).address
                'Next


                'laligne = 5


            End While

            ' montant total
            'appXL.Cells(4, lacol).value = "'Total"
            'For i = 5 To laLigneTotal
            '    appXL.Cells(i, lacol).formula = "="
            '    For j = 6 To lacol - 1 Step 2
            '        appXL.Cells(i, lacol).formula &= "+" & appXL.Cells(i, j).address
            '    Next
            'Next

            'For i = 5 To lacol + 1
            '    appXL.Columns(i).NumberFormat = "# ##0.00"
            'Next
            If TotalNbjour < nbjourAn Then
                appXL.Cells(laligne, 3).value = "Vacant"
                appXL.Cells(laligne, 4).value = nbjourAn - TotalNbjour
                laligne += 1
            End If

            'laLigneTotal = laligne

            lers.Close()



            'APP.Range("A1:C1").ColumnWidth = 10
            'APP.Range("D1").ColumnWidth = 40
            'APP.Range("E1:X1").ColumnWidth = 10

            'APP.Range("A5:X5").WrapText = True
            'APP.Range("A5:X5").Interior.Color = RGB(155, 194, 230)
            'APP.Range("R4:U4").Interior.Color = RGB(155, 194, 230)
            'APP.Range("A4:T5").Font.Color = RGB(255, 255, 255)
            'APP.Range("A4:X5").Font.Bold = True

            'APP.Range("A4:B20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'APP.Range("A4:X20000").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            'APP.Range("A4:F20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'APP.Range("G6:I20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'APP.Range("J6:X20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            'APP.Range("J6:P20000").NumberFormat = "0.000"
            'APP.Range("Q6:V20000").NumberFormat = "# ##0"
            'APP.Range("S6:S20000").NumberFormat = "# ##0;[Red]-# ##0"
            'APP.Range("W6:X20000").NumberFormat = "# ##0;[Red]-# ##0"
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepartLot3(sender As System.Object, e As System.EventArgs)
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim laligne As Integer
        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim laRepart As String = ""
        Dim lesLignes As New List(Of Integer)
        Dim nbjourAn As Integer = DateDiff(DateInterval.Day, CDate("01/01/" & Me.lBudget.Text), CDate("31/12/" & Me.lBudget.Text)) + 1

        Try
            sqlDo("Truncate table temprepartLoc", conSql)

            sSql = "insert into temprepartloc " _
                & "SELECT ComptaGene.cleid, SUM(ComptaGene.ecrMontantHT) AS MontantHT, SUM(ComptaGene.ecrMontantTVA) AS MontantTVA" _
                & " , SUM(ComptaGene.ecrMontantTTC) AS MontantTTC, CleRepart.TotalQuotePart, CleRepartLot.lotID, CleRepartLot.QuotePart" _
                & " , Location.LocId, Locataire.DateEntree, Locataire.DateSortie, 0 , 0, 0,Locataire.DateEntree, Locataire.DateSortie,0,0" _
                & " FROM comptaGene" _
                & " LEFT JOIN CleRepart  ON CleRepart.CleId = comptaGene.cleid  " _
                & " LEFT JOIN CleRepartLot ON CleRepartLot.CleId = CleRepart.CleId" _
                & " LEFT JOIN Location ON Location.LotId = CleRepartLot.lotID" _
                & " LEFT JOIN locataire ON (Locataire.LocId = Location.LocId  and year(locataire.dateentree)<=" & Me.lBudget.Text & "  and  (year(locataire.datesortie)>=" & Me.lBudget.Text & "))" _
                & " WHERE ComptaGene.coproId = " & lacoproId & "  AND ComptaGene.Rubrique = 'COPRO' AND YEAR(ComptaGene.ecrDate) = " & Me.lBudget.Text _
                & " GROUP BY Locataire.DateEntree, Locataire.DateSortie, CleRepartLot.QuotePart, ComptaGene.cleid, CleRepartLot.lotID, Location.LocId, CleRepart.TotalQuotePart"

            sqlDo(sSql, conSql)
            sqlDo("update TempRepartLoc set nbjourtotal = " & nbjourAn, conSql)
            sqlDo("update TempRepartLoc set datedebut = '01/01/" & Me.lBudget.Text & "' where datedebut is null or datedebut < '01/01/" & Me.lBudget.Text & "'", conSql)
            sqlDo("update TempRepartLoc set datefin = '31/12/" & Me.lBudget.Text & "' where datefin is null or datefin >'31/12/" & Me.lBudget.Text & "'", conSql)
            sqlDo("update TempRepartLoc set nbjour = datediff(day,datedebut,datefin)+1", conSql)
            sqlDo("update TempRepartLoc set montantHTloc = MontantHTTotal * nbjour/ nbjourtotal * QuotePartLot/QuotePartTotal", conSql)
            sqlDo("update TempRepartLoc set montantTVAloc = MontantTVATotal * nbjour/ nbjourtotal * QuotePartLot/QuotePartTotal", conSql)
            sqlDo("update TempRepartLoc set montantTTCloc = MontantTTCTotal * nbjour/ nbjourtotal * QuotePartLot/QuotePartTotal", conSql)

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            '************************
            'Onglet 1 : controle des répartition
            '************************

            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Ecritures " & Me.lBudget.Text
            appXL.ActiveSheet.name = "Ecritures"
            laligne = 3
            appXL.Cells(laligne, 1).value = "'Charges"
            appXL.Cells(laligne, 2).value = "'Compte"
            appXL.Cells(laligne, 3).value = "'Date"
            appXL.Cells(laligne, 4).value = "'Libellé"
            appXL.Cells(laligne, 5).value = "'Montant HT"
            appXL.Cells(laligne, 6).value = "'Montant TVA"
            appXL.Cells(laligne, 7).value = "'Montant TTC"

            lesLignes.Clear()
            lesLignes.Add(laligne)
            laligne += 1

            sSql = "SELECT  CleNom, CptNum, CptNom, ecrDate, ecrMontantHT, ecrMontantTVA, ecrMontantTTC, ecrLib" _
                & " FROM ComptaGene " _
                & " LEFT OUTER JOIN PlanComptable ON ComptaGene.CptId = PlanComptable.CptId" _
                & " LEFT OUTER JOIN CleRepart ON ComptaGene.cleid = CleRepart.CleId" _
                & " WHERE  ComptaGene.coproId = " & Me.lacoproId _
                & " AND ComptaGene.Rubrique = 'COPRO' AND (YEAR(ComptaGene.ecrDate)) = " & Me.lBudget.Text _
                & " ORDER BY CleNom, CptNum, ecrDate"
            lers = sqlLit(sSql, conSql)
            laRepart = ""
            While lers.Read
                laligne += 1
                'Sous-Total
                If laRepart <> lers("CleNom") Then
                    If laRepart <> "" Then
                        appXL.Cells(laligne, 1).value = "'Sous-Total"
                        appXL.Cells(laligne, 5).formula = "=SUM(E" & lesLignes(lesLignes.Count - 1) + 2 & ":E" & laligne - 1 & ")"
                        appXL.Cells(laligne, 6).formula = "=SUM(F" & lesLignes(lesLignes.Count - 1) + 2 & ":F" & laligne - 1 & ")"
                        appXL.Cells(laligne, 7).formula = "=SUM(G" & lesLignes(lesLignes.Count - 1) + 2 & ":G" & laligne - 1 & ")"
                        lesLignes.Add(laligne)
                        laligne += 2
                    End If
                    laRepart = lers("CleNom")
                    appXL.Cells(laligne, 1).value = lers("CleNom").ToString
                End If

                '       If appXL.Cells(laligne - 1, 1).value <> lers("CleNom") Then appXL.Cells(laligne, 1).value = lers("CleNom").ToString
                If appXL.Cells(laligne - 1, 2).value <> (lers("CptNum") & " - " & lers("CptNom")) Then appXL.Cells(laligne, 2).value = (lers("CptNum") & " - " & lers("CptNom")).ToString
                appXL.Cells(laligne, 3).value = date2Xl(lers("ecrdate")) ' "'" & ladate.ToString("yyyy-MM-dd")
                appXL.Cells(laligne, 4).value = lers("ecrLib")
                appXL.Cells(laligne, 5).value = -lers("ecrMontantHT")
                appXL.Cells(laligne, 6).value = -lers("ecrMontantTVA")
                appXL.Cells(laligne, 7).value = -lers("ecrMontantTTC")
            End While
            lers.Close()

            'Sous-Total
            laligne += 1
            If laRepart <> "" Then
                appXL.Cells(laligne, 1).value = "'Sous-Total"
                appXL.Cells(laligne, 5).formula = "=SUM(E" & lesLignes(lesLignes.Count - 1) + 2 & ":E" & laligne - 1 & ")"
                appXL.Cells(laligne, 6).formula = "=SUM(F" & lesLignes(lesLignes.Count - 1) + 2 & ":F" & laligne - 1 & ")"
                appXL.Cells(laligne, 7).formula = "=SUM(G" & lesLignes(lesLignes.Count - 1) + 2 & ":G" & laligne - 1 & ")"
                lesLignes.Add(laligne)
                laligne += 2

                'Total
                appXL.Cells(laligne, 1).value = "'Total"
                appXL.Cells(laligne, 5).formula = "="
                appXL.Cells(laligne, 6).formula = "="
                appXL.Cells(laligne, 7).formula = "="
                For i = 1 To lesLignes.Count - 1
                    appXL.Cells(laligne, 5).formula = appXL.Cells(laligne, 5).formula & "+E" & lesLignes(i)
                    appXL.Cells(laligne, 6).formula = appXL.Cells(laligne, 6).formula & "+F" & lesLignes(i)
                    appXL.Cells(laligne, 7).formula = appXL.Cells(laligne, 7).formula & "+G" & lesLignes(i)
                Next
            End If
            appXL.Cells.Select()
            appXL.Cells.EntireColumn.AutoFit()

            '************************
            'Onglet 2
            '************************

            appXL.Sheets.Add(After:=appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Répartition"

            Dim lelot As Integer = 0
            Dim lacle As Integer = 0
            Dim TotalNbjour As Integer = 0
            Dim lacol As Integer = 0
            Dim leloc As Integer = 0

            laligne = 4
            appXL.Cells(laligne, 1).value = "'Lot"
            appXL.Cells(laligne, 3).value = "'Locataire"
            appXL.Cells(laligne, 4).value = "'Nbjours"
            TotalNbjour = nbjourAn
            laligne += 1

            sSql = "SELECT lot.lotid,lot.lotnom,loc.locid,annuaire.nom,loc.dateentree,loc.datesortie,nbjour,[1],[2]" _
& " FROM ( SELECT  lotid,locid,dateentree,datesortie,cleid,montanthtloc,nbjour FROM   TempRepartLoc) AS TableSource" _
& "            PIVOT" _
& " (sum(montanthtloc) FOR cleid IN ([1], [2]) ) AS t" _
& " inner join lot on t.lotid=lot.lotid" _
& " left join locataire as loc on t.locid = loc.locid" _
& " left join annuaire on loc.persid=annuaire.persid" _
& " order by lotid"
            lers = sqlLit(sSql, conSql)
            While lers.Read
                laligne += 1
                appXL.Cells(laligne, 1).value = lers("LotNom").ToString
                appXL.Cells(laligne, 2).value = lers("Nom")
                appXL.Cells(laligne, 3).value = nz(lers("dateentree"), "")
                appXL.Cells(laligne, 4).value = nz(lers("DateSortie"), "")
                appXL.Cells(laligne, 5).value = nz(lers("nbjour"), "")
                appXL.Cells(laligne, 6).value = nz(lers("1"), "")
                appXL.Cells(laligne, 7).value = nz(lers("2"), "")


            End While

            lers.Close()



            'APP.Range("A1:C1").ColumnWidth = 10
            'APP.Range("D1").ColumnWidth = 40
            'APP.Range("E1:X1").ColumnWidth = 10

            'APP.Range("A5:X5").WrapText = True
            'APP.Range("A5:X5").Interior.Color = RGB(155, 194, 230)
            'APP.Range("R4:U4").Interior.Color = RGB(155, 194, 230)
            'APP.Range("A4:T5").Font.Color = RGB(255, 255, 255)
            'APP.Range("A4:X5").Font.Bold = True

            'APP.Range("A4:B20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'APP.Range("A4:X20000").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            'APP.Range("A4:F20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'APP.Range("G6:I20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'APP.Range("J6:X20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            'APP.Range("J6:P20000").NumberFormat = "0.000"
            'APP.Range("Q6:V20000").NumberFormat = "# ##0"
            'APP.Range("S6:S20000").NumberFormat = "# ##0;[Red]-# ##0"
            'APP.Range("W6:X20000").NumberFormat = "# ##0;[Red]-# ##0"
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub repartLot()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim lers2 As OleDb.OleDbDataReader
        Dim laligne As Integer
        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim laRepart As String = ""
        Dim lesLignes As New List(Of Integer)

        If Me.lBudget.SelectedIndex < 0 Then Exit Sub

        Try
            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            'Onglet 1 : controle des répartition
            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Ecritures " & Me.lBudget.Text
            appXL.ActiveSheet.name = "Ecritures"
            laligne = 3
            appXL.Cells(laligne, 1).value = "'Charges"
            appXL.Cells(laligne, 2).value = "'Compte"
            appXL.Cells(laligne, 3).value = "'Date"
            appXL.Cells(laligne, 4).value = "'Libellé"
            appXL.Cells(laligne, 5).value = "'Montant HT"
            appXL.Cells(laligne, 6).value = "'Montant TVA"
            appXL.Cells(laligne, 7).value = "'Montant TTC"

            lesLignes.Clear()
            lesLignes.Add(laligne)
            laligne += 1

            sSql = "SELECT  CleNom, CptNum, CptNom, ecrDate, ecrMontantHT, ecrMontantTVA, ecrMontantTTC, ecrLib" _
                & " FROM ComptaGene " _
                & " LEFT OUTER JOIN PlanComptable ON ComptaGene.CptId = PlanComptable.CptId" _
                & " LEFT OUTER JOIN CleRepart ON ComptaGene.cleid = CleRepart.CleId" _
                & " WHERE  ComptaGene.coproId = " & Me.lacoproId _
                & " AND ComptaGene.Rubrique = 'COPRO' AND (YEAR(ComptaGene.ecrDate)) = " & Me.lBudget.Text _
                & " ORDER BY CleNom, CptNum, ecrDate"
            lers = sqlLit(sSql, conSql)
            laRepart = ""
            While lers.Read
                laligne += 1
                'Sous-Total
                If laRepart <> lers("CleNom") Then
                    If laRepart <> "" Then
                        appXL.Cells(laligne, 1).value = "'Sous-Total"
                        appXL.Cells(laligne, 5).formula = "=SUM(E" & lesLignes(lesLignes.Count - 1) + 2 & ":E" & laligne - 1 & ")"
                        appXL.Cells(laligne, 6).formula = "=SUM(F" & lesLignes(lesLignes.Count - 1) + 2 & ":F" & laligne - 1 & ")"
                        appXL.Cells(laligne, 7).formula = "=SUM(G" & lesLignes(lesLignes.Count - 1) + 2 & ":G" & laligne - 1 & ")"
                        lesLignes.Add(laligne)
                        laligne += 2
                    End If
                    laRepart = lers("CleNom")
                    appXL.Cells(laligne, 1).value = lers("CleNom").ToString
                End If

                '       If appXL.Cells(laligne - 1, 1).value <> lers("CleNom") Then appXL.Cells(laligne, 1).value = lers("CleNom").ToString
                If appXL.Cells(laligne - 1, 2).value <> (lers("CptNum") & " - " & lers("CptNom")) Then appXL.Cells(laligne, 2).value = (lers("CptNum") & " - " & lers("CptNom")).ToString
                appXL.Cells(laligne, 3).value = date2Xl(lers("ecrdate")) ' "'" & ladate.ToString("yyyy-MM-dd")
                appXL.Cells(laligne, 4).value = lers("ecrLib")
                appXL.Cells(laligne, 5).value = -lers("ecrMontantHT")
                appXL.Cells(laligne, 6).value = -lers("ecrMontantTVA")
                appXL.Cells(laligne, 7).value = -lers("ecrMontantTTC")
            End While
            lers.Close()

            'Sous-Total
            laligne += 1
            If laRepart <> "" Then
                appXL.Cells(laligne, 1).value = "'Sous-Total"
                appXL.Cells(laligne, 5).formula = "=SUM(E" & lesLignes(lesLignes.Count - 1) + 2 & ":E" & laligne - 1 & ")"
                appXL.Cells(laligne, 6).formula = "=SUM(F" & lesLignes(lesLignes.Count - 1) + 2 & ":F" & laligne - 1 & ")"
                appXL.Cells(laligne, 7).formula = "=SUM(G" & lesLignes(lesLignes.Count - 1) + 2 & ":G" & laligne - 1 & ")"
                lesLignes.Add(laligne)
                laligne += 2

                'Total
                appXL.Cells(laligne, 1).value = "'Total"
                appXL.Cells(laligne, 5).formula = "="
                appXL.Cells(laligne, 6).formula = "="
                appXL.Cells(laligne, 7).formula = "="
                For i = 1 To lesLignes.Count - 1
                    appXL.Cells(laligne, 5).formula = appXL.Cells(laligne, 5).formula & "+E" & lesLignes(i)
                    appXL.Cells(laligne, 6).formula = appXL.Cells(laligne, 6).formula & "+F" & lesLignes(i)
                    appXL.Cells(laligne, 7).formula = appXL.Cells(laligne, 7).formula & "+G" & lesLignes(i)
                Next
            End If
            appXL.Cells.Select()
            appXL.Cells.EntireColumn.AutoFit()

            'Onglet 2
            appXL.Sheets.Add(After:=appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Répartition"

            Dim nbjour As Integer = 0
            Dim lelot As Integer = 0
            Dim TotalNbjour As Integer = 0
            Dim nbjourAn As Integer = DateDiff(DateInterval.Day, CDate("01/01/" & Me.lBudget.Text), CDate("31/12/" & Me.lBudget.Text)) + 1
            Dim dateFin As Date
            Dim dateDebut As Date
            Dim laLigneTotal As Integer = 0

            laligne = 4
            appXL.Cells(laligne, 1).value = "'Lot"
            appXL.Cells(laligne, 3).value = "'Locataire"
            appXL.Cells(laligne, 4).value = "'Nbjours"
            TotalNbjour = nbjourAn
            laligne += 1

            sSql = "SELECT Batiment , TlocalNom, LotNom, Nom, DateEntree, DateSortie,lot.lotId FROM Lot " _
            & " LEFT OUTER JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
            & " LEFT OUTER JOIN Annuaire RIGHT OUTER JOIN Locataire ON Annuaire.PersId = Locataire.PersId " _
            & " RIGHT OUTER JOIN  Location ON Locataire.LocId = Location.LocId ON Lot.LotId = Location.LotId" _
            & " WHERE Lot.CoproId = " & lacoproId _
            & " ORDER BY Batiment, LotNom,lotId, DateEntree"
            lers = sqlLit(sSql, conSql)
            While lers.Read
                appXL.StatusBar = "Locataire " & laligne - 4
                If lelot <> lers("LotId") Then
                    If TotalNbjour < nbjourAn Then
                        appXL.Cells(laligne, 3).value = "Vacant"
                        appXL.Cells(laligne, 4).value = nbjourAn - TotalNbjour
                        laligne += 1
                    End If
                    lelot = lers("LotId")
                    appXL.Cells(laligne, 1).value = lers("LotNom").ToString & " (" & lers("TlocalNom").ToString & ")"
                    appXL.Cells(laligne, 2).value = lelot
                    If nz(lers("Batiment"), "") <> "" Then appXL.Cells(laligne, 1).value = lers("Batiment").ToString & " - " & appXL.Cells(laligne, 1).value
                    TotalNbjour = 0
                End If

                If nz(lers("Nom"), "") <> "" Then
                    dateDebut = lers("DateEntree")
                    dateFin = nz(lers("DateSortie"), CDate("31/12/" & Me.lBudget.Text))

                    If Year(dateDebut) <= Val(Me.lBudget.Text) And Year(dateFin) = Val(Me.lBudget.Text) Then
                        dateDebut = MaxDate(dateDebut, CDate("01/01/" & Me.lBudget.Text))
                        nbjour = DateDiff(DateInterval.Day, dateDebut, dateFin) + 1
                        TotalNbjour += nbjour
                        appXL.Cells(laligne, 3).value = lers("Nom")
                        appXL.Cells(laligne, 4).value = nbjour
                        laligne += 1
                    End If
                End If
            End While
            lers.Close()
            appXL.StatusBar = ""

            If TotalNbjour < nbjourAn Then
                appXL.Cells(laligne, 3).value = "Vacant"
                appXL.Cells(laligne, 4).value = nbjourAn - TotalNbjour
                laligne += 1
            End If
            appXL.Cells(laligne, 1).value = "'Total"
            appXL.Cells(laligne, 4).value = nbjourAn
            laLigneTotal = laligne

            'boucle des charges
            Dim lacol As Integer = 5
            sSql = "SELECT CleNom, sum(ecrMontantHT) as montantHT, CleRepart.CleId, TotalQuotePart" _
            & " FROM ComptaGene " _
            & " LEFT OUTER JOIN CleRepart ON ComptaGene.cleid = CleRepart.CleId" _
            & " WHERE  ComptaGene.coproId = " & lacoproId & " AND ComptaGene.Rubrique = 'COPRO' and  YEAR(ComptaGene.ecrDate) = " & Me.lBudget.Text _
            & " GROUP BY CleNom, CleRepart.CleId, TotalQuotePart ORDER BY CleNom"
            lers = sqlLit(sSql, conSql)
            While lers.Read
                appXL.StatusBar = "Charges " & lacol - 4
                laligne = 3
                appXL.Range(appXL.Cells(laligne, lacol).address, appXL.Cells(laligne, lacol + 1)).Merge()
                appXL.Cells(laligne, lacol).value = lers("Clenom")
                laligne += 1
                appXL.Cells(laligne, lacol).value = "'Quote-Part"
                appXL.Cells(laligne, lacol + 1).value = "'Montant"
                appXL.Cells(laLigneTotal, lacol).value = lers("TotalQuotePart")
                appXL.Cells(laLigneTotal, lacol + 1).value = -lers("montantHt")

                'les repart
                sSql = "select lotid,quotepart from clerepartlot where cleid=" & lers("CleId") _
                & " order by lotID"
                lers2 = sqlLit(sSql, conSql)
                Dim nb As Integer = 1
                While lers2.Read
                    appXL.StatusBar = "Charges " & lacol - 4 & " - Lot " & nb
                    nb += 1
                    'affiche la repart
                    For i = 5 To laLigneTotal - 1
                        If appXL.Cells(i, 2).value = lers2("lotid") Then appXL.Cells(i, lacol).value = lers2("quotepart")
                    Next

                    laligne = 5
                    'formule du montant
                    For i = 5 To laLigneTotal - 1
                        If appXL.Cells(i, 2).value <> 0 Then laligne = i
                        appXL.Cells(i, lacol + 1).formula = "= (D" & i & "/D" & laLigneTotal & ") *" _
                            & " (" & appXL.Cells(laligne, lacol).address & "/" & appXL.Cells(laLigneTotal, lacol).address & ") * " _
                            & appXL.Cells(laLigneTotal, lacol + 1).address
                    Next
                End While

                laligne = 5


                lers2.Close()
                lacol += 2
            End While
            lers.Close()

            ' montant total
            appXL.Cells(4, lacol).value = "'Total"
            For i = 5 To laLigneTotal
                appXL.Cells(i, lacol).formula = "="
                For j = 6 To lacol - 1 Step 2
                    appXL.Cells(i, lacol).formula &= "+" & appXL.Cells(i, j).address
                Next
            Next

            For i = 5 To lacol + 1
                appXL.Columns(i).NumberFormat = "# ##0.00"
            Next



            'APP.Range("A1:C1").ColumnWidth = 10
            'APP.Range("D1").ColumnWidth = 40
            'APP.Range("E1:X1").ColumnWidth = 10

            'APP.Range("A5:X5").WrapText = True
            'APP.Range("A5:X5").Interior.Color = RGB(155, 194, 230)
            'APP.Range("R4:U4").Interior.Color = RGB(155, 194, 230)
            'APP.Range("A4:T5").Font.Color = RGB(255, 255, 255)
            'APP.Range("A4:X5").Font.Bold = True

            'APP.Range("A4:B20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'APP.Range("A4:X20000").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            'APP.Range("A4:F20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            'APP.Range("G6:I20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'APP.Range("J6:X20000").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            'APP.Range("J6:P20000").NumberFormat = "0.000"
            'APP.Range("Q6:V20000").NumberFormat = "# ##0"
            'APP.Range("S6:S20000").NumberFormat = "# ##0;[Red]-# ##0"
            'APP.Range("W6:X20000").NumberFormat = "# ##0;[Red]-# ##0"
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub gcompta_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gcompta.CellContentClick

    End Sub

    Private Sub gcompta_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gcompta.CellDoubleClick
        F_CoproCharge.laSocId = Me.tSocId.Text
        F_CoproCharge.lacoproId = Me.lacoproId
        F_CoproCharge.laPiece = Me.gcompta.SelectedRows(0).Cells("numpiece").Value
        If F_CoproCharge.ShowDialog = Windows.Forms.DialogResult.OK Then listeEcrCopro()
        F_CoproCharge.Dispose()
    End Sub

    Private Sub Button11_Click_2(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Call repartLot()
    End Sub
End Class