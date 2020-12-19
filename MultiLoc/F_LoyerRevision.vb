Imports System.Math
Imports System.IO

Public Class F_LoyerRevision

    Class UnIndice
        Public type As String
        Public valeur As Double

        Sub New(TYpeIndice As String, valeurIndice As Double)
            type = TYpeIndice
            valeur = valeurIndice
        End Sub
    End Class

    Sub listeIndice()
        Call ComboRempli("SELECT DISTINCT Annee*10+trimestrenum AS i1, trimestrenom + ' ' + cast(annee as nvarchar(4)) AS Expr1, annee, trimestrenum FROM indice order by annee desc, trimestrenum desc", Me.lIndice.ComboBox, conSql)
    End Sub
    Private Sub F_Revision_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call listeIndice()
    End Sub

    Sub listeLocat()
        Dim sSql As String
        Dim lers As OleDb.OleDbDataReader
        Dim lindice As Double
        Dim leloyer As Double
        Dim lannee As Integer
        Dim leTrimestre As Integer

        lannee = Me.lIndice.SelectedItem.value.ToString.Substring(0, 4)
        leTrimestre = Me.lIndice.SelectedItem.value.ToString.Substring(4, 1)
        Dim lesINdices As New List(Of UnIndice)
        sSql = "select TypeIndice,indice from indice where annee=" & lannee & " and trimestrenum=" & leTrimestre
        lers = sqlLit(sSql, conSql)
        While lers.Read
            lesINdices.Add(New UnIndice(lers("TypeIndice"), lers("indice")))
        End While
        lers.Close()

        Me.gRevision.Rows.Clear()
        sSql = "SELECT LocId, nom, Adr1, LoyerInit, TypeIndice, Annee, TrimestreNum, Indice, Localite " _
        & " FROM Indice INNER JOIN (Annuaire INNER JOIN Locataire ON Annuaire.PersId = Locataire.PersId) ON Indice.IndId = Locataire.IndId " _
        & " where trimestrenum=" & leTrimestre

        lers = sqlLit(sSql, conSql)
        While lers.Read
            lindice = 0
            leloyer = 0
            For Each l In lesINdices
                If l.type = lers("TypeIndice") Then lindice = l.valeur
            Next

            If lindice <> 0 And lers("indice") <> 0 Then
                leloyer = lindice / nz(lers("indice"), 0) * nz(lers("loyerInit"), 0)
            End If

            Me.gRevision.Rows.Add(lers("locid"), lers("nom"), lers("Adr1").ToString & " - " & lers("localite").ToString _
            , lers("loyerInit"), lers("TypeIndice").ToString, lers("Annee").ToString, lers("TrimestreNum"), lers("Indice"), lindice, leloyer, 0)
        End While
        lers.Close()
    End Sub




    Private Sub tXL_Click(sender As System.Object, e As System.EventArgs) Handles tXL.Click
        Call XLexport(Me.gRevision, "Révision Loyer")
    End Sub

    Private Sub tWord_Click(sender As System.Object, e As System.EventArgs)
        If Me.gRevision.SelectedRows.Count > 0 Then
            Call wordFusionSQL("courrier.docx", "SELECT nom, Adr1, CodePostal, Localite FROM Annuaire WHERE PersId=" & Me.gRevision.SelectedRows(0).Cells("PersId").Value)

        End If
    End Sub


    Private Sub lIndice_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lIndice.SelectedIndexChanged
        Call listeLocat()
    End Sub

    Private Sub cTout_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cTout.CheckedChanged
        For i = 0 To Me.gRevision.RowCount - 1
            Me.gRevision.Rows(i).Cells("Enreg").Value = IIf(Me.cTout.Checked, 1, 0)
        Next
    End Sub

    Private Sub bEnreg_Click(sender As System.Object, e As System.EventArgs) Handles bEnreg.Click
        Dim sSql As String = ""
        Dim leslots As String = ""
        Dim leCsv As String = ""
        Dim s As String = ""
        Dim lannee As Integer
        Dim leTrimestre As Integer
        Dim NBloc As Integer = 0

        Try
            Me.gRevision.EndEdit()

            lannee = Me.lIndice.SelectedItem.value.ToString.Substring(0, 4)
            leTrimestre = Me.lIndice.SelectedItem.value.ToString.Substring(4, 1)

            leCsv = My.Settings.ChemTemp & "LocataireRevisionLoyer.csv"
            Dim fFichier As New StreamWriter(leCsv)
            s = "nom;Adr1;CodePostal;Localite;TBailNom;lesLots;TypeIndice;LoyerDepart;IndiceDepart;TrimestreDepart;IndiceActuel;TrimestreActuel;LoyerActuel"
            fFichier.WriteLine(s)

            s = ""
            For i = 0 To Me.gRevision.RowCount - 1
                With Me.gRevision.Rows(i)
                    If .Cells("Enreg").Value = 1 Then
                        NBloc += 1
                        sSql = "update locataire set loyerActu = '" & Round(txt2num(.Cells("loyFin").Value), 2) & "' where locid= " & .Cells("locid").Value
                        sqlDo(sSql, conSql)

                        s = ""

                        ''liste des lots du locataire
                        'leslots = ""
                        'sSql = "SELECT Batiment, Typelocaux, LotNom" _
                        '& " FROM Lot INNER JOIN location ON Lot.lotid = location.lotId" _
                        '& " where locId= " & .Cells("Locid").Value
                        'lers = sqlLit(sSql, conSql)
                        'While lers.Read
                        '    leslots &= lers("Batiment").ToString & " - " & lers("typeLocaux").ToString & " " & lers("lotNom").ToString & Chr(13)
                        'End While
                        'lers.Close()

                        ''Données locataire
                        'sSql = "SELECT Societe, Adr1, CodePostal, Localite, TBailNom" _
                        '& " FROM (Locataire LEFT JOIN Annuaire ON Locataire.PersId = Annuaire.PersId) " _
                        '& " LEFT JOIN TypeBail ON Locataire.TBailId = TypeBail.TBailId " _
                        '& " where locId=" & .Cells("LocID").Value
                        'lers = sqlLit(sSql, conSql)
                        'While lers.Read
                        '    s = lers("Societe").ToString & ";" & lers("Adr1").ToString & ";" & lers("CodePostal").ToString & ";" & lers("Localite").ToString & ";" & lers("TBailNom").ToString & ";" & leslots
                        'End While

                        ''Données loyer
                        's &= " ;" & .Cells("TypeIndice").Value & ";" & .Cells("LoyDepart").Value & ";" & .Cells("Indice").Value _
                        '& ";" & .Cells("Annee").Value & "-" & .Cells("Trimestre").Value _
                        '& ";" & .Cells("IndiceActu").Value & ";" & lannee & "-" & leTrimestre & ";" & Round(.Cells("LoyFIn").Value, 2)

                        'fFichier.WriteLine(s)
                    End If
                End With
            Next
            ' fFichier.Close()

            '  If NBloc > 0 Then
            'If MessageBox.Show("Imprimer les documents ?", "Attention", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then Call wordFusion("LocataireRevisionLoyer.dotx", "")
            '    End If
        Catch ex As Exception

        End Try

        Me.Dispose()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripLabel1.Click

        If F_IndiceListe.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call listeIndice()
            Call listeLocat()
        End If
    End Sub


End Class