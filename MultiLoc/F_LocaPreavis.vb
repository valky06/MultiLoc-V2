Public Class F_locaPreavis
    Public leLocId As Integer

    Sub EnregPreavis()
        Dim ssql As String

        If Me.dPreavis.Checked Then
            ssql = "update locataire set datepreavis = '" & Me.dPreavis.Value & "', dateSortiePrev ='" & Me.dSortiePrev.Value & "' where locid=" & Me.leLocId
            sqlDo(ssql, conSql)
            sqlDo("UPDATE Lot INNER JOIN Location ON Lot.LotId = Location.LotId SET statut = 'Préavis' where statut='Occupé' and locId=" & Me.leLocId, conSql)
        Else
            ssql = "update locataire set datepreavis = NULL, dateSortiePrev = NULL where locid=" & Me.leLocId
            sqlDo(ssql, conSql)
            sqlDo("UPDATE Lot INNER JOIN Location ON Lot.LotId = Location.LotId SET statut = 'Occupé' where locId=" & Me.leLocId, conSql)
        End If

    End Sub

    Sub courrierPreavis()
        Dim ssql As String
        Dim lesLot As String = ""
        Try
            For i = 0 To F_LocaSuivi.gLot.RowCount - 1
                lesLot &= F_LocaSuivi.gLot.Rows(i).Cells("Batiment").Value & " - " & F_LocaSuivi.gLot.Rows(i).Cells("typeLot").Value & " " & F_LocaSuivi.gLot.Rows(i).Cells("lotNom").Value & Chr(13)
            Next

            ssql = "SELECT nom, Adr1, CodePostal, Localite, TRgtNom, TPerNom, TBailNom, DateEntree, DatePreavis,DateSortiePrev, Loyer, charge, RegimeFiscal" _
            & ", '" & lesLot & "' as lesLots, Indice, TrimestreNom, Annee, TypeIndice" _
            & " FROM ((((Locataire LEFT JOIN Annuaire ON Locataire.PersId = Annuaire.PersId) " _
            & " LEFT JOIN TypeBail ON Locataire.TBailId = TypeBail.TBailId) " _
            & " LEFT JOIN TypePeriode ON Locataire.TPerId = TypePeriode.TPerId) " _
            & " LEFT JOIN TypeReglement ON Locataire.TRgtId = TypeReglement.TRgtId)" _
            & "  LEFT JOIN Indice ON Locataire.IndId = Indice.IndId " _
            & " where locId=" & leLocId

            Call wordFusionSQL("LocatairePreavis.docx", ssql)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub F_locPreavis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader

        ssql = "select DatePreavis, dateSortiePrev from locataire where locId=" & leLocId
        lers = sqlLit(ssql, conSql)
        While lers.Read
            Me.dSortiePrev.Value = nz(lers("DatePreavis"), Now)
            Me.dSortiePrev.Value = nz(lers("dateSortiePrev"), Now)
        End While
        lers.Close()
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Call EnregPreavis()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub bCourrier_Click(sender As System.Object, e As System.EventArgs) Handles bCourrier.Click
        Call EnregPreavis()
        Call courrierPreavis()
    End Sub

    Private Sub dPreavis_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dPreavis.ValueChanged
        Me.dSortiePrev.Checked = Me.dPreavis.Checked
    End Sub
End Class