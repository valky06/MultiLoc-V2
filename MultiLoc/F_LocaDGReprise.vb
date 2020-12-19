Public Class F_LocaDGReprise
    Public leLocId As Integer
    Public laSocId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader

        Me.ErrorProvider1.Clear()
        ssql = "select sum(ecrMontantHT ) as depotHT,sum(ecrMontantTTC ) as depotTTC " _
            & " FROM  ComptaGene where  rubrique='LOCATAIRE' and  journal='DEPOT' and locid=" & Me.leLocId _
            & " and numfacture <>'T" & leLocId & "'" _
            & " group by locid"

        ssql = "select ecrMontantHT from comptagene where locid=" & Me.leLocId _
            & " and rubrique='LOCATAIRE' and categorie='APPELDG' order by ecrdate asc"
        lers = sqlLit(ssql, conSql)
        While lers.Read
            Me.tDGHT.Text = num2txt(-lers(0))
        End While
        lers.Close()
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()

        Dim lapiece As Integer
        If FormVerif(Me, Me.ErrorProvider1) Then
            lapiece = NextNumPiece()

            Dim lecr As New EcritureCompta(Me.dDate.Value, Me.dDate.Value, lapiece, leLocId, 0, 0, 0, Me.laSocId, 0, 0, 0, Me.tLib.Text, txt2num(Me.tDGHT.Text), txt2num(Me.tDGTTC.Text), 100, F_LocaAppel.lafacture, Now, Now, 0, "", Me.dDate.Value.Year, 3)

            lecr.NumFacture = F_LocaAppel.lafacture
            Call EnregCompta(lecr, ecrType.LocRepriseDG)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub tDGHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tDGHT.TextChanged
        Me.tDGTTC.Text = txt2num(Me.tDGHT.Text) * (1 + txt2num(Me.tTVA.Text) / 100)
    End Sub

    Private Sub tTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTVA.TextChanged
        Me.tDGTTC.Text = Math.Round(txt2num(Me.tDGHT.Text) * (1 + txt2num(Me.tTVA.Text) / 100), 2)
    End Sub


End Class