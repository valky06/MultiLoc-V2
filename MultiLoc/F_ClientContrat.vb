Public Class F_ClientContrat
    Public leCliId As Integer
    Public leContratId As Integer

    Dim modif As Boolean


    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader

        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Me.tCliId.Text = Me.leCliId
        If Me.leContratId <> 0 Then
            Call FormRempli(Me, "select cliid,contratid,datedebut,datefin,datefinprev,montantHT, tauxTVA, montantTTC from contrat where contratId=" & Me.leContratId, conSql)
            Me.gListe.Rows.Clear()
            sSql = "select emplacement.empid,emplacement from contratEmplacement" _
                & " inner join emplacement on emplacement.empId=contratEmplacement.empId" _
                & " where contratId=" & Me.leContratId
            lers = sqlLit(sSql, conSql)
            While lers.Read
                Me.gListe.Rows.Add(lers("empid"), lers("Emplacement"))
            End While
        End If
        Me.bEnreg.Text = "OK"
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Dim sSql As String
        If Me.bEnreg.Text = "OK" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Else
            Me.ErrorProvider1.Clear()
            If FormVerif(Me, Me.ErrorProvider1) Then
                Me.leContratId = FormEnreg(Me, "contrat", conSql)

                sSql = "delete from contratEmplacement where contratID=" & Me.leContratId
                sqlDo(sSql, conSql)
                For i = 0 To Me.gListe.RowCount - 1
                    sqlDo("insert into contratEmplacement (contratId,EmpId) values (" & Me.leContratId & "," & Me.gListe.Rows(i).Cells("EmpId").Value & ")", conSql)
                Next
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub



    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If F_EmpRech.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.gListe.Rows.Add(F_EmpRech.lEmpId, F_EmpRech.lEmpNom)
            Me.bEnreg.Text = "Enregistrer"
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If gListe.SelectedRows.Count = 0 Then Exit Sub
        gListe.Rows.Remove(Me.gListe.SelectedRows(0))
        Me.bEnreg.Text = "Enregistrer"
    End Sub

    Private Sub tMontantHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontantHT.TextChanged
        Me.tMontantTTC.Text = txt2num(Me.tMontantHT.Text) * (1 + txt2num(Me.tTVA.Text) / 100)
        Me.bEnreg.Text = "Enregistrer"
    End Sub

    Private Sub tTVA_TextChanged(sender As System.Object, e As System.EventArgs) Handles tTVA.TextChanged
        Me.tMontantTTC.Text = txt2num(Me.tMontantHT.Text) * (1 + txt2num(Me.tTVA.Text) / 100)
        Me.bEnreg.Text = "Enregistrer"
    End Sub

    Private Sub dEntre_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dEntre.ValueChanged
        Me.bEnreg.Text = "Enregistrer"
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Me.bEnreg.Text = "Enregistrer"
    End Sub

    Private Sub dSortie_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dSortie.ValueChanged
        Me.bEnreg.Text = "Enregistrer"
    End Sub
End Class