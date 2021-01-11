Imports System.IO

Public Class F_ClientSuivi
    Public leTiersId As Integer


    Sub ListeClient()
        Dim sSql As String
        sSql = "SELECT locid, nom" _
        & " FROM locataire INNER JOIN Annuaire ON locataire.PersId = Annuaire.PersId " _
        & " where typeloc=2  and nom like '%" & Me.tRech.Text & "%'"

        Me.lCLient.Items.Clear()
        Call ComboRempli(sSql, Me.lCLient, conSql)

        If Me.lCLient.Items.Count = 1 Then
            Me.lCLient.SelectedIndex = 0
            Call afficheClient()
        End If
    End Sub

    Sub comptaClient()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim ladate As Date

        Try
            sSql = "SELECT ecrId,numPiece, numfacture, ecrDate, ecrLib, ecrMontantTTC FROM ComptaGene" _
            & " where Tiers='CLIENT' and locid= " & Me.lCLient.SelectedItem.value & " order by ecrDate desc"

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

        Me.leTiersId = Me.lCLient.SelectedItem.value
        Call FormRempli(Me.gClient, "SELECT locid, PersId, CptSuffixe FROM locataire where locid=" & Me.leTiersId, conSql)

        StatutBar("Compta")
        Call comptaClient()

        StatutBar("Documents")
        Call DocListe(docType.Client, Me.leTiersId, Me.gDoc)

        Me.oOnglet.Enabled = True
        F_main.sLabel.Text = ""
    End Sub

    Private Sub F_Locat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.tRech.Text = ""
        Try
            Call ListeClient()

            If Me.leTiersId > 0 Then
                Me.tRech.Text = ""
                Call ComboSelectValue(Me.leTiersId, Me.lCLient)
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

    Private Sub tRech_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tRech.KeyUp
        If e.KeyCode = Keys.Enter Then Call ListeClient()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles mnuNouveau.Click
        If F_ClientNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call ListeClient()
            Call ComboSelectValue(F_ClientNew.leCliId, Me.lCLient)
            '    Me.oOnglet.SelectTab("Contrats")
        End If
    End Sub

    Private Sub gCompta_Sorted(sender As Object, e As System.EventArgs) Handles gCompta.Sorted
        If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        F_Document.leDocType = docType.Client
        F_Document.lId = Me.leTiersId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Client, Me.leTiersId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Client, Me.leTiersId, Me.gDoc)
    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If Me.leTiersId = 0 Then Exit Sub
        F_ClientEncaissement.leTiersId = Me.leTiersId
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


    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Me.leTiersId = 0 Then Exit Sub
        F_FactureClient.leTiersid = Me.leTiersId
        If F_FactureClient.ShowDialog = Windows.Forms.DialogResult.OK Then
            comptaClient()
        End If
        F_FactureClient.Dispose()
    End Sub

    Private Sub bEditFacture_Click(sender As System.Object, e As System.EventArgs) Handles bEditFActure.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub
        If Me.gCompta.SelectedRows(0).Cells("numFacture").Value = "" Then Exit Sub
        If MessageBox.Show("Editer la Facture '" & Me.gCompta.SelectedRows(0).Cells("numFacture").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call FactureEdition(Me.gCompta.SelectedRows(0).Cells("numfacture").Value)
        End If
    End Sub

End Class