Public Class F_LocaLot
    Public laSocId As Integer
    Public leBailid As Integer

    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        If Me.dSortie.Value.Year > 2099 Then Me.dSortie.Checked = False
        Me.LinkLabel1.Enabled = (Me.leBailid = 0)
        Me.tLotNom.Enabled = (Me.leBailid = 0)
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            Dim ssql As String

            If Me.leBailid > 0 Then
                ssql = "update location set DateDebut=" & Date2sql(Me.dEntre.Value) & ", datefin=" & IIf(Me.dSortie.Checked, Date2sql(Me.dSortie.Value), "NULL") & ", surface = '" & txt2num(Me.tSurface.Text) & "'  where BailId=" & Me.leBailid
                sqlDo(ssql, conSql)
            Else

                ssql = "insert into location (locId, lotId,DateDebut,DateFin,surface) values (" & Me.tLocatID.Text & "," & Me.tLotId.Text & "," & Date2sql(Me.dEntre.Value) & "," & Date2sql(Me.dSortie.Value) & "," & txt2num(Me.tSurface.Text) & ")"
                sqlDo(ssql, conSql)

                If Me.laSocId = 0 Then
                    ssql = "update locataire set socId=" & F_LotRech.laSocId & " where locid=" & Me.tLocatID.Text
                    sqlDo(ssql, conSql)
                End If
            End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        F_LotRech.laSocId = Me.laSocId
        If F_LotRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.tLotId.Text = F_LotRech.leLotId
            Me.tLotNom.Text = F_LotRech.leLotNom
            Me.tSurface.Text = num2txt(F_LotRech.laSurface)
            Me.tSurftot.Text = " / " & num2txt(F_LotRech.laSurface) & " m2"

        End If
    End Sub
End Class