Imports System.Math

Public Class F_ClientAppMensuel
    Public leContratID As Integer
    Dim leCliId As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim lers As OleDb.OleDbDataReader
        Dim sSql As String = ""
        Me.ErrorProvider1.Clear()
        sSql = "select cliid,montantHT,tauxTVA from contrat where contratId=" & Me.leContratID
        lers = sqlLit(sSql, conSql)
        While lers.Read
            Me.tMontantHT.Text = lers("MontantHT")
            Me.tTauxTVA.Text = lers("TauxTVA")
            Me.leCliId = lers("cliId")
        End While
        lers.Close()
        dEntre_ValueChanged(Nothing, Nothing)

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        'Me.ErrorProvider1.Clear()
        'Dim lapiece As Integer
        'Dim laFActure As String

        'lapiece = NextNumPiece()
        'laFActure = nextFactInterne(0, Me.dEntre.Value.Year)


        'Dim lecrLoyer As New EcritureCompta(Me.dEntre.Value, Me.dEntre.Value, lapiece, 0, 0, 0, Me.leCliId, 0, 0, 0, 0, "Contrat E" & Me.leContratID.ToString.PadLeft(5, "0") & " " & Me.dEntre.Value.Month & "/" & Me.dEntre.Value.Year, txt2num(Me.tMontantAppHT.Text), txt2num(Me.tMontantAppTTC.Text), 100, laFActure, Now, Now, 0, "", Me.dEntre.Value.Year, 0)
        'lIndexPiece = 0
        'Call EnregCompta(lecrLoyer, ecrType.ClientStockage)


        'Me.DialogResult = Windows.Forms.DialogResult.OK
        'Me.Close()


    End Sub


    Private Sub dEntre_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dEntre.ValueChanged
        Dim dFinMois As Date
        Dim dDebMois As Date
        Dim nbjourMois As Integer
        dDebMois = CDate("01/" & Me.dEntre.Value.Month & "/" & Me.dEntre.Value.Year)
        dFinMois = dDebMois.AddMonths(1)
        Me.tNbJour.Text = DateDiff(DateInterval.Day, dEntre.Value, dFinMois) + 1
        nbjourMois = DateDiff(DateInterval.Day, dDebMois, dFinMois)

        Me.tMontantAppHT.Text = Round(txt2num(Me.tMontantHT.Text) / nbjourMois * txt2num(Me.tNbJour.Text), 2)
        Me.tMontantAppTTC.Text = MontantTTC(Me.tMontantAppHT.Text, tTauxTVA.Text)

    End Sub




    Private Sub tMontantAppHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantAppHT.TextChanged
        Call dEntre_ValueChanged(Nothing, Nothing)
    End Sub

    Private Sub tTauxTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTauxTVA.TextChanged
        Call dEntre_ValueChanged(Nothing, Nothing)
    End Sub
End Class