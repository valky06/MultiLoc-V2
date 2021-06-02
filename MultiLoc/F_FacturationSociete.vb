Imports System.IO
Imports Microsoft.Office.Interop


Public Class F_FacturationSociete

    Sub ComptaBanque()
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date

        Try

            sSql = "select annuaire2.nom as societe,annuaire.nom as tiers,locataire.CptSuffixe,ecrDate,numfacture, ecrlib" _
            & " ,ecrmontantHT, ecrmontantTVA, ecrmontantTTC, c.CptNum, R.rubnom " _
            & " from comptagene " _
            & " left join locataire on locataire.locid=comptagene.locid" _
            & " left join annuaire on annuaire.persid=locataire.persId" _
            & " left join societe on societe.socId=comptagene.socid" _
            & " left join annuaire as annuaire2 on annuaire2.persid=societe.persid" _
            & " Left join ComptaPlan C on C.LocId=ComptaGene.LocId and c.RubId= ComptaGene.rubid and c.SocId = ComptaGene.SocId" _
            & " left join ComptaRubrique R on R.RubId = ComptaGene.RubId" _
            & " where tiers='SOCIETE' and categorie='VENTE'" _
            & " And ecrdate>=" & SqlDate(Me.dDebut) & " And ecrdate<=" & SqlDate(Me.dFin) _
            & " order by annuaire2.nom,Annuaire.nom,ecrdate"


            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                ladate = lers("ecrdate")
                Me.gCompta.Rows.Add(lers("societe").ToString, lers("tiers").ToString, lers("CptSuffixe").ToString, ladate.ToString("dd/MM/yyyy"), lers("numfacture").ToString _
                , lers("ecrlib"), lers("rubnom"), lers("CptNum"), lers("ecrmontantHT"), lers("ecrmontantTVA"), lers("ecrmontantTTC"))
            End While
            lers.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.dFin.Value = CDate("01/01/1900")
        Me.dDebut.Value = CDate("01/" & Now.Month & "/" & Now.Year)
        Me.dFin.Value = Me.dDebut.Value.AddMonths(1).AddDays(-1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call XLexport(Me.gCompta, "Facturation Société - " & Now.ToString("dd/MM/yyyy"), False, False)
    End Sub

    Private Sub dDebut_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDebut.ValueChanged, dFin.ValueChanged
        If Me.dDebut.Value < Me.dFin.Value Then
            Call ComptaBanque()
        Else
            Me.gCompta.Rows.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call ExportCompta(Me.dDebut.Value, Me.dFin.Value)
    End Sub
End Class