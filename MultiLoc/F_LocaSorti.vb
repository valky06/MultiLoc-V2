Public Class F_LocaSorti
    Public leLocId As Integer

    Sub EnregSortie()
        Dim ssql As String

        If Me.dSortie.Checked Then
            ssql = "update locataire set dateSortie = '" & Me.dSortie.Value & "' where locid=" & Me.leLocId
            sqlDo(ssql, conSql)
            sqlDo("UPDATE Lot INNER JOIN Location ON Lot.LotId = Location.LotId SET statut = 'Libre', locActuId=0 where locId=" & Me.leLocId, conSql)
        Else
            ssql = "update locataire set datesortie = NULL where  locid=" & Me.leLocId
            sqlDo(ssql, conSql)

            sqlDo("UPDATE (Location INNER JOIN Locataire ON Location.LocId = Locataire.LocId) INNER JOIN Lot ON Location.LotId = Lot.LotId " _
            & " SET Lot.Statut = 'Prévis' WHERE datePreavis is not null and  Locataire.LocId= " & Me.leLocId, conSql)

            sqlDo("UPDATE (Location INNER JOIN Locataire ON Location.LocId = Locataire.LocId) INNER JOIN Lot ON Location.LotId = Lot.LotId " _
            & " SET Lot.Statut = 'Occupé' WHERE datePreavis is  null and Locataire.LocId= " & Me.leLocId, conSql)

        End If

    End Sub

    Sub courrierSortie()
        Dim ssql As String
        Dim lesLot As String = ""
        Try
            For i = 0 To F_LocaSuivi.gLot.RowCount - 1
                lesLot &= F_LocaSuivi.gLot.Rows(i).Cells("Batiment").Value & " - " & F_LocaSuivi.gLot.Rows(i).Cells("typeLot").Value & " " & F_LocaSuivi.gLot.Rows(i).Cells("lotNom").Value & Chr(13)
            Next

            ssql = "SELECT nom, Adr1, CodePostal, Localite, TRgtNom, TPerNom, TBailNom, DateEntree,DateSortie,  Loyer, charge, RegimeFiscal" _
            & ", '" & lesLot & "' as lesLots, Indice, TrimestreNom, Annee, TypeIndice" _
            & " FROM ((((Locataire LEFT JOIN Annuaire ON Locataire.PersId = Annuaire.PersId) " _
            & " LEFT JOIN TypeBail ON Locataire.TBailId = TypeBail.TBailId) " _
            & " LEFT JOIN TypePeriode ON Locataire.TPerId = TypePeriode.TPerId) " _
            & " LEFT JOIN TypeReglement ON Locataire.TRgtId = TypeReglement.TRgtId)" _
            & "  LEFT JOIN Indice ON Locataire.IndId = Indice.IndId " _
            & " where locId=" & leLocId

            Call wordFusionSQL("LocataireSortie.docx", ssql)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub F_locPreavis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim lers As OleDb.OleDbDataReader

        ssql = "select DateSortie from locataire where locId=" & leLocId
        lers = sqlLit(ssql, conSql)
        While lers.Read
            Me.dSortie.Value = nz(lers("dateSortie"), Now)
        End While
        lers.Close()
    End Sub

    Private Sub bAnnul_Click(sender As System.Object, e As System.EventArgs) Handles bAnnul.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bOK_Click(sender As System.Object, e As System.EventArgs) Handles bOK.Click
        Call EnregSortie()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub bCourrier_Click(sender As System.Object, e As System.EventArgs) Handles bCourrier.Click
        Call EnregSortie()
        Call courrierSortie()
    End Sub


End Class