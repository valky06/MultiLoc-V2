Imports System.IO
Public Class F_LocaBalance


    Sub ComptaLocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim debit As Double
        Dim credit As Double
        Dim leType As String

        Try
            sSql = "SELECT A2.nom societe ,case when L.TypeLoc=1 then 'Locataire' else 'Client' end as Type,  A.nom as locataire, Sum(C.ecrMontantTTC) AS solde" _
                & " FROM comptaGene C " _
                & " left join  Locataire L ON C.LocId = L.LocId LEFT JOIN Annuaire A ON A.PersId = L.PersId left join societe S on S.SocId = c.SocId" _
                & " left join Annuaire A2 on A2.PersId = S.PersId" _
                & " where tiers in ('LOCATAIRE','CLIENT')  GROUP BY L.LocId,  A.nom, A2.Nom,L.TypeLoc  order by A2.nom, A.Nom"



            Me.gCompta.Rows.Clear()
            lers = sqlLit(sSql, conSql)
            While lers.Read
                credit = IIf(lers("solde") >= 0, lers("solde"), 0)
                debit = IIf(lers("solde") < 0, -lers("solde"), 0)
                Me.gCompta.Rows.Add(lers("societe"), lers("Type"), lers("locataire").ToString, debit, credit)
            End While
            lers.Close()

        Catch ex As Exception
            If debug Then MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub F_proprio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call ComptaLocat()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bXL.Click
        Call XLexport(Me.gCompta, "Balance Locataires")
    End Sub

End Class