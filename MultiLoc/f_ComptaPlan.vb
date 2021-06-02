Public Class f_ComptaPlan
    Public leSocId As Integer
    Public lePcId As Integer
    Public avecRub As Boolean

    Private Sub bOK_Click(sender As Object, e As EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()

        If FormVerif(Me, Me.ErrorProvider1) Then

            Dim sSql As String = "select count(*) From comptaplan where socid=" & Me.leSocId & " and pcid<>" & Me.lePcId & " and locid=" & Me.lTiers.SelectedItem.value & " and rubid=" & Me.lRubrique.SelectedItem.value
            Dim leRS As OleDb.OleDbDataReader = sqlLit(sSql, conSql)
            Dim nb As Integer = 0
            While leRS.Read
                nb = leRS(0)
            End While
            leRS.Close()

            If nb = 0 Then
                Call FormEnreg(Me, "ComptaPlan", conSql)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("Cet enregistrement existe déjà")

            End If
        End If
    End Sub

    Private Sub f_ComptaPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tSocId.Text = leSocId
        Me.tPCID.Text = lePcId

        Call ComboRempli("Select locid,Case When l.typeLoc=1 Then 'Loc ' + a.nom + '-' + ISNULL(LotLib,'') else 'Client ' + a.nom  end as loc from locataire L " _
        & " inner join Annuaire A on A.PersId = l.PersId order by Nom", Me.lTiers, conSql)

        If Me.avecRub Then
            Call ComboRempli("SELECT RubId,RubNom from ComptaRubrique", Me.lRubrique, conSql)
        Else
            Me.lRubrique.Items.Add(New ListItem(0, "0"))
            Me.lRubrique.SelectedIndex = 0
            Me.lRubrique.Visible = False
            Me.Label5.Visible = False
        End If

        If Me.lePcId <> 0 Then Call FormRempli(Me, "SELECT * FROM Comptaplan where pcid=" & Me.lePcId, conSql)

    End Sub
End Class