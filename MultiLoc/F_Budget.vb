Public Class F_Budget
    Public lacoproId As Integer
    Dim lesAN As New List(Of Integer)

    Private Sub F_locPreavis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.lAnnee.SelectedIndex = -1
        Me.tCoproId.Text = lacoproId
        Me.tBudId.Text = 0

        For i = Now.Year - 2 To Now.Year + 2
            Me.lAnnee.Items.Add(New ListItem(i, i))
        Next
    End Sub


    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        If Not FormVerif(Me, ErrorProvider1) Then Exit Sub

        Dim leRs As OleDb.OleDbDataReader
        lesAN.Clear()
        leRs = sqlLit("select budannee from budget where coproid=" & Me.lacoproId, conSql)
        While leRs.Read
            lesAN.Add(leRs(0))
        End While
        leRs.Close()

        If Not lesAN.Contains(Val(Me.lAnnee.Text)) Then
            Call FormEnreg(Me, "Budget", conSql)
            If MessageBox.Show("Recopier les lignes du budget précédent ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                Dim ssql As String
                Dim leBudId As Integer = 0
                Dim leBudIdOld As Integer = 0

                'recherche l'id du budget créé
                ssql = "select budId from budget where coproid = " & Me.tCoproId.Text & " and budAnnee=" & Me.lAnnee.Text
                leRs = sqlLit(ssql, conSql)
                While leRs.Read
                    leBudId = leRs(0)
                End While
                leRs.Close()

                'reccherche l'id du budget précédent
                ssql = "select top 1 budId  from budget where coproid = " & Me.lacoproId & " and budAnnee<" & Me.lAnnee.Text & " order by budannee desc"
                leRs = sqlLit(ssql, conSql)
                While leRs.Read
                    leBudIdOld = leRs(0)
                End While
                leRs.Close()

                ssql = "insert into coprocharge SELECT ChAn, coproId, cleid, " & leBudId & ", ChLib, 0, 0, 0, tChCatId, ChMontantBudgetHT" _
                & " FROM CoproCharge WHERE budId = " & leBudIdOld
                sqlDo(ssql, conSql)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
        Me.Close()
    End Sub


End Class