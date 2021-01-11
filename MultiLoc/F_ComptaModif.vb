Imports System.Math

Public Class F_ComptaModif
    Public lEcrId As Integer


    Sub AffCategorie()
        Me.cCategorie.Items.Add(New ListItem("APPELDG", "APPELDG"))
        Me.cCategorie.Items.Add(New ListItem("AVOIRDG", "AVOIRDG"))
        Me.cCategorie.Items.Add(New ListItem("CHARGE", "CHARGE"))
        Me.cCategorie.Items.Add(New ListItem("DECAISSEMENT", "DECAISSEMENT"))
        Me.cCategorie.Items.Add(New ListItem("ENCAISSEMENT", "ENCAISSEMENT"))
        Me.cCategorie.Items.Add(New ListItem("LOYER", "LOYER"))
        Me.cCategorie.Items.Add(New ListItem("PROVCHARGE", "PROVCHARGE"))
        Me.cCategorie.Items.Add(New ListItem("REGULPROV", "REGULPROV"))
        Me.cCategorie.Items.Add(New ListItem("REGULREEL", "REGULREEL"))
        Me.cCategorie.Items.Add(New ListItem("REPRISEDG", "REPRISEDG"))
    End Sub
    Private Sub F_location_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ErrorProvider1.Clear()
        Call formVide(Me)
        Call AffCategorie()
        Dim sSql As String = ""

        If Me.lEcrId <> 0 Then
            sSql = "select ecrdate,ecrEcheance,categorie,NumPIece,IndexPiece,ecrLib,ecrMontantHT,ecrMontantTVA,ecrMontantTTC,AnneeEffet from ComptaGene" _
                & " where ecrid=" & lEcrId
            Call FormRempli(Me, ssql, conSql)
        End If
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Me.ErrorProvider1.Clear()
        Dim ssql As String
        Dim mHT, mTVA, mTTC As Double

        mHT = txt2num(Me.tMontHT.Text)
        mTVA = txt2num(Me.tMontTVA.Text)
        mTTC = txt2num(Me.tMontTTC.Text)

        If FormVerif(Me, Me.ErrorProvider1) Then
            ssql = "Update comptaGene set ecrdate=" & Date2sql(Me.dDate.Value) _
                & ",AnneeEffet=" & num2sql(Me.tAnneeEff.Text) _
                & ",ecrecheance=" & Date2sql(Me.dEcheance.Value) _
                & ",ecrlib='" & txt2sql(Me.tLib.Text) & "'" _
                & ",Categorie='" & txt2sql(Me.cCategorie.Text) & "'" _
                & ",ecrMontantHT=" & num2sql(mHT) _
                & ",ecrMontantTVA=" & num2sql(mTVA) _
                & ",ecrMontantTTC=" & num2sql(mTTC) _
                & " where numpiece=" & Me.tnumpiece.Text & " and indexpiece=" & Me.tINdexPiece.Text _
                & " and ecrid=" & Me.lEcrId
            sqlDo(ssql, conSql)

            ssql = "Update comptaGene set ecrdate=" & Date2sql(Me.dDate.Value) _
                & ",AnneeEffet=" & num2sql(Me.tAnneeEff.Text) _
                & ",ecrecheance=" & Date2sql(Me.dEcheance.Value) _
                & ",ecrlib='" & txt2sql(Me.tLib.Text) & "'" _
                & ",Categorie='" & txt2sql(Me.cCategorie.Text) & "'" _
                & ",ecrMontantHT=" & num2sql(-mHT) _
                & ",ecrMontantTVA=" & num2sql(-mTVA) _
                & ",ecrMontantTTC=" & num2sql(-mTTC) _
                & " where numpiece=" & Me.tnumpiece.Text & " and indexpiece=" & Me.tINdexPiece.Text _
                & " and ecrid<>" & Me.lEcrId
            sqlDo(ssql, conSql)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cCategorie.SelectedIndexChanged

    End Sub

    Private Sub tMontHT_TextChanged(sender As System.Object, e As System.EventArgs) Handles tMontHT.TextChanged
        '        Me.tMontTVA.Text = Round(Val(Me.tMontHT.Text) * My.Settings.TVADefaut / 100, 2)
    End Sub
End Class