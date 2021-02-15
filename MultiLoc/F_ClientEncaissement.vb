Public Class F_ClientEncaissement
    Public leTiersId As Integer


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Me.dReglt.Value = Now
        Call ComboRempli("select cptbkid,cptbknom from comptebancaire", Me.lCptBk, conSql)
        sSql = " Select numfacture from ComptaGene where locid=" & leTiersId & " And tiers='CLIENT' group by numfacture having sum(ecrMontantHT + ecrMontantTVA + ecrMontantTTC) <> 0"
        Call ComboRempli(sSql, Me.lFacture, conSql)
        Me.lCptBk.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Dim NumPiece As Integer
        NumPiece = NextNumPiece()

        Dim lecr As New EcritureCompta(Me.dReglt.Value, Me.dReglt.Value, NumPiece, leTiersId, 0, 0, 0, 0, Me.lCptBk.SelectedItem.value, 0, 0, Me.tLib.Text, txt2num(Me.tHT.Text), txt2num(Me.tTTC.Text), 100, Me.lFacture.Text, Me.dReglt.Value, Me.dReglt.Value, 0, "", Me.dReglt.Value.Year, 0)
        Call EnregCompta(lecr, ecrType.ClientEncaisse)
        sqlDo("update comptagene set NumPieceReg=" & NumPiece & " where Tiers='CLIENT' and journal='VENTES' and numfacture='" & Me.lFacture.Text & "'", conSql)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub lFacture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lFacture.SelectedIndexChanged
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader
        ssql = "Select numfacture,sum(-ecrMontantHT) As montantHT,sum(-ecrMontantTVA) As montantTVA, SUM(-ecrmontantttc) As montantTTC from ComptaGene " _
        & " where numfacture='" & Me.lFacture.Text & "'" _
        & "And tiers='CLIENT'  and locid=" & Me.leTiersId & " group by numfacture"
        lers = sqlLit(ssql, conSql)
        While lers.Read
            Me.sHT.Text = lers("montantHT")
            Me.sTVA.Text = lers("montantTVA")
            Me.sTTC.Text = lers("montantTTC")
            Me.tHT.Text = lers("montantHT")
            Me.tTVA.Text = lers("montantTVA")
            Me.tTTC.Text = lers("montantTTC")
        End While
        lers.Close()
    End Sub

    Private Sub tTVA_TextChanged(sender As Object, e As EventArgs) Handles tTVA.TextChanged
        Me.tHT.Text = Val(Me.tTTC.Text) - Val(Me.tTVA.Text)
    End Sub

    Private Sub tTTC_TextChanged(sender As Object, e As EventArgs) Handles tTTC.TextChanged
        Me.tHT.Text = Math.Round(Val(Me.tTTC.Text) / 1.2, 2)
        Me.tTVA.Text = Val(Me.tTTC.Text) - Val(Me.tHT.Text)

    End Sub
End Class