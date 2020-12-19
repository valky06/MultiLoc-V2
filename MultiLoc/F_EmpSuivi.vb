Public Class F_EmpSuivi
    Public lEmpId As Integer

    Sub listeClient()
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Me.gContrat.Rows.Clear()
        sSql = "select contrat.contratid,contrat.cliid,nom, datedebut,datefin from contratEmplacement " _
        & " inner join contrat on contrat.contratId = contratEmplacement.contratId" _
        & " inner join client on contrat.cliid = client.cliid" _
        & " inner join annuaire on annuaire.persId = client.persId" _
        & " where empId = " & Me.lEmpId
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gContrat.Rows.Add(lers("contratId"), lers("cliId"), "E" & lers("contratId").ToString.PadLeft(5, "0"), lers("nom").ToString, lers("dateDebut"), lers("dateFin"))

        End While
        lers.Close()
    End Sub

    Sub EmpListe()
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Dim laZone As TreeNode = Nothing
        Dim lAllee As TreeNode = Nothing
        Dim leNiveau As TreeNode = Nothing
        Dim leRang As TreeNode = Nothing
        Dim statut As Integer = 2

        sSql = "SELECT empId, empZone, empAllee, empNiveau, empRang, Colis,emplacement FROM Emplacement"

        If Me.tRech.Text <> "" Then sSql &= " where emplacement like '%" & Me.tRech.Text & "%'"
        sSql &= " order by empZone, empAllee, empNiveau, empRang, Colis"

        Me.gEmp.Rows.Clear()

        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gEmp.Rows.Add(lers("empId"), lers("emplacement").ToString)
        End While
        lers.Close()
    End Sub

    Sub EmpCompta()
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Dim debit As Decimal
        Dim credit As Decimal
        Try
            sSql = "SELECT ecrId, numPiece, ecrDate, ecrEcheance, ecrLib, ecrMontantTTC,numfacture" _
            & " FROM ComptaGene " _
            & " where rubrique='STOCKAGE' order by ecrDate desc"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                debit = IIf(lers("ecrmontantTTC") < 0, -lers("ecrmontantTTC"), 0)
                credit = IIf(lers("ecrmontantTTC") >= 0, lers("ecrmontantTTC"), 0)
                Me.gCompta.Rows.Add(lers("ecrId"), lers("ecrDate"), lers("NumPIece").ToString, lers("numfacture").ToString, lers("ecrLib").ToString, debit, credit)
            End While
            lers.Close()

            If Me.gCompta.Rows.Count > 0 Then Call Gridcalculsolde(Me.gCompta)
        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub F_Copro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call EmpListe()
        Call EmpCompta()
    End Sub


    Private Sub bDocAjout_Click(sender As System.Object, e As System.EventArgs) Handles bDocAjout.Click
        F_Document.leDocType = docType.Emplacement
        F_Document.lId = Me.lEmpId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Emplacement, Me.lEmpId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub bDocSupp_Click(sender As System.Object, e As System.EventArgs) Handles bDocSupp.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Lot, Me.lEmpId, Me.gDoc)
    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tRech.KeyUp
        If e.KeyCode = Keys.Enter Then Call EmpListe()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Call EmpListe()
    End Sub




    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Call XLexport(Me.gCompta, "Grand Livre Stockage")
    End Sub



    Private Sub gEmp_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gEmp.CellDoubleClick
        Me.lEmpId = Me.gEmp.SelectedRows(0).Cells("empId").Value
        Me.tEmplacement.Text = Me.gEmp.SelectedRows(0).Cells(1).Value
        Call listeClient()
        Call DocListe(docType.Emplacement, Me.lEmpId, Me.gDoc)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        F_EmpNew.lEmpId = 0
        If F_EmpNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call EmpListe()
        End If
        F_EmpNew.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        F_EmpNew.lEmpId = Me.lEmpId
        If F_EmpNew.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call EmpListe()
            Me.tEmplacement.Text = F_EmpNew.tEmplacement.Text
        End If
        F_EmpNew.Dispose()
    End Sub

    Private Sub gContrat_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gContrat.CellContentClick
        Select Case e.ColumnIndex
            Case Me.gContrat.Columns("client").Index
                F_ClientSuivi.leCliId = Me.gContrat.SelectedRows(0).Cells("cliId").Value
                Call F_main.mnuClient(Nothing, Nothing)
                Me.Dispose()
        End Select
    End Sub
End Class