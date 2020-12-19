Public Class F_LocaNew
    Public leLocId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call ComboRempli("select tbailid,tbailNom from typeBail", Me.lTypeBail, conSql)
        Call ComboRempli("select tperId,tperNom from typePEriode", Me.lTypePer, conSql)
        Call ComboRempli("select tRgtId,tRgtNom from typeReglement", Me.lTypeRgt, conSql)
        Call ComboRempli("SELECT IndId, typeindice + ' - ' + TrimestreNom +' ' + cast( annee as nvarchar(4)) as indice FROM Indice order by annee desc, trimestrenum desc", Me.lIndice, conSql)
        Me.dEntre.Value = Now
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            Me.tIndActuId.Text = Me.lIndice.SelectedItem.value
            Me.leLocId = FormEnreg(Me, "locataire", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If F_IndiceListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT IndId, typeindice + ' - '  + TrimestreNom + ' ' +  cast( annee as nvarchar(4))  as indice FROM Indice order by annee desc, trimestrenum desc", Me.lIndice, conSql)
    End Sub

    Private Sub bTypeBail_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles bTypeBail.LinkClicked
        F_TypeListe.laForm = F_TypeBail
        F_TypeListe.MOdeEdit = False

        If F_TypeListe.ShowDialog = Windows.Forms.DialogResult.OK Then Call ComboRempli("SELECT Tbailid, Tbailnom FROM TypeBail", Me.lTypeBail, conSql)
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

    Private Sub tLoyer_TextChanged(sender As System.Object, e As System.EventArgs) Handles tLoyer.TextChanged
        Me.tLoyerActu.Text = Me.tLoyer.Text
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tPersId.Text = F_AnnuRech.lePersId
            Me.tPersNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub

    Private Sub dEntre_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dEntre.ValueChanged
        Me.dRevision.Value = Me.dEntre.Value.AddYears(1)
    End Sub
End Class