Public Class f_ComptaPlan
    Public leSocId As Integer
    Public lePcId As Integer

    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()

        If FormVerif(Me, Me.ErrorProvider1) Then
            Call FormEnreg(Me, "ComptaPlan", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub f_ComptaPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tSocId.Text = leSocId
        Me.tPCID.Text = lePcId
        Call ComboRempli("SELECT RubId,RubNom from ComptaRubrique", Me.lRubrique, conSql)
        Call ComboRempli("select locid,case when l.typeLoc=1 then 'Loc ' + a.nom + '-' + ISNULL(LotLib,'') else 'Client ' + a.nom  end as loc from locataire L " _
        & " inner join Annuaire A on A.PersId = l.PersId order by Nom", Me.lTiers, conSql)

        If Me.lePcId <> 0 Then
            Me.ErrorProvider1.Clear()
            Call formVide(Me)
            If Me.lePcId <> 0 Then Call FormRempli(Me, "SELECT * FROM Comptaplan where pcid=" & Me.lePcId, conSql)
        End If
    End Sub
End Class