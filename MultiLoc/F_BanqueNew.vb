Public Class F_BanqueNew
    'Public leCptBkId As Integer = 0

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader


        Me.ErrorProvider1.Clear()


        Call formVide(Me)
        Call ComboRempli("select socid,nom from societe inner join Annuaire on Societe.PersId = Annuaire.PersId", Me.lSociete, conSql)
        Me.lSociete.SelectedIndex = 0

        If F_TypeListe.laSelId > 0 Then
            FormRempli(Me, "Select cptbkID, cptbkNom,cptbkiban, socid,cptbketab,cptbkguichet,cptbkCOmpte,cptbkcle,cptbkswift,ComptaNum,ComptaNOm from comptebancaire where cptbkid= " & F_TypeListe.laSelId, conSql)
        End If
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            F_TypeListe.laSelId = FormEnreg(Me, "CompteBancaire", conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub


End Class