Public Class F_LocaPlanC
    Public leLocId As Integer
    Public lePCId As Integer
    Public larubid As Integer


    '    Sub listeFournisseur()
    '        Call ComboRempli("SELECT FourId, nom FROM Fournisseur INNER JOIN Annuaire ON Fournisseur.PersId = Annuaire.PersId", Me.lFour, conSql)
    '    End Sub


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call ComboRempli("select rubid,rubnom from comptarubrique", Me.lRubrique, conSql)
        Call ComboSelectValue(larubid, Me.lRubrique)
        If Me.lePCId <> 0 Then
            Call FormRempli(Me, "select pcid,rubid,locid,cptNUm,cptNom from ComptaPlan where pcid=" & lePCId, conSql)
        End If
        Me.tLocId.Text = Me.leLocId

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            lePCId = FormEnreg(Me, "ComptaPlan", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub



    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class