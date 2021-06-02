Public Class F_ClientEncaissement
    Public leTiersId As Integer
    '
    '    Select Case* From comptagene C1 
    ' left join comptagene C2 On C2.numpiecereg=C1.numpiece
    'where C1.categorie='Encaissement' and c1.tiers='CLIENT'
    'And C1.anneeeffet=2021
    'order by C1.numpiece


    Sub FactureListe()
        Dim sSql As String = ""
        Dim leRS As OleDb.OleDbDataReader
        sSql = " Select numFacture,ecrdate,sum(-ecrmontantttc) As TTC,sum(-ecrmontantHT) HT, sum(-ecrmontantTVA) TVA, c.libfacture from ComptaGene C" _
        & " inner Join societe S on S.socid = C.socid " _
        & " where tiers ='CLIENT' and categorie='VENTE'  and isnull(numpiecereg,'')='' " _
        & " and C.locid=" & leTiersId _
        & " and C.socid=" & Me.lSociete.SelectedItem.value _
        & " group by numfacture, ecrdate, c.libfacture"

        Me.gCompta.Rows.Clear()
        leRS = sqlLit(sSql, conSql)
        While leRS.Read
            Me.gCompta.Rows.Add(False, date2Grid(leRS("ecrdate")), leRS("numfacture"), leRS("libfacture"), leRS("HT"), leRS("TVA"), leRS("TTC"))
        End While
        leRS.Close()
        Call CalculSolde()

    End Sub

    Sub banqueliste()
        Call ComboRempli("select cptbkid,cptbknom from comptebancaire where socid=" & Me.lSociete.SelectedItem.value, Me.lCptBk, conSql)
        If Me.lCptBk.Items.Count > 0 Then Me.lCptBk.SelectedIndex = 0
    End Sub

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.dReglt.Value = Now
        Call ComboRempli("select socid,nom from societe inner join Annuaire on Societe.PersId = Annuaire.PersId", Me.lSociete, conSql)
        Me.lSociete.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Dim NumPiece As Integer
        NumPiece = NextNumPiece()

        Dim lecr As New EcritureCompta(Me.dReglt.Value, Me.dReglt.Value, NumPiece, leTiersId, 0, 0, 0, Me.lSociete.SelectedItem.value, Me.lCptBk.SelectedItem.value, 0, 0, Me.tLib.Text, txt2num(Me.tHT.Text), txt2num(Me.tTTC.Text), 100, "", Me.dReglt.Value, Me.dReglt.Value, 0, "", Me.dReglt.Value.Year, 0)
        Call EnregCompta(lecr, ecrType.ClientEncaisse)

        For i = 0 To Me.gCompta.RowCount - 1
            If Me.gCompta.Rows(i).Cells("choix").Value = True Then
                sqlDo("update comptagene set NumPieceReg=" & NumPiece & " where Tiers='CLIENT' and journal='VENTES' and socid=" & Me.lSociete.SelectedItem.value & " and  numfacture='" & Me.gCompta.Rows(i).Cells("numfacture").Value & "'", conSql)
            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub tTVA_TextChanged(sender As Object, e As EventArgs) Handles tTVA.TextChanged
        '     Me.tHT.Text = Val(Me.tTTC.Text) - Val(Me.tTVA.Text)
    End Sub

    Private Sub tTTC_TextChanged(sender As Object, e As EventArgs) Handles tTTC.TextChanged
        '    Me.tHT.Text = Math.Round(Val(Me.tTTC.Text) / 1.2, 2)
        '      Me.tTVA.Text = Val(Me.tTTC.Text) - Val(Me.tHT.Text)

    End Sub


    Sub CalculSolde()
        Dim dHT As Decimal = 0
        Dim dTVA As Decimal = 0
        Dim dTTC As Decimal = 0

        For i = 0 To Me.gCompta.RowCount - 1
            If Me.gCompta.Rows(i).Cells("choix").Value = True Then
                dHT += Me.gCompta.Rows(i).Cells("HT").Value
                dTVA += Me.gCompta.Rows(i).Cells("TVA").Value
                dTTC += Me.gCompta.Rows(i).Cells("TTC").Value
            End If
        Next

        Me.sTTC.Text = dTTC
        Me.sHT.Text = dHT
        Me.sTVA.Text = dTVA

        Me.tHT.Text = Me.sHT.Text
        Me.tTVA.Text = Me.sTVA.Text
        Me.tTTC.Text = Me.sTTC.Text
    End Sub

    Private Sub gCompta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gCompta.CellContentClick
        Me.sTTC.Focus()
        CalculSolde()
    End Sub


    Private Sub lSociete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lSociete.SelectedIndexChanged
        Call FactureListe()
        Call BanqueListe()
    End Sub
End Class