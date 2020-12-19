Imports System.IO
Imports Microsoft.Office.Interop

Public Class F_CoproSuivi
    Public lacoproId As Integer

    Public Class locRepart
        Public locId As Integer
        Public loyer As Decimal
        Public charge As Decimal
        Public hono As Decimal
        Public Solde As Decimal
        Public Prov As Decimal

        Public Sub New(ByVal leLocId As Integer, leloyer As Decimal, lacharge As Decimal, leshono As Decimal, leSolde As Decimal, laProv As Decimal)
            locId = leLocId
            loyer = leloyer
            charge = lacharge
            hono = leshono
            Solde = leSolde
            Prov = laProv
        End Sub
    End Class

    Sub ListeCopro()
        Dim sSql As String
        sSql = "SELECT CoproId, CoproNom FROM Copro"
        Call ComboRempli(sSql, Me.lCopro, conSql)
    End Sub

    Sub totalQuote()
        Dim tot As Decimal = 0

        If Me.gCle.Visible Then
            For i = 0 To Me.gCle.Rows.Count - 1
                If Me.gCle.Rows(i).Visible = True Then tot += txt2num(nz(Me.gCle.Rows(i).Cells("QuotePartNew").Value, 0))
            Next
        End If

        If Me.gCleLoc.Visible Then
            For i = 0 To Me.gCleLoc.Rows.Count - 1
                If Me.gCleLoc.Rows(i).Visible = True Then tot += txt2num(nz(Me.gCleLoc.Rows(i).Cells("QuotePartLoc").Value, 0))
            Next
        End If

        Me.tTotalQuote.Text = tot
    End Sub

    Sub afficheTypeLocal()
        Dim lers As OleDb.OleDbDataReader
        lers = sqlLit("select tlocalid,tlocalnom from typelocal order by tlocalnom", conSql)
        Me.gTypeLocal.Rows.Clear()

        While lers.Read
            Me.gTypeLocal.Rows.Add(lers("tlocalid"), True, lers("tlocalnom"))
        End While
        lers.Close()
    End Sub


    Sub listeRepartCleLot(filtre As Boolean)



        If Me.lCle.SelectedIndex < 0 Then Exit Sub

        Dim lefiltre As String = ","

        For i = 0 To Me.gTypeLocal.Rows.Count - 1
            If filtre Then
                lefiltre &= Me.gTypeLocal.Rows(i).Cells(2).Value & ","
            Else
                Me.gTypeLocal.Rows(i).Cells(1).Value = True
            End If
        Next

        Me.gCle.Visible = False
        Me.gCle.Rows.Clear()

        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim loc As Boolean = False
        Dim tmp As Boolean = False
        Dim TMPActu As String = ""

        'calcul surface louée
        sqlDo("truncate table temprepartloc", conSql)

        sSql = " insert into temprepartloc (CoproId,lotID,locId,DateEntree,datesortie,surfaceloc)" _
        & " select coproid,lot.lotId,locid,datedebut,datefin,location.surface from lot" _
        & " inner join location on lot.lotId=location.Lotid where coproid=" & Me.lacoproId _
        & " and year(datedebut)<=year(getdate())-1" _
        & " And (Year(datefin) >= Year(getdate()) - 1 Or datefin Is null)"
        sqlDo(sSql, conSql)

        sSql = "update temprepartloc set dateentree='" & Year(Now) - 1 & "-01-01' where dateentree<'" & Year(Now) - 1 & "-01-01'"
        sqlDo(sSql, conSql)

        sSql = "update temprepartloc set datesortie='" & Year(Now) - 1 & "-12-31' where datesortie>'" & Year(Now) - 1 & "-12-31' or datesortie is null"
        sqlDo(sSql, conSql)

        sSql = " update temprepartloc set nbjour=365, nbjourlotOcc = datediff(""dd"",dateentree,datesortie)+1"
        sqlDo(sSql, conSql)

        sSql = "update temprepartloc set surfaceMoyLoc=surfaceloc* nbjourlotOcc/ nbjour"
        sqlDo(sSql, conSql)

        'sSql = "MERGE INTO clerepartlot AS T USING " _
        '    & " (select lotid,sum(surfacemoy) as surfacemoy from temprepartloc group by lotid ) as S" _
        '    & " ON T.LotID = S.LotId  " _
        '    & " WHEN MATCHED THEN  UPDATE SET SurfLoc = S.SurfaceMoy" _
        '    & " WHEN NOT MATCHED  THEN  INSERT (cleid,lotid, surfLoc) VALUES (" & Me.lCle.SelectedItem.value & " ,s.lotid,SurfaceMoy);"
        'sqlDo(sSql, conSql)

        'lot avec clé
        sSql = "SELECT lot.LotId, lot.batiment, TlocalNom, LotNom, lot.Surface,Loc,Tmp, QuotePart,nom,surfaceMoyLoc" _
        & " , row_number() over( partition by lot.lotid order by lot.lotid,dateentree desc) as nb" _
        & " FROM Lot LEFT JOIN CleRepartLot ON Lot.LotId = CleRepartLot.lotID and cleid=" & Me.lCle.SelectedItem.value _
        & " LEFT JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
        & " left join (select lotid,locid from temprepartloc ) as location on location.lotid=lot.lotid " _
        & " Left join (select lotid,sum(surfacemoyLoc) as surfacemoyLoc from temprepartloc group by lotid ) as t on t.lotId=lot.lotid" _
        & " left JOIN locataire  on location.locid = locataire.locid" _
        & " LEFT JOIN  Annuaire ON locataire.PersId = Annuaire.PersId" _
        & " WHERE lot.coproid=" & Me.lacoproId
        lers = sqlLit(sSql, conSql)
        While lers.Read
            If lers("nb") = 1 Then
                loc = nz(lers("loc"), False)
                tmp = nz(lers("tmp"), False)
                '      If loc = False And pro = False Then tmp = True
                TMPActu = IIf(loc, "L", "") & IIf(tmp, "T", "")
                Me.gCle.Rows.Add(lers("lotId"), lers("TlocalNom").ToString, lers("BAtiment").ToString, lers("LotNom").ToString, lers("Surface").ToString, lers("SurfaceMoyLoc").ToString, lers("nom").ToString, tmp, loc, lers("QuotePart").ToString, lers("QuotePart").ToString, TMPActu)
                If filtre And lefiltre.Contains("," & lers("Tlocalnom").ToString & ",") = False Then Me.gCle.Rows(Me.gCle.Rows.Count - 1).Visible = False
            End If
        End While
        lers.Close()

        Call totalQuote()

        lers.Close()

        Call Gridfiltre(False)
        Me.gCle.Visible = True


    End Sub


    Sub listeRepartCleLoc(filtre As Boolean)
        Dim lefiltre As String = ","

        If Me.lCle.SelectedIndex < 0 Then Exit Sub

        For i = 0 To Me.gTypeLocal.Rows.Count - 1
            If filtre Then
                lefiltre &= Me.gTypeLocal.Rows(i).Cells(2).Value & ","
            Else
                Me.gTypeLocal.Rows(i).Cells(1).Value = True
            End If
        Next

        Me.gCleLoc.Visible = False
        Me.gCleLoc.Rows.Clear()

        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim loc As Boolean = False
        Dim pro As Boolean = False
        Dim tmp As Boolean = False
        Dim TMPActu As String = ""


        'lot avec clé
        sSql = "SELECT        locataire.LocId, Lot.LotId, Lot.Batiment, TypeLocal.TlocalNom, Lot.LotNom, Lot.Surface" _
        & ", CleRepartLot.QuotePart, Annuaire.Nom, Location.dateDebut, Location.dateFin" _
        & ", Location.Surface AS SurfLoc, Location.BailId" _
        & " FROM Lot" _
        & " LEFT OUTER JOIN  TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
        & " INNER JOIN Location ON Lot.LotId = Location.LotId " _
        & " LEFT OUTER JOIN CleRepartLot ON Location.BailId = CleRepartLot.BailId AND CleRepartLot.CleId = " & Me.lCle.SelectedItem.value _
        & " INNER JOIN locataire ON Location.LocId = locataire.LocId " _
        & " LEFT OUTER JOIN  Annuaire ON locataire.PersId = Annuaire.PersId" _
        & " WHERE Lot.CoproId = " & Me.lacoproId _
        & " and year(location.datedebut)<=year(getdate())-1 " _
        & " and ( year(location.datefin)>=year(getdate())-1 or location.datefin is null)"

        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gCleLoc.Rows.Add(lers("locId"), lers("nom").ToString, lers("TlocalNom").ToString, lers("BAtiment").ToString, lers("LotNom").ToString, lers("Surface").ToString, lers("SurfLoc").ToString, _
                date2Grid(lers("datedebut")), date2Grid(lers("datefin")), lers("QuotePart").ToString, lers("QuotePart").ToString, lers("lotid").ToString, lers("BailId").ToString)
            If filtre And lefiltre.Contains("," & lers("Tlocalnom").ToString & ",") = False Then Me.gCle.Rows(Me.gCle.Rows.Count - 1).Visible = False
        End While
        lers.Close()

        Call totalQuote()

        lers.Close()

        Call Gridfiltre(True)
        Me.gCleLoc.Visible = True


    End Sub


    Private Sub gCle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCle.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 7 Or e.ColumnIndex = 8 Then
                With (Me.gCle.Rows(e.RowIndex))
                    If e.ColumnIndex <> 7 And .Cells(7).Value <> False Then Me.gCle.Rows(e.RowIndex).Cells(7).Value = False
                    If e.ColumnIndex <> 8 And .Cells(8).Value <> False Then Me.gCle.Rows(e.RowIndex).Cells(8).Value = False
                End With
            End If
        End If
    End Sub

    Sub listeLots()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.gLots.Rows.Clear()
        'lot avec clé
        sSql = "SELECT LotId, Batiment, TlocalNom, LotNom, socid, Surface " _
        & " FROM LOT left join TypeLocal ON TypeLocal.TlocalId = Lot.TLocalId " _
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

            Me.gChargeCopro.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
                credit = IIf(lers("ecrmontantTTC") >= 0, lers("ecrmontantTTC"), 0)
                ladate = lers("ecrDate")
                Me.gChargeCopro.Rows.Add(lers("ecrId"), lers("numpiece").ToString, ladate.ToString("yyyy-MM-dd"), lers("numfacture").ToString, lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()
            If Me.gChargeCopro.Rows.Count > 0 Then Call Gridcalculsolde(Me.gChargeCopro)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ListeCoproCharge()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim totBudget As Decimal = 0
        Dim totreel As Decimal = 0
        Try
            If Me.lBudget.SelectedIndex >= 0 Then
                sSql = "SELECT CoproCharge.ChId, CoproCharge.ChLib,CoproCharge.ChMontantBudgetHT, CoproCharge.ChMontantHT, CoproCharge.ChMontantTVA, " _
                    & " CoproCharge.ChMontantTTC, TypeChargeCat.tChCatLib, CLeRepart.CleNom" _
                    & " FROM CoproCharge " _
                    & " LEFT OUTER JOIN CleRepart ON CoproCharge.cleid = CleRepart.CleId " _
                    & " LEFT OUTER JOIN TypeChargeCat ON CoproCharge.tChCatId = TypeChargeCat.tChCatId" _
                    & " where budId=" & Me.lBudget.SelectedItem.value & " order by tChCatLib,ChLib"

                Me.gChargeCopro.Rows.Clear()
                lers = sqlLit(sSql, conSql)
                While lers.Read
                    totreel += nz(lers("ChMontantHT"), 0)
                    totBudget += nz(lers("ChMontantBudgetHT"), 0)
                    Me.gChargeCopro.Rows.Add(lers("chid"), lers("tChCatLib").ToString, lers("CleNom").ToString, lers("ChLib").ToString, lers("ChMontantBudgetHT"), lers("ChMontantHT"), lers("ChMontantTVA"), lers("ChMontantTTC"))
                End While
                lers.Close()
                Me.tTotBudget.Text = totBudget
                Me.tTotReel.Text = totreel
            End If
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BudgetListe()
        Dim sSql As String
        sSql = "SELECT budId, budAnnee  from budget where coproId= " & Me.lCopro.SelectedItem.value
        Call ComboRempli(sSql, Me.lBudget, conSql)
        Me.gChargeCopro.Rows.Clear()
        Me.tTotBudget.Text = ""
    End Sub

    Sub listeCle(Reaffiche As Boolean)
        Dim sSql As String

        sSql = "SELECT cleId, cleNom + case when cleloc=1 then ' (Loc)' else '' end as clenom from cleRepart where coproId= " & Me.lCopro.SelectedItem.value
        Call ComboRempli(sSql, Me.lCle, conSql)
        If Reaffiche Then Me.gCle.Rows.Clear()
    End Sub

    Sub afficheCopro()
        Me.lacoproId = Me.lCopro.SelectedItem.value
        Call FormRempli(Me.gCoord, "SELECT coproid,copronom, Adr1, CodePostal, Localite,socId FROM copro where coproid=" & lacoproId, conSql)
        Call FormRempli(Me.gSyndic, "SELECT nom, persId FROM Copro LEFT JOIN Annuaire ON copro.SyndicId = annuaire.PersId where coproId=" & lacoproId, conSql)

        Call listeCle(True)
        Call listeLots()
        '    Call listeEcrCopro()
        Call BudgetListe()

        Call DocListe(docType.Copro, Me.lacoproId, Me.gDoc)

        Me.oOnglet.Enabled = True
    End Sub

    Private Sub Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ListeCopro()
        Call afficheTypeLocal()
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
            Call listeCle(False)
            Call ComboSelectTxt(F_CleRepart.laCleId, Me.lCle)
        End If
    End Sub



    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If Me.lCle.SelectedIndex < 0 Then Exit Sub

        Dim sSql As String
        If MessageBox.Show("Supprimer cette clé ?", "Attention", MessageBoxButtons.OK) = Windows.Forms.DialogResult.OK Then
            sSql = "delete from clerepartlot where cleid=" & Me.lCle.SelectedItem.value
            sqlDo(sSql, conSql)
            sSql = "delete from clerepart where cleid=" & Me.lCle.SelectedItem.value
            sqlDo(sSql, conSql)
            Call listeCle(True)
            Me.gCle.Rows.Clear()
            Me.gCleLoc.Rows.Clear()
        End If

    End Sub

    Private Sub lCle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lCle.SelectedIndexChanged
        If Me.lCle.SelectedIndex < 0 Then Exit Sub

        If Me.lCle.SelectedItem.text.ToString.Contains("(Loc)") Then
            Me.gCle.Rows.Clear()
            Me.gCle.Visible = False
            Me.gCleLoc.Visible = True
            listeRepartCleLoc(True)
        Else
            Me.gCleLoc.Rows.Clear()
            Me.gCle.Visible = True
            Me.gCleLoc.Visible = False
            listeRepartCleLot(True)
        End If
    End Sub

    Private Sub gCle_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCle.CellDoubleClick

        If (e.ColumnIndex = 7 Or e.ColumnIndex = 8) And (e.RowIndex < 0) Then
            For i = 0 To Me.gCle.Rows.Count - 1
                Me.gCle.Rows(i).Cells(7).Value = False
                Me.gCle.Rows(i).Cells(8).Value = False
                If e.ColumnIndex = 7 Then Me.gCle.Rows(i).Cells(7).Value = True
                If e.ColumnIndex = 8 Then Me.gCle.Rows(i).Cells(8).Value = True
            Next
        End If


        If e.RowIndex >= 0 Then
            If e.ColumnIndex = Me.gCle.Columns("surface").Index Then
                For i = 0 To Me.gCle.RowCount - 1
                    Me.gCle.Rows(i).Cells("quotepartnew").Value = Me.gCle.Rows(i).Cells("surface").Value
                    Me.gCle.Rows(i).Cells(7).Value = True
                    Me.gCle.Rows(i).Cells(8).Value = False
                Next
                Call totalQuote()
            End If
            If e.ColumnIndex = Me.gCle.Columns("surfMoy").Index Then
                For i = 0 To Me.gCle.RowCount - 1
                    Me.gCle.Rows(i).Cells("quotepartnew").Value = Me.gCle.Rows(i).Cells("surfMoy").Value
                    Me.gCle.Rows(i).Cells(7).Value = False
                    Me.gCle.Rows(i).Cells(8).Value = True
                Next
                Call totalQuote()
            End If
        End If
    End Sub

    Private Sub gCleLoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCleLoc.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = Me.gCleLoc.Columns("surfaceLotLoc").Index Then
            For i = 0 To Me.gCleLoc.RowCount - 1
                Me.gCleLoc.Rows(i).Cells("quotepartLoc").Value = Me.gCleLoc.Rows(i).Cells("surfaceLotLoc").Value
            Next
            Call totalQuote()
        End If

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If lacoproId = 0 Then Exit Sub
        If Me.lCle.SelectedIndex < 0 Then Exit Sub

        F_CleRepart.laCleId = Me.lCle.SelectedItem.value
        If F_CleRepart.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeCle(False)
            Call ListeCoproCharge()
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

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles bAddBudget.Click
        If lacoproId = 0 Then Exit Sub
        F_Budget.lacoproId = Me.lacoproId
        If F_Budget.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call BudgetListe()
        End If
    End Sub

    Private Sub lBudget_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lBudget.SelectedIndexChanged, lBudget.SelectedValueChanged
        Call ListeCoproCharge()
    End Sub


    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles bDelBudget.Click
        Dim sSql As String

        If MessageBox.Show("Supprimer le Budget ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            sSql = "delete from budgetligne where budid=" & Me.lBudget.SelectedItem.value
            sqlDo(sSql, conSql)
            sSql = "delete from budget where budid=" & Me.lBudget.SelectedItem.value
            sqlDo(sSql, conSql)
            sSql = "delete from coprocharge where budid=" & Me.lBudget.SelectedItem.value
            sqlDo(sSql, conSql)
            Call BudgetListe()
            Me.gChargeCopro.Rows.Clear()
        End If
    End Sub

    Public Sub EnregistreCleLot()
        Dim sSql As String = ""
        Dim TPLNew As String = ""
        Dim modif As Boolean = False

        For i = 0 To Me.gCle.RowCount - 1
            Call StatutBar("Ligne " & i)

            'Met la clé à repart = Temp par defaut
            If Me.gCle.Rows(i).Cells(8).Value = False Then Me.gCle.Rows(i).Cells(7).Value = True

            'met la quotepart à 0 si non visible
            If Me.gCle.Rows(i).Visible = False Then Me.gCle.Rows(i).Cells("QuotePArtNew").Value = 0

            TPLNew = IIf(Me.gCle.Rows(i).Cells(7).Value, "T", "") & IIf(Me.gCle.Rows(i).Cells(8).Value, "L", "")

            If Me.gCle.Rows(i).Cells("TPLActu").Value = "" And Me.gCle.Rows(i).Cells("quotepartactu").Value = "" Then
                If Val(Me.gCle.Rows(i).Cells("quotepartnew").Value) <> 0 Then
                    sSql = " insert into clerepartlot (cleid,lotid,quotepart,pro,loc,tmp) values (" & Me.lCle.SelectedItem.value & "," & Me.gCle.Rows(i).Cells("lotid").Value _
                    & "," & num2sql(Me.gCle.Rows(i).Cells("quotepartnew").Value) & ",'" & (TPLNew = "P") & "','" & (TPLNew = "L") & "','" & (TPLNew = "T") & "'" _
                    & ")"
                    sqlDo(sSql, conSql)
                    modif = True
                End If
            Else
                If (txt2num(Me.gCle.Rows(i).Cells("quotepartactu").Value) <> txt2num(Me.gCle.Rows(i).Cells("quotepartnew").Value)) _
                    Or (Me.gCle.Rows(i).Cells("TPLActu").Value <> TPLNew) Then
                    sSql = " update clerepartlot set quotepart=" & num2sql(Me.gCle.Rows(i).Cells("quotepartnew").Value) & ",pro='" & (TPLNew = "P") & "',loc='" & (TPLNew = "L") & "',tmp='" & (TPLNew = "T") & "' where cleid=" & Me.lCle.SelectedItem.value & " and lotid= " & Me.gCle.Rows(i).Cells("lotid").Value
                    sqlDo(sSql, conSql)
                    modif = True
                End If
            End If
        Next

        If modif Then
            'enregistre le total dans la clé
            sSql = "update clerepart set TotalQuotePart = total from" _
            & " (select sum (quotepart) as total from clerepartlot where cleid= " & Me.lCle.SelectedItem.value & ") as t " _
            & " where cleid=" & Me.lCle.SelectedItem.value
            sqlDo(sSql, conSql)
            Call lCle_SelectedIndexChanged(Nothing, Nothing)
        End If

        MessageBox.Show("Enregistrement effectué", "Attention", MessageBoxButtons.OK)
    End Sub

    Public Sub EnregistreCleLoc()
        Dim sSql As String = ""
        Dim TPLNew As String = ""
        Dim modif As Boolean = False

        For i = 0 To Me.gCleLoc.RowCount - 1
            Call StatutBar("Ligne " & i)

            'met la quotepart à 0 si non visible
            If Me.gCleLoc.Rows(i).Visible = False Then Me.gCleLoc.Rows(i).Cells("QuotePArtLoc").Value = 0

            If Me.gCleLoc.Rows(i).Cells("quotepartactuLoc").Value = "" Then
                If Val(Me.gCleLoc.Rows(i).Cells("quotepartLoc").Value) <> 0 Then
                    sSql = " insert into clerepartlot (cleid,lotid,bailid,quotepart) values (" & Me.lCle.SelectedItem.value & "," & Me.gCleLoc.Rows(i).Cells("lotidLoc").Value _
                     & "," & Me.gCleLoc.Rows(i).Cells("bailid").Value & "," & num2sql(Me.gCleLoc.Rows(i).Cells("quotepartLoc").Value) & ")"
                    sqlDo(sSql, conSql)
                    modif = True
                End If
            Else
                If (txt2num(Me.gCleLoc.Rows(i).Cells("quotepartLoc").Value) <> txt2num(Me.gCleLoc.Rows(i).Cells("quotepartActuLoc").Value)) Then
                    sSql = " update clerepartlot set quotepart=" & num2sql(Me.gCleLoc.Rows(i).Cells("quotepartloc").Value) & "  where cleid=" & Me.lCle.SelectedItem.value _
                     & " and bailid= " & Me.gCleLoc.Rows(i).Cells("bailid").Value
                    sqlDo(sSql, conSql)
                    modif = True
                End If
            End If
        Next

        If modif Then
            'enregistre le total dans la clé
            sSql = "update clerepart set TotalQuotePart = total from" _
            & " (select sum (quotepart) as total from clerepartlot where cleid= " & Me.lCle.SelectedItem.value & ") as t " _
            & " where cleid=" & Me.lCle.SelectedItem.value
            sqlDo(sSql, conSql)
            Call lCle_SelectedIndexChanged(Nothing, Nothing)
        End If


        MessageBox.Show("Enregistrement effectué", "Attention", MessageBoxButtons.OK)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.lCle.SelectedIndex < 0 Then Exit Sub
        If lacoproId = 0 Then Exit Sub


        If Me.gCle.Visible Then Call EnregistreCleLot()
        If Me.gCleLoc.Visible Then Call EnregistreCleLoc()

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If Me.lCopro.SelectedIndex < 0 Then Exit Sub
        Select Case oOnglet.SelectedTab.Text
            Case "Ecritures" : Call XLexport(Me.gChargeCopro, "Ecritures Copro : " & Me.lCopro.Text)
            Case "Lots" : Call XLexport(Me.gLots, "Lots Copro : " & Me.lCopro.Text)
            Case "Clé Répartition"
                If Me.gCle.Visible Then Call XLexport(Me.gCle, "Clé répartition Copro : " & Me.lCopro.Text & " - " & Me.lCle.Text)
                If Me.gCleLoc.Visible Then Call XLexport(Me.gCleLoc, "Clé répartition Locataire : " & Me.lCopro.Text & " - " & Me.lCle.Text)

            Case "Budget / Charges" : Call XLexport(Me.gChargeCopro, "Budget copro : " & Me.lCopro.Text & " - " & Me.lBudget.Text)
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

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        F_Lot.tCoproId.Text = Me.lacoproId
        F_Lot.tSocId.Text = Me.tSocId.Text
        F_Lot.leLotId = 0
        If F_Lot.ShowDialog = Windows.Forms.DialogResult.OK Then Call listeLots()
        F_Lot.Dispose()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If Me.gLots.SelectedRows.Count < 1 Then Exit Sub
        If MessageBox.Show("Supprimer le lot " & Me.gLots.SelectedRows(0).Cells("glotNOm").Value, "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            sqlDo("delete from lot where lotid=" & Me.gLots.SelectedRows(0).Cells("glotID").Value, conSql)
            sqlDo("delete from location where lotid=" & Me.gLots.SelectedRows(0).Cells("glotID").Value, conSql)
            sqlDo("delete from Clerepartlot where lotid=" & Me.gLots.SelectedRows(0).Cells("glotID").Value, conSql)
            Call listeLots()
        End If
    End Sub


    'Private Sub SuiviBudget(sender As System.Object, e As System.EventArgs) Handles bSUiviBudget.Click

    '    If Me.lBudget.SelectedIndex < 0 Then Exit Sub

    '    Dim appXL As New Microsoft.Office.Interop.Excel.Application
    '    Dim sSql As String
    '    Dim lers As OleDb.OleDbDataReader
    '    Dim laligne As Integer
    '    Dim leBudIdOld As Integer
    '    Dim lacat As String = ""
    '    Dim anneePrec As String = ""
    '    Dim Stot1, Stot2, Stot3, Stot4 As Decimal
    '    Dim Tot1, Tot2, Tot3, Tot4 As Decimal

    '    Try
    '        StatutBar("MAZ table temporaire")
    '        'vide la table tempo
    '        sSql = "Delete from TempSuiviBudget"
    '        sqlDo(sSql, conSql)

    '        StatutBar("Recherche du budget précédent")
    '        'reccherche l'id du budget précédent
    '        sSql = "select top 1 budget.budid,budget.budAnnee from budget " _
    '        & " inner join budget as B2 on budget.coproid = b2.coproid and b2.budid=" & Me.lBudget.SelectedItem.value & "  and budget.budannee < b2.budannee" _
    '        & " order by budget.budannee desc"
    '        lers = sqlLit(sSql, conSql)
    '        While lers.Read
    '            leBudIdOld = lers(0)
    '            anneePrec = lers(1)
    '        End While
    '        lers.Close()

    '        StatutBar("Calcul budget N")
    '        sSql = "INSERT INTO TempSuiviBudget ( tChCatId,CHLib,montantHTPrev, MontantHTReel ) " _
    '            & " SELECT tChCatId,chlib,sum(chmontantbudgetHT) as MontantHTPrev, sum(chmontantHT) as MontantHT from coprocharge" _
    '            & " WHERE budid=" & Me.lBudget.SelectedItem.value _
    '            & " group by tchcatid,chlib "
    '        sqlDo(sSql, conSql)

    '        StatutBar("Calcul Budget N-1")
    '        sSql = "INSERT INTO TempSuiviBudget ( tChCatId,CHLib,[montantHTPrev-1], [montantHTReel-1] ) " _
    '            & " SELECT tChCatId,chlib,sum(chmontantbudgetHT) as MontantHTPrev, sum(chmontantHT) as MontantHT from coprocharge" _
    '            & " WHERE budid=" & leBudIdOld _
    '            & " group by tchcatid,chlib "
    '        sqlDo(sSql, conSql)


    '        appXL.Workbooks.Add()
    '        appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
    '        appXL.Visible = True

    '        'Recherche les données
    '        StatutBar("Export Excel")
    '        sSql = "SELECT ChLib, SUM([MontantHTPrev-1]) AS [MontantHTPrev-1], SUM([MontantHTReel-1]) AS [MontantHTReel-1], " _
    '            & " SUM(MontantHTPrev) AS MontantHTPrev, SUM(MontantHTReel) AS MontantHTReel " _
    '            & " , TypeChargeCat.tChCatLib, TypeChargeCat.tChCatOrdre" _
    '            & " FROM TempSuiviBudget INNER JOIN TypeChargeCat ON TempSuiviBudget.tChCatId = TypeChargeCat.tChCatId" _
    '            & " GROUP BY ChLib, tChCatLib, tChCatOrdre" _
    '            & " order by tChCatordre,ChLib"
    '        lers = sqlLit(sSql, conSql)

    '        laligne = 3
    '        appXL.Cells(laligne, 1).value = "'Nature des charges"
    '        appXL.Cells(laligne, 2).value = "'Montant Prev HT " & anneePrec
    '        appXL.Cells(laligne, 3).value = "'Montant Réel HT " & anneePrec
    '        appXL.Cells(laligne, 4).value = "'Montant Prev HT " & Me.lBudget.Text
    '        appXL.Cells(laligne, 5).value = "'Montant Réel HT " & Me.lBudget.Text
    '        appXL.Range("A" & laligne & ":E" & laligne).Interior.Color = RGB(155, 194, 230)

    '        laligne += 1
    '        Tot1 = 0
    '        Tot2 = 0
    '        Tot3 = 0
    '        Tot4 = 0
    '        Stot1 = 0
    '        Stot2 = 0
    '        Stot3 = 0
    '        Stot4 = 0

    '        While lers.Read
    '            If lers("tChCatLib") <> lacat Then
    '                ' sous total catégorie
    '                If lacat <> "" Then
    '                    appXL.Cells(laligne, 1).value = "'Total " & lacat
    '                    appXL.Cells(laligne, 2).value = Stot1
    '                    appXL.Cells(laligne, 3).value = Stot2
    '                    appXL.Cells(laligne, 4).value = Stot3
    '                    appXL.Cells(laligne, 5).value = Stot4
    '                    appXL.Range("A" & laligne & ":E" & laligne).Interior.Color = RGB(210, 210, 210)

    '                    Stot1 = 0
    '                    Stot2 = 0
    '                    Stot3 = 0
    '                    Stot4 = 0
    '                    laligne += 1
    '                End If
    '                laligne += 1
    '                appXL.Cells(laligne, 1).value = "'" & lers("tchCatlib").ToString
    '                appXL.Cells(laligne, 1).Font.Bold = True
    '                lacat = lers("tChCatLib")
    '                laligne += 1
    '            End If
    '            appXL.Cells(laligne, 1).value = "'" & lers("chlib").ToString
    '            appXL.Cells(laligne, 2).value = lers("MontantHTPrev-1")
    '            appXL.Cells(laligne, 3).value = lers("MontantHTReel-1")
    '            appXL.Cells(laligne, 4).value = lers("MontantHTPrev")
    '            appXL.Cells(laligne, 5).value = lers("MontantHTReel")
    '            Stot1 += nz(lers("MontantHTPrev-1"), 0)
    '            Stot2 += nz(lers("MontantHTReel-1"), 0)
    '            Stot3 += nz(lers("MontantHTPrev"), 0)
    '            Stot4 += nz(lers("MontantHTReel"), 0)
    '            Tot1 += nz(lers("MontantHTPrev-1"), 0)
    '            Tot2 += nz(lers("MontantHTReel-1"), 0)
    '            Tot3 += nz(lers("MontantHTPrev"), 0)
    '            Tot4 += nz(lers("MontantHTReel"), 0)
    '            laligne += 1
    '        End While
    '        lers.Close()
    '        If lacat <> "" Then
    '            appXL.Cells(laligne, 1).value = "'Total " & lacat
    '            appXL.Cells(laligne, 2).value = Stot1
    '            appXL.Cells(laligne, 3).value = Stot2
    '            appXL.Cells(laligne, 4).value = Stot3
    '            appXL.Cells(laligne, 5).value = Stot4
    '            appXL.Range("A" & laligne & ":E" & laligne).Interior.Color = RGB(210, 210, 210)
    '            laligne += 1
    '        End If
    '        laligne += 1
    '        appXL.Cells(laligne, 1).value = "'Total"
    '        appXL.Cells(laligne, 1).Font.Bold = True
    '        appXL.Cells(laligne, 2).value = Tot1
    '        appXL.Cells(laligne, 3).value = Tot2
    '        appXL.Cells(laligne, 4).value = Tot3
    '        appXL.Cells(laligne, 5).value = Tot4
    '        appXL.Range("A" & laligne & ":E" & laligne).Interior.Color = RGB(155, 194, 230)

    '        appXL.Cells.Select()
    '        appXL.Cells.EntireColumn.AutoFit()
    ''Facture Excel
    '        appXL.Range("A1").Value = "'Suivi budget " & Me.lCopro.Text & " - " & Me.lBudget.Text
    '        appXL.Range("A1").Select()
    '        appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

    '        appXL.Visible = True
    '        appXL.UserControl = True

    '        StatutBar("")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try


    'End Sub

    Private Sub SuiviBudget2(sender As System.Object, e As System.EventArgs) Handles bSUiviBudget.Click

        If Me.lBudget.SelectedIndex < 0 Then Exit Sub

        Dim appXL As New Microsoft.Office.Interop.Excel.Application
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim laligne As Integer
        Dim lacat As String = ""
        Dim anneePrec As String = ""
        Dim BudgetAn As Integer
        Dim Stot1, Stot2, Stot3, Stot4, stotN1, stotN2, stotN3 As Decimal
        Dim Tot1, Tot2, Tot3, Tot4, totN1, totN2, totN3 As Decimal

        Try
            StatutBar("MAZ table temporaire")
            'vide la table tempo
            sSql = "Delete from TempSuiviBudget"
            sqlDo(sSql, conSql)

            BudgetAn = Val(Me.lBudget.SelectedItem.text)


            'StatutBar("Recherche du budget précédent")
            ''reccherche l'id du budget précédent
            'sSql = "select top 1 budget.budid,budget.budAnnee from budget " _
            '& " inner join budget as B2 on budget.coproid = b2.coproid and b2.budid=" & Me.lBudget.SelectedItem.value & "  and budget.budannee < b2.budannee" _
            '& " order by budget.budannee desc"
            'lers = sqlLit(sSql, conSql)
            'While lers.Read
            '    leBudIdOld = lers(0)
            '    anneePrec = lers(1)
            'End While
            'lers.Close()

            StatutBar("Calcul budget N")
            sSql = "INSERT INTO TempSuiviBudget ( tChCatId,CHLib,montantHTPrev, MontantHTReel ) " _
                & " SELECT tChCatId,chlib,sum(chmontantbudgetHT) as MontantHTPrev, sum(chmontantHT) as MontantHT from coprocharge" _
                & " inner join budget on CoproCharge.BudId = budget.budId" _
                & " where CoproCharge.coproId =" & Me.lacoproId & " And budAnnee =" & BudgetAn _
                & " group by tchcatid,chlib "
            sqlDo(sSql, conSql)

            StatutBar("Calcul Budget N-1")
            sSql = "INSERT INTO TempSuiviBudget ( tChCatId,CHLib,[montantHTPrev-1], [montantHTReel-1] ) " _
                 & " SELECT tChCatId,chlib,sum(chmontantbudgetHT) as MontantHTPrev, sum(chmontantHT) as MontantHT from coprocharge" _
                & " inner join budget on CoproCharge.BudId = budget.budId" _
                & " where CoproCharge.coproId =" & Me.lacoproId & " And budAnnee =" & BudgetAn - 1 _
                & " group by tchcatid,chlib "
            sqlDo(sSql, conSql)

            StatutBar("Calcul Budget N+1")
            sSql = "INSERT INTO TempSuiviBudget ( tChCatId,CHLib,[montantHTPrev+1] ) " _
                & " select tChCatId,chlib,ChMontantBudgetHT from CoproCharge" _
                & " inner join budget on CoproCharge.BudId = budget.budId" _
                & " where CoproCharge.coproId =" & Me.lacoproId & " And budAnnee =" & BudgetAn + 1
            sqlDo(sSql, conSql)

            StatutBar("Calcul Budget N+2")
            sSql = "INSERT INTO TempSuiviBudget ( tChCatId,CHLib,[montantHTPrev+2] ) " _
                & " select tChCatId,chlib,ChMontantBudgetHT from CoproCharge" _
                & " inner join budget on CoproCharge.BudId = budget.budId" _
                & " where CoproCharge.coproId =" & Me.lacoproId & " And budAnnee =" & BudgetAn + 2
            sqlDo(sSql, conSql)

            StatutBar("Calcul Budget N+3")
            sSql = "INSERT INTO TempSuiviBudget ( tChCatId,CHLib,[montantHTPrev+3] ) " _
                & " select tChCatId,chlib,ChMontantBudgetHT from CoproCharge" _
                & " inner join budget on CoproCharge.BudId = budget.budId" _
                & " where CoproCharge.coproId =" & Me.lacoproId & " And budAnnee =" & BudgetAn + 3
            sqlDo(sSql, conSql)


            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            'Recherche les données
            StatutBar("Export Excel")
            sSql = "SELECT ChLib, SUM([MontantHTPrev-1]) AS [MontantHTPrev-1], SUM([MontantHTReel-1]) AS [MontantHTReel-1], " _
                & " SUM(MontantHTPrev) AS MontantHTPrev, SUM(MontantHTReel) AS MontantHTReel " _
                & " , sum([MontantHTprev+1]) as BudgetN1,sum([MontantHTprev+2]) as BudgetN2, sum([MontantHTprev+3]) as BudgetN3 " _
                & " , TypeChargeCat.tChCatLib, TypeChargeCat.tChCatOrdre" _
                & " FROM TempSuiviBudget INNER JOIN TypeChargeCat ON TempSuiviBudget.tChCatId = TypeChargeCat.tChCatId" _
                & " GROUP BY ChLib, tChCatLib, tChCatOrdre" _
                & " order by tChCatordre,ChLib"
            lers = sqlLit(sSql, conSql)

            laligne = 3
            appXL.Cells(laligne, 1).value = "'Nature des charges"
            appXL.Cells(laligne, 2).value = "'Budget HT " & BudgetAn - 1
            appXL.Cells(laligne, 3).value = "'Montant Réel HT " & BudgetAn - 1
            appXL.Cells(laligne, 4).value = "'Budget HT " & BudgetAn
            appXL.Cells(laligne, 5).value = "'Montant Réel HT " & BudgetAn
            appXL.Cells(laligne, 6).value = "'Budget HT " & BudgetAn + 1
            appXL.Cells(laligne, 7).value = "'Budget HT " & BudgetAn + 2
            appXL.Cells(laligne, 8).value = "'Budget HT " & BudgetAn + 3


            appXL.Range("A" & laligne & ":H" & laligne).Interior.Color = RGB(155, 194, 230)

            laligne += 1
            Tot1 = 0
            Tot2 = 0
            Tot3 = 0
            Tot4 = 0
            totN1 = 0
            totN2 = 0
            totN3 = 0
            Stot1 = 0
            Stot2 = 0
            Stot3 = 0
            Stot4 = 0
            stotN1 = 0
            stotN2 = 0
            stotN3 = 0

            While lers.Read
                If lers("tChCatLib") <> lacat Then
                    ' sous total catégorie
                    If lacat <> "" Then
                        appXL.Cells(laligne, 1).value = "'Total " & lacat
                        appXL.Cells(laligne, 2).value = Stot1
                        appXL.Cells(laligne, 3).value = Stot2
                        appXL.Cells(laligne, 4).value = Stot3
                        appXL.Cells(laligne, 5).value = Stot4
                        appXL.Cells(laligne, 6).value = stotN1
                        appXL.Cells(laligne, 7).value = stotN2
                        appXL.Cells(laligne, 8).value = stotN3

                        appXL.Range("A" & laligne & ":H" & laligne).Interior.Color = RGB(210, 210, 210)

                        Stot1 = 0
                        Stot2 = 0
                        Stot3 = 0
                        Stot4 = 0
                        stotN1 = 0
                        stotN2 = 0
                        stotN3 = 0

                        laligne += 1
                    End If
                    laligne += 1
                    appXL.Cells(laligne, 1).value = "'" & lers("tchCatlib").ToString
                    appXL.Cells(laligne, 1).Font.Bold = True
                    lacat = lers("tChCatLib")
                    laligne += 1
                End If
                appXL.Cells(laligne, 1).value = "'" & lers("chlib").ToString
                appXL.Cells(laligne, 2).value = lers("MontantHTPrev-1")
                appXL.Cells(laligne, 3).value = lers("MontantHTReel-1")
                appXL.Cells(laligne, 4).value = lers("MontantHTPrev")
                appXL.Cells(laligne, 5).value = lers("MontantHTReel")
                appXL.Cells(laligne, 6).value = lers("BudgetN1")
                appXL.Cells(laligne, 7).value = lers("BudgetN2")
                appXL.Cells(laligne, 8).value = lers("BudgetN3")


                Stot1 += nz(lers("MontantHTPrev-1"), 0)
                Stot2 += nz(lers("MontantHTReel-1"), 0)
                Stot3 += nz(lers("MontantHTPrev"), 0)
                Stot4 += nz(lers("MontantHTReel"), 0)
                stotN1 += nz(lers("BudgetN1"), 0)
                stotN2 += nz(lers("BudgetN2"), 0)
                stotN3 += nz(lers("BudgetN3"), 0)
                Tot1 += nz(lers("MontantHTPrev-1"), 0)
                Tot2 += nz(lers("MontantHTReel-1"), 0)
                Tot3 += nz(lers("MontantHTPrev"), 0)
                Tot4 += nz(lers("MontantHTReel"), 0)
                totN1 += nz(lers("BudgetN1"), 0)
                totN2 += nz(lers("BudgetN2"), 0)
                totN3 += nz(lers("BudgetN3"), 0)

                laligne += 1
            End While
            lers.Close()
            If lacat <> "" Then
                appXL.Cells(laligne, 1).value = "'Total " & lacat
                appXL.Cells(laligne, 2).value = Stot1
                appXL.Cells(laligne, 3).value = Stot2
                appXL.Cells(laligne, 4).value = Stot3
                appXL.Cells(laligne, 5).value = Stot4
                appXL.Cells(laligne, 6).value = stotN1
                appXL.Cells(laligne, 7).value = stotN2
                appXL.Cells(laligne, 8).value = stotN3

                appXL.Range("A" & laligne & ":H" & laligne).Interior.Color = RGB(210, 210, 210)
                laligne += 1
            End If
            laligne += 1
            appXL.Cells(laligne, 1).value = "'Total"
            appXL.Cells(laligne, 1).Font.Bold = True
            appXL.Cells(laligne, 2).value = Tot1
            appXL.Cells(laligne, 3).value = Tot2
            appXL.Cells(laligne, 4).value = Tot3
            appXL.Cells(laligne, 5).value = Tot4
            appXL.Cells(laligne, 6).value = totN1
            appXL.Cells(laligne, 7).value = totN2
            appXL.Cells(laligne, 8).value = totN3
            appXL.Range("A" & laligne & ":H" & laligne).Interior.Color = RGB(155, 194, 230)

            appXL.Cells.Select()
            appXL.Cells.EntireColumn.AutoFit()
            'Facture Excel
            appXL.Range("A1").Value = "'Suivi budget " & Me.lCopro.Text & " - " & Me.lBudget.Text
            appXL.Range("A1").Select()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            appXL.Visible = True
            appXL.UserControl = True

            StatutBar("")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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

    Private Sub repartChargeV0(txHono As Decimal, RepartLoc As Boolean)

        If Me.lBudget.SelectedIndex < 0 Then Exit Sub
        Try

            Dim sSql As String
            Dim lers As OleDb.OleDbDataReader
            Dim lan As String = Me.lBudget.Text
            Dim d1 As Date = CDate("01/01/" & lan)
            Dim d2 As Date = CDate("31/12/" & lan)

            StatutBar("MAZ table temporaire")
            sqlDo("truncate table tempRepartLoc", conSql)

            StatutBar("Recherche lots/locataires")
            sSql = "insert into tempRepartLoc SELECT lot.coproid, Lot.LotId , Lot.Batiment, TypeLocal.TlocalNom, Lot.LotNom, 1,locataire.locid,Annuaire.Nom, location.dateDebut, location.datefin,0,0" _
            & " FROM  Lot " _
            & " LEFT OUTER JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
            & " left outer join location on location.lotid = lot.lotid" _
            & " left outer join locataire on location.locid = locataire.locid" _
            & " left outer join annuaire on annuaire.persid = locataire.persid" _
            & " WHERE Lot.CoproId =" & Me.lacoproId
            sqlDo(sSql, conSql)

            'efface les loc non concernés
            sSql = "delete from tempRepartLoc where dateentree >" & Date2sql(d2) & " or datesortie<" & Date2sql(d1)
            sqlDo(sSql, conSql)

            'MAJ date entree
            StatutBar("Calcul des dates")
            sSql = "update tempRepartLoc set dateentree =" & Date2sql(d1) & " where dateentree<" & Date2sql(d1)
            sqlDo(sSql, conSql)
            'MAJ date entree
            sSql = "update tempRepartLoc set datesortie = " & Date2sql(d2) & " where datesortie is null or datesortie>" & Date2sql(d2)
            sqlDo(sSql, conSql)
            'calcul nbjour
            StatutBar("Calcul des périodes")
            sSql = "update tempRepartLoc set nbjour = datediff(dd,dateentree,datesortie)+1, nbjourLotocc=" & DateDiff(DateInterval.Day, d1, d2) + 1
            sqlDo(sSql, conSql)

            StatutBar("Calcul des périodes d'occupation")
            sSql = " Update temprepartloc set nbjourlotocc =  ( select sum(nbjour) as tot from temprepartloc as T2" _
                & " where temprepartloc.lotid = T2.lotid group by lotid ) "
            sqlDo(sSql, conSql)
            sSql = "update tempRepartLoc set nbjourlotocc = 0 where nbjourlotocc is null"
            sqlDo(sSql, conSql)

            StatutBar("recherche des répartitions")
            sqlDo("truncate table tempRepartCharge", conSql)
            sSql = "insert into temprepartCharge  SELECT  temprepartloc.LotId , Batiment, TypeLocal, LotNom,locordre,LocId, LocNom, DateEntree, DateSortie" _
            & " ,chid,chlib,chmontantHT,  QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart,nbjour," & DateDiff(DateInterval.Day, d1, d2) + 1 & ",nbjourlotocc,0 ,0,0,tChCatLib,tchcatordre" _
            & " FROM temprepartloc " _
            & " left outer join coprocharge on coprocharge.coproid = temprepartloc.coproid and coprocharge.budid=" & Me.lBudget.SelectedItem.value _
            & " left outer join clerepart on coprocharge.cleid = clerepart.cleid" _
            & " left outer join clerepartlot on clerepartlot.cleid = clerepart.cleid and clerepartlot.lotid = temprepartloc.lotid" _
            & " left outer join typechargeCat on typechargecat.tchcatid = coprocharge.tchCatID"
            lers = sqlLit(sSql, conSql)

            'MAJ valeurs null
            StatutBar("MAJ  quote-part")
            sSql = "update TempRepartCharge set QuotePart = 0 ,pro=0,loc=0,tmp=0 where quotepart is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set pro=0, loc=0, tmp=0 where pro is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set TotalQuotePart=0 where TotalQuotePart is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set nbjour=0 where nbjour is null"
            sqlDo(sSql, conSql)


            'calcul des montants
            StatutBar("Calcul des montants prorata")
            sSql = "update temprepartcharge set chmontanthtloc =round( chmontantHT *nbjour / NbJourAn * (QuotePart/TotalQuotePart),2) where tmp = 1"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des montants Locataire")
            sSql = "update temprepartcharge set chmontanthtloc =round( chmontantHT *nbjour / nbjourLotOcc * (QuotePart/TotalQuotePart),2) where Loc = 1 And locid <> 0"
            sqlDo(sSql, conSql)

            ' sSql = " update temprepartcharge set chmontanthtloc =round( chmontantHT * (QuotePart/TotalQuotePart),2) where pro = 1 And locid = 0"
            'sqlDo(sSql, conSql)
            StatutBar("Calcul des montants Propriétaire")
            sSql = "insert into temprepartcharge select 0,'','','',3,0,'Propriétaire',null,null,chid,chlib,chmontantht,0,0,0,0,'',0,0,0,0, chmontantHT - sum(chmontanthtloc),0,0,tChCatLib,tchcatordre" _
            & "  from TempRepartCharge group by chid,chlib,chmontantht,tChCatLib,tchcatordre"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des loyers")
            sSql = "update TempRepartCharge set loyerht= ( select sum(ecrmontantHT) from comptagene" _
            & " where rubrique='SOCIETE' and categorie='LOYER' and year(ecrEcheance)= " & Me.lBudget.Text _
            & " and comptagene.locid=temprepartcharge.locid group by locid )"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des charges")
            sSql = "update TempRepartCharge set chargeht= ( select sum(ecrmontantHT) from comptagene" _
            & " where rubrique='SOCIETE' and categorie='PROVCHARGE' and year(ecrEcheance)= " & Me.lBudget.Text _
            & " and comptagene.locid=temprepartcharge.locid group by locid )"
            sqlDo(sSql, conSql)

            sSql = "update temprepartcharge set loyerht=0 where loyerht is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set chargeht=0 where chargeht is null"
            sqlDo(sSql, conSql)

            '  sSql = "delete from temprepartcharge where lotid in ( select lotid from temprepartcharge" _
            '    & " group by lotid having sum(chmontantHTloc)=0)"
            'sqlDo(sSql, conSql)

            StatutBar("Lancement Excel")

            Dim appXL As New Microsoft.Office.Interop.Excel.Application
            Dim laligne As Integer = 10
            Dim laCol As Integer = 2
            Dim laCat As String = ""
            Dim laLigneCat As Integer = 0
            Dim lelotActu As Integer = 0
            Dim lelocActu As Integer = 0
            Dim sousTotCat As Decimal = 0
            Dim totalCat As Decimal = 0
            Dim sousTotCharge As Decimal = 0
            Dim totalCharge As Decimal = 0
            Dim ligneCharge As New List(Of Integer)

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            StatutBar("Export Excel")

            'Onglet 2 : répartition par lot

            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges " & Me.lBudget.Text
            appXL.ActiveSheet.name = "Répartition Lot"
            appXL.Cells(6, 2).value = "Montant"
            appXL.Cells(3, 1).value = "Lot"
            appXL.Cells(4, 1).value = "Locataire"
            appXL.Columns(1).ColumnWidth = 40

            sSql = "SELECT locid,lotid,Batiment, TlocalNom, LotNom, LocNom, chlib, chmontantHT, chMontantHtLoc, tChCatOrdre, tChCatLib" _
            & " FROM TempRepartCharge" _
            & " ORDER BY locordre,Batiment,LotNom,DateEntree,locnom ,tChCatOrdre, tChCatLib,TempRepartCharge.chlib"

            lers = sqlLit(sSql, conSql)
            laCat = ""
            laLigneCat = 0
            While lers.Read
                'au changement de locataire
                If lelocActu <> nz(lers("locid"), 0) Or lelotActu <> nz(lers("lotid"), 0) Then
                    Call StatutBar("Lot : " & nz(lers("LotNom"), ""))
                    appXL.StatusBar = "Lot : " & nz(lers("LotNom"), "")
                    If lelotActu <> 0 Then
                        'sous-total du lot précédent
                        laligne += 1
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, 2).value = sousTotCharge

                        End If
                        appXL.Cells(laligne, laCol).value = sousTotCat

                        'total du lot précédent
                        laligne += 2
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total"
                            appXL.Cells(laligne, 2).value = totalCharge
                        End If
                        appXL.Cells(laligne, laCol).value = totalCat
                    End If

                    lelotActu = nz(lers("lotId"), 0)
                    lelocActu = nz(lers("locid"), 0)
                    laCol += 1
                    laCat = ""
                    appXL.Cells(3, laCol).value = nz(lers("LotNom"), "")
                    appXL.Cells(4, laCol).value = nz(lers("LocNom"), "")

                    laligne = 4
                    laLigneCat = 4
                    sousTotCat = 0
                    totalCat = 0
                End If

                'AU changement de catégorie
                If laCat <> lers("tChCatLib") Then
                    If laCat <> "" Then
                        laligne += 1
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, 2).value = sousTotCharge

                        End If
                        appXL.Cells(laligne, laCol).value = sousTotCat
                        sousTotCat = 0
                        sousTotCharge = 0
                    End If

                    laligne += 2
                    appXL.Cells(laligne, 1).value = lers("tChCatLib")
                    appXL.Cells(laligne, 1).Font.Bold = True
                    laCat = lers("tChCatLib")
                    If laCol = 3 Then ligneCharge.Add(laligne + 1)
                End If

                laligne += 1

                'ecrit la 1er colonne : total des charges
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = lers("chlib")
                    appXL.Cells(laligne, 2).value = nz(lers("chmontantHT"), 0)
                    totalCharge += nz(lers("chmontantHT"), 0)
                    sousTotCharge += nz(lers("chmontantHT"), 0)
                End If

                appXL.Cells(laligne, laCol).value = nz(lers("chMontantHtLoc"), 0)
                sousTotCat += nz(lers("chMontantHtLoc"), 0)
                totalCat += nz(lers("chMontantHtLoc"), 0)

            End While
            appXL.StatusBar = ""

            'sous-total et total du dernier lot, derniere cat
            If laCat <> "" Then
                laligne += 1
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = "Total " & laCat
                    appXL.Cells(laligne, 2).value = totalCharge
                    ligneCharge.Add(laligne + 2)
                End If
                appXL.Cells(laligne, laCol).value = sousTotCat
                appXL.Cells(laligne + 2, laCol).value = totalCat
                ligneCharge.Add(laligne + 3)
            End If

            lers.Close()

            'quadrillage lot
            With appXL.Range(appXL.Cells(3, 3), appXL.Cells(4, laCol))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With
            'quadrillage charges
            For i = 0 To ligneCharge.Count - 2
                With appXL.Range(appXL.Cells(ligneCharge(i), 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With
                appXL.Range(appXL.Cells(ligneCharge(i + 1) - 3, 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol)).Interior.Color = RGB(155, 194, 230)
            Next
            'quadrillage total
            With appXL.Range(appXL.Cells(laligne + 2, 1), appXL.Cells(laligne + 2, laCol))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With
            appXL.Range(appXL.Cells(laligne + 2, 1), appXL.Cells(laligne + 2, laCol)).Interior.Color = RGB(155, 194, 230)

            appXL.ActiveWindow.DisplayGridlines = False


            'Onglet 1 : répartition par LOC

            Dim sousTotLoc As Decimal = 0
            Dim totalLoc As Decimal = 0
            Dim totHono As Decimal = 0
            Dim ChargeApp As Decimal = 0

            Call StatutBar("Calcul des honoraires")
            'Ajoute les honoraires
            sSql = "insert into temprepartcharge" _
                & " select   LotId, Batiment, TlocalNom, LotNom, LocOrdre, LocId, LocNom, DateEntree, DateSortie, chId, chlib, chmontantHT, QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart " _
                & " ,NbJour, NbJourAn, NbJourLotOcc, chMontantHtLoc, LoyerHT, ChargeHT,'Honoraires' ,9999 from " _
                & " (select  LotId, Batiment, TlocalNom, LotNom, LocOrdre, LocId, LocNom, DateEntree, DateSortie, 3 as chid, 'Honoraires ' as chlib" _
                & " ,0 as chmontantHT, 1 as  QuotePart,0 as Pro, 1 as Loc, 0 as Tmp, 'Honoraires' as CleNom, 1 as TotalQuotePart " _
                & " ,NbJour, NbJourAn, NbJourLotOcc,round( LoyerHT * " & txHono & " /100,2) as chMontantHtloc,LoyerHT, ChargeHT ,row_number() over( partition by locid order by locid,lotid) as Nlo  from temprepartcharge" _
                & " ) as t where t.Nlo=1"
            sqlDo(sSql, conSql)

            sSql = "update TempRepartCharge set chmontantHT = (select sum(chmontantHtLoc) from temprepartcharge where tChCatordre = 9999 )" _
            & " where(tChCatordre = 9999)"
            sqlDo(sSql, conSql)

            Call StatutBar("Export XL")
            appXL.Sheets.Add(, appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Répartition Locataire"
            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges / Locataire " & Me.lBudget.Text
            appXL.Cells(3, 1).value = "Locataire"
            appXL.Cells(4, 1).value = "Appels de Loyer"
            appXL.Cells(6, 2).value = "Montant"
            appXL.Columns(1).ColumnWidth = 40
            appXL.ActiveWindow.DisplayGridlines = False

            lelocActu = 0
            laCol = 2
            laligne = 4
            totalCat = 0

            sSql = "SELECT  locid, locordre, LocNom, chlib, chmontantHT,sum( chMontantHtLoc) as chmontantHtLoc, tChCatOrdre, tChCatLib,loyerHT,chargeHT" _
            & " FROM TempRepartCharge" _
            & " group by locordre, locid,  LocNom, TempRepartCharge.chlib, TempRepartCharge.chmontantHT,  tChCatOrdre, tChCatLib,loyerHT,ChargeHT " _
            & " ORDER BY locnom,locid ,tChCatOrdre, tChCatLib,chlib"

            lers = sqlLit(sSql, conSql)
            laCat = ""
            While lers.Read
                If lelocActu <> nz(lers("locId"), 0) Then
                    Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
                    appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")

                    'ecrit le total et les charge du loc précédent
                    If laCol > 2 Then
                        laligne += 2
                        appXL.Cells(laligne, laCol).value = totalLoc
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total"
                            appXL.Cells(laligne, 2).value = totalCat
                        End If

                        laligne += 2
                        appXL.Cells(laligne, laCol).value = nz(lers("chargeHT"), 0)
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Appels de Charges"
                        End If

                        laligne += 2
                        appXL.Cells(laligne, laCol).value = nz(lers("chargeHT"), 0) - totalLoc
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Solde Charges"
                        End If
                    End If

                    'initialise les variables du loc
                    laligne = 4
                    lelocActu = nz(lers("locId"), 0)
                    laCol += 1
                    appXL.Cells(3, laCol).value = nz(lers("LocNom"), "")
                    appXL.Cells(4, laCol).value = nz(lers("loyerHT"), 0)
                    sousTotCat = 0
                    sousTotLoc = 0
                    totalLoc = 0
                    totalCharge = 0
                    laCat = ""
                End If

                If laCat <> lers("tChCatLib") Then
                    If laCat <> "" Then
                        laligne += 1
                        appXL.Cells(laligne, laCol).value = sousTotLoc
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Sous-Total"
                            appXL.Cells(laligne, 2).value = sousTotCat
                        End If
                    End If

                    laligne += 1
                    If lers("tChCatOrdre") <> 9999 Then
                        laligne += 1
                        appXL.Cells(laligne, 1).value = lers("tChCatLib")
                        appXL.Cells(laligne, 1).Font.Bold = True
                    End If
                    laCat = lers("tChCatLib")
                    sousTotLoc = 0
                    sousTotCat = 0
                End If

                laligne += 1

                'ecrit la 1er colonne
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = lers("chlib")
                    appXL.Cells(laligne, 2).value = nz(lers("chmontantHT"), 0)
                End If

                appXL.Cells(laligne, laCol).value = nz(lers("chMontantHtLoc"), 0)
                sousTotLoc += nz(lers("chMontantHtLoc"), 0)
                totalLoc += nz(lers("chMontantHtLoc"), 0)
                sousTotCat += nz(lers("chMontantHT"), 0)
                totalCat += nz(lers("chMontantHT"), 0)
                ChargeApp = nz(lers("chargeHT"), 0)
            End While
            lers.Close()

            'ecrit le total et les charge du DERNIER loc
            If laCol > 2 Then

                'quadrillage lot
                With appXL.Range(appXL.Cells(3, 3), appXL.Cells(4, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With
                'quadrillage charges
                For i = 0 To ligneCharge.Count - 2
                    With appXL.Range(appXL.Cells(ligneCharge(i), 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol))
                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                    End With
                    appXL.Range(appXL.Cells(ligneCharge(i + 1) - 3, 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol)).Interior.Color = RGB(155, 194, 230)
                Next
                'quadrillage honoraire
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With

                laligne += 2
                appXL.Cells(laligne, laCol).value = totalLoc
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    .Interior.Color = RGB(155, 194, 230)
                End With


                laligne += 2
                appXL.Cells(laligne, laCol).value = ChargeApp
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With

                laligne += 2
                appXL.Cells(laligne, laCol).value = ChargeApp - totalLoc
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    .Interior.Color = RGB(155, 194, 230)
                End With

            End If


            If RepartLoc = True Then
                '-------------------------------------------------
                'Repart 1 onglet par locataire
                '-------------------------------------------------
                Dim locOrdre As Integer = 0
                Dim lelocactuNom As String = ""


                Call StatutBar("Export Locataire")
                sSql = " SELECT    LocNom, chlib, chmontantHT, tChCatOrdre, tChCatLIb, LoyerHT, ChargeHT, LotId, QuotePart, TotalQuotePart" _
                    & ", NbJour, NbJourAn, LotNom, Batiment, TlocalNom, Pro, Loc, Tmp, NbJourLotOcc, chMontantHtLoc" _
                    & " FROM TempRepartCharge WHERE LocId <> 0 and tChCatOrdre <> 9999" _
                    & " ORDER BY LocNom,  lotid, tChCatOrdre, tChCatLIb, chlib"
                lers = sqlLit(sSql, conSql)
                lelocActu = 0
                laCat = ""
                lelotActu = 0

                While lers.Read
                    If lelocactuNom <> nz(lers("locNom"), 0) Or lelotActu <> lers("LotId") Or laCat <> lers("tChCatLib") Then

                        'Mise en forme catégorie précédente
                        If laCat <> "" Then
                            laligne += 1
                            If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, laCol + 2).value = sousTotCat
                            sousTotCat = 0
                        End If

                        If lelocactuNom <> nz(lers("locNom"), 0) Or lelotActu <> lers("LotId") Then
                            'Mise en forme Lot précédent
                            If lelotActu <> 0 Then
                                If laCol = 3 Then ligneCharge.Add(laligne + 2)
                                laligne += 2
                                appXL.Cells(laligne, laCol + 2).value = totalCharge
                                appXL.Cells(laligne, 1).value = "'Total Lot"
                            End If

                            If lelocactuNom <> lers("LocNom") Then
                                'Mise en forme ANciel loc
                                If lelocactuNom <> "" Then

                                    With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 2))
                                        .Interior.Color = RGB(155, 194, 230)
                                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                                    End With

                                    appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 2)).Interior.Color = RGB(155, 194, 230)

                                    For i = 0 To ligneCharge.Count - 2
                                        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2))
                                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2)).Interior.Color = RGB(155, 194, 230)
                                    Next

                                End If
                                'Mise en forme Nouveau Loc
                                locOrdre += 1
                                Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
                                appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")
                                appXL.Sheets.Add(, appXL.ActiveSheet)
                                Dim n As String = locOrdre & "." & lers("LocNom").ToString
                                If n.Length > 25 Then n = n.Substring(0, 25)
                                appXL.ActiveSheet.name = n
                                appXL.Columns.ColumnWidth = 15
                                appXL.Columns(1).ColumnWidth = 40
                                appXL.ActiveWindow.DisplayGridlines = False
                                appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges " & Me.lBudget.Text & " / " & lers("LocNom")
                                appXL.Range("A3").Value = "'Lot"
                                appXL.Range("A4").Value = "'Type Lot"

                                'initialise les variables du loc
                                ligneCharge.Clear()
                                laligne = 6
                                lelocactuNom = nz(lers("locNom"), 0)
                                lelotActu = 0
                                laCol = 0
                                totalCharge = 0
                                laCat = ""
                                sousTotCat = 0
                            End If

                            'Mise en forme nouveau lot
                            laligne = 5
                            laCol += 3
                            appXL.Cells(3, laCol).value = "'" & lers("LotNom") & " - " & lers("Batiment")
                            appXL.Cells(4, laCol).value = "'" & lers("TlocalNom")
                            appXL.Columns(laCol).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Columns(laCol + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).Merge()
                            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).Merge()
                            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Cells(laligne, laCol).value = "'Nb jours"
                            appXL.Cells(laligne, laCol + 1).value = "'Quote-Part"
                            appXL.Cells(laligne, laCol + 2).value = "'Montant Lot"
                            lelotActu = nz(lers("lotid"), 0)
                            totalCharge = 0
                            sousTotCat = 0

                        End If

                        'Mise en forme  nouvelle catéorie
                        laligne += 2
                        laCat = lers("tChCatLib")
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = lers("tChCatLib")
                            appXL.Cells(laligne, 1).Font.Bold = True
                            ligneCharge.Add(laligne)
                        End If
                    End If

                    laligne += 1

                    'ecrit la 1er colonne
                    If laCol = 3 Then
                        appXL.Cells(laligne, 1).value = lers("chlib")
                        appXL.Cells(laligne, 2).value = nz(lers("chmontantHT"), 0)
                    End If

                    appXL.Cells(laligne, laCol).value = "'" & nz(lers("NbJour"), 0) & " / " & nz(lers("NbJourAn"), 0)
                    If lers("loc") Then appXL.Cells(laligne, laCol).value = "'" & nz(lers("NbJour"), 0) & " / " & nz(lers("NbJourLotOcc"), 0)
                    If lers("Pro") Then
                        appXL.Cells(laligne, laCol).value = "'Propriétaire"
                    Else
                        appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("QuotePart"), 0) & " / " & nz(lers("TotalQuotePart"), 0)
                    End If
                    appXL.Cells(laligne, laCol + 2).value = nz(lers("chMontantHtLoc"), 0)

                    totalCharge += nz(lers("chMontantHtLoc"), 0)
                    sousTotCat += nz(lers("chMontantHtLoc"), 0)

                End While
                lers.Close()

                'mise en forme dernier loc
                If lelocactuNom <> "" Then
                    'Mise en forme derniere catégorie
                    If laCat <> "" Then
                        laligne += 1
                        If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                        appXL.Cells(laligne, laCol + 2).value = sousTotCat
                        sousTotCat = 0
                        ligneCharge.Add(laligne + 2)
                    End If

                    'Mise en forme dernier lot
                    If lelotActu <> 0 Then
                        laligne += 2
                        appXL.Cells(laligne, laCol + 2).value = totalCharge
                        appXL.Cells(laligne, 1).value = "'Total Lot"

                        With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 2))
                            .Interior.Color = RGB(155, 194, 230)
                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                        End With

                        appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 2)).Interior.Color = RGB(155, 194, 230)

                    End If

                    'Mise en forme dernier loc
                    For i = 0 To ligneCharge.Count - 2
                        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2))
                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                        End With
                        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2)).Interior.Color = RGB(155, 194, 230)
                    Next
                End If
            End If

            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            StatutBar("")
            appXL.StatusBar = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub repartChargev2(txHono As Decimal, budget As Boolean)

        If Me.lBudget.SelectedIndex < 0 Then Exit Sub
        Try
            Dim sSql As String
            Dim lers As OleDb.OleDbDataReader
            Dim lan As String = Me.lBudget.Text
            Dim d1 As Date = CDate("01/01/" & lan)
            Dim d2 As Date = CDate("31/12/" & lan)

            StatutBar("MAZ table temporaire")
            sqlDo("truncate table tempRepartLoc", conSql)

            StatutBar("Recherche lots/locataires")
            sSql = "insert into tempRepartLoc SELECT lot.coproid," & Me.lBudget.Text & ", Lot.LotId , Lot.Batiment, TypeLocal.TlocalNom" _
            & " ,Lot.LotNom, 1,locataire.locid,Annuaire.Nom, location.dateDebut, location.datefin,0,0,location.BailId,location.surface,lot.surface,0,0,soumisHono" _
            & " FROM  Lot " _
            & " LEFT OUTER JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
            & " left outer join location on location.lotid = lot.lotid" _
            & " left outer join locataire on location.locid = locataire.locid" _
            & " left outer join annuaire on annuaire.persid = locataire.persid" _
            & " WHERE Lot.CoproId =" & Me.lacoproId
            sqlDo(sSql, conSql)

            'efface les loc non concernés
            sSql = "delete from tempRepartLoc where dateentree >" & Date2sql(d2) & " or datesortie<" & Date2sql(d1)
            sqlDo(sSql, conSql)

            'MAJ date entree
            StatutBar("Calcul des dates")
            sSql = "update tempRepartLoc set dateentree =" & Date2sql(d1) & " where dateentree<" & Date2sql(d1)
            sqlDo(sSql, conSql)
            'MAJ date entree
            sSql = "update tempRepartLoc set datesortie = " & Date2sql(d2) & " where datesortie is null or datesortie>" & Date2sql(d2)
            sqlDo(sSql, conSql)

            'calcul nb jours
            StatutBar("Calcul des périodes")
            sSql = "update tempRepartLoc set nbjour = datediff(dd,dateentree,datesortie)+1, nbjourLotocc=" & DateDiff(DateInterval.Day, d1, d2) + 1
            sqlDo(sSql, conSql)

            StatutBar("Calcul des périodes d'occupation")
            sSql = " Update temprepartloc set nbjourlotocc =  ( select sum(nbjour) as tot from temprepartloc as T2" _
                & " where temprepartloc.lotid = T2.lotid group by lotid ) "
            sqlDo(sSql, conSql)
            sSql = "update tempRepartLoc set nbjourlotocc = 0 where nbjourlotocc is null"
            sqlDo(sSql, conSql)

            'calcul surface moyenne loc
            sSql = "update tempRepartLoc set surfaceMoyLoc = surfaceloc/" & DateDiff(DateInterval.Day, d1, d2) + 1 & " * nbjour"
            sqlDo(sSql, conSql)
            sSql = " Update temprepartloc set surfaceMoyLocTot =  ( select sum(surfaceMoyLoc) as tot from temprepartloc as T2" _
                & " where temprepartloc.lotid = T2.lotid group by lotid ) "
            sqlDo(sSql, conSql)

            StatutBar("recherche des répartitions")
            sqlDo("truncate table tempRepartCharge", conSql)

            sSql = "insert into temprepartCharge  SELECT " & Me.lacoproId & "," & Me.lBudget.Text & ", temprepartloc.LotId , Batiment, TypeLocal, LotNom,locordre,tempRepartLoc.LocId, LocNom, DateEntree, DateSortie" _
            & " ,chid,chlib, " & IIf(budget, "ChMontantBudgetHT", "chmontantHT") & " ,  QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart,0,nbjour," & DateDiff(DateInterval.Day, d1, d2) + 1 _
            & ",nbjourlotocc,0 ,0,0,tChCatLib,tchcatordre,CleLoc,temprepartloc.BailId,surfaceLoc,surfacelot,surfaceMoyLoc,surfaceMoyLoctot,soumisHono" _
            & " FROM temprepartloc " _
            & " left outer join coprocharge on coprocharge.coproid = temprepartloc.coproid and coprocharge.budid=" & Me.lBudget.SelectedItem.value _
            & " left outer join clerepart on coprocharge.cleid = clerepart.cleid" _
            & " left outer join clerepartlot on clerepartlot.cleid = clerepart.cleid and clerepartlot.lotid = temprepartloc.lotid" _
            & " left outer join typechargeCat on typechargecat.tchcatid = coprocharge.tchCatID" _
            & " where cleloc<>1"
            lers = sqlLit(sSql, conSql)

            sSql = "insert into temprepartCharge  SELECT " & Me.lacoproId & "," & Me.lBudget.Text & ", temprepartloc.LotId , Batiment, TypeLocal, LotNom,locordre,tempRepartLoc.LocId, LocNom, DateEntree, DateSortie" _
            & " ,chid,chlib,chmontantHT,  QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart,0,nbjour," & DateDiff(DateInterval.Day, d1, d2) + 1 _
            & ",nbjourlotocc,0 ,0,0,tChCatLib,tchcatordre,CleLoc,temprepartloc.BailId,surfaceLoc,surfacelot,surfaceMoyLoc,surfaceMoyLoctot,soumisHono" _
            & " FROM temprepartloc " _
            & " left outer join coprocharge on coprocharge.coproid = temprepartloc.coproid and coprocharge.budid=" & Me.lBudget.SelectedItem.value _
            & " left outer join clerepart on coprocharge.cleid = clerepart.cleid" _
            & " left outer join clerepartlot on clerepartlot.cleid = clerepart.cleid and clerepartlot.bailid = temprepartloc.bailid" _
            & " left outer join typechargeCat on typechargecat.tchcatid = coprocharge.tchCatID" _
            & " where cleloc=1"
            lers = sqlLit(sSql, conSql)

            'MAJ valeurs null
            StatutBar("MAJ  quote-part")
            sSql = "update TempRepartCharge set QuotePart = 0 ,pro=0,loc=0,tmp=0 where quotepart is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set pro=0, loc=0, tmp=0 where pro is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set TotalQuotePart=0 where TotalQuotePart is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set TotalQuotePartLoc=0 where TotalQuotePartLoc is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set nbjour=0 where nbjour is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set CleLoc=0 where CleLoc is null"
            sqlDo(sSql, conSql)

            'Calcul quotepart loc
            sSql = "Update temprepartcharge  set totalquotepartloc =( select sum(distinct TotalQuotePart) as tot " _
                & " from temprepartcharge as T2 where temprepartcharge.lotid=T2.lotid and temprepartcharge.chid=T2.chid)"
            sqlDo(sSql, conSql)

            'calcul des montants
            StatutBar("Calcul des montants prorata")
            sSql = "update temprepartcharge set chmontanthtloc =round( chmontantHT * surfaceMoyLoc / SurfaceLot * (QuotePart/TotalQuotePart),2) where tmp = 1 and CleLoc=0 and surfacelot<>0 and TotalQuotePart<>0"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des montants Locataire")
            sSql = "update temprepartcharge set chmontanthtloc =round( chmontantHT * surfaceMoyLoc / SurfaceMoyLocTot * (QuotePart/TotalQuotePart),2) where Loc = 1 And locid <> 0  and CleLoc=0 and SurfaceMoyLocTot<>0 and TotalQuotePart<>0"
            ' sSql = "update temprepartcharge set chmontanthtloc =round( chmontantHT *  (QuotePart/TotalQuotePart),2) where Loc = 1 And locid <> 0  and CleLoc=0  and TotalQuotePart<>0"

            sqlDo(sSql, conSql)

            StatutBar("Calcul des montants directs Locataire")
            sSql = "update temprepartcharge set chmontanthtloc = QuotePart where locid <> 0  and CleLoc=1"
            sqlDo(sSql, conSql)

            ' sSql = " update temprepartcharge set chmontanthtloc =round( chmontantHT * (QuotePart/TotalQuotePart),2) where pro = 1 And locid = 0"
            'sqlDo(sSql, conSql)
            StatutBar("Calcul des montants Propriétaire")
            sSql = "insert into temprepartcharge select " & Me.lacoproId & "," & Me.lBudget.Text & ",0,'','','',3,0,'Propriétaire',null,null,chid,chlib,chmontantht,0,0,0,0,'',0,0,0,0,0, chmontantHT - sum(chmontanthtloc),0,0,tChCatLib,tchcatordre,0,0,0,0,0,0,0" _
            & "  from TempRepartCharge group by chid,chlib,chmontantht,tChCatLib,tchcatordre"
            sqlDo(sSql, conSql)

            If Not budget Then

                StatutBar("Calcul des loyers")
                sSql = "update TempRepartCharge set loyerht= ( select -sum(ecrmontantHT) from comptagene" _
                & " where rubrique='LOCATAIRE' and categorie='LOYER' and AnneeEffet= " & Me.lBudget.Text _
                & " and comptagene.locid=temprepartcharge.locid group by locid )"
                sqlDo(sSql, conSql)

                StatutBar("Calcul des charges")
                sSql = "update TempRepartCharge set chargeht= ( select -sum(ecrmontantHT) from comptagene" _
                & " where rubrique='LOCATAIRE' and categorie='PROVCHARGE' and AnneeEffet = " & Me.lBudget.Text _
                & " and comptagene.locid=temprepartcharge.locid group by locid )"
                sqlDo(sSql, conSql)
            Else
                sSql = "update TempRepartCharge set loyerht= (" _
                & " select LoyerActu from locataire" _
                & " where locataire.locid=temprepartcharge.locid )"
                sqlDo(sSql, conSql)

            End If

            sSql = "update temprepartcharge set loyerht=0 where loyerht is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set chargeht=0 where chargeht is null"
            sqlDo(sSql, conSql)

            'Ajoute les honoraires

            sSql = "update temprepartcharge set loyerHT=0 where soumisHono=0"
            sqlDo(sSql, conSql)

            sSql = "insert into temprepartcharge" _
                & " select  " & Me.lacoproId & "," & Me.lBudget.Text & ", LotId, Batiment, TlocalNom, LotNom, LocOrdre, LocId, LocNom, DateEntree, DateSortie, chId, chlib, chmontantHT, QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart, Totalquotepartloc " _
                & " ,NbJour, NbJourAn, NbJourLotOcc, chMontantHtLoc, LoyerHT, ChargeHT,'Honoraires' ,9999,0,BailId,0,0,0,0,0 from " _
                & " (select  LotId, Batiment, TlocalNom, LotNom, LocOrdre, LocId, LocNom, DateEntree, DateSortie, 3 as chid, 'Honoraires ' as chlib" _
                & " ,0 as chmontantHT, 1 as  QuotePart,0 as Pro, 1 as Loc, 0 as Tmp, 'Honoraires' as CleNom, 1 as TotalQuotePart,0 as totalquotepartLoc " _
                & " ,NbJour, NbJourAn, NbJourLotOcc,round( LoyerHT * " & txHono & " /100,2) as chMontantHtloc,LoyerHT, ChargeHT ,BailId,row_number() over( partition by locid order by locid,lotid) as Nlo " _
                & " from temprepartcharge" _
                & " ) as t where t.Nlo=1"
            sqlDo(sSql, conSql)

            sSql = "update TempRepartCharge set chmontantHT = (select sum(chmontantHtLoc) from temprepartcharge where tChCatordre = 9999 )" _
            & " where(tChCatordre = 9999)"
            sqlDo(sSql, conSql)
        Catch

        End Try
    End Sub


    Sub RepartchargeEdite(RepartLoc As Boolean, lotZero As Boolean, budget2 As Boolean)


        Try
            Dim sSql As String
            Dim lers As OleDb.OleDbDataReader
            Dim lan As String = Me.lBudget.Text
            Dim d1 As Date = CDate("01/01/" & lan)
            Dim d2 As Date = CDate("31/12/" & lan)

            StatutBar("Lancement Excel")

            Dim appXL As New Microsoft.Office.Interop.Excel.Application
            Dim laligne As Integer = 10
            Dim laCol As Integer = 2
            Dim laCat As String = ""
            Dim laLigneCat As Integer = 0
            Dim leBailActu As Integer = 0
            Dim lelotActu As Integer = 0
            Dim lelocActu As Integer = 0
            Dim sousTotCat As Decimal = 0
            Dim totalCat As Decimal = 0
            Dim sousTotCharge As Decimal = 0
            Dim totalCharge As Decimal = 0
            Dim ligneCharge As New List(Of Integer)
            Dim lesLocRepart As New List(Of locRepart)
            Dim nbLoc As Integer = 0

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            StatutBar("Export Excel")

            '**************************************************************
            'Onglet 1 : répartition par lot
            '**************************************************************

            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges " & Me.lBudget.Text
            appXL.ActiveSheet.name = "Répartition Lot"
            appXL.Cells(6, 2).value = "Montant"
            appXL.Cells(3, 1).value = "Lot"
            appXL.Cells(4, 1).value = "Locataire"
            appXL.Columns(1).ColumnWidth = 40

            sSql = "SELECT locid,lotid,Batiment, TlocalNom, LotNom, LocNom, chlib, chmontantHT, chMontantHtLoc, tChCatOrdre, tChCatLib,BailId" _
            & " FROM TempRepartCharge" _
            & " where tChCatordre <> 9999 "
            If Not lotZero Then sSql &= " and lotid not in (select lotid from TempRepartCharge  group by lotid  having sum(chMontantHtLoc)=0 )"
            sSql &= " ORDER BY locordre,Batiment,LotNom,DateEntree,locnom ,tChCatOrdre, tChCatLib,TempRepartCharge.chlib"

            lers = sqlLit(sSql, conSql)
            laCat = ""
            laLigneCat = 0
            While lers.Read
                'au changement de locataire
                If leBailActu <> nz(lers("BailId"), 0) Or (lelotActu <> nz(lers("lotid"), 0)) Then
                    Call StatutBar("Lot : " & nz(lers("LotNom"), ""))
                    appXL.StatusBar = "Lot : " & nz(lers("LotNom"), "")
                    If lelotActu <> 0 Then
                        'sous-total du lot précédent
                        laligne += 1
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, 2).value = sousTotCharge

                        End If
                        appXL.Cells(laligne, laCol).value = sousTotCat

                        'total du lot précédent
                        laligne += 2
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total"
                            appXL.Cells(laligne, 2).value = totalCharge
                        End If
                        appXL.Cells(laligne, laCol).value = totalCat
                    End If

                    lelotActu = nz(lers("lotId"), 0)
                    lelocActu = nz(lers("locid"), 0)
                    leBailActu = nz(lers("BailId"), 0)
                    laCol += 1
                    laCat = ""
                    appXL.Cells(3, laCol).value = nz(lers("LotNom"), "")
                    appXL.Cells(4, laCol).value = nz(lers("LocNom"), "")

                    laligne = 4
                    laLigneCat = 4
                    sousTotCat = 0
                    totalCat = 0
                End If

                'AU changement de catégorie
                If laCat <> lers("tChCatLib") Then
                    If laCat <> "" Then
                        laligne += 1
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, 2).value = sousTotCharge

                        End If
                        appXL.Cells(laligne, laCol).value = sousTotCat
                        sousTotCat = 0
                        sousTotCharge = 0
                    End If

                    laligne += 2
                    appXL.Cells(laligne, 1).value = lers("tChCatLib")
                    appXL.Cells(laligne, 1).Font.Bold = True
                    laCat = lers("tChCatLib")
                    If laCol = 3 Then ligneCharge.Add(laligne + 1)
                End If

                laligne += 1

                'ecrit la 1er colonne : total des charges
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = lers("chlib")
                    appXL.Cells(laligne, 2).value = lers("chmontantHT")
                    totalCharge += nz(lers("chmontantHT"), 0)
                    sousTotCharge += nz(lers("chmontantHT"), 0)
                End If

                appXL.Cells(laligne, laCol).value = lers("chMontantHtLoc")
                sousTotCat += nz(lers("chMontantHtLoc"), 0)
                totalCat += nz(lers("chMontantHtLoc"), 0)

            End While
            appXL.StatusBar = ""

            'sous-total et total du dernier lot, derniere cat
            If laCat <> "" Then
                laligne += 1
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = "Total " & laCat
                    appXL.Cells(laligne, 2).value = totalCharge
                    ligneCharge.Add(laligne + 2)
                End If
                appXL.Cells(laligne, laCol).value = sousTotCat
                appXL.Cells(laligne + 2, laCol).value = totalCat
                ligneCharge.Add(laligne + 3)
            End If

            lers.Close()

            'quadrillage lot
            With appXL.Range(appXL.Cells(3, 3), appXL.Cells(4, laCol))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With

            'quadrillage charges
            For i = 0 To ligneCharge.Count - 2
                With appXL.Range(appXL.Cells(ligneCharge(i), 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With
                appXL.Range(appXL.Cells(ligneCharge(i + 1) - 3, 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol)).Interior.Color = RGB(155, 194, 230)
            Next

            'quadrillage total
            With appXL.Range(appXL.Cells(laligne + 2, 1), appXL.Cells(laligne + 2, laCol))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With
            appXL.Range(appXL.Cells(laligne + 2, 1), appXL.Cells(laligne + 2, laCol)).Interior.Color = RGB(155, 194, 230)

            appXL.ActiveWindow.DisplayGridlines = False


            If Not budget2 Then
                '**************************************************************
                ''Onglet 2 : Surface Moyenne
                '**************************************************************

                Call StatutBar("Export XL")
                appXL.Sheets.Add(, appXL.ActiveSheet)
                appXL.ActiveSheet.name = "Surface Loc"
                appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Surface occupées / Locataire " & Me.lBudget.Text
                appXL.Cells(3, 1).value = "Lots"
                appXL.Cells(3, 2).value = "Batiment"
                appXL.Cells(3, 3).value = "Surface Lot"
                appXL.Cells(3, 4).value = "Locataire"
                appXL.Cells(3, 5).value = "Date Début"
                appXL.Cells(3, 6).value = "DateFin"
                appXL.Cells(3, 7).value = "Nb jour Loc"
                appXL.Cells(3, 8).value = "Nb jour Loc"
                appXL.Cells(3, 9).value = "Surface Louée"
                appXL.Cells(3, 10).value = "Surf. Moy. Louée"
                appXL.Cells(3, 11).value = "Surf. Moy. Louée /Lot"

                appXL.Range(appXL.Cells(3, 1), appXL.Cells(3, 11)).Interior.Color = RGB(155, 194, 230)
                appXL.Columns(1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
                appXL.Columns(1).ColumnWidth = 40
                appXL.ActiveWindow.DisplayGridlines = False

                lelocActu = 0
                laCol = 2
                laligne = 3
                lelotActu = 0

                sSql = "SELECT   lotID, Batiment, TypeLocal, LotNom, LocNom, DateEntree, DateSortie, NbJour, NbJourLotOcc" _
                    & " , SurfaceLoc, SurfaceLot, SurfaceMoyLoc, SurfaceMoyLocTot" _
                    & " FROM TempRepartLoc ORDER BY lotnom,lotid"

                lers = sqlLit(sSql, conSql)
                lelotActu = 0
                While lers.Read
                    laligne += 1
                    If lelotActu <> lers("lotid") Then
                        appXL.Cells(laligne, 1).value = lers("Lotnom").ToString
                        appXL.Cells(laligne, 2).value = lers("batiment").ToString
                        appXL.Cells(laligne, 3).value = num2txt(nz(lers("surfaceLot"), 0))
                        lelotActu = lers("lotid")
                    End If
                    appXL.Cells(laligne, 4).value = nz(lers("Locnom"), "")
                    appXL.Cells(laligne, 5).value = date2Xl(lers("DateEntree"))
                    appXL.Cells(laligne, 6).value = date2Xl(lers("DateSortie"))
                    appXL.Cells(laligne, 7).value = num2txt(nz(lers("NbJour"), 0))
                    appXL.Cells(laligne, 8).value = DateDiff(DateInterval.Day, d1, d2) + 1
                    appXL.Cells(laligne, 9).value = num2txt(nz(lers("SurfaceLoc"), 0))
                    appXL.Cells(laligne, 10).value = num2txt(nz(lers("SurfaceMoyLoc"), 0))
                    appXL.Cells(laligne, 11).value = num2txt(nz(lers("SurfaceMoyLocTot"), 0))
                End While
                lers.Close()

                'quadrillage total
                With appXL.Range(appXL.Cells(3, 1), appXL.Cells(laligne, 11))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With
            End If

            '**************************************************************
            'Onglet 3 : répartition par LOC
            '**************************************************************

            Dim sousTotLoc As Decimal = 0
            Dim totalLoc As Decimal = 0
            Dim totHono As Decimal = 0
            Dim ChargeApp As Decimal = 0

            Call StatutBar("Export XL")
            appXL.Sheets.Add(, appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Répartition Locataire"
            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges / Locataire " & Me.lBudget.Text
            appXL.Cells(3, 1).value = "Locataire"
            appXL.Cells(4, 1).value = "Appels de Loyer"
            appXL.Cells(6, 2).value = "Montant"
            appXL.Columns(1).ColumnWidth = 40
            appXL.ActiveWindow.DisplayGridlines = False

            lelocActu = -1
            laCol = 2
            laligne = 4
            totalCat = 0
            leBailActu = 0
            nbLoc = 0

            sSql = "SELECT  locid, locordre, LocNom, chlib, chmontantHT,sum( chMontantHtLoc) as chmontantHtLoc, tChCatOrdre, tChCatLib,loyerHT,chargeHT" _
            & " FROM TempRepartCharge" _
            & " where locid is not null  " _
            & " group by  locordre,batiment, locid,  LocNom, TempRepartCharge.chlib, TempRepartCharge.chmontantHT,  tChCatOrdre, tChCatLib,loyerHT,ChargeHT" _
            & " ORDER BY locordre,batiment, locnom,locid ,tChCatOrdre, tChCatLib,chlib"

            lers = sqlLit(sSql, conSql)
            laCat = ""
            While lers.Read
                If lelocActu <> nz(lers("locId"), 0) Then
                    Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
                    appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")

                    'ecrit le total et les charge du loc précédent
                    If laCol > 2 Then
                        laligne += 2
                        appXL.Cells(laligne, laCol).value = totalLoc
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total"
                            appXL.Cells(laligne, 2).value = totalCat
                        End If

                        lesLocRepart.Last.Solde = -ChargeApp + totalLoc
                        lesLocRepart.Last.charge = totalLoc

                        If Not budget2 Then
                            laligne += 2
                            appXL.Cells(laligne, laCol).value = -ChargeApp
                            If laCol = 3 Then appXL.Cells(laligne, 1).value = "Appels de Charges"


                            laligne += 2
                            appXL.Cells(laligne, laCol).value = -ChargeApp + totalLoc
                            If laCol = 3 Then appXL.Cells(laligne, 1).value = "Solde Charges"
                        End If

                    End If

                    'initialise les variables du loc
                    laligne = 4
                    lesLocRepart.Add(New locRepart(lers("locid"), lers("loyerHT"), 0, 0, 0, -lers("ChargeHT")))
                    lelocActu = nz(lers("locId"), 0)
                    laCol += 1
                    appXL.Cells(3, laCol).value = nz(lers("LocNom"), "")
                    appXL.Cells(4, laCol).value = lers("loyerHT")
                    '               ChargeApp = nz(lers("CHargeHT"), 0)

                    sousTotCat = 0
                    sousTotLoc = 0
                    totalLoc = 0
                    totalCharge = 0
                    laCat = ""
                End If

                If laCat <> lers("tChCatLib") Then
                    If laCat <> "" Then
                        laligne += 1
                        appXL.Cells(laligne, laCol).value = sousTotLoc
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Sous-Total"
                            appXL.Cells(laligne, 2).value = sousTotCat
                        End If
                    End If

                    laligne += 1
                    If lers("tChCatOrdre") <> 9999 Then
                        laligne += 1
                        appXL.Cells(laligne, 1).value = lers("tChCatLib")
                        appXL.Cells(laligne, 1).Font.Bold = True
                    End If
                    laCat = lers("tChCatLib")
                    sousTotLoc = 0
                    sousTotCat = 0
                End If


                'If budget And lers("tChCatOrdre") = 9999 Then

                '                Else

                laligne += 1


                'ecrit la 1er colonne
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = lers("chlib")
                    appXL.Cells(laligne, 2).value = lers("chmontantHT")
                End If

                appXL.Cells(laligne, laCol).value = lers("chMontantHtLoc")
                sousTotLoc += nz(lers("chMontantHtLoc"), 0)
                totalLoc += nz(lers("chMontantHtLoc"), 0)
                sousTotCat += nz(lers("chMontantHT"), 0)
                totalCat += nz(lers("chMontantHT"), 0)
                ChargeApp = nz(lers("chargeHT"), 0)
                If lers("tChCatOrdre") = 9999 Then lesLocRepart.Last.hono = lers("chmontantHTLoc")

                'End If

            End While
            lers.Close()

            'ecrit le total et les charge du DERNIER loc
            If laCol > 2 Then

                'quadrillage lot
                With appXL.Range(appXL.Cells(3, 3), appXL.Cells(4, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With

                'quadrillage charges
                For i = 0 To ligneCharge.Count - 2
                    With appXL.Range(appXL.Cells(ligneCharge(i), 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol))
                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                    End With
                    appXL.Range(appXL.Cells(ligneCharge(i + 1) - 3, 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol)).Interior.Color = RGB(155, 194, 230)
                Next

                'If Not budget Then
                'quadrillage honoraire
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With
                'End If

                laligne += 2
                appXL.Cells(laligne, laCol).value = totalLoc
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    .Interior.Color = RGB(155, 194, 230)
                End With

                If Not budget2 Then
                    laligne += 2
                    appXL.Cells(laligne, laCol).value = ChargeApp
                    With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                    End With

                    laligne += 2
                    appXL.Cells(laligne, laCol).value = ChargeApp - totalLoc
                    With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                        .Interior.Color = RGB(155, 194, 230)
                    End With
                End If
            End If

            'total par ligne
            appXL.Cells(3, laCol + 2).value = "Total"
            appXL.Cells(4, laCol + 2).formula = "=SUM(" & appXL.Range(appXL.Cells(4, 3), appXL.Cells(4, laCol)).Address(False, False) & ")"
            appXL.Cells(4, laCol + 2).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

            For i = 0 To 100
                If nz(appXL.Cells(i + 7, 2).value, "") <> "" Then
                    appXL.Cells(i + 7, laCol + 2).formula = "=SUM(" & appXL.Range(appXL.Cells(i + 7, 3), appXL.Cells(i + 7, laCol)).Address(False, False) & ")"
                    appXL.Cells(i + 7, laCol + 2).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                End If
            Next
            appXL.Cells.NumberFormat = "#,##0.00"

            If Not budget2 Then
                '**************************************************************
                'Onglet 4 : Vérif Loyer/charges
                '**************************************************************
                appXL.Sheets.Add(, appXL.ActiveSheet)
                appXL.ActiveSheet.name = "Loyers-Charges"
                appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Loyers et charges / Locataire " & Me.lBudget.Text
                appXL.Cells(3, 1).value = "Locataire"
                appXL.Cells(3, 2).value = "Date"
                appXL.Cells(3, 3).value = "Libellé"
                appXL.Cells(3, 4).value = "Montant"
                appXL.Cells(3, 5).value = "Catégorie"
                appXL.Cells(3, 6).value = "Loyer"
                appXL.Cells(3, 7).value = "Prov Charges"
                appXL.ActiveWindow.DisplayGridlines = False

                appXL.Columns.ColumnWidth = 14
                appXL.Columns(1).ColumnWidth = 20
                appXL.Columns(3).ColumnWidth = 40
                appXL.Range("A3:G3").Interior.Color = RGB(155, 194, 230)

                laligne = 3
                sSql = "select nom,ecrecheance, ecrlib, -ecrmontantHT as montant,categorie,soumishono from comptagene" _
                    & " inner join locataire on locataire.locid=comptagene.locid" _
                    & " inner join annuaire on annuaire.persid=locataire.persid" _
                    & " where rubrique='LOCATAIRE'  and year(ecrEcheance)= " & Me.lBudget.Text _
                    & " and locataire.locid in  (select distinct locid from temprepartcharge where locid <>0 or locid is not null)" _
                    & " order by nom, ecrecheance,ecrlib "
                lers = sqlLit(sSql, conSql)
                While lers.Read
                    laligne += 1
                    appXL.Cells(laligne, 1).value = lers("nom").ToString
                    appXL.Cells(laligne, 2).value = date2Xl(lers("ecrecheance"))
                    appXL.Cells(laligne, 3).value = lers("ecrlib").ToString
                    appXL.Cells(laligne, 4).value = lers("montant")
                    appXL.Cells(laligne, 5).value = lers("categorie").ToString
                    If nz(lers("soumishono"), 1) = 1 And lers("categorie") = "LOYER" Then appXL.Cells(laligne, 6).value = lers("montant")
                    If lers("categorie") = "PROVCHARGE" Then appXL.Cells(laligne, 7).value = lers("montant")
                End While
                lers.Close()
                appXL.Range("A3:G" & laligne + 1).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                appXL.Cells(3, 1).select()
                appXL.Selection.Subtotal(GroupBy:=1, Function:=Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlSum, TotalList:=New Int32() {6, 7}, Replace:=True, PageBreaks:=False, SummaryBelowData:=True)
                appXL.ActiveSheet.Outline.ShowLevels(RowLevels:=2)
                'laligne += 1
                'appXL.Cells(laligne, 1).value = "Total"
                'appXL.Cells(laligne, 6).formula = "=SUM(F4:F" & laligne - 1 & ")"
                'appXL.Cells(laligne, 7).formula = "=SUM(G4:G" & laligne - 1 & ")"

            End If


            '**************************************************************
            'Repart 5+ onglet par locataire
            '**************************************************************

            If RepartLoc = True Then
                Dim locOrdre As Integer = 0
                Dim lelocactuNom As String = ""

                Call StatutBar("Export Locataire")
                sSql = " SELECT  locid,  LocNom, chlib, chmontantHT, tChCatOrdre, tChCatLIb, LoyerHT, ChargeHT, LotId, QuotePart, TotalQuotePart" _
                    & ", NbJour, NbJourAn, LotNom, Batiment, TlocalNom, Pro, Loc, Tmp, NbJourLotOcc, chMontantHtLoc,CleLoc,BailId,surfaceMoyLoc,SurfaceLot,SurfaceMoyLocTot,surfaceLoc" _
                    & " FROM TempRepartCharge WHERE (LocId <> 0 or locid is not null) and tChCatOrdre <> 9999 and chmontantHT<>0 "
                If Not lotZero Then sSql &= " and lotid not in (select lotid from TempRepartCharge  group by lotid  having sum(chMontantHtLoc)=0 )"
                sSql &= " ORDER BY LocNom,locid, lotid,bailId, tChCatOrdre, tChCatLIb, chlib"

                lers = sqlLit(sSql, conSql)
                lelocActu = 0
                laCat = ""
                lelotActu = 0
                leBailActu = 0

                While lers.Read
                    If leBailActu <> nz(lers("BailId"), 0) Or laCat <> lers("tChCatLib") Then

                        'Mise en forme catégorie précédente
                        If laCat <> "" Then
                            laligne += 1
                            If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, laCol + 2).value = sousTotCat
                            sousTotCat = 0
                        End If

                        If leBailActu <> nz(lers("BailId"), 0) Then
                            'Mise en forme Lot précédent
                            If lelotActu <> 0 And laCol = 3 Then ligneCharge.Add(laligne + 2)

                            If lelocActu <> lers("Locid") Then
                                'Mise en forme Ancien loc
                                If lelocactuNom <> "" Then

                                    appXL.Columns(laCol + 3).NumberFormat = "#,##0.00"

                                    'Colonne total
                                    appXL.Cells(4, laCol + 3).value = "Total"
                                    Dim tligne As Decimal = 0
                                    For tc = 6 To laligne
                                        tligne = 0
                                        If appXL.Cells(tc, 1).Font.Bold = False And appXL.Cells(tc, 1).value <> "" Then
                                            For td = 3 To laCol Step 3
                                                tligne += appXL.Cells(tc, td + 2).value
                                            Next
                                            appXL.Cells(tc, laCol + 3).value = tligne
                                        End If
                                    Next

                                    With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 3))
                                        .Interior.Color = RGB(155, 194, 230)
                                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                                    End With

                                    appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 3)).Interior.Color = RGB(155, 194, 230)

                                    For i = 0 To ligneCharge.Count - 2
                                        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 3))
                                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 3)).Interior.Color = RGB(155, 194, 230)
                                    Next

                                    'affiche global
                                    For lo = 0 To lesLocRepart.Count - 1
                                        If lesLocRepart(lo).locId = lelocActu Then
                                            appXL.Cells(laligne + 2, laCol + 2).value = "Loyers"
                                            appXL.Cells(laligne + 3, laCol + 2).value = "Honoraires"
                                            appXL.Cells(laligne + 5, laCol + 2).value = "Total Charges"
                                            appXL.Cells(laligne + 2, laCol + 3).value = lesLocRepart(lo).loyer
                                            appXL.Cells(laligne + 3, laCol + 3).value = lesLocRepart(lo).hono
                                            appXL.Cells(laligne + 5, laCol + 3).value = lesLocRepart(lo).charge
                                            appXL.Cells(laligne + 3, laCol + 2).Interior.Color = RGB(155, 194, 230)
                                            appXL.Cells(laligne + 5, laCol + 2).Interior.Color = RGB(155, 194, 230)
                                            appXL.Cells(laligne + 3, laCol + 3).Interior.Color = RGB(155, 194, 230)
                                            appXL.Cells(laligne + 5, laCol + 3).Interior.Color = RGB(155, 194, 230)

                                            If Not budget2 Then
                                                appXL.Cells(laligne + 6, laCol + 2).value = "Provisions"
                                                appXL.Cells(laligne + 7, laCol + 2).value = "Solde"
                                                appXL.Cells(laligne + 6, laCol + 3).value = lesLocRepart(lo).Prov
                                                appXL.Cells(laligne + 7, laCol + 3).value = lesLocRepart(lo).Solde
                                                appXL.Cells(laligne + 7, laCol + 2).Interior.Color = RGB(155, 194, 230)
                                                appXL.Cells(laligne + 7, laCol + 3).Interior.Color = RGB(155, 194, 230)
                                            End If
                                        End If
                                    Next
                                End If

                                'Mise en forme Nouveau Loc
                                locOrdre += 1
                                Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
                                appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")
                                appXL.Sheets.Add(, appXL.ActiveSheet)
                                Dim n As String = locOrdre & "." & lers("LocNom").ToString
                                If n.Length > 25 Then n = n.Substring(0, 25)
                                appXL.ActiveSheet.name = n
                                appXL.Columns.ColumnWidth = 15
                                appXL.Columns(1).ColumnWidth = 40
                                appXL.ActiveWindow.DisplayGridlines = False
                                appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges " & Me.lBudget.Text & " / " & lers("LocNom")
                                appXL.Range("A3").Value = "'Lot"
                                appXL.Range("A4").Value = "'Type Lot"

                                'initialise les variables du loc
                                ligneCharge.Clear()
                                laligne = 6
                                lelocactuNom = nz(lers("locNom"), 0)
                                lelocActu = nz(lers("Locid"), 0)
                                lelotActu = 0
                                leBailActu = nz(lers("BailId"), 0)
                                laCol = 0
                                totalCharge = 0
                                sousTotCharge = 0
                                laCat = ""
                                sousTotCat = 0
                            End If


                            'Mise en forme nouveau lot
                            laligne = 5
                            laCol += 3
                            appXL.Cells(3, laCol).value = "'" & lers("LotNom") & " - " & lers("Batiment")
                            appXL.Cells(4, laCol).value = "'" & lers("TlocalNom")
                            appXL.Columns(laCol).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Columns(laCol + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).Merge()
                            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).Merge()
                            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Cells(laligne, laCol).value = "'Quote-Part"
                            appXL.Cells(laligne, laCol + 1).value = "'Prorata Surface"
                            appXL.Cells(laligne, laCol + 2).value = "'Montant Lot"
                            lelotActu = nz(lers("lotid"), 0)
                            leBailActu = nz(lers("BailId"), 0)
                            sousTotCharge = 0
                            sousTotCat = 0
                        End If

                        'Mise en forme  nouvelle catéorie
                        laligne += 2
                        laCat = lers("tChCatLib")
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = lers("tChCatLib")
                            appXL.Cells(laligne, 1).Font.Bold = True
                            ligneCharge.Add(laligne)
                        End If
                    End If

                    laligne += 1

                    'ecrit la 1er colonne
                    If laCol = 3 Then
                        appXL.Cells(laligne, 1).value = lers("chlib")
                        appXL.Cells(laligne, 2).value = lers("chmontantHT")
                    End If

                    If lers("CleLoc") = 0 Then
                        appXL.Cells(laligne, laCol).value = "'" & nz(lers("QuotePart"), 0) & " / " & nz(lers("TotalQuotePart"), 0)
                        If lers("Loc") = True Then
                            appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceMoyLocTot"), 0)
                        Else
                            appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceLot"), 0)
                        End If
                    End If

                    appXL.Cells(laligne, laCol + 2).value = lers("chMontantHtLoc")

                    totalCharge += nz(lers("chMontantHtLoc"), 0)
                    sousTotCat += nz(lers("chMontantHtLoc"), 0)

                End While
                lers.Close()

                'mise en forme dernier loc
                If lelocactuNom <> "" Then
                    'Mise en forme derniere catégorie
                    If laCat <> "" Then
                        laligne += 1
                        If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                        appXL.Cells(laligne, laCol + 2).value = sousTotCat
                        sousTotCat = 0
                        ligneCharge.Add(laligne + 2)
                    End If

                    ''Mise en forme dernier lot
                    If lelotActu <> 0 Then
                        With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 3))
                            .Interior.Color = RGB(155, 194, 230)
                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                        End With

                        'laligne += 2
                        'appXL.Cells(laligne, laCol + 2).value = totalCharge
                        'appXL.Cells(laligne, 1).value = "'Total Lot"
                        'appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 3)).Interior.Color = RGB(155, 194, 230)

                    End If

                    'Mise en forme dernier loc
                    appXL.Columns(laCol + 3).NumberFormat = "#,##0.00"

                    'Colonne total
                    appXL.Cells(4, laCol + 3).value = "Total"
                    Dim tligne As Decimal = 0
                    For tc = 6 To laligne
                        tligne = 0
                        If appXL.Cells(tc, 1).Font.Bold = False And appXL.Cells(tc, 1).value <> "" Then
                            For td = 3 To laCol Step 3
                                tligne += appXL.Cells(tc, td + 2).value
                            Next
                            appXL.Cells(tc, laCol + 3).value = tligne
                        End If
                    Next

                    For i = 0 To ligneCharge.Count - 2
                        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 3))
                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                        End With

                        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 3)).Interior.Color = RGB(155, 194, 230)
                    Next


                    'affiche global
                    For lo = 0 To lesLocRepart.Count - 1
                        If lesLocRepart(lo).locId = lelocActu Then
                            appXL.Cells(laligne + 2, laCol + 2).value = "Loyers"
                            appXL.Cells(laligne + 3, laCol + 2).value = "Honoraires"
                            appXL.Cells(laligne + 5, laCol + 2).value = "Total Charges"
                            appXL.Cells(laligne + 2, laCol + 3).value = lesLocRepart(lo).loyer
                            appXL.Cells(laligne + 3, laCol + 3).value = lesLocRepart(lo).hono
                            appXL.Cells(laligne + 5, laCol + 3).value = lesLocRepart(lo).charge
                            appXL.Cells(laligne + 3, laCol + 2).Interior.Color = RGB(155, 194, 230)
                            appXL.Cells(laligne + 5, laCol + 2).Interior.Color = RGB(155, 194, 230)
                            appXL.Cells(laligne + 3, laCol + 3).Interior.Color = RGB(155, 194, 230)
                            appXL.Cells(laligne + 5, laCol + 3).Interior.Color = RGB(155, 194, 230)

                            If Not budget2 Then
                                appXL.Cells(laligne + 6, laCol + 2).value = "Provisions"
                                appXL.Cells(laligne + 7, laCol + 2).value = "Solde"
                                appXL.Cells(laligne + 6, laCol + 3).value = lesLocRepart(lo).Prov
                                appXL.Cells(laligne + 7, laCol + 3).value = lesLocRepart(lo).Solde
                                appXL.Cells(laligne + 7, laCol + 2).Interior.Color = RGB(155, 194, 230)
                                appXL.Cells(laligne + 7, laCol + 3).Interior.Color = RGB(155, 194, 230)
                            End If
                        End If
                    Next
                End If
            End If

            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            StatutBar("")
            appXL.StatusBar = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Sub editlocPArLoc()

        'Dim locOrdre As Integer = 0
        'Dim lelocactuNom As String = ""

        'Call StatutBar("Export Locataire")
        'sSql = " SELECT    LocNom, chlib, chmontantHT, tChCatOrdre, tChCatLIb, LoyerHT, ChargeHT, LotId, QuotePart, TotalQuotePart" _
        '    & ", NbJour, NbJourAn, LotNom, Batiment, TlocalNom, Pro, Loc, Tmp, NbJourLotOcc, chMontantHtLoc,CleLoc,BailId,surfaceMoyLoc,SurfaceLot,SurfaceMoyLocTot,surfaceLoc" _
        '    & " FROM TempRepartCharge WHERE (LocId <> 0 or locid is not null) and tChCatOrdre <> 9999"
        'If Not lotZero Then sSql &= " and lotid not in (select lotid from TempRepartCharge  group by lotid  having sum(chMontantHtLoc)=0 )"
        'sSql &= " ORDER BY LocNom, lotid,bailId, tChCatOrdre, tChCatLIb, chlib"

        'lers = sqlLit(sSql, conSql)
        'lelocActu = 0
        'laCat = ""
        'lelotActu = 0
        'leBailActu = 0

        'While lers.Read
        '    If leBailActu <> nz(lers("BailId"), 0) Or laCat <> lers("tChCatLib") Then

        '        'Mise en forme catégorie précédente
        '        If laCat <> "" Then
        '            laligne += 1
        '            If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
        '            appXL.Cells(laligne, laCol + 2).value = sousTotCat
        '            sousTotCat = 0
        '        End If

        '        If leBailActu <> nz(lers("BailId"), 0) Then
        '            'Mise en forme Lot précédent
        '            If lelotActu <> 0 Then
        '                If laCol = 3 Then ligneCharge.Add(laligne + 2)
        '                laligne += 2
        '                appXL.Cells(laligne, laCol + 2).value = totalCharge
        '                appXL.Cells(laligne, 1).value = "'Total Lot"
        '            End If

        '            If lelocactuNom <> lers("LocNom") Then
        '                'Mise en forme ANciel loc
        '                If lelocactuNom <> "" Then
        '                    appXL.Columns(laCol + 3).width = 3

        '                    With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 2))
        '                        .Interior.Color = RGB(155, 194, 230)
        '                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '                        .Borders.Weight = Excel.XlBorderWeight.xlThin
        '                    End With

        '                    appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 2)).Interior.Color = RGB(155, 194, 230)

        '                    For i = 0 To ligneCharge.Count - 2
        '                        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2))
        '                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '                            .Borders.Weight = Excel.XlBorderWeight.xlThin
        '                        End With
        '                        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2)).Interior.Color = RGB(155, 194, 230)

        '                        'colonne totale'
        '                        For tc = 5 To laCol + 2 Step 3
        '                        Next
        '                    Next

        '                End If
        '                'Mise en forme Nouveau Loc
        '                locOrdre += 1
        '                Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
        '                appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")
        '                appXL.Sheets.Add(, appXL.ActiveSheet)
        '                Dim n As String = locOrdre & "." & lers("LocNom").ToString
        '                If n.Length > 25 Then n = n.Substring(0, 25)
        '                appXL.ActiveSheet.name = n
        '                appXL.Columns.ColumnWidth = 15
        '                appXL.Columns(1).ColumnWidth = 40
        '                appXL.ActiveWindow.DisplayGridlines = False
        '                appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges " & Me.lBudget.Text & " / " & lers("LocNom")
        '                appXL.Range("A3").Value = "'Lot"
        '                appXL.Range("A4").Value = "'Type Lot"

        '                'initialise les variables du loc
        '                ligneCharge.Clear()
        '                laligne = 6
        '                lelocactuNom = nz(lers("locNom"), 0)
        '                lelotActu = 0
        '                leBailActu = nz(lers("BailId"), 0)
        '                laCol = 0
        '                totalCharge = 0
        '                laCat = ""
        '                sousTotCat = 0
        '            End If

        '            'Mise en forme nouveau lot
        '            laligne = 5
        '            laCol += 3
        '            appXL.Cells(3, laCol).value = "'" & lers("LotNom") & " - " & lers("Batiment")
        '            appXL.Cells(4, laCol).value = "'" & lers("TlocalNom")
        '            appXL.Columns(laCol).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
        '            appXL.Columns(laCol + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
        '            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).Merge()
        '            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
        '            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).Merge()
        '            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
        '            appXL.Cells(laligne, laCol).value = "'Quote-Part"
        '            appXL.Cells(laligne, laCol + 1).value = "'Prorata Surface"
        '            appXL.Cells(laligne, laCol + 2).value = "'Montant Lot"
        '            lelotActu = nz(lers("lotid"), 0)
        '            leBailActu = nz(lers("BailId"), 0)
        '            totalCharge = 0
        '            sousTotCat = 0

        '        End If

        '        'Mise en forme  nouvelle catéorie
        '        laligne += 2
        '        laCat = lers("tChCatLib")
        '        If laCol = 3 Then
        '            appXL.Cells(laligne, 1).value = lers("tChCatLib")
        '            appXL.Cells(laligne, 1).Font.Bold = True
        '            ligneCharge.Add(laligne)
        '        End If
        '    End If

        '    laligne += 1

        '    'ecrit la 1er colonne
        '    If laCol = 3 Then
        '        appXL.Cells(laligne, 1).value = lers("chlib")
        '        appXL.Cells(laligne, 2).value = lers("chmontantHT")
        '    End If


        '    If lers("CleLoc") = 0 Then
        '        appXL.Cells(laligne, laCol).value = "'" & nz(lers("QuotePart"), 0) & " / " & nz(lers("TotalQuotePart"), 0)

        '        If lers("Loc") = True Then
        '            appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceMoyLocTot"), 0)
        '        Else
        '            appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceLot"), 0)
        '        End If
        '    End If

        '    appXL.Cells(laligne, laCol + 2).value = lers("chMontantHtLoc")

        '    totalCharge += nz(lers("chMontantHtLoc"), 0)
        '    sousTotCat += nz(lers("chMontantHtLoc"), 0)

        'End While
        'lers.Close()

        ''mise en forme dernier loc
        'If lelocactuNom <> "" Then
        '    'Mise en forme derniere catégorie
        '    If laCat <> "" Then
        '        laligne += 1
        '        If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
        '        appXL.Cells(laligne, laCol + 2).value = sousTotCat
        '        sousTotCat = 0
        '        ligneCharge.Add(laligne + 2)
        '    End If

        '    'Mise en forme dernier lot
        '    If lelotActu <> 0 Then
        '        laligne += 2
        '        appXL.Cells(laligne, laCol + 2).value = totalCharge
        '        appXL.Cells(laligne, 1).value = "'Total Lot"

        '        With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 2))
        '            .Interior.Color = RGB(155, 194, 230)
        '            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            .Borders.Weight = Excel.XlBorderWeight.xlThin
        '        End With

        '        appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 2)).Interior.Color = RGB(155, 194, 230)

        '    End If

        '    'Mise en forme dernier loc
        '    For i = 0 To ligneCharge.Count - 2
        '        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2))
        '            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
        '            .Borders.Weight = Excel.XlBorderWeight.xlThin
        '        End With
        '        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2)).Interior.Color = RGB(155, 194, 230)
        '    Next
        'End If
    End Sub

    Private Sub repartCharge(txHono As Decimal, RepartLoc As Boolean, lotZero As Boolean)

        If Me.lBudget.SelectedIndex < 0 Then Exit Sub
        Try
            Dim sSql As String
            Dim lers As OleDb.OleDbDataReader
            Dim lan As String = Me.lBudget.Text
            Dim d1 As Date = CDate("01/01/" & lan)
            Dim d2 As Date = CDate("31/12/" & lan)

            StatutBar("MAZ table temporaire")
            sqlDo("truncate table tempRepartLoc", conSql)

            StatutBar("Recherche lots/locataires")
            sSql = "insert into tempRepartLoc SELECT lot.coproid, Lot.LotId , Lot.Batiment, TypeLocal.TlocalNom" _
            & " ,Lot.LotNom, 1,locataire.locid,Annuaire.Nom, location.dateDebut, location.datefin,0,0,location.BailId,location.surface,lot.surface,0,0,soumisHono" _
            & " FROM  Lot " _
            & " LEFT OUTER JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
            & " left outer join location on location.lotid = lot.lotid" _
            & " left outer join locataire on location.locid = locataire.locid" _
            & " left outer join annuaire on annuaire.persid = locataire.persid" _
            & " WHERE Lot.CoproId =" & Me.lacoproId
            sqlDo(sSql, conSql)

            'efface les loc non concernés
            sSql = "delete from tempRepartLoc where dateentree >" & Date2sql(d2) & " or datesortie<" & Date2sql(d1)
            sqlDo(sSql, conSql)

            'MAJ date entree
            StatutBar("Calcul des dates")
            sSql = "update tempRepartLoc set dateentree =" & Date2sql(d1) & " where dateentree<" & Date2sql(d1)
            sqlDo(sSql, conSql)
            'MAJ date entree
            sSql = "update tempRepartLoc set datesortie = " & Date2sql(d2) & " where datesortie is null or datesortie>" & Date2sql(d2)
            sqlDo(sSql, conSql)

            'calcul nb jours
            StatutBar("Calcul des périodes")
            sSql = "update tempRepartLoc set nbjour = datediff(dd,dateentree,datesortie)+1, nbjourLotocc=" & DateDiff(DateInterval.Day, d1, d2) + 1
            sqlDo(sSql, conSql)

            StatutBar("Calcul des périodes d'occupation")
            sSql = " Update temprepartloc set nbjourlotocc =  ( select sum(nbjour) as tot from temprepartloc as T2" _
                & " where temprepartloc.lotid = T2.lotid group by lotid ) "
            sqlDo(sSql, conSql)
            sSql = "update tempRepartLoc set nbjourlotocc = 0 where nbjourlotocc is null"
            sqlDo(sSql, conSql)

            'calcul surface moyenne loc
            sSql = "update tempRepartLoc set surfaceMoyLoc = surfaceloc/" & DateDiff(DateInterval.Day, d1, d2) + 1 & " * nbjour"
            sqlDo(sSql, conSql)
            sSql = " Update temprepartloc set surfaceMoyLocTot =  ( select sum(surfaceMoyLoc) as tot from temprepartloc as T2" _
                & " where temprepartloc.lotid = T2.lotid group by lotid ) "
            sqlDo(sSql, conSql)

            StatutBar("recherche des répartitions")
            sqlDo("truncate table tempRepartCharge", conSql)
            sSql = "insert into temprepartCharge  SELECT  temprepartloc.LotId , Batiment, TypeLocal, LotNom,locordre,tempRepartLoc.LocId, LocNom, DateEntree, DateSortie" _
            & " ,chid,chlib,chmontantHT,  QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart,0,nbjour," & DateDiff(DateInterval.Day, d1, d2) + 1 _
            & ",nbjourlotocc,0 ,0,0,tChCatLib,tchcatordre,CleLoc,temprepartloc.BailId,surfaceLoc,surfacelot,surfaceMoyLoc,surfaceMoyLoctot,soumisHono" _
            & " FROM temprepartloc " _
            & " left outer join coprocharge on coprocharge.coproid = temprepartloc.coproid and coprocharge.budid=" & Me.lBudget.SelectedItem.value _
            & " left outer join clerepart on coprocharge.cleid = clerepart.cleid" _
            & " left outer join clerepartlot on clerepartlot.cleid = clerepart.cleid and clerepartlot.lotid = temprepartloc.lotid" _
            & " left outer join typechargeCat on typechargecat.tchcatid = coprocharge.tchCatID" _
            & " where cleloc<>1"
            lers = sqlLit(sSql, conSql)

            sSql = "insert into temprepartCharge  SELECT  temprepartloc.LotId , Batiment, TypeLocal, LotNom,locordre,tempRepartLoc.LocId, LocNom, DateEntree, DateSortie" _
            & " ,chid,chlib,chmontantHT,  QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart,0,nbjour," & DateDiff(DateInterval.Day, d1, d2) + 1 _
            & ",nbjourlotocc,0 ,0,0,tChCatLib,tchcatordre,CleLoc,temprepartloc.BailId,surfaceLoc,surfacelot,surfaceMoyLoc,surfaceMoyLoctot,soumisHono" _
            & " FROM temprepartloc " _
            & " left outer join coprocharge on coprocharge.coproid = temprepartloc.coproid and coprocharge.budid=" & Me.lBudget.SelectedItem.value _
            & " left outer join clerepart on coprocharge.cleid = clerepart.cleid" _
            & " left outer join clerepartlot on clerepartlot.cleid = clerepart.cleid and clerepartlot.bailid = temprepartloc.bailid" _
            & " left outer join typechargeCat on typechargecat.tchcatid = coprocharge.tchCatID" _
            & " where cleloc=1"
            lers = sqlLit(sSql, conSql)




            'MAJ valeurs null
            StatutBar("MAJ  quote-part")
            sSql = "update TempRepartCharge set QuotePart = 0 ,pro=0,loc=0,tmp=0 where quotepart is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set pro=0, loc=0, tmp=0 where pro is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set TotalQuotePart=0 where TotalQuotePart is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set TotalQuotePartLoc=0 where TotalQuotePartLoc is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set nbjour=0 where nbjour is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set CleLoc=0 where CleLoc is null"
            sqlDo(sSql, conSql)

            'If lotZero Then
            '    sSql = "delete from temprepartcharge where lotid in (" _
            '        & " select lotid  from temprepartcharge group by lotid having(sum(quotepart) = 0))"
            '    sqlDo(sSql, conSql)
            'End If


            'Calcul quotepart loc
            sSql = "Update temprepartcharge  set totalquotepartloc =( select sum(distinct TotalQuotePart) as tot " _
                & " from temprepartcharge as T2 where temprepartcharge.lotid=T2.lotid and temprepartcharge.chid=T2.chid)"
            sqlDo(sSql, conSql)

            'calcul des montants
            StatutBar("Calcul des montants prorata")
            sSql = "update temprepartcharge set chmontanthtloc =round( chmontantHT * surfaceMoyLoc / SurfaceLot * (QuotePart/TotalQuotePart),2) where tmp = 1 and CleLoc=0 and surfacelot<>0 and TotalQuotePart<>0"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des montants Locataire")
            sSql = "update temprepartcharge set chmontanthtloc =round( chmontantHT * surfaceMoyLoc / SurfaceMoyLocTot * (QuotePart/TotalQuotePart),2) where Loc = 1 And locid <> 0  and CleLoc=0 and SurfaceMoyLocTot<>0 and TotalQuotePart<>0"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des montants directs Locataire")
            sSql = "update temprepartcharge set chmontanthtloc = QuotePart where locid <> 0  and CleLoc=1"
            sqlDo(sSql, conSql)

            ' sSql = " update temprepartcharge set chmontanthtloc =round( chmontantHT * (QuotePart/TotalQuotePart),2) where pro = 1 And locid = 0"
            'sqlDo(sSql, conSql)
            StatutBar("Calcul des montants Propriétaire")
            sSql = "insert into temprepartcharge select 0,'','','',3,0,'Propriétaire',null,null,chid,chlib,chmontantht,0,0,0,0,'',0,0,0,0,0, chmontantHT - sum(chmontanthtloc),0,0,tChCatLib,tchcatordre,0,0,0,0,0,0,0" _
            & "  from TempRepartCharge group by chid,chlib,chmontantht,tChCatLib,tchcatordre"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des loyers")
            sSql = "update TempRepartCharge set loyerht= ( select -sum(ecrmontantHT) from comptagene" _
            & " where rubrique='LOCATAIRE' and categorie='LOYER' and year(ecrEcheance)= " & Me.lBudget.Text _
            & " and comptagene.locid=temprepartcharge.locid group by locid )"
            sqlDo(sSql, conSql)

            StatutBar("Calcul des charges")
            sSql = "update TempRepartCharge set chargeht= ( select -sum(ecrmontantHT) from comptagene" _
            & " where rubrique='LOCATAIRE' and categorie='PROVCHARGE' and year(ecrEcheance)= " & Me.lBudget.Text _
            & " and comptagene.locid=temprepartcharge.locid group by locid )"
            sqlDo(sSql, conSql)

            sSql = "update temprepartcharge set loyerht=0 where loyerht is null"
            sqlDo(sSql, conSql)
            sSql = "update temprepartcharge set chargeht=0 where chargeht is null"
            sqlDo(sSql, conSql)

            'Efface Lot a montant =0
            'If lotZero Then
            '    sSql = " delete from temprepartcharge where lotid in (" _
            '        & "select lotid  from temprepartcharge group by lotid having sum(chMontantHtLoc)=0)"
            '    sqlDo(sSql, conSql)
            'End If

            StatutBar("Lancement Excel")

            Dim appXL As New Microsoft.Office.Interop.Excel.Application
            Dim laligne As Integer = 10
            Dim laCol As Integer = 2
            Dim laCat As String = ""
            Dim laLigneCat As Integer = 0
            Dim leBailActu As Integer = 0
            Dim lelotActu As Integer = 0
            Dim lelocActu As Integer = 0
            Dim sousTotCat As Decimal = 0
            Dim totalCat As Decimal = 0
            Dim sousTotCharge As Decimal = 0
            Dim totalCharge As Decimal = 0
            Dim ligneCharge As New List(Of Integer)

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            StatutBar("Export Excel")

            '**************************************************************
            'Onglet 1 : répartition par lot
            '**************************************************************

            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges " & Me.lBudget.Text
            appXL.ActiveSheet.name = "Répartition Lot"
            appXL.Cells(6, 2).value = "Montant"
            appXL.Cells(3, 1).value = "Lot"
            appXL.Cells(4, 1).value = "Locataire"
            appXL.Columns(1).ColumnWidth = 40

            sSql = "SELECT locid,lotid,Batiment, TlocalNom, LotNom, LocNom, chlib, chmontantHT, chMontantHtLoc, tChCatOrdre, tChCatLib,BailId" _
            & " FROM TempRepartCharge"
            If Not lotZero Then sSql &= " where lotid not in (select lotid from TempRepartCharge  group by lotid  having sum(chMontantHtLoc)=0 )"
            sSql &= " ORDER BY locordre,Batiment,LotNom,DateEntree,locnom ,tChCatOrdre, tChCatLib,TempRepartCharge.chlib"

            lers = sqlLit(sSql, conSql)
            laCat = ""
            laLigneCat = 0
            While lers.Read
                'au changement de locataire
                If leBailActu <> nz(lers("BailId"), 0) Or (lelotActu <> nz(lers("lotid"), 0)) Then
                    Call StatutBar("Lot : " & nz(lers("LotNom"), ""))
                    appXL.StatusBar = "Lot : " & nz(lers("LotNom"), "")
                    If lelotActu <> 0 Then
                        'sous-total du lot précédent
                        laligne += 1
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, 2).value = sousTotCharge

                        End If
                        appXL.Cells(laligne, laCol).value = sousTotCat

                        'total du lot précédent
                        laligne += 2
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total"
                            appXL.Cells(laligne, 2).value = totalCharge
                        End If
                        appXL.Cells(laligne, laCol).value = totalCat
                    End If

                    lelotActu = nz(lers("lotId"), 0)
                    lelocActu = nz(lers("locid"), 0)
                    leBailActu = nz(lers("BailId"), 0)
                    laCol += 1
                    laCat = ""
                    appXL.Cells(3, laCol).value = nz(lers("LotNom"), "")
                    appXL.Cells(4, laCol).value = nz(lers("LocNom"), "")

                    laligne = 4
                    laLigneCat = 4
                    sousTotCat = 0
                    totalCat = 0
                End If

                'AU changement de catégorie
                If laCat <> lers("tChCatLib") Then
                    If laCat <> "" Then
                        laligne += 1
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, 2).value = sousTotCharge

                        End If
                        appXL.Cells(laligne, laCol).value = sousTotCat
                        sousTotCat = 0
                        sousTotCharge = 0
                    End If

                    laligne += 2
                    appXL.Cells(laligne, 1).value = lers("tChCatLib")
                    appXL.Cells(laligne, 1).Font.Bold = True
                    laCat = lers("tChCatLib")
                    If laCol = 3 Then ligneCharge.Add(laligne + 1)
                End If

                laligne += 1

                'ecrit la 1er colonne : total des charges
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = lers("chlib")
                    appXL.Cells(laligne, 2).value = lers("chmontantHT")
                    totalCharge += nz(lers("chmontantHT"), 0)
                    sousTotCharge += nz(lers("chmontantHT"), 0)
                End If

                appXL.Cells(laligne, laCol).value = lers("chMontantHtLoc")
                sousTotCat += nz(lers("chMontantHtLoc"), 0)
                totalCat += nz(lers("chMontantHtLoc"), 0)

            End While
            appXL.StatusBar = ""

            'sous-total et total du dernier lot, derniere cat
            If laCat <> "" Then
                laligne += 1
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = "Total " & laCat
                    appXL.Cells(laligne, 2).value = totalCharge
                    ligneCharge.Add(laligne + 2)
                End If
                appXL.Cells(laligne, laCol).value = sousTotCat
                appXL.Cells(laligne + 2, laCol).value = totalCat
                ligneCharge.Add(laligne + 3)
            End If

            lers.Close()

            'quadrillage lot
            With appXL.Range(appXL.Cells(3, 3), appXL.Cells(4, laCol))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With
            'quadrillage charges
            For i = 0 To ligneCharge.Count - 2
                With appXL.Range(appXL.Cells(ligneCharge(i), 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With
                appXL.Range(appXL.Cells(ligneCharge(i + 1) - 3, 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol)).Interior.Color = RGB(155, 194, 230)
            Next
            'quadrillage total
            With appXL.Range(appXL.Cells(laligne + 2, 1), appXL.Cells(laligne + 2, laCol))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With
            appXL.Range(appXL.Cells(laligne + 2, 1), appXL.Cells(laligne + 2, laCol)).Interior.Color = RGB(155, 194, 230)

            appXL.ActiveWindow.DisplayGridlines = False

            '**************************************************************
            ''Onglet 2 : Surface Moyenne
            '**************************************************************

            Call StatutBar("Export XL")
            appXL.Sheets.Add(, appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Surface Loc"
            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Surface occupées / Locataire " & Me.lBudget.Text
            appXL.Cells(3, 1).value = "Lots"
            appXL.Cells(3, 2).value = "Batiment"
            appXL.Cells(3, 3).value = "Surface Lot"
            appXL.Cells(3, 4).value = "Locataire"
            appXL.Cells(3, 5).value = "Date Début"
            appXL.Cells(3, 6).value = "DateFin"
            appXL.Cells(3, 7).value = "Nb jour Loc"
            appXL.Cells(3, 8).value = "Nb jour Loc"
            appXL.Cells(3, 9).value = "Surface Louée"
            appXL.Cells(3, 10).value = "Surf. Moy. Louée"
            appXL.Cells(3, 11).value = "Surf. Moy. Louée /Lot"

            appXL.Range(appXL.Cells(3, 1), appXL.Cells(3, 11)).Interior.Color = RGB(155, 194, 230)
            appXL.Columns(1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
            appXL.Columns(1).ColumnWidth = 40
            appXL.ActiveWindow.DisplayGridlines = False

            lelocActu = 0
            laCol = 2
            laligne = 3
            lelotActu = 0

            sSql = "SELECT   lotID, Batiment, TypeLocal, LotNom, LocNom, DateEntree, DateSortie, NbJour, NbJourLotOcc" _
                & " , SurfaceLoc, SurfaceLot, SurfaceMoyLoc, SurfaceMoyLocTot" _
                & " FROM TempRepartLoc ORDER BY lotnom,lotid"

            lers = sqlLit(sSql, conSql)
            lelotActu = 0
            While lers.Read
                laligne += 1
                If lelotActu <> lers("lotid") Then
                    appXL.Cells(laligne, 1).value = lers("Lotnom").ToString
                    appXL.Cells(laligne, 2).value = lers("batiment").ToString
                    appXL.Cells(laligne, 3).value = num2txt(nz(lers("surfaceLot"), 0))
                    lelotActu = lers("lotid")
                End If
                appXL.Cells(laligne, 4).value = nz(lers("Locnom"), "")
                appXL.Cells(laligne, 5).value = date2Xl(lers("DateEntree"))
                appXL.Cells(laligne, 6).value = date2Xl(lers("DateSortie"))
                appXL.Cells(laligne, 7).value = num2txt(nz(lers("NbJour"), 0))
                appXL.Cells(laligne, 8).value = DateDiff(DateInterval.Day, d1, d2) + 1
                appXL.Cells(laligne, 9).value = num2txt(nz(lers("SurfaceLoc"), 0))
                appXL.Cells(laligne, 10).value = num2txt(nz(lers("SurfaceMoyLoc"), 0))
                appXL.Cells(laligne, 11).value = num2txt(nz(lers("SurfaceMoyLocTot"), 0))
            End While
            lers.Close()

            'quadrillage total
            With appXL.Range(appXL.Cells(3, 1), appXL.Cells(laligne, 11))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With

            '**************************************************************
            'Onglet 3 : répartition par LOC
            '**************************************************************

            Dim sousTotLoc As Decimal = 0
            Dim totalLoc As Decimal = 0
            Dim totHono As Decimal = 0
            Dim ChargeApp As Decimal = 0

            'Call StatutBar("Calcul des honoraires")
            'Ajoute les honoraires

            '
            sSql = "update temprepartcharge set loyerHT=0 where soumisHono=0"
            sqlDo(sSql, conSql)

            sSql = "insert into temprepartcharge" _
                & " select   LotId, Batiment, TlocalNom, LotNom, LocOrdre, LocId, LocNom, DateEntree, DateSortie, chId, chlib, chmontantHT, QuotePart, Pro, Loc, Tmp, CleNom, TotalQuotePart, Totalquotepartloc " _
                & " ,NbJour, NbJourAn, NbJourLotOcc, chMontantHtLoc, LoyerHT, ChargeHT,'Honoraires' ,9999,0,BailId,0,0,0,0,0 from " _
                & " (select  LotId, Batiment, TlocalNom, LotNom, LocOrdre, LocId, LocNom, DateEntree, DateSortie, 3 as chid, 'Honoraires ' as chlib" _
                & " ,0 as chmontantHT, 1 as  QuotePart,0 as Pro, 1 as Loc, 0 as Tmp, 'Honoraires' as CleNom, 1 as TotalQuotePart,0 as totalquotepartLoc " _
                & " ,NbJour, NbJourAn, NbJourLotOcc,round( LoyerHT * " & txHono & " /100,2) as chMontantHtloc,LoyerHT, ChargeHT ,BailId,row_number() over( partition by locid order by locid,lotid) as Nlo " _
                & " from temprepartcharge" _
                & " ) as t where t.Nlo=1"
            sqlDo(sSql, conSql)

            sSql = "update TempRepartCharge set chmontantHT = (select sum(chmontantHtLoc) from temprepartcharge where tChCatordre = 9999 )" _
            & " where(tChCatordre = 9999)"
            sqlDo(sSql, conSql)

            Call StatutBar("Export XL")
            appXL.Sheets.Add(, appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Répartition Locataire"
            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges / Locataire " & Me.lBudget.Text
            appXL.Cells(3, 1).value = "Locataire"
            appXL.Cells(4, 1).value = "Appels de Loyer"
            appXL.Cells(6, 2).value = "Montant"
            appXL.Columns(1).ColumnWidth = 40
            appXL.ActiveWindow.DisplayGridlines = False

            lelocActu = -1
            laCol = 2
            laligne = 4
            totalCat = 0
            leBailActu = 0


            sSql = "SELECT  locid, locordre, LocNom, chlib, chmontantHT,sum( chMontantHtLoc) as chmontantHtLoc, tChCatOrdre, tChCatLib,loyerHT,chargeHT" _
            & " FROM TempRepartCharge" _
            & " where locid is not null" _
            & " group by  locordre,batiment, locid,  LocNom, TempRepartCharge.chlib, TempRepartCharge.chmontantHT,  tChCatOrdre, tChCatLib,loyerHT,ChargeHT" _
            & " ORDER BY locordre,batiment, locnom,locid ,tChCatOrdre, tChCatLib,chlib"

            lers = sqlLit(sSql, conSql)
            laCat = ""
            While lers.Read
                If lelocActu <> nz(lers("locId"), 0) Then
                    Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
                    appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")

                    'ecrit le total et les charge du loc précédent
                    If laCol > 2 Then
                        laligne += 2
                        appXL.Cells(laligne, laCol).value = totalLoc
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Total"
                            appXL.Cells(laligne, 2).value = totalCat
                        End If

                        laligne += 2
                        appXL.Cells(laligne, laCol).value = -ChargeApp
                        If laCol = 3 Then appXL.Cells(laligne, 1).value = "Appels de Charges"

                        laligne += 2
                        appXL.Cells(laligne, laCol).value = -ChargeApp + totalLoc
                        If laCol = 3 Then appXL.Cells(laligne, 1).value = "Solde Charges"
                    End If

                    'initialise les variables du loc
                    laligne = 4
                    lelocActu = nz(lers("locId"), 0)
                    laCol += 1
                    appXL.Cells(3, laCol).value = nz(lers("LocNom"), "")
                    appXL.Cells(4, laCol).value = lers("loyerHT")
                    '               ChargeApp = nz(lers("CHargeHT"), 0)
                    sousTotCat = 0
                    sousTotLoc = 0
                    totalLoc = 0
                    totalCharge = 0
                    laCat = ""
                End If

                If laCat <> lers("tChCatLib") Then
                    If laCat <> "" Then
                        laligne += 1
                        appXL.Cells(laligne, laCol).value = sousTotLoc
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = "Sous-Total"
                            appXL.Cells(laligne, 2).value = sousTotCat
                        End If
                    End If

                    laligne += 1
                    If lers("tChCatOrdre") <> 9999 Then
                        laligne += 1
                        appXL.Cells(laligne, 1).value = lers("tChCatLib")
                        appXL.Cells(laligne, 1).Font.Bold = True
                    End If
                    laCat = lers("tChCatLib")
                    sousTotLoc = 0
                    sousTotCat = 0
                End If

                laligne += 1

                'ecrit la 1er colonne
                If laCol = 3 Then
                    appXL.Cells(laligne, 1).value = lers("chlib")
                    appXL.Cells(laligne, 2).value = lers("chmontantHT")
                End If

                appXL.Cells(laligne, laCol).value = lers("chMontantHtLoc")
                sousTotLoc += nz(lers("chMontantHtLoc"), 0)
                totalLoc += nz(lers("chMontantHtLoc"), 0)
                sousTotCat += nz(lers("chMontantHT"), 0)
                totalCat += nz(lers("chMontantHT"), 0)
                ChargeApp = nz(lers("chargeHT"), 0)
            End While
            lers.Close()

            'ecrit le total et les charge du DERNIER loc
            If laCol > 2 Then

                'quadrillage lot
                With appXL.Range(appXL.Cells(3, 3), appXL.Cells(4, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With
                'quadrillage charges
                For i = 0 To ligneCharge.Count - 2
                    With appXL.Range(appXL.Cells(ligneCharge(i), 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol))
                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                    End With
                    appXL.Range(appXL.Cells(ligneCharge(i + 1) - 3, 1), appXL.Cells(ligneCharge(i + 1) - 3, laCol)).Interior.Color = RGB(155, 194, 230)
                Next
                'quadrillage honoraire
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With

                laligne += 2
                appXL.Cells(laligne, laCol).value = totalLoc
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    .Interior.Color = RGB(155, 194, 230)
                End With


                laligne += 2
                appXL.Cells(laligne, laCol).value = ChargeApp
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                End With

                laligne += 2
                appXL.Cells(laligne, laCol).value = ChargeApp - totalLoc
                With appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol))
                    .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    .Borders.Weight = Excel.XlBorderWeight.xlThin
                    .Interior.Color = RGB(155, 194, 230)
                End With
            End If

            'total par ligne
            appXL.Cells(3, laCol + 2).value = "Total"
            appXL.Cells(4, laCol + 2).formula = "=SUM(" & appXL.Range(appXL.Cells(4, 3), appXL.Cells(4, laCol)).Address(False, False) & ")"
            appXL.Cells(4, laCol + 2).Borders.LineStyle = Excel.XlLineStyle.xlContinuous

            For i = 0 To 100
                If nz(appXL.Cells(i + 7, 2).value, "") <> "" Then
                    appXL.Cells(i + 7, laCol + 2).formula = "=SUM(" & appXL.Range(appXL.Cells(i + 7, 3), appXL.Cells(i + 7, laCol)).Address(False, False) & ")"
                    appXL.Cells(i + 7, laCol + 2).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                End If
            Next
            appXL.Cells.NumberFormat = "#,##0.00"

            '**************************************************************
            'Onglet 4 : Vérif Loyer/charges
            '**************************************************************
            appXL.Sheets.Add(, appXL.ActiveSheet)
            appXL.ActiveSheet.name = "Loyers-Charges"
            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Loyers et charges / Locataire " & Me.lBudget.Text
            appXL.Cells(3, 1).value = "Locataire"
            appXL.Cells(3, 2).value = "Date"
            appXL.Cells(3, 3).value = "Libellé"
            appXL.Cells(3, 4).value = "Montant"
            appXL.Cells(3, 5).value = "Catégorie"
            appXL.Cells(3, 6).value = "Loyer"
            appXL.Cells(3, 7).value = "Prov Charges"
            appXL.ActiveWindow.DisplayGridlines = False

            appXL.Columns.ColumnWidth = 14
            appXL.Columns(1).ColumnWidth = 20
            appXL.Columns(3).ColumnWidth = 40
            appXL.Range("A3:G3").Interior.Color = RGB(155, 194, 230)

            laligne = 3
            sSql = "select nom,ecrecheance, ecrlib, -ecrmontantHT as montant,categorie,soumishono from comptagene" _
                & " inner join locataire on locataire.locid=comptagene.locid" _
                & " inner join annuaire on annuaire.persid=locataire.persid" _
                & " where rubrique='LOCATAIRE'  and year(ecrEcheance)= " & Me.lBudget.Text _
                & " and locataire.locid in  (select distinct locid from temprepartloc)" _
                & " order by nom, ecrecheance,ecrlib "
            lers = sqlLit(sSql, conSql)
            While lers.Read
                laligne += 1
                appXL.Cells(laligne, 1).value = lers("nom").ToString
                appXL.Cells(laligne, 2).value = date2Xl(lers("ecrecheance"))
                appXL.Cells(laligne, 3).value = lers("ecrlib").ToString
                appXL.Cells(laligne, 4).value = lers("montant")
                appXL.Cells(laligne, 5).value = lers("categorie").ToString
                If nz(lers("soumishono"), 1) = 1 And lers("categorie") = "LOYER" Then appXL.Cells(laligne, 6).value = lers("montant")
                If lers("categorie") = "PROVCHARGE" Then appXL.Cells(laligne, 7).value = lers("montant")
            End While
            lers.Close()
            appXL.Range("A3:G" & laligne + 1).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            appXL.Cells(3, 1).select()
            appXL.Selection.Subtotal(GroupBy:=1, Function:=Microsoft.Office.Interop.Excel.XlConsolidationFunction.xlSum, TotalList:=New Int32() {6, 7}, Replace:=True, PageBreaks:=False, SummaryBelowData:=True)
            appXL.ActiveSheet.Outline.ShowLevels(RowLevels:=2)
            'laligne += 1
            'appXL.Cells(laligne, 1).value = "Total"
            'appXL.Cells(laligne, 6).formula = "=SUM(F4:F" & laligne - 1 & ")"
            'appXL.Cells(laligne, 7).formula = "=SUM(G4:G" & laligne - 1 & ")"

            '**************************************************************
            'Repart 5+ onglet par locataire
            '**************************************************************
            If RepartLoc = True Then

                Dim locOrdre As Integer = 0
                Dim lelocactuNom As String = ""

                Call StatutBar("Export Locataire")
                sSql = " SELECT    LocNom, chlib, chmontantHT, tChCatOrdre, tChCatLIb, LoyerHT, ChargeHT, LotId, QuotePart, TotalQuotePart" _
                    & ", NbJour, NbJourAn, LotNom, Batiment, TlocalNom, Pro, Loc, Tmp, NbJourLotOcc, chMontantHtLoc,CleLoc,BailId,surfaceMoyLoc,SurfaceLot,SurfaceMoyLocTot,surfaceLoc" _
                    & " FROM TempRepartCharge WHERE LocId <> 0 and tChCatOrdre <> 9999"
                If Not lotZero Then sSql &= " and lotid not in (select lotid from TempRepartCharge  group by lotid  having sum(chMontantHtLoc)=0 )"
                sSql &= " ORDER BY LocNom, lotid,bailId, tChCatOrdre, tChCatLIb, chlib"

                lers = sqlLit(sSql, conSql)
                lelocActu = 0
                laCat = ""
                lelotActu = 0
                leBailActu = 0

                While lers.Read
                    If leBailActu <> nz(lers("BailId"), 0) Or laCat <> lers("tChCatLib") Then

                        'Mise en forme catégorie précédente
                        If laCat <> "" Then
                            laligne += 1
                            If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                            appXL.Cells(laligne, laCol + 2).value = sousTotCat
                            sousTotCat = 0
                        End If

                        If leBailActu <> nz(lers("BailId"), 0) Then
                            'Mise en forme Lot précédent
                            If lelotActu <> 0 Then
                                If laCol = 3 Then ligneCharge.Add(laligne + 2)
                                laligne += 2
                                appXL.Cells(laligne, laCol + 2).value = totalCharge
                                appXL.Cells(laligne, 1).value = "'Total Lot"
                            End If

                            If lelocactuNom <> lers("LocNom") Then
                                'Mise en forme ANciel loc
                                If lelocactuNom <> "" Then

                                    With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 2))
                                        .Interior.Color = RGB(155, 194, 230)
                                        .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                        .Borders.Weight = Excel.XlBorderWeight.xlThin
                                    End With

                                    appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 2)).Interior.Color = RGB(155, 194, 230)

                                    For i = 0 To ligneCharge.Count - 2
                                        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2))
                                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                                        End With
                                        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2)).Interior.Color = RGB(155, 194, 230)
                                    Next

                                End If
                                'Mise en forme Nouveau Loc
                                locOrdre += 1
                                Call StatutBar("Locataire : " & nz(lers("LocNom"), ""))
                                appXL.StatusBar = "Locataire : " & nz(lers("LocNom"), "")
                                appXL.Sheets.Add(, appXL.ActiveSheet)
                                Dim n As String = locOrdre & "." & lers("LocNom").ToString
                                If n.Length > 25 Then n = n.Substring(0, 25)
                                appXL.ActiveSheet.name = n
                                appXL.Columns.ColumnWidth = 15
                                appXL.Columns(1).ColumnWidth = 40
                                appXL.ActiveWindow.DisplayGridlines = False
                                appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Répartition charges " & Me.lBudget.Text & " / " & lers("LocNom")
                                appXL.Range("A3").Value = "'Lot"
                                appXL.Range("A4").Value = "'Type Lot"

                                'initialise les variables du loc
                                ligneCharge.Clear()
                                laligne = 6
                                lelocactuNom = nz(lers("locNom"), 0)
                                lelotActu = 0
                                leBailActu = nz(lers("BailId"), 0)
                                laCol = 0
                                totalCharge = 0
                                laCat = ""
                                sousTotCat = 0
                            End If

                            'Mise en forme nouveau lot
                            laligne = 5
                            laCol += 3
                            appXL.Cells(3, laCol).value = "'" & lers("LotNom") & " - " & lers("Batiment")
                            appXL.Cells(4, laCol).value = "'" & lers("TlocalNom")
                            appXL.Columns(laCol).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Columns(laCol + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).Merge()
                            appXL.Range(appXL.Cells(3, laCol), appXL.Cells(3, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).Merge()
                            appXL.Range(appXL.Cells(4, laCol), appXL.Cells(4, laCol + 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                            appXL.Cells(laligne, laCol).value = "'Quote-Part"
                            appXL.Cells(laligne, laCol + 1).value = "'Prorata Surface"
                            appXL.Cells(laligne, laCol + 2).value = "'Montant Lot"
                            lelotActu = nz(lers("lotid"), 0)
                            leBailActu = nz(lers("BailId"), 0)
                            totalCharge = 0
                            sousTotCat = 0

                        End If

                        'Mise en forme  nouvelle catéorie
                        laligne += 2
                        laCat = lers("tChCatLib")
                        If laCol = 3 Then
                            appXL.Cells(laligne, 1).value = lers("tChCatLib")
                            appXL.Cells(laligne, 1).Font.Bold = True
                            ligneCharge.Add(laligne)
                        End If
                    End If

                    laligne += 1

                    'ecrit la 1er colonne
                    If laCol = 3 Then
                        appXL.Cells(laligne, 1).value = lers("chlib")
                        appXL.Cells(laligne, 2).value = lers("chmontantHT")
                    End If


                    If lers("CleLoc") = 0 Then
                        appXL.Cells(laligne, laCol).value = "'" & nz(lers("QuotePart"), 0) & " / " & nz(lers("TotalQuotePart"), 0)

                        If lers("Loc") = True Then
                            appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceMoyLocTot"), 0)
                        Else
                            appXL.Cells(laligne, laCol + 1).value = "'" & nz(lers("SurfaceMoyLoc"), 0) & " / " & nz(lers("SurfaceLot"), 0)
                        End If
                    End If

                    appXL.Cells(laligne, laCol + 2).value = lers("chMontantHtLoc")

                    totalCharge += nz(lers("chMontantHtLoc"), 0)
                    sousTotCat += nz(lers("chMontantHtLoc"), 0)

                End While
                lers.Close()

                'mise en forme dernier loc
                If lelocactuNom <> "" Then
                    'Mise en forme derniere catégorie
                    If laCat <> "" Then
                        laligne += 1
                        If laCol = 3 Then appXL.Cells(laligne, 1).value = "Total " & laCat
                        appXL.Cells(laligne, laCol + 2).value = sousTotCat
                        sousTotCat = 0
                        ligneCharge.Add(laligne + 2)
                    End If

                    'Mise en forme dernier lot
                    If lelotActu <> 0 Then
                        laligne += 2
                        appXL.Cells(laligne, laCol + 2).value = totalCharge
                        appXL.Cells(laligne, 1).value = "'Total Lot"

                        With appXL.Range(appXL.Cells(3, 3), appXL.Cells(5, laCol + 2))
                            .Interior.Color = RGB(155, 194, 230)
                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                        End With

                        appXL.Range(appXL.Cells(laligne, 1), appXL.Cells(laligne, laCol + 2)).Interior.Color = RGB(155, 194, 230)

                    End If

                    'Mise en forme dernier loc
                    For i = 0 To ligneCharge.Count - 2
                        With appXL.Range(appXL.Cells(ligneCharge(i) + 1, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2))
                            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            .Borders.Weight = Excel.XlBorderWeight.xlThin
                        End With
                        appXL.Range(appXL.Cells(ligneCharge(i + 1) - 2, 1), appXL.Cells(ligneCharge(i + 1) - 2, laCol + 2)).Interior.Color = RGB(155, 194, 230)
                    Next
                End If
            End If

            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            StatutBar("")
            appXL.StatusBar = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub repartChargeVide()

        Try

            Dim sSql As String
            Dim lers As OleDb.OleDbDataReader
            Dim lan As String = Now.AddYears(-1).Year.ToString
            Dim d1 As Date = CDate("01/01/" & lan)
            Dim d2 As Date = CDate("31/12/" & lan)

            StatutBar("MAZ table temporaire")
            sqlDo("truncate table tempRepartLoc", conSql)

            StatutBar("Recherche lots/locataires")
            sSql = "insert into tempRepartLoc SELECT lot.coproid," & Me.lBudget.Text & ", Lot.LotId , Lot.Batiment, TypeLocal.TlocalNom" _
            & " ,Lot.LotNom, 1,locataire.locid,Annuaire.Nom, location.dateDebut, location.datefin,0,0,location.BailId,location.surface,lot.surface,0,0,soumisHono" _
            & " FROM  Lot " _
            & " LEFT OUTER JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
            & " left outer join location on location.lotid = lot.lotid" _
            & " left outer join locataire on location.locid = locataire.locid" _
            & " left outer join annuaire on annuaire.persid = locataire.persid" _
            & " WHERE Lot.CoproId =" & Me.lacoproId
            sqlDo(sSql, conSql)

            'efface les loc non concernés
            sSql = "delete from tempRepartLoc where dateentree >" & Date2sql(d2) & " or datesortie<" & Date2sql(d1)
            sqlDo(sSql, conSql)

            'MAJ date entree
            StatutBar("Calcul des dates")
            sSql = "update tempRepartLoc set dateentree =" & Date2sql(d1) & " where dateentree<" & Date2sql(d1)
            sqlDo(sSql, conSql)
            'MAJ date entree
            sSql = "update tempRepartLoc set datesortie = " & Date2sql(d2) & " where datesortie is null or datesortie>" & Date2sql(d2)
            sqlDo(sSql, conSql)

            'calcul nb jours
            StatutBar("Calcul des périodes")
            sSql = "update tempRepartLoc set nbjour = datediff(dd,dateentree,datesortie)+1, nbjourLotocc=" & DateDiff(DateInterval.Day, d1, d2) + 1
            sqlDo(sSql, conSql)

            StatutBar("Calcul des périodes d'occupation")
            sSql = " Update temprepartloc set nbjourlotocc =  ( select sum(nbjour) as tot from temprepartloc as T2" _
                & " where temprepartloc.lotid = T2.lotid group by lotid ) "
            sqlDo(sSql, conSql)
            sSql = "update tempRepartLoc set nbjourlotocc = 0 where nbjourlotocc is null"
            sqlDo(sSql, conSql)

            'calcul surface moyenne loc
            sSql = "update tempRepartLoc set surfaceMoyLoc = surfaceloc/" & DateDiff(DateInterval.Day, d1, d2) + 1 & " * nbjour"
            sqlDo(sSql, conSql)
            sSql = " Update temprepartloc set surfaceMoyLocTot =  ( select sum(surfaceMoyLoc) as tot from temprepartloc as T2" _
                & " where temprepartloc.lotid = T2.lotid group by lotid ) "
            sqlDo(sSql, conSql)


            StatutBar("Lancement Excel")

            Dim appXL As New Microsoft.Office.Interop.Excel.Application
            Dim laLigne As Integer
            Dim nbJourAn As Integer = DateDiff(DateInterval.Day, d1, d2) + 1

            appXL.Workbooks.Add()
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
            appXL.Visible = True

            StatutBar("Export Excel")

            'Onglet 1 : répartition par lot

            appXL.Range("A1").Value = "'" & Me.lCopro.Text & " - Modèle calcul " & Me.lBudget.Text
            appXL.ActiveSheet.name = "Répartition Lot"
            appXL.Cells(3, 1).value = "Lot"
            appXL.Cells(3, 2).value = "Batiment"
            appXL.Cells(3, 3).value = "Type Lot"
            appXL.Cells(3, 4).value = "Locataire"
            appXL.Cells(3, 5).value = "Début"
            appXL.Cells(3, 6).value = "Fin"
            appXL.Cells(3, 7).value = "Nb Jour Loc"
            appXL.Cells(3, 8).value = "Nb Jours loc / Lot"
            appXL.Cells(3, 9).value = "Nb Jours an"
            appXL.Cells(3, 10).value = "Surface Louée"
            appXL.Cells(3, 11).value = "Surface Lot"
            appXL.Cells(3, 12).value = "Surf. Moy. Louée"
            appXL.Cells(3, 13).value = "Surf. Moy louée / Lot"


            sSql = "SELECT lotID, Batiment, typelocal,LotNom, LocNom, DateEntree, DateSortie, NbJour" _
                & " , NbJourLotOcc, SurfaceLoc, SurfaceLot, SurfaceMoyLoc, SurfaceMoyLocTot FROM  TempRepartLoc order by lotnom, lotid"
            lers = sqlLit(sSql, conSql)
            laLigne = 3
            While lers.Read
                laLigne += 1
                appXL.Cells(laLigne, 1).value = lers("LotNom")
                appXL.Cells(laLigne, 2).value = lers("Batiment")
                appXL.Cells(laLigne, 3).value = lers("TypeLocal")
                appXL.Cells(laLigne, 4).value = lers("LocNom")
                appXL.Cells(laLigne, 5).value2 = date2Xl(lers("DateEntree"))
                appXL.Cells(laLigne, 6).value2 = date2Xl(lers("DateSOrtie"))
                appXL.Cells(laLigne, 7).value = lers("Nbjour")
                appXL.Cells(laLigne, 8).value = lers("NbJourLotOcc")
                appXL.Cells(laLigne, 9).value = nbJourAn
                appXL.Cells(laLigne, 10).value = lers("SurfaceLoc")
                appXL.Cells(laLigne, 11).value = lers("SurfaceLot")
                appXL.Cells(laLigne, 12).value = lers("SurfaceMoyLoc")
                appXL.Cells(laLigne, 13).value = lers("SurfaceMoyLocTot")
            End While
            appXL.StatusBar = ""

            'quadrillage total
            With appXL.Range(appXL.Cells(3, 1), appXL.Cells(laLigne, 13))
                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                .Borders.Weight = Excel.XlBorderWeight.xlThin
            End With
            With appXL.Range(appXL.Cells(3, 1), appXL.Cells(3, 13))
                .HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                .VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
                .WrapText = True
            End With


            appXL.ActiveWindow.DisplayGridlines = False
            appXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationAutomatic

            StatutBar("")
            appXL.StatusBar = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click_2(sender As System.Object, e As System.EventArgs) Handles bRepart.Click
        If Me.lBudget.SelectedIndex < 0 Then Exit Sub
        If F_CoproHono.ShowDialog = Windows.Forms.DialogResult.OK Then
            '   Call repartCharge(num2sql(F_CoproHono.TextBox1.Text), F_CoproHono.cRepartLoc.Checked, F_CoproHono.cLotZero.Checked)
            Call repartChargev2(num2sql(F_CoproHono.TextBox1.Text), F_CoproHono.cBudget.Checked)
            Call RepartchargeEdite(F_CoproHono.cRepartLoc.Checked, F_CoproHono.cLotZero.Checked, F_CoproHono.cBudget.Checked)
            Me.bCloture.Enabled = True
        End If
    End Sub

    Private Sub lChBudget_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Call ListeCoproCharge()
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles bDelCharge.Click
        Dim sSql As String
        If MessageBox.Show("Supprimer cette charge ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            If Me.gChargeCopro.SelectedRows.Count < 1 Then Exit Sub
            sSql = "delete from Coprocharge where chid=" & Me.gChargeCopro.SelectedRows(0).Cells("chid").Value
            sqlDo(sSql, conSql)
            Call ListeCoproCharge()
        End If
    End Sub

    Private Sub bAddCharge_Click(sender As System.Object, e As System.EventArgs) Handles bAddCharge.Click

        If Me.lacoproId = 0 Then Exit Sub
        F_CoproCharge.lacoproId = Me.lacoproId
        If Me.lBudget.SelectedIndex >= 0 Then
            F_CoproCharge.lebudgetId = Me.lBudget.SelectedItem.value
        Else
            F_CoproCharge.lebudgetId = 0
        End If

        If F_CoproCharge.ShowDialog = Windows.Forms.DialogResult.OK Then ListeCoproCharge()
        F_CoproCharge.Dispose()
    End Sub

    Private Sub gChargeCopro_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gChargeCopro.CellDoubleClick
        F_CoproCharge.lacoproId = Me.lacoproId
        F_CoproCharge.laChargeId = Me.gChargeCopro.SelectedRows(0).Cells("chid").Value
        If F_CoproCharge.ShowDialog = Windows.Forms.DialogResult.OK Then ListeCoproCharge()
        F_CoproCharge.Dispose()
    End Sub

    Private Sub gChargeCopro_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gChargeCopro.KeyUp
        If e.KeyCode = Keys.F2 Then gChargeCopro_CellDoubleClick(Nothing, Nothing)
    End Sub


    Sub Gridfiltre(laGrilleLoc As Boolean)

        Dim leFiltre As String = ","

        For i = 0 To Me.gTypeLocal.Rows.Count - 1
            If Me.gTypeLocal.Rows(i).Cells(1).Value = True Then leFiltre &= Me.gTypeLocal.Rows(i).Cells(2).Value & ","
        Next

        If laGrilleLoc Then

            For i = 0 To Me.gCleLoc.Rows.Count - 1
                Me.gCleLoc.Rows(i).Visible = leFiltre.Contains("," & Me.gCleLoc.Rows(i).Cells("TypelotLoc").Value & ",")
            Next
        Else
            For i = 0 To Me.gCle.Rows.Count - 1
                Me.gCle.Rows(i).Visible = leFiltre.Contains("," & Me.gCle.Rows(i).Cells("Typelot").Value & ",")
            Next
        End If

        Call totalQuote()
    End Sub

    Private Sub bRafraichir_Click(sender As System.Object, e As System.EventArgs) Handles bRafraichir.Click
        Call Gridfiltre(Me.gCleLoc.Visible)
    End Sub

    Private Sub gCle_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCle.CellValidated
        Call totalQuote()
    End Sub

    Private Sub gCleLoc_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gCleLoc.CellValidated
        Call totalQuote()
    End Sub


    Private Sub Button3_Click_2(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call repartChargeVide()
    End Sub


    Private Sub bCloture_Click(sender As System.Object, e As System.EventArgs) Handles bCloture.Click

        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim lapiece As Integer

        If MessageBox.Show("Cloturer " & Me.lBudget.Text & " ?", "Attention", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call StatutBar("Archivage cloture")
            'efface l'ancienne cloture
            sSql = "delete  from  comptagene where numfacture like 'T%'"
            sqlDo(sSql, conSql)
            sSql = "delete from repartcharge where coproid=" & Me.lacoproId & " and annee = " & Me.lBudget.Text
            sqlDo(sSql, conSql)
            sSql = "delete from repartloc where coproid=" & Me.lacoproId & " and annee = " & Me.lBudget.Text
            sqlDo(sSql, conSql)

            'archive les ecritures
            sSql = "insert into repartcharge select * from temprepartcharge"
            sqlDo(sSql, conSql)
            sSql = "insert into repartloc select * from temprepartloc"
            sqlDo(sSql, conSql)


            'Ecrit les écritures sur chaque locataire
            sSql = "select locid, sum(chmontantHtLoc) as montantHT ,chargeHT  from repartcharge" _
            & " where(LocId <> 0 And LocId Is Not null) " _
            & " and coproid=" & Me.lacoproId _
            & " and annee=" & Me.lBudget.Text _
            & " group by locid,chargeht" _
            & " order by locid"
            lers = sqlLit(sSql, conSql)
            While lers.Read
                Call StatutBar("Ecriture sur Loc " & lers("locid"))
                lapiece = NextNumPiece()
                Dim lecr As New EcritureCompta(Now, Now, lapiece, lers("locid"), Me.lacoproId, 0, 0, Me.tSocId.Text, 0, 0, 9, "Reprise Prov. Charges " & Me.lBudget.Text, -lers("ChargeHT"), -Math.Round(lers("ChargeHT") * 1.2, 2), 100, "T" & lers("locid").ToString, Now, Now, 0, "", Now.Year, 2)
                Call EnregCompta(lecr, ecrType.ChargeReprise)

                Call StatutBar("Loc " & lers("locid"))
                lecr.MontantHT = lers("montantHT")
                lecr.MontantTTC = Math.Round(lers("montantHT") * 1.2, 2)
                lecr.Libelle = "Charge réelles " & Me.lBudget.Text
                Call EnregCompta(lecr, ecrType.ChargeReel)

                lapiece += 1
            End While
            lers.Close()
            Call StatutBar("")
            MessageBox.Show("Cloture terminée", "Attention", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Me.lBudget.Text = "" Then Exit Sub

        If MessageBox.Show("Rééditer la cloture du budget " & Me.lBudget.Text & " ?", "Rééditer cloture", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Dim ssql As String
            ssql = "truncate table temprepartloc"
            sqlDo(ssql, conSql)
            ssql = "truncate table temprepartcharge"
            sqlDo(ssql, conSql)
            ssql = "insert into temprepartloc select * from repartloc" _
                & " where coproid = " & Me.lacoproId & " and annee=" & Me.lBudget.Text
            sqlDo(ssql, conSql)
            ssql = "insert into temprepartcharge select * from repartcharge" _
                & " where coproid = " & Me.lacoproId & " and annee=" & Me.lBudget.Text
            sqlDo(ssql, conSql)
            Call RepartchargeEdite(F_CoproHono.cRepartLoc.Checked, F_CoproHono.cLotZero.Checked, False)
        End If



    End Sub

    Private Sub tTotalQuote_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTotalQuote.TextChanged

    End Sub
End Class