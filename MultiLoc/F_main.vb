Imports System.Windows.Forms
Imports System.IO

Public Class F_main

    Sub fermeToutFenetre()
        For Each f In Me.MdiChildren
            f.Dispose()
        Next
    End Sub

    Private Sub F_main_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(appXL)
            appXL = Nothing
        Catch ex As Exception
            appXL = Nothing
        Finally

            GC.Collect() ' Start .NET CLR Garbage Collection
            GC.WaitForPendingFinalizers() ' Wait for Garbage Collection to finish
        End Try
    End Sub

    Private Sub F_main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '        select Nom,DateSortiePrev ,* from locataire
        'inner join annuaire on annuaire.PersId = locataire.PersId
        'where DateSortiePrev< DATEADD(mm,+1,getdate())
        'and DateSortie>getdate()
        'order by locataire.DateSortiePrev desc

        Try
            My.Settings.Reload()
            debug = My.Settings.Debug
            debugAppel = My.Settings.DebugAppel
            If debug Then
                conSql.ConnectionString = My.Settings.SqlConDebug
                Me.Text = My.Application.Info.ProductName & " : Debug"
            Else
                Me.Text = My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString
                conSql.ConnectionString = My.Settings.SqlCon
            End If
            For Each w In Me.MdiChildren
                w.Close()
            Next

            For Each f In Directory.GetFiles(My.Settings.ChemTemp)
                If f.Contains("Appel") And f.Contains(".pdf") Then
                    File.Delete(f)

                End If
            Next
        Catch ex As Exception

        End Try
    End Sub


    Public Sub mproprio_Click(sender As System.Object, e As System.EventArgs) Handles mProprio.Click
        Call fermeToutFenetre()
        F_SocieteSuivi.MdiParent = Me
        F_SocieteSuivi.Show()
    End Sub

    Public Sub AnnuaireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AnnuaireToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_annuaire.MdiParent = Me
        F_annuaire.Show()
    End Sub

    Public Sub mnuLot_Click(sender As System.Object, e As System.EventArgs) Handles mnuLot.Click
        Call fermeToutFenetre()
        F_LotSuivi.MdiParent = Me
        F_LotSuivi.Show()
    End Sub


    Public Sub Locataire_Click(sender As System.Object, e As System.EventArgs) Handles mnuLocataire.Click
        Call fermeToutFenetre()
        F_LocaSuivi.MdiParent = Me
        F_LocaSuivi.Show()

    End Sub


    Private Sub RevisionDeLoyerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RevisionDeLoyerToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_LoyerRevision.MdiParent = Me
        F_LoyerRevision.Show()
    End Sub

    Public Sub mnuCopro_Click(sender As System.Object, e As System.EventArgs) Handles CoproToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_CoproSuivi.MdiParent = Me
        F_CoproSuivi.Show()

    End Sub

    Private Sub mnuTBail_Click(sender As System.Object, e As System.EventArgs) Handles mnuTBail.Click
        F_TypeListe.laForm = F_TypeBail
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()

    End Sub

    Private Sub mnuTSociete_Click(sender As System.Object, e As System.EventArgs) Handles mnuTSociete.Click
        F_TypeListe.laForm = F_TypeSociete
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()
    End Sub

    Private Sub mnuTLocal_Click(sender As System.Object, e As System.EventArgs) Handles mnuTLocal.Click
        F_TypeListe.laForm = F_TypeLocal
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()
    End Sub

    Private Sub mParam_Click(sender As System.Object, e As System.EventArgs) Handles mParam.Click
        If F_Param.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If conSql.State <> ConnectionState.Closed Then conSql.Close()
            Call F_main_Load(Nothing, Nothing)

            'conSql.ConnectionString = My.Settings.SqlCon
            'debug = My.Settings.Debug
        End If
    End Sub

    Private Sub mnuTRgt_Click(sender As System.Object, e As System.EventArgs) Handles mnuTRgt.Click
        F_TypeListe.laForm = F_TypeReglement
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()
    End Sub

    Private Sub mnuTPeriode_Click(sender As System.Object, e As System.EventArgs) Handles mnuTPeriode.Click
        F_TypeListe.laForm = F_TypePeriode
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()
    End Sub

    Private Sub mnuIndices(sender As System.Object, e As System.EventArgs) Handles IndicesToolStripMenuItem.Click
        F_IndiceListe.ShowDialog()
    End Sub

    Private Sub mnuBilanLocataire(sender As System.Object, e As System.EventArgs) Handles BilanLocataireToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_LocaBalance.MdiParent = Me
        F_LocaBalance.Show()
    End Sub

    Private Sub CompteDépôtToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompteDépôtToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_DepotBalance.MdiParent = Me
        F_DepotBalance.Show()
    End Sub

    Private Sub RèglementFournisseurToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RèglementFournisseurToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_FourBalance.MdiParent = Me
        F_FourBalance.Show()
    End Sub


    Private Sub RévisionDépôtGarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RévisionDépôtGarToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_DepotRevision.MdiParent = Me
        F_DepotRevision.Show()
    End Sub


    Public Sub mnuClient(sender As System.Object, e As System.EventArgs)
        Call fermeToutFenetre()
        F_ClientSuivi.MdiParent = Me
        F_ClientSuivi.Show()
    End Sub

    Private Sub GrandLiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GrandLiToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_DepotSuivi.MdiParent = Me
        F_DepotSuivi.Show()
    End Sub

    Private Sub EmplacementsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmplacementsToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_EmpSuivi.MdiParent = Me
        F_EmpSuivi.Show()
    End Sub

    Private Sub ClientsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientsToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_ClientSuivi.MdiParent = Me
        F_ClientSuivi.Show()
    End Sub

    Private Sub MiseÀJourToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MiseÀJourToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.asyst.fr/MultiLoc/")
    End Sub

    Private Sub GrandLivreLocataireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GrandLivreLocataireToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_GrandLivre.GL = "Locataire"
        F_GrandLivre.MdiParent = Me
        F_GrandLivre.Show()
    End Sub

    Private Sub TypeAdresseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TypeAdresseToolStripMenuItem.Click
        F_TypeListe.laForm = F_TypeContact
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()
    End Sub

    Private Sub TypeChargeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TypeChargeToolStripMenuItem.Click
        F_TypeListe.laForm = F_TypeChargeCat
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()
    End Sub

    Private Sub AppelDeLoyerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AppelDeLoyerToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_LocaListeAppel.MdiParent = Me
        F_LocaListeAppel.Show()
    End Sub

    Private Sub FacturesMensuellesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturesMensuellesToolStripMenuItem.Click
        Call fermeToutFenetre()
        F_FacturationLoc.MdiParent = Me
        F_FacturationLoc.Show()
    End Sub

    Private Sub RubriqueComptableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RubriqueComptableToolStripMenuItem.Click
        F_TypeListe.laForm = F_TypeCptRub
        F_TypeListe.MOdeEdit = True
        F_TypeListe.ShowDialog()
    End Sub

    Private Sub FinDeBailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinDeBailToolStripMenuItem.Click
        F_Requete.laReq = "select a.nom as locataire, t.tbailnom as [Type Bail], t.freqan as [Fréquence], l.dateentree as [Entrée] " _
            & " ,dateadd(yy,(floor(dbo.fullmonthsdif(dateentree,getdate())/12/freqan)+1)*freqan,dateentree) [Prochaine Echéance]" _
            & " from locataire L inner join annuaire A on A.persid=L.persId left join typebail T on t.tbailid=l.tbailid" _
            & "  where DateSortie is null or DateSortie>getdate()" _
            & " order by [Prochaine Echéance] asc"
        F_Requete.leNOm = "Liste des Baux"
        F_Requete.MdiParent = Me
        F_Requete.Show()
    End Sub
End Class
