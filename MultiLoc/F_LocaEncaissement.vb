Public Class F_locaEncaissement
    Public leLocid As Integer
    Public laSocId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim lers As OleDb.OleDbDataReader

        Dim sSql As String = ""
        Me.dDate.Value = Now
        Me.tHT.Text = ""
        Me.tHT.Text = ""
        Me.tTVA.Text = ""
        Me.tTTC.Text = ""
        Call ComboRempli("select cptbkid,cptbknom from comptebancaire", Me.lCptBk, conSql)
        Me.lCptBk.SelectedIndex = 0
        lers = sqlLit("select sum(ecrMontantHT), sum(ecrMontantTTC),sum(ecrmontantTVA)  from comptagene where rubrique='LOCATAIRE' and locid=" & Me.leLocid, conSql)
        While lers.Read
            Me.sHT.Text = num2txt(Math.Round(lers(0), 2))
            Me.sTTC.Text = num2txt(Math.Round(lers(1), 2))
            Me.sTVA.Text = num2txt(Math.Round(lers(2), 2))
        End While
        lers.Close()

        If txt2num(Me.sTTC.Text) < 0 Then
            '      Me.tHT.Text = -txt2num(Me.sHT.Text)
            '    Me.tTVA.Text = -txt2num(Me.sTVA.Text)
            Me.tTTC.Text = -txt2num(Me.sTTC.Text)
        End If

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Dim NumPiece As Integer
        NumPiece = NextNumPiece()
        Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dDate.Value, NumPiece, leLocid, 0, 0, 0, Me.laSocId, Me.lCptBk.SelectedItem.value, 0, 0, Me.tLib.Text, txt2num(Me.tHT.Text), txt2num(Me.tTTC.Text), 100, "", Now, Now, 0, "", Me.dDate.Value.Year, 4)
        Call EnregCompta(lecr, ecrType.LocEncaisse)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub tHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tHT.TextChanged
        '  Me.tTVA.Text = txt2num(txt2num(Me.tHT.Text) * txt2num(F_LocaSuivi.tTauxTVA.Text) / 100)
        ' Me.tTTC.Text = num2txt(txt2num(Me.tHT.Text) + txt2num(Me.tTVA.Text))
    End Sub

    Private Sub tTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTVA.TextChanged
        'Me.tTTC.Text = num2txt(txt2num(Me.tHT.Text) + txt2num(Me.tTVA.Text))
    End Sub

    Private Sub tTTC_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTTC.TextChanged
        Me.tTVA.Text = num2txt(Math.Round((txt2num(Me.tTTC.Text) - txt2num(Me.tTTC.Text) / (1 + txt2num(F_LocaSuivi.tTauxTVA.Text) / 100)), 2))
        If num2txt(Me.tTVA.Text) > -(num2txt(Me.sTVA.Text)) Then Me.tTVA.Text = num2txt(-txt2num(Me.sTVA.Text))
        Me.tHT.Text = num2txt(txt2num(Me.tTTC.Text) - txt2num(Me.tTVA.Text))

    End Sub
End Class