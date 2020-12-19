Imports System.IO
Public Class F_LocaListeAppel
    Sub ListeAppel()
        Dim sSql As String = ""
        Dim lers As OleDb.OleDbDataReader
        Dim ladate As Date

        Try

            sqlDo("drop table #Q1", conSql, False)
            sqlDo("drop table #Q2", conSql, False)


            sSql = "select locid,numpiece,numfacture,ecrecheance, ecrLib,ecrmontantHT as loyerHT,0 as chargeHT" _
            & " , ecrmontantTVA, ecrmontantTTC  into #Q1 from comptagene " _
            & " where rubrique='LOCATAIRE' and Categorie='LOYER'" _
            & " and ecrecheance>=" & SqlDate(Me.dDebut) & " and ecrecheance<=" & SqlDate(Me.dFin)
            sqlDo(sSql, conSql)

            sSql = "select locid,numpiece,numfacture,ecrecheance, ecrLib,0 as loyerHT,ecrmontantHT as chargeHT" _
            & ", ecrmontantTVA, ecrmontantTTC  into #Q2 from comptagene" _
            & " where rubrique='LOCATAIRE' and Categorie='PROVCHARGE'" _
            & " and ecrecheance>=" & SqlDate(Me.dDebut) & " and ecrecheance<=" & SqlDate(Me.dFin)
            sqlDo(sSql, conSql)

            sSql = " select l.nom as tiers,numfacture,ecrecheance,'411' + cptsuffixe as cpt,lotlib,s.nom as societe" _
            & " ,sum(-loyerHT) as LOYHT,sum(-chargeHT) as CHHT, sum(-loyerHT-chargeHT) as LOYCH" _
            & " ,sum(-ecrmontantTVA) as TVA, sum(-ecrmontantTTC) as TTC" _
            & " from (" _
            & " select * from #q1 union  select  * from #q2 ) as T" _
            & " inner join locataire on t.locId = locataire.locId " _
            & " left join annuaire as l on locataire.persId= l.persId " _
            & " left join societe on locataire.socid=societe.socid" _
            & " left join annuaire as s on societe.persid=s.persid" _
            & " group by l.nom ,numfacture,cptsuffixe ,lotlib,s.nom ,ecrecheance" _
            & " order by  tiers,cpt,societe,ecrecheance,numfacture"

            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                ladate = lers("ecrecheance")
                Me.gCompta.Rows.Add(lers("societe").ToString, ladate.ToString("dd/MM/yyyy"), lers("cpt").ToString, lers("tiers").ToString, lers("lotlib").ToString, lers("numfacture").ToString, lers("LOYHT"), lers("CHHT"), lers("LOYCH"), lers("TVA"), lers("TTC"))
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
        If Me.bSousTotal.Checked Then Call ListeAppel()
        Call XLexport(Me.gCompta, "Liste des appels - " & Now.ToString("dd/MM/yyyy"), IIf(Me.bSousTotal.Checked, "LISTEAPP", ""))
    End Sub

    Private Sub dDebut_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dDebut.ValueChanged, dFin.ValueChanged
        If Me.dDebut.Value < Me.dFin.Value Then
            Call ListeAppel()
        Else
            Me.gCompta.Rows.Clear()
        End If
    End Sub

End Class