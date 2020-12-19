Public Class F_Lot
    Public leLotId As Integer = 0

    Sub listeTypeLocal()
        Call ComboRempli("select tlocalid,tlocalNom from typelocal", Me.lTypeLocal, conSql)
    End Sub


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call listeTypeLocal()
        If Me.leLotId <> 0 Then
            Call FormRempli(Me.gLot, "select lotid,batiment,tlocalid,lotnom,milliemes, niveau,surface,coproid,socid from lot where lotid=" & Me.leLotId, conSql)
        End If
    End Sub

    Private Sub Annul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub Enreg_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            leLotId = FormEnreg(Me, "lot", conSql)
            Call LotLib(leLotId)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub


    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        F_TypeListe.laForm = F_TypeLocal
        F_TypeListe.MOdeEdit = False
        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call listeTypeLocal()
    End Sub


End Class