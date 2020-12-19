Public Class F_LotSuivi
    Public lelotId As Integer

    Sub listeLoc()
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Me.gLocataire.Rows.Clear()
        sSql = "SELECT Locataire.LocId, DateEntree, DateSortie, nom" _
        & " FROM (Annuaire INNER JOIN Locataire ON Annuaire.PersId = Locataire.PersId) " _
        & " INNER JOIN Location ON Locataire.LocId = Location.LocId " _
        & " where Location.LotId=" & lelotId _
        & " GROUP BY Locataire.LocId, Locataire.DateEntree, Locataire.DateSortie, nom, Location.LotId;"

        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.gLocataire.Rows.Add(lers("LocId"), date2Xl(lers("DateEntree")), date2Xl(lers("DateSortie")), lers("nom"))

        End While
        lers.Close()
    End Sub


    Sub lotAffiche()
        Dim sSql As String
        lelotId = Me.TreeCopro.SelectedNode.Name.Replace("L", "")
        sSql = "SELECT LotId, coproid, Batiment, TLocalId, LotNom, Milliemes, Niveau, Surface, Statut, nom, lot.socid" _
        & " FROM (Lot INNER JOIN societe ON Lot.socid = societe.socid)" _
        & " INNER JOIN Annuaire ON societe.PersId = Annuaire.PersId " _
        & " where lotid = " & lelotId
        Call FormRempli(Me.gLot, sSql, conSql)
        Call listeLoc()
        Call DocListe(docType.Lot, Me.lelotId, Me.gDoc)
        Me.oOnglet.Enabled = True

    End Sub

    Sub lotListe()
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String
        Dim laCopro As TreeNode
        Dim statut As Integer = 2
        Dim leNodetxt As String = ""

        sSql = "SELECT lot.CoproId, LotId, CoproNom, Batiment, LotNom, TlocalNom , Statut " _
        & " FROM ( Lot INNER JOIN Copro ON Lot.CoproId = Copro.CoproId) " _
        & " LEFT JOIN TypeLocal ON Lot.TLocalId = TypeLocal.TlocalId " _
        & " order by copronom,batiment, lotnom"
        lers = sqlLit(sSql, conSql)
        TreeCopro.Nodes.Clear()
        laCopro = Nothing
        While lers.Read
            If laCopro Is Nothing Then
                laCopro = Me.TreeCopro.Nodes.Add("C" & lers("CoproId"), lers("CoproNom"), 0)
            Else
                If (laCopro.Name <> "C" & lers("coproId")) Then laCopro = Me.TreeCopro.Nodes.Add("C" & lers("CoproId"), lers("CoproNom"))
            End If

            statut = 3

            leNodetxt = ""
            If nz(lers("batiment"), "") <> "" Then leNodetxt = lers("batiment") & " - "
            leNodetxt &= lers("LotNom") & " (" & lers("TlocalNom") & ")"
            laCopro.Nodes.Add("L" & lers("LotID"), leNodetxt, statut)
        End While
        lers.Close()
    End Sub

    Private Sub F_Copro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call lotListe()
        Call ComboRempli("SELECT TlocalId, TlocalNom FROM TypeLocal", Me.lTypeLocal, conSql)
        If Me.lelotId <> 0 Then
            For Each n As TreeNode In Me.TreeCopro.Nodes
                If n.Nodes.Count > 0 Then
                    For Each n2 As TreeNode In n.Nodes
                        If n2.Name = "L" & Me.lelotId Then
                            n2.EnsureVisible()
                            Me.TreeCopro.SelectedNode = n2
                            Call lotAffiche()
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub TreeCopro_DoubleClick(sender As Object, e As System.EventArgs) Handles TreeCopro.DoubleClick
        Try
            If Me.TreeCopro.SelectedNode.Name.Substring(0, 1) = "L" Then Call lotAffiche()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        If F_Lot.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.lelotId = F_Lot.leLotId
            Call lotListe()
            Call ComboRempli("SELECT TlocalId, TlocalNom FROM TypeLocal", Me.lTypeLocal, conSql)
            Me.lelotId = F_Lot.leLotId
            For Each n As TreeNode In Me.TreeCopro.Nodes
                If n.Nodes.Count > 0 Then
                    For Each n2 As TreeNode In n.Nodes
                        If n2.Name = "L" & Me.lelotId Then
                            n2.EnsureVisible()
                            Me.TreeCopro.SelectedNode = n2
                            Call lotAffiche()
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        F_TypeListe.laForm = F_TypeLocal
        F_TypeListe.MOdeEdit = False
        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT TlocalId, TlocalNom FROM TypeLocal", Me.lTypeLocal, conSql)
    End Sub


    Private Sub bDocAjout_Click(sender As System.Object, e As System.EventArgs) Handles bDocAjout.Click
        F_Document.leDocType = docType.Lot
        F_Document.lId = Me.lelotId
        If F_Document.ShowDialog = Windows.Forms.DialogResult.OK Then Call DocListe(docType.Lot, Me.lelotId, Me.gDoc)
        F_Document.Dispose()
    End Sub

    Private Sub bDocSupp_Click(sender As System.Object, e As System.EventArgs) Handles bDocSupp.Click
        If Me.gDoc.SelectedRows.Count < 1 Then Exit Sub
        If DocSupprime(Me.gDoc.SelectedRows(0).Cells(0).Value) Then Call DocListe(docType.Lot, Me.lelotId, Me.gDoc)

    End Sub

    Private Sub gDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gDoc.CellClick
        If e.ColumnIndex = 3 Then
            System.Diagnostics.Process.Start(Me.gDoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        End If
    End Sub

    Private Sub lProprio_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lProprio.LinkClicked
        If Me.tSocId.Text <> "" Then
            F_SocieteSuivi.laSocId = Me.tSocId.Text
            Call F_main.mproprio_Click(Nothing, Nothing)
            Me.Dispose()
        End If
    End Sub


    Private Sub gLocataire_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gLocataire.CellContentClick
        If Me.gLocataire.SelectedRows.Count > 0 Then
            If e.ColumnIndex = Me.gLocataire.Columns("locataire").Index Then
                F_LocaSuivi.leLocId = Me.gLocataire.SelectedRows(0).Cells("locid").Value
                F_main.Locataire_Click(Nothing, Nothing)
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If FormVerif(Me, Nothing) Then
            lelotId = FormEnreg(Me.gLot, "lot", conSql)
            Call LotLib(lelotId)
            MessageBox.Show("Modification enregistrée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gLot_Enter(sender As System.Object, e As System.EventArgs) Handles gLot.Enter

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class