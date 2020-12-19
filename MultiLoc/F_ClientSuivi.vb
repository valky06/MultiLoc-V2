Imports System.IO
Public Class F_ClientSuivi
    Public leCliId As Integer


    Sub ListeClient()
        Dim sSql As String
        sSql = "SELECT cliId, nom" _
        & " FROM client INNER JOIN Annuaire ON client.PersId = Annuaire.PersId" _
        & " where nom like '%" & Me.tRech.Text & "%'"

        Me.lCLient.Items.Clear()
        Call ComboRempli(sSql, Me.lCLient, conSql)

        If Me.lCLient.Items.Count = 1 Then
            Me.lCLient.SelectedIndex = 0
            Call afficheClient()
        End If
    End Sub


    Sub listeContrat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        sSql = "SELECT Contrat.contratId, DateDebut, DateFinPrev, DateFin, MontantHT, count(ContratEmplacement.EmpId) AS NBEmp" _
        & " FROM Contrat LEFT JOIN ContratEmplacement ON Contrat.ContratId = ContratEmplacement.ContratId" _
        & " where cliid=" & Me.leCliId _
        & " GROUP BY Contrat.contratId, DateDebut, DateFinPrev, DateFin, MontantHT"

        Me.gContrat.Rows.Clear()
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gContrat.Rows.Add(lers("contratId"), "E" & lers("contratId").ToString.PadLeft(5, "0"), date2Grid(lers("dateDebut")), date2Grid(lers("dateFinPrev")), date2Grid(lers("dateFin")), lers("MontantHT").ToString, lers("nbEmp").ToString)
        End While
    End Sub



    Sub comptaClient()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim ladate As Date

        Try
            sSql = "SELECT ecrId,numPiece, numfacture, ecrDate, ecrLib, ecrMontantTTC FROM ComptaGene" _
            & " where rubrique='CLIENT' and cliId= " & Me.lCLient.SelectedItem.value & " order by ecrDate desc"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
                credit = IIf(lers("ecrmontantTTC") >= 0, lers("ecrmontantTTC"), 0)
                ladate = lers("ecrDate")
                Me.gCompta.Rows.Add(lers("ecrId"), lers("NumPiece").ToString, ladate.ToString("yyyy-MM-dd"), lers("NumFacture").ToString, lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub afficheClient()

        Me.leCliId = Me.lCLient.SelectedItem.value
        Call FormRempli(Me.gBail, "SELECT cliId, PersId, TRgtId, TPerId,  CptSuffixe FROM Client where cliid=" & Me.leCliId, conSql)

        StatutBar("Client")
        Call listeContrat()

        StatutBar("Compta")
        Call comptaClient()

        StatutBar("Documents")
        Call DocListe(docType.Client, Me.leCliId, Me.gDoc)

        Me.oOnglet.Enabled = True
        F_main.sLabel.Text = ""
    End Sub

    Private Sub F_Locat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.tRech.Text = ""
        Try
            Call ListeClient()
            StatutBar("Type Période")
            Call ComboRempli("select tperId,tperNom from typePEriode", Me.lTypePer, conSql)

            StatutBar("Type Règlement")
            Call ComboRempli("select tRgtId,tRgtNom from typeReglement", Me.lTypeRgt, conSql)


            If Me.leCliId > 0 Then
                Me.tRech.Text = ""
                Call ComboSelectValue(Me.leCliId, Me.lCLient)
            End If
            F_main.sLabel.Text = ""
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        If Me.lCLient.SelectedIndex < 0 Then Exit Sub
        Select Case oOnglet.SelectedTab.Text
            Case "Ecritures" : Call XLexport(Me.gCompta, "Ecritures : " & Me.lCLient.Text)
            Case "Contrats" : Call XLexport(Me.gContrat, "Contrats : " & Me.lCLient.Text)
        End Select
      End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bWord.Click
        Dim ssql As String
        ssql = "SELECT nom, Adr1, CodePostal, Localite, telbureau, fax FROM Annuaire where persId=" & Me.tPersId.Text
        Call wordFusionSQL("client.docx", ssql)
    End Sub

    Private Sub lproprio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lCLient.SelectedIndexChanged
        If Me.lCLient.SelectedIndex >= 0 Then Call afficheClient()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs)
        Call FormEnreg(Me.gBail, "locataire", conSql)
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.gContrat.Rows.Count < 1 Then Exit Sub

        Dim ssql As String
        Dim lesLot As String = ""
        Dim lers As OleDb.OleDbDataReader

        If Me.tLocId.Text <> "" Then
            Try
                lesLot = ""
                ssql = "SELECT Emplacement FROM ContratEmplacement " _
                    & " left join emplacement  ON ContratEmplacement.empId = emplacement.empId" _
                    & " where contratId = " & Me.gContrat.SelectedRows(0).Cells("contratId").Value
                lers = sqlLit(ssql, conSql)
                While lers.Read
                    lesLot &= lers("emplacement").ToString & ","
                End While
                lers.Close()


                ssql = "SELECT nom, Adr1, CodePostal,'" & Me.gContrat.SelectedRows(0).Cells("contratNom").Value & "' as NumContrat,Localite, TRgtNom, TPerNom, '" & lesLot & "' as lesEmp, datedebut,datefinprev,montantHt,MontantTTC,contrat.tauxTVA" _
                & " FROM client LEFT JOIN Annuaire ON client.PersId = Annuaire.PersId" _
                & " left join contrat on contrat.cliId = client.cliId" _
                & "  LEFT JOIN TypePeriode ON client.TPerId = TypePeriode.TPerId" _
                & " LEFT JOIN TypeReglement ON client.TRgtId = TypeReglement.TRgtID " _
                & " where contratid=" & Me.gContrat.SelectedRows(0).Cells("contratId").Value

                Call wordFusionSQL("ClientContrat.docx", ssql)
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub tRech_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tRech.KeyUp
        If e.KeyCode = Keys.Enter Then Call ListeClient()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If F_LocaNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call ListeClient()
            Call ComboSelectValue(F_LocaNew.leLocId, Me.lCLient)
            Me.oOnglet.SelectTab("Bail")
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        F_TypeListe.laForm = F_TypePeriode
        F_TypeListe.MOdeEdit = False

        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT TPerid, TPernom FROM TypePeriode", Me.lTypePer, conSql)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        F_TypeListe.laForm = F_TypeReglement
        F_TypeListe.MOdeEdit = False

        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT TRgtid, TRgtnom FROM TypeReglement", Me.lTypeRgt, conSql)
    End Sub

    Private Sub NouveauToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles mnuNouveau.Click
        If F_ClientNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call ListeClient()
            Call ComboSelectValue(F_ClientNew.leCliId, Me.lCLient)
            Me.oOnglet.SelectTab("Contrats")
        End If
    End Sub

    Private Sub gCompta_Sorted(sender As Object, e As System.EventArgs) Handles gCompta.Sorted
        If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        F_Document.leDocType = docType.Client
        F_Document.lId = Me.leCliId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Client, Me.leCliId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Client, Me.leCliId, Me.gDoc)
    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If Me.leCliId = 0 Then Exit Sub
        F_ClientEncaissement.leCliId = Me.leCliId
        If F_ClientEncaissement.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call comptaClient()
        End If
        F_ClientEncaissement.Dispose()
    End Sub

    Private Sub bRech_Click(sender As System.Object, e As System.EventArgs) Handles bRech.Click
        Call ListeClient()
    End Sub



    Private Sub kLocataire_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles kLocataire.LinkClicked
        If Me.tPersId.Text <> "" Then
            F_pers.lID = txt2num(Me.tPersId.Text)
            If F_pers.ShowDialog() = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("numpiece").Value)
            Call comptaClient()
        End If
    End Sub

    Private Sub Button2_Click_2(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call FormEnreg(Me.gBail, "client", conSql)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        F_ClientContrat.leCliId = Me.leCliId
        F_ClientContrat.leContratId = 0
        If F_ClientContrat.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeContrat()
        End If
    End Sub


    Private Sub gContrat_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gContrat.CellDoubleClick
        If Me.gContrat.SelectedRows.Count = 0 Then Exit Sub

        F_ClientContrat.leCliId = Me.leCliId
        F_ClientContrat.leContratId = Me.gContrat.SelectedRows(0).Cells("contratId").Value
        If F_ClientContrat.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeContrat()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("Effacer le contrat ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            sqlDo("delete from contratEmplacement where contratId=" & Me.gContrat.SelectedRows(0).Cells("COntratID").Value, conSql)
            sqlDo("delete from contrat where contratId=" & Me.gContrat.SelectedRows(0).Cells("COntratID").Value, conSql)
            Call listeContrat()
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If Me.gContrat.SelectedRows.Count = 0 Then Exit Sub
        F_ClientAppMensuel.leContratID = Me.gContrat.SelectedRows(0).Cells("contratId").Value
        If F_ClientAppMensuel.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call comptaClient()
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Me.leCliId = 0 Then Exit Sub
        F_ClientCharge.lecliid = Me.leCliId
        F_ClientCharge.FactInterne = True
        If F_ClientCharge.ShowDialog = Windows.Forms.DialogResult.OK Then
            comptaClient()
        End If
        F_ClientCharge.Dispose()
    End Sub

    Private Sub bEditFacture_Click(sender As System.Object, e As System.EventArgs) Handles bEditFActure.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub
        If Me.gCompta.SelectedRows(0).Cells("numFacture").Value = "" Then Exit Sub
        If MessageBox.Show("Editer la Facture '" & Me.gCompta.SelectedRows(0).Cells("numFacture").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call FactureEdition(Me.gCompta.SelectedRows(0).Cells("numfacture").Value, docType.Client, 0, leCliId)
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click



        If Me.gContrat.Rows.Count < 1 Then Exit Sub

        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim appXL As New Microsoft.Office.Interop.Excel.Application

        For i = 0 To Me.gContrat.Rows.Count - 1
            sSql = "SELECT ContratId, Emplacement,ContratEmplacement.empid FROM ContratEmplacement " _
            & "INNER JOIN Emplacement ON ContratEmplacement.EmpId = Emplacement.empId" _
            & " where contratId=" & Me.gContrat.Rows(i).Cells("COntratId").Value
            lers = sqlLit(sSql, conSql)
            While lers.Read
                appXL.Workbooks.Add(My.Settings.ChemModeleOffice & "Etiquette.xlsx")
                appXL.Visible = True
                'recherche la cellule Client
                appXL.Range("NumClient").Value = "'" & Me.lCLient.SelectedItem.value
                appXL.Range("NomClient").Value = "'" & Me.lCLient.SelectedItem.text
                appXL.Range("Contrat").Value = "'" & "E" & lers("contratId").ToString.PadLeft(5, "0")
                appXL.Range("ContratCode").Value = "'" & code128("E" & lers("contratId").ToString.PadRight(5, "0"))
                appXL.Range("Emplacement").Value = "'" & lers("emplacement").ToString
                appXL.Range("EmplacementCode").Value = "'" & code128("E" & lers("contratId").ToString.PadRight(5, "0") & "- " & lers("emplacement").ToString)
                appXL.Range("A1").Select()
            End While
        Next

        appXL.Visible = True
        appXL.UserControl = True

    End Sub


End Class