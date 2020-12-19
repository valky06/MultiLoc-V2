Public Class F_locaRembours
    Public leLocid As Integer
    Public laSocId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Me.dDate.Value = Now
        Call ComboRempli("select cptbkid,cptbknom from comptebancaire", Me.lCptBk, conSql)
        Me.lCptBk.SelectedIndex = 0


        lers = sqlLit("select sum(ecrMontantHT), sum(ecrMontantTTC) from comptagene where rubrique='LOCATAIRE' and locid=" & Me.leLocid, conSql)
        While lers.Read
            Me.sHT.Text = num2txt(lers(0))
            Me.sTTC.Text = num2txt(lers(1))
            Me.sTVA.Text = num2txt(lers(1) - lers(0))
        End While
        lers.Close()

        If txt2num(Me.sTTC.Text) > 0 Then
            Me.tHT.Text = txt2num(Me.sHT.Text)
            Me.tTVA.Text = txt2num(Me.sTVA.Text)
            Me.tTTC.Text = txt2num(Me.sTTC.Text)
        End If
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Dim NumPiece As Integer
        NumPiece = NextNumPiece()
        Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dDate.Value, NumPiece, leLocid, 0, 0, 0, Me.laSocId, Me.lCptBk.SelectedItem.value, 0, 0, Me.tLib.Text, txt2num(Me.tHT.Text), txt2num(Me.tTTC.Text), 100, "", Now, Now, 0, "", Me.dDate.Value.Year, 4)
        Call EnregCompta(lecr, ecrType.LocRemboursement)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


End Class