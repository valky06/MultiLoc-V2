Public Class F_pers
    Public lID As Integer

    Sub affichePersonne()
        Call FormRempli(Me.gCoord, "SELECT persid,typesociete,nom, Adr1, CodePostal, Localite, telbureau, fax, TContactId FROM Annuaire where persId=" & Me.lID, conSql)
        Call listecontact(Me.gAdress, Me.lID)
    End Sub

    Private Sub F_pers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call formVide(Me.gCoord)
        Me.gAdress.Rows.Clear()
        Call ComboRempli("Select tsocid,tsoclib from typesociete", Me.cTypeSoc, conSql)
        Call ComboRempli("Select tContactid,tContactlib from typeContact", Me.cTypeAdr, conSql)

        If Me.lID > 0 Then
            Call affichePersonne()
            'Else
            '    Me.gContact.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Dim ssql As String = ""
        If Not FormVerif(Me.gCoord, Me.ErrorProvider1) Then
            Exit Sub
        End If

        lID = FormEnreg(Me.gCoord, "Annuaire", conSql)

        ssql = "delete from contact where persId=" & Me.lID
        sqlDo(ssql, conSql)
        For i = 0 To Me.gAdress.RowCount - 1
            With Me.gAdress.Rows(i)
                If Not .IsNewRow Then
                    ssql = "insert into contact (PersiD, CivId , NomPrenom,  TelFixe, TelMobile, Fax, Email) values (" _
                    & lID & ",'" & .Cells("civilite").Value & "','" & .Cells("contact").Value & "','" & .Cells("telfixe").Value & "','" & .Cells("telmob").Value & "','" & .Cells("fax").Value & "','" & .Cells("email").Value & "')"
                    sqlDo(ssql, conSql)
                End If
            End With
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub gCoord_Enter(sender As System.Object, e As System.EventArgs) Handles gCoord.Enter

    End Sub

    Private Sub bSuppr_Click(sender As System.Object, e As System.EventArgs) Handles bSuppr.Click
        Dim ssql As String = ""
        Dim lers As OleDb.OleDbDataReader

        ssql = "select persid from client where persid=" & Me.lID
        lers = sqlLit(ssql, conSql)
        If lers.HasRows Then
            MessageBox.Show("Suppression impossible, cette entité est un client", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        lers.Close()

        ssql = "select persid from societe where persid=" & Me.lID
        lers = sqlLit(ssql, conSql)
        If lers.HasRows Then
            MessageBox.Show("Suppression impossible, cette entité est une société", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        lers.Close()

        'ssql = "select persid from fournisseur where persid=" & Me.lID
        'lers = sqlLit(ssql, conSql)
        'If lers.HasRows Then
        '    MessageBox.Show("Suppression impossible, cette entité est un fournisseur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        'lers.Close()

        ssql = "select persid from locataire where persid=" & Me.lID
        lers = sqlLit(ssql, conSql)
        If lers.HasRows Then
            MessageBox.Show("Suppression impossible, cette entité est un locataire", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        lers.Close()

        sqlDo("delete from annuaire where persid=" & Me.lID, conSql)
        sqlDo("delete from contact where persid=" & Me.lID, conSql)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cTypeSoc_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cTypeSoc.SelectedIndexChanged

    End Sub
End Class