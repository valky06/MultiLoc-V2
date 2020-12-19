Public Class F_SocieteCharge
    Public laSocId As Integer

    'Sub listeFournisseur()
    '    Call ComboRempli("SELECT FourId, nom FROM Fournisseur INNER JOIN Annuaire ON Fournisseur.PersId = Annuaire.PersId", Me.lFour, conSql)
    'End Sub

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        'Call listeFournisseur()
        Call ComboRempli("SELECT CptId, CptNum + ' - ' + cptNom AS COmpte FROM PlanComptable wHERE CptNum Like '6%'", Me.lCompte, conSql)
        Me.tTauxTVA.Text = My.Settings.TVADefaut
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim NumPiece As Integer
        Dim leloc As Integer = 0
        Dim laFactINterne As String = ""

        NumPiece = NextNumPiece()
        laFactINterne = nextFactInterne(laSocId, Me.dDate.Value.Year)
        Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dEcheance.Value, NumPiece, leloc, 0, Me.tFourId.Text, 0, Me.laSocId, 0, 0, Me.lCompte.SelectedItem.value, Me.tLibelle.Text, txt2num(Me.tMontantHT.Text), txt2num(Me.tMontantTTC.Text), 0, txt2sql(Me.tNUmfacture.Text), Now, Now, 0, laFactINterne, Me.dDate.Value.Year, 0)
        If FormVerif(Me, Me.ErrorProvider1) Then
            Call EnregCompta(lecr, ecrType.SocChargeExt)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    'Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
    '    Dim leFour As Integer = 0
    '    If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        ' leFour = FournisseurAjoutPers(F_AnnuRech.lePersId)
    '        '  Call listeFournisseur()
    '        '  Call ComboSelectValue(leFour, Me.lFour)
    '    End If
    'End Sub

    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged, tTauxTVA.TextChanged
        Me.tMontantTTC.Text = MontantTTC(Me.tMontantHT.Text, Me.tTauxTVA.Text)
    End Sub


    Private Sub liFour_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles liFour.LinkClicked
        If F_AnnuRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tFourId.Text = F_AnnuRech.lePersId
            Me.tFourNom.Text = F_AnnuRech.lePersNom
        End If
    End Sub
End Class