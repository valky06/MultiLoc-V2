Imports System.IO
Public Class F_FourSuivi

    Public leFourId As Integer

    Sub ListeFour()
        Dim sSql As String
        sSql = "SELECT distinct FourId, Annuaire.nom FROM Annuaire inner join comptagene ON Annuaire.PersId = comptagene.fourid"
        Me.lFour.Items.Clear()
        Call ComboRempli(sSql, Me.lFour, conSql)

    End Sub

    Sub ComptaFour()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim ladate As Date
        Dim lEcheance As Date
        Dim vEchance As String = ""

        Try
            sSql = "SELECT ecrId, numPiece, ecrDate, ecrEcheance, ecrLib, ecrMontantTTC,numfacture" _
            & " FROM ComptaGene " _
            & " where tiers='FOURNISSEUR' and fourid= " & leFourId & " order by ecrDate desc"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrmontantTTC") > 0, lers("ecrmontantTTC"), 0)
                credit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
                ladate = lers("ecrDate")
                lEcheance = nz(lers("ecrEcheance"), CDate("01/01/1900"))
                Me.gCompta.Rows.Add(lers("ecrId"), lers("NumPIece").ToString, ladate.ToString("yyyy-MM-dd"), lers("numfacture").ToString, IIf(lEcheance.Year > 2000, lEcheance.ToString("yyyy-MM-dd"), ""), lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub afficheFour()
        leFourId = Me.lFour.SelectedItem.value
        'sSql = "SELECT persId from annuaire where persid=" & leFourId
        'lers = sqlLit(sSql, conSql)
        'While lers.Read
        '    Me.kPersId.Text = lers("persId")
        'End While
        'lers.Close()

        Call FormRempli(Me.gCoord, "SELECT nom, Adr1, CodePostal, Localite, telbureau, fax FROM Annuaire where persId=" & leFourId, conSql)
        Call listecontact(Me.gContact, leFourId)
        Call ComptaFour()
        Call DocListe(docType.Four, leFourId, Me.gDoc)

        Me.oOnglet.Enabled = True
    End Sub

    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ListeFour()
        If Me.leFourId <> 0 Then
            Call ComboSelectValue(leFourId, Me.lFour)
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bWord.Click
        Dim ssql As String
        ssql = "SELECT nom, Adr1, CodePostal, Localite, telbureau, fax FROM Annuaire where persId=" & kPersId.Text
        Call wordFusionSQL("Fournisseeur.docx", ssql)
    End Sub


    Private Sub lproprio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lFour.SelectedIndexChanged
        Call afficheFour()
    End Sub



    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        F_Document.leDocType = docType.Four
        F_Document.lId = leFourId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Four, leFourId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Four, leFourId, Me.gDoc)
    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        F_FourReglement.leFourId = Me.leFourId
        If F_FourReglement.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call ComptaFour()
        End If
        F_FourReglement.Dispose()
    End Sub

    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("numpiece").Value)
            Call ComptaFour()
        End If
    End Sub
End Class