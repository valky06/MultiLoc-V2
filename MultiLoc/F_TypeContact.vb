Public Class F_TypeContact

    Private lechampId As String
    Private latable As String
    Private lechampNom As String


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)

        Me.latable = Me.Tag
        Me.lechampId = Me.Controls("tId").Tag.ToString.Split(",")(0)
        Me.lechampNom = Me.Controls("tNom").Tag.ToString.Split(",")(0)

        If F_TypeListe.laSelId > 0 Then
            Call FormRempli(Me, "select " & lechampId & "," & lechampNom & " from " & latable & " where " & Me.lechampId & " =" & F_TypeListe.laSelId, conSql)
        End If
    End Sub


    Private Sub Enreg_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Me.ErrorProvider1.Clear()
        If FormVerif(Me, Me.ErrorProvider1) Then
            F_TypeListe.laSelId = FormEnreg(Me, Me.latable, conSql)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class