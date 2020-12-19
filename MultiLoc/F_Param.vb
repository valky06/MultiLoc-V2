Public Class F_Param

    Private Sub F_Param_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        pGrid1.SelectedObject = My.Settings
    End Sub

    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click

        My.Settings.ChemTemp = repNom(My.Settings.ChemTemp)
        My.Settings.ChemModeleOffice = repNom(My.Settings.ChemModeleOffice)

        My.Settings.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()

    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        My.Settings.Reload()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        '        Me.Dispose()
    End Sub

    Private Sub bTestCon_Click(sender As System.Object, e As System.EventArgs) Handles bTestCon.Click
        Try
            If ConnexionTest(My.Settings.SqlCon) Then
                MessageBox.Show("Base Prod : Connexion réussie")
            Else
                MessageBox.Show("Base Prod : Echec Connexion")
            End If

            If ConnexionTest(My.Settings.SqlConDebug) Then
                MessageBox.Show("Base debug : Connexion réussie")
            Else
                MessageBox.Show("Base debug : Echec Connexion")
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class