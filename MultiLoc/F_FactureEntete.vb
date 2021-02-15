Imports System.Math

Public Class F_FactureEntete
    Public laSocId As Integer
    Public laFactNum As String = ""
    Public lafact As String = ""

    Sub numfact()
        If laFactNum = "" Then
            Me.tNum.Text = nextFactInterne(Me.laSocId, Year(Me.dDate.Value))
            Me.tNumFacture.Text = nextFacture(Me.laSocId, Year(Me.dDate.Value))
        End If
    End Sub

    Sub AfficheFactEntete()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim total As Double = 0


        Try
            sSql = "SELECT        ecrDate, ecrEcheance,  LocId, NumFacture, numfactureInterne, LibFacture" _
            & " From ComptaGene where Tiers='SOCIETE' and socid=" & Me.laSocId & " and numfacture ='" & Me.lafact & "'" _
            & " GROUP BY ecrDate, ecrEcheance,  LocId, NumFacture, numfactureInterne, LibFacture "

            lers = sqlLit(sSql, conSql)
            While lers.Read
                Me.tNum.Text = lers("NumfactureInterne").ToString
                Me.tNumFacture.Text = lers("NumFacture").ToString
                Me.tLibFact.Text = lers("LibFacture").ToString
                Me.dDate.Value = lers("ecrDate")
                Me.dEcheance.Value = lers("ecrEcheance")
                Call ComboSelectValue(lers("locid"), Me.lClient)
            End While
            lers.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub AfficheFactLigne()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim total As Double = 0


        Try
            sSql = "Select numPiece, ecrLib, ecrMontantHT, ecrmontantTVA, ecrmontantTTC FROM ComptaGene" _
            & " where Tiers='SOCIETE' and socid=" & Me.laSocId & " and numfacture ='" & Me.lafact & "' order by ecrid asc"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                Me.gCompta.Rows.Add(lers("NumPiece").ToString, lers("ecrlib").ToString, lers("ecrmontantHT"), lers("ecrmontantTVA"), lers("ecrmontantTTC"))
                total += lers("ecrmontantHT")
            End While
            lers.Close()
            Me.tTotal.Text = num2txt(Round(total, 2))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub F_LocaFacture_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            Dim sSql As String = ""
            Call ComboRempli("SELECT locid, nom FROM locataire INNER JOIN Annuaire ON locataire.PersId = Annuaire.PersId where typeloc=2", Me.lClient, conSql)


            If laFactNum <> "" Then
                Me.lafact = Me.laFactNum
                Call AfficheFactEntete()
                Call AfficheFactLigne()
                Me.dDate.Enabled = False
                Me.bAnnul.Visible = False
            Else
                Me.lClient.SelectedIndex = 0
                Call numfact()
                Me.lafact = "$" & laSocId
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        '    If debug Then
        'Me.tNum.Visible = True
        'Me.tNum.ReadOnly = False
        'Me.tNumFacture.Enabled = True
        'Me.tNumFacture.ReadOnly = False
        'Me.dDate.Enabled = True
        '   End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        If Me.lafact(0) = "$" Then sqlDo("delete from comptagene where numfacture='" & Me.lafact & "'", conSql)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Dim sSql As String
        sSql = "Update ComptaGene Set locid=" & Me.lClient.SelectedItem.value & ", ecrdate = " & Date2sql(Me.dDate.Value) & ", ecrEcheance = " & Date2sql(Me.dEcheance.Value) _
            & " , NumFacture= '" & Me.tNumFacture.Text & "' , numfactureInterne = '" & Me.tNum.Text & "' , libfacture='" & txt2sql(Me.tLibFact.Text) & "'" _
            & " where socid=" & Me.laSocId & " and NumFacture='" & Me.lafact & "'"
        sqlDo(sSql, conSql)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bsuppEcrit_Click(sender As System.Object, e As System.EventArgs) Handles bsuppEcrit.Click
        If Me.gCompta.SelectedRows.Count = 0 Then Exit Sub

        If MessageBox.Show("Supprimer l'écriture '" & Me.gCompta.SelectedRows(0).Cells("libelle").Value & "' ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            If Me.gCompta.SelectedRows(0).Cells("id").Value <> 0 Then
                Call SupprEcr(Me.gCompta.SelectedRows(0).Cells("id").Value)
                Call AfficheFactLigne()
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles bAjout.Click
        If F_FactureLigne.ShowDialog = DialogResult.OK Then
            Call AfficheFactLigne()
        End If
        F_FactureLigne.Dispose()
    End Sub

    Private Sub dDate_ValueChanged(sender As Object, e As EventArgs) Handles dDate.ValueChanged
        If Me.laFactNum = "" Then Call numfact()
    End Sub

    Private Sub dEcheance_ValueChanged(sender As Object, e As EventArgs) Handles dEcheance.ValueChanged

    End Sub

    Private Sub gCompta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gCompta.CellContentClick

    End Sub

    Private Sub gCompta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gCompta.CellDoubleClick
        If e.RowIndex >= 0 Then
            F_FactureLigne.laPiece = Me.gCompta.SelectedRows(0).Cells("id").Value
            If F_FactureLigne.ShowDialog = DialogResult.OK Then
                Call AfficheFactLigne()
            End If
            F_FactureLigne.Dispose()
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

End Class