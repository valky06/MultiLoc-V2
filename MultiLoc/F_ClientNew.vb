Public Class F_ClientNew
    Public leCliId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call ComboRempli("select tperId,tperNom from typePeriode", Me.lTypePer, conSql)
        Call ComboRempli("select tRgtId,tRgtNom from typeReglement", Me.lTypeRgt, conSql)
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            leCliId = FormEnreg(Me, "Client", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        F_TypeListe.laForm = F_TypePeriode
        F_TypeListe.MOdeEdit = False
        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT TPerid, TPernom FROM TypePeriode", Me.lTypePer, conSql)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        F_TypeListe.laForm = F_TypeReglement
        F_TypeListe.MOdeEdit = False
        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT TRgtid, TRgtnom FROM TypeReglement", Me.lTypeRgt, conSql)

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tPersId.Text = F_AnnuRech.lePersId
            Me.tPersNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub
End Class