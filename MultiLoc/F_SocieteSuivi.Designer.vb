﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_SocieteSuivi
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.oOnglet = New System.Windows.Forms.TabControl()
        Me.Compta = New System.Windows.Forms.TabPage()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.dateEcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lots = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFacture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numfact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tRechCat = New System.Windows.Forms.TextBox()
        Me.lAnnee = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bEditFActure = New System.Windows.Forms.Button()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Bien = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gLot = New System.Windows.Forms.DataGridView()
        Me.lotId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coproId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Copro = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.batiment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.niveau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.soldeLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.locId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Locataire = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Document = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.gDoc = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docPath = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tModeleAppel = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.gSociete = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.dEntre = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tModeleFacture = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PlanCompta = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.bAddCpt = New System.Windows.Forms.Button()
        Me.gPlanC = New System.Windows.Forms.DataGridView()
        Me.bDelCpt = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gPlanLoc = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bWord = New System.Windows.Forms.ToolStripButton()
        Me.bXL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.lSociete = New System.Windows.Forms.ComboBox()
        Me.kSociete = New System.Windows.Forms.LinkLabel()
        Me.oDial = New System.Windows.Forms.OpenFileDialog()
        Me.pcid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rubrique = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeTiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeTiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cptnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cptnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcidloc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lesLots = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cptNumLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oOnglet.SuspendLayout()
        Me.Compta.SuspendLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bien.SuspendLayout()
        CType(Me.gLot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Document.SuspendLayout()
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.gSociete.SuspendLayout()
        Me.PlanCompta.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gPlanC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gPlanLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'oOnglet
        '
        Me.oOnglet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oOnglet.Controls.Add(Me.Compta)
        Me.oOnglet.Controls.Add(Me.Bien)
        Me.oOnglet.Controls.Add(Me.Document)
        Me.oOnglet.Controls.Add(Me.TabPage1)
        Me.oOnglet.Controls.Add(Me.PlanCompta)
        Me.oOnglet.Enabled = False
        Me.oOnglet.Location = New System.Drawing.Point(12, 67)
        Me.oOnglet.Name = "oOnglet"
        Me.oOnglet.SelectedIndex = 0
        Me.oOnglet.Size = New System.Drawing.Size(1124, 503)
        Me.oOnglet.TabIndex = 2
        '
        'Compta
        '
        Me.Compta.Controls.Add(Me.gCompta)
        Me.Compta.Controls.Add(Me.Label16)
        Me.Compta.Controls.Add(Me.tRechCat)
        Me.Compta.Controls.Add(Me.lAnnee)
        Me.Compta.Controls.Add(Me.Label15)
        Me.Compta.Controls.Add(Me.bEditFActure)
        Me.Compta.Controls.Add(Me.bsuppEcrit)
        Me.Compta.Controls.Add(Me.Button9)
        Me.Compta.Location = New System.Drawing.Point(4, 22)
        Me.Compta.Name = "Compta"
        Me.Compta.Size = New System.Drawing.Size(1116, 477)
        Me.Compta.TabIndex = 3
        Me.Compta.Text = "Compte"
        Me.Compta.UseVisualStyleBackColor = True
        '
        'gCompta
        '
        Me.gCompta.AllowUserToAddRows = False
        Me.gCompta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gCompta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gCompta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gCompta.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gCompta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gCompta.ColumnHeadersHeight = 46
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dateEcr, Me.DateEch, Me.Compte, Me.Tiers, Me.Cat, Me.lots, Me.NumFacture, Me.Libelle, Me.MontantHT, Me.numfact})
        Me.gCompta.Location = New System.Drawing.Point(6, 32)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(974, 442)
        Me.gCompta.TabIndex = 55
        '
        'dateEcr
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dateEcr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dateEcr.FillWeight = 40.0!
        Me.dateEcr.HeaderText = "Date"
        Me.dateEcr.Name = "dateEcr"
        Me.dateEcr.ReadOnly = True
        '
        'DateEch
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DateEch.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateEch.FillWeight = 40.0!
        Me.DateEch.HeaderText = "Echéance"
        Me.DateEch.Name = "DateEch"
        Me.DateEch.ReadOnly = True
        '
        'Compte
        '
        Me.Compte.FillWeight = 50.0!
        Me.Compte.HeaderText = "Compte"
        Me.Compte.Name = "Compte"
        Me.Compte.ReadOnly = True
        '
        'Tiers
        '
        Me.Tiers.HeaderText = "Tiers"
        Me.Tiers.Name = "Tiers"
        Me.Tiers.ReadOnly = True
        '
        'Cat
        '
        Me.Cat.FillWeight = 50.0!
        Me.Cat.HeaderText = "Catégorie"
        Me.Cat.Name = "Cat"
        Me.Cat.ReadOnly = True
        '
        'lots
        '
        Me.lots.HeaderText = "Lots"
        Me.lots.Name = "lots"
        Me.lots.ReadOnly = True
        '
        'NumFacture
        '
        Me.NumFacture.FillWeight = 50.0!
        Me.NumFacture.HeaderText = "N°Facture"
        Me.NumFacture.Name = "NumFacture"
        Me.NumFacture.ReadOnly = True
        '
        'Libelle
        '
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        '
        'MontantHT
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.MontantHT.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontantHT.FillWeight = 50.0!
        Me.MontantHT.HeaderText = "Montant HT"
        Me.MontantHT.Name = "MontantHT"
        Me.MontantHT.ReadOnly = True
        '
        'numfact
        '
        Me.numfact.HeaderText = "numfact"
        Me.numfact.Name = "numfact"
        Me.numfact.ReadOnly = True
        Me.numfact.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(174, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Catégorie contient"
        '
        'tRechCat
        '
        Me.tRechCat.Location = New System.Drawing.Point(273, 6)
        Me.tRechCat.Name = "tRechCat"
        Me.tRechCat.Size = New System.Drawing.Size(100, 20)
        Me.tRechCat.TabIndex = 53
        '
        'lAnnee
        '
        Me.lAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lAnnee.FormattingEnabled = True
        Me.lAnnee.Location = New System.Drawing.Point(47, 5)
        Me.lAnnee.Name = "lAnnee"
        Me.lAnnee.Size = New System.Drawing.Size(121, 21)
        Me.lAnnee.TabIndex = 52
        Me.lAnnee.Tag = "budAnnee,no"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Année"
        '
        'bEditFActure
        '
        Me.bEditFActure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEditFActure.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bEditFActure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditFActure.Image = Global.MultiLoc.My.Resources.Resources.Edit1
        Me.bEditFActure.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bEditFActure.Location = New System.Drawing.Point(1003, 141)
        Me.bEditFActure.Name = "bEditFActure"
        Me.bEditFActure.Size = New System.Drawing.Size(94, 42)
        Me.bEditFActure.TabIndex = 13
        Me.bEditFActure.Text = "Edition Facture"
        Me.bEditFActure.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bEditFActure.UseVisualStyleBackColor = True
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.bsuppEcrit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bsuppEcrit.Location = New System.Drawing.Point(1003, 189)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(94, 42)
        Me.bsuppEcrit.TabIndex = 12
        Me.bsuppEcrit.Text = "Supprimer Ecrit."
        Me.bsuppEcrit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bsuppEcrit.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.Location = New System.Drawing.Point(1003, 93)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(94, 42)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Facture Client"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Bien
        '
        Me.Bien.Controls.Add(Me.Button1)
        Me.Bien.Controls.Add(Me.gLot)
        Me.Bien.Location = New System.Drawing.Point(4, 22)
        Me.Bien.Name = "Bien"
        Me.Bien.Padding = New System.Windows.Forms.Padding(3)
        Me.Bien.Size = New System.Drawing.Size(1116, 477)
        Me.Bien.TabIndex = 0
        Me.Bien.Text = "Biens"
        Me.Bien.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1034, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 41)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Nouvelle copro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gLot
        '
        Me.gLot.AllowUserToAddRows = False
        Me.gLot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gLot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gLot.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gLot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gLot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gLot.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lotId, Me.coproId, Me.Copro, Me.batiment, Me.typeLot, Me.lot, Me.niveau, Me.statut, Me.soldeLot, Me.locId, Me.Locataire})
        Me.gLot.Location = New System.Drawing.Point(6, 6)
        Me.gLot.MultiSelect = False
        Me.gLot.Name = "gLot"
        Me.gLot.ReadOnly = True
        Me.gLot.RowHeadersVisible = False
        Me.gLot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gLot.Size = New System.Drawing.Size(1022, 468)
        Me.gLot.TabIndex = 1
        '
        'lotId
        '
        Me.lotId.HeaderText = "Id"
        Me.lotId.Name = "lotId"
        Me.lotId.ReadOnly = True
        Me.lotId.Visible = False
        '
        'coproId
        '
        Me.coproId.HeaderText = "coproId"
        Me.coproId.Name = "coproId"
        Me.coproId.ReadOnly = True
        Me.coproId.Visible = False
        '
        'Copro
        '
        Me.Copro.HeaderText = "Copro"
        Me.Copro.Name = "Copro"
        Me.Copro.ReadOnly = True
        Me.Copro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Copro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'batiment
        '
        Me.batiment.HeaderText = "Batiment"
        Me.batiment.Name = "batiment"
        Me.batiment.ReadOnly = True
        '
        'typeLot
        '
        Me.typeLot.FillWeight = 50.0!
        Me.typeLot.HeaderText = "Type"
        Me.typeLot.Name = "typeLot"
        Me.typeLot.ReadOnly = True
        '
        'lot
        '
        Me.lot.FillWeight = 50.0!
        Me.lot.HeaderText = "Lot"
        Me.lot.Name = "lot"
        Me.lot.ReadOnly = True
        Me.lot.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'niveau
        '
        Me.niveau.HeaderText = "Niveau"
        Me.niveau.Name = "niveau"
        Me.niveau.ReadOnly = True
        '
        'statut
        '
        Me.statut.FillWeight = 50.0!
        Me.statut.HeaderText = "statut"
        Me.statut.Name = "statut"
        Me.statut.ReadOnly = True
        Me.statut.Visible = False
        '
        'soldeLot
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.soldeLot.DefaultCellStyle = DataGridViewCellStyle5
        Me.soldeLot.FillWeight = 50.0!
        Me.soldeLot.HeaderText = "solde"
        Me.soldeLot.Name = "soldeLot"
        Me.soldeLot.ReadOnly = True
        '
        'locId
        '
        Me.locId.HeaderText = "LocId"
        Me.locId.Name = "locId"
        Me.locId.ReadOnly = True
        Me.locId.Visible = False
        '
        'Locataire
        '
        Me.Locataire.HeaderText = "Locataire"
        Me.Locataire.Name = "Locataire"
        Me.Locataire.ReadOnly = True
        Me.Locataire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Locataire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Document
        '
        Me.Document.Controls.Add(Me.Button3)
        Me.Document.Controls.Add(Me.Button6)
        Me.Document.Controls.Add(Me.gDoc)
        Me.Document.Location = New System.Drawing.Point(4, 22)
        Me.Document.Name = "Document"
        Me.Document.Padding = New System.Windows.Forms.Padding(3)
        Me.Document.Size = New System.Drawing.Size(1116, 477)
        Me.Document.TabIndex = 2
        Me.Document.Text = "Documents"
        Me.Document.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.Button3.Location = New System.Drawing.Point(1081, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 23)
        Me.Button3.TabIndex = 51
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button6.Location = New System.Drawing.Point(1081, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(29, 23)
        Me.Button6.TabIndex = 50
        Me.Button6.TabStop = False
        Me.Button6.UseVisualStyleBackColor = True
        '
        'gDoc
        '
        Me.gDoc.AllowUserToAddRows = False
        Me.gDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gDoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gDoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dateCrea, Me.docNom, Me.docPath})
        Me.gDoc.Location = New System.Drawing.Point(6, 6)
        Me.gDoc.MultiSelect = False
        Me.gDoc.Name = "gDoc"
        Me.gDoc.ReadOnly = True
        Me.gDoc.RowHeadersVisible = False
        Me.gDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gDoc.Size = New System.Drawing.Size(1069, 468)
        Me.gDoc.TabIndex = 49
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'dateCrea
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dateCrea.DefaultCellStyle = DataGridViewCellStyle7
        Me.dateCrea.FillWeight = 20.0!
        Me.dateCrea.HeaderText = "Date"
        Me.dateCrea.Name = "dateCrea"
        Me.dateCrea.ReadOnly = True
        '
        'docNom
        '
        Me.docNom.HeaderText = "Document"
        Me.docNom.Name = "docNom"
        Me.docNom.ReadOnly = True
        '
        'docPath
        '
        Me.docPath.HeaderText = "Fichier"
        Me.docPath.Name = "docPath"
        Me.docPath.ReadOnly = True
        Me.docPath.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tModeleAppel)
        Me.TabPage1.Controls.Add(Me.LinkLabel2)
        Me.TabPage1.Controls.Add(Me.gSociete)
        Me.TabPage1.Controls.Add(Me.tModeleFacture)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1116, 477)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Paramètres"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tModeleAppel
        '
        Me.tModeleAppel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tModeleAppel.Location = New System.Drawing.Point(100, 37)
        Me.tModeleAppel.Name = "tModeleAppel"
        Me.tModeleAppel.ReadOnly = True
        Me.tModeleAppel.Size = New System.Drawing.Size(743, 20)
        Me.tModeleAppel.TabIndex = 4
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(13, 40)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(72, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Modèle Appel"
        '
        'gSociete
        '
        Me.gSociete.Controls.Add(Me.Label10)
        Me.gSociete.Controls.Add(Me.TextBox9)
        Me.gSociete.Controls.Add(Me.Button2)
        Me.gSociete.Controls.Add(Me.Label9)
        Me.gSociete.Controls.Add(Me.Label7)
        Me.gSociete.Controls.Add(Me.TextBox8)
        Me.gSociete.Controls.Add(Me.TextBox7)
        Me.gSociete.Controls.Add(Me.Label6)
        Me.gSociete.Controls.Add(Me.TextBox5)
        Me.gSociete.Controls.Add(Me.Label5)
        Me.gSociete.Controls.Add(Me.TextBox4)
        Me.gSociete.Controls.Add(Me.Label3)
        Me.gSociete.Controls.Add(Me.TextBox2)
        Me.gSociete.Controls.Add(Me.Label4)
        Me.gSociete.Controls.Add(Me.Label1)
        Me.gSociete.Controls.Add(Me.TextBox3)
        Me.gSociete.Controls.Add(Me.tTauxTVA)
        Me.gSociete.Controls.Add(Me.TextBox1)
        Me.gSociete.Controls.Add(Me.Label8)
        Me.gSociete.Controls.Add(Me.TextBox6)
        Me.gSociete.Controls.Add(Me.dEntre)
        Me.gSociete.Controls.Add(Me.Label2)
        Me.gSociete.Location = New System.Drawing.Point(16, 79)
        Me.gSociete.Name = "gSociete"
        Me.gSociete.Size = New System.Drawing.Size(438, 294)
        Me.gSociete.TabIndex = 2
        Me.gSociete.TabStop = False
        Me.gSociete.Text = "Informations"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Code Comptable"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(117, 102)
        Me.TextBox9.MaxLength = 20
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(126, 20)
        Me.TextBox9.TabIndex = 99
        Me.TextBox9.Tag = "SocCode,to"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.MultiLoc.My.Resources.Resources.MC_MiniSave
        Me.Button2.Location = New System.Drawing.Point(381, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 34)
        Me.Button2.TabIndex = 98
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Compte Client"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Pouvoir"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(117, 258)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(195, 20)
        Me.TextBox8.TabIndex = 96
        Me.TextBox8.Tag = "cptClient,t"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(117, 232)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(195, 20)
        Me.TextBox7.TabIndex = 96
        Me.TextBox7.Tag = "pouvoir,t"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Gérant 2"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(117, 206)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(195, 20)
        Me.TextBox5.TabIndex = 94
        Me.TextBox5.Tag = "gerant2,t"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Gérant 1"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(117, 180)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(195, 20)
        Me.TextBox4.TabIndex = 92
        Me.TextBox4.Tag = "gerant1,t"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Code NAF"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(117, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(305, 20)
        Me.TextBox2.TabIndex = 90
        Me.TextBox2.Tag = "codenaf,t"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Registre Commerce"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Siren"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(117, 151)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(126, 20)
        Me.TextBox3.TabIndex = 86
        Me.TextBox3.Tag = "registrecommerce,t"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.Location = New System.Drawing.Point(117, 76)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(126, 20)
        Me.tTauxTVA.TabIndex = 87
        Me.tTauxTVA.Tag = "siren,t"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(37, 20)
        Me.TextBox1.TabIndex = 83
        Me.TextBox1.Tag = "socid,k"
        Me.TextBox1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Capital"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(117, 50)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(126, 20)
        Me.TextBox6.TabIndex = 81
        Me.TextBox6.Tag = "capital,n"
        '
        'dEntre
        '
        Me.dEntre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEntre.Location = New System.Drawing.Point(117, 24)
        Me.dEntre.Name = "dEntre"
        Me.dEntre.Size = New System.Drawing.Size(126, 20)
        Me.dEntre.TabIndex = 80
        Me.dEntre.Tag = "dateCrea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Date Création"
        '
        'tModeleFacture
        '
        Me.tModeleFacture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tModeleFacture.Location = New System.Drawing.Point(100, 11)
        Me.tModeleFacture.Name = "tModeleFacture"
        Me.tModeleFacture.ReadOnly = True
        Me.tModeleFacture.Size = New System.Drawing.Size(743, 20)
        Me.tModeleFacture.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Modèle Facture"
        '
        'PlanCompta
        '
        Me.PlanCompta.Controls.Add(Me.SplitContainer1)
        Me.PlanCompta.Location = New System.Drawing.Point(4, 22)
        Me.PlanCompta.Name = "PlanCompta"
        Me.PlanCompta.Size = New System.Drawing.Size(1116, 477)
        Me.PlanCompta.TabIndex = 5
        Me.PlanCompta.Text = "Plan Compta"
        Me.PlanCompta.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.bAddCpt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gPlanC)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bDelCpt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gPlanLoc)
        Me.SplitContainer1.Size = New System.Drawing.Size(1110, 471)
        Me.SplitContainer1.SplitterDistance = 524
        Me.SplitContainer1.TabIndex = 64
        '
        'bAddCpt
        '
        Me.bAddCpt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddCpt.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bAddCpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddCpt.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.bAddCpt.Location = New System.Drawing.Point(479, 8)
        Me.bAddCpt.Name = "bAddCpt"
        Me.bAddCpt.Size = New System.Drawing.Size(29, 29)
        Me.bAddCpt.TabIndex = 57
        Me.bAddCpt.TabStop = False
        Me.bAddCpt.UseVisualStyleBackColor = True
        '
        'gPlanC
        '
        Me.gPlanC.AllowUserToAddRows = False
        Me.gPlanC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gPlanC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gPlanC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gPlanC.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gPlanC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.gPlanC.ColumnHeadersHeight = 21
        Me.gPlanC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pcid, Me.Rubrique, Me.LeTiers, Me.TypeTiers, Me.cptnum, Me.cptnom})
        Me.gPlanC.Location = New System.Drawing.Point(3, 8)
        Me.gPlanC.MultiSelect = False
        Me.gPlanC.Name = "gPlanC"
        Me.gPlanC.ReadOnly = True
        Me.gPlanC.RowHeadersVisible = False
        Me.gPlanC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gPlanC.Size = New System.Drawing.Size(470, 458)
        Me.gPlanC.TabIndex = 56
        '
        'bDelCpt
        '
        Me.bDelCpt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDelCpt.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bDelCpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDelCpt.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.bDelCpt.Location = New System.Drawing.Point(479, 59)
        Me.bDelCpt.Name = "bDelCpt"
        Me.bDelCpt.Size = New System.Drawing.Size(29, 29)
        Me.bDelCpt.TabIndex = 58
        Me.bDelCpt.TabStop = False
        Me.bDelCpt.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button4.Location = New System.Drawing.Point(543, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(29, 29)
        Me.Button4.TabIndex = 60
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.Button5.Location = New System.Drawing.Point(543, 59)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(29, 29)
        Me.Button5.TabIndex = 61
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = True
        '
        'gPlanLoc
        '
        Me.gPlanLoc.AllowUserToAddRows = False
        Me.gPlanLoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gPlanLoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gPlanLoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gPlanLoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gPlanLoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.gPlanLoc.ColumnHeadersHeight = 21
        Me.gPlanLoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pcidloc, Me.DataGridViewTextBoxColumn3, Me.TTiers, Me.lesLots, Me.cptNumLoc, Me.DataGridViewTextBoxColumn5})
        Me.gPlanLoc.Location = New System.Drawing.Point(15, 8)
        Me.gPlanLoc.MultiSelect = False
        Me.gPlanLoc.Name = "gPlanLoc"
        Me.gPlanLoc.ReadOnly = True
        Me.gPlanLoc.RowHeadersVisible = False
        Me.gPlanLoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gPlanLoc.Size = New System.Drawing.Size(518, 458)
        Me.gPlanLoc.TabIndex = 59
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bWord, Me.bXL, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1148, 28)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bWord
        '
        Me.bWord.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bWord.Image = Global.MultiLoc.My.Resources.Resources.word
        Me.bWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bWord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bWord.Name = "bWord"
        Me.bWord.Size = New System.Drawing.Size(25, 25)
        Me.bWord.Text = "ToolStripButton1"
        '
        'bXL
        '
        Me.bXL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bXL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bXL.Image = Global.MultiLoc.My.Resources.Resources.xl1
        Me.bXL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bXL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bXL.Name = "bXL"
        Me.bXL.Size = New System.Drawing.Size(25, 25)
        Me.bXL.Text = "ToolStripButton2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(75, 25)
        Me.ToolStripButton2.Text = "Nouveau"
        '
        'lSociete
        '
        Me.lSociete.FormattingEnabled = True
        Me.lSociete.Location = New System.Drawing.Point(61, 32)
        Me.lSociete.Name = "lSociete"
        Me.lSociete.Size = New System.Drawing.Size(354, 21)
        Me.lSociete.TabIndex = 10
        '
        'kSociete
        '
        Me.kSociete.AutoSize = True
        Me.kSociete.Location = New System.Drawing.Point(12, 35)
        Me.kSociete.Name = "kSociete"
        Me.kSociete.Size = New System.Drawing.Size(43, 13)
        Me.kSociete.TabIndex = 11
        Me.kSociete.TabStop = True
        Me.kSociete.Text = "Société"
        '
        'oDial
        '
        Me.oDial.FileName = "OpenFileDialog1"
        Me.oDial.Filter = "Excel|*.xls;*.xlsx"
        '
        'pcid
        '
        Me.pcid.HeaderText = "pcid"
        Me.pcid.Name = "pcid"
        Me.pcid.ReadOnly = True
        Me.pcid.Visible = False
        '
        'Rubrique
        '
        Me.Rubrique.FillWeight = 66.75761!
        Me.Rubrique.HeaderText = "Rubrique"
        Me.Rubrique.Name = "Rubrique"
        Me.Rubrique.ReadOnly = True
        '
        'LeTiers
        '
        Me.LeTiers.FillWeight = 111.2627!
        Me.LeTiers.HeaderText = "Tiers"
        Me.LeTiers.Name = "LeTiers"
        Me.LeTiers.ReadOnly = True
        '
        'TypeTiers
        '
        Me.TypeTiers.FillWeight = 63.95939!
        Me.TypeTiers.HeaderText = "Type"
        Me.TypeTiers.Name = "TypeTiers"
        Me.TypeTiers.ReadOnly = True
        '
        'cptnum
        '
        Me.cptnum.FillWeight = 66.75761!
        Me.cptnum.HeaderText = "N° Compte"
        Me.cptnum.Name = "cptnum"
        Me.cptnum.ReadOnly = True
        '
        'cptnom
        '
        Me.cptnom.FillWeight = 111.2627!
        Me.cptnom.HeaderText = "Compte"
        Me.cptnom.Name = "cptnom"
        Me.cptnom.ReadOnly = True
        '
        'pcidloc
        '
        Me.pcidloc.HeaderText = "pcid"
        Me.pcidloc.Name = "pcidloc"
        Me.pcidloc.ReadOnly = True
        Me.pcidloc.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tiers"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'TTiers
        '
        Me.TTiers.FillWeight = 50.0!
        Me.TTiers.HeaderText = "Type"
        Me.TTiers.Name = "TTiers"
        Me.TTiers.ReadOnly = True
        '
        'lesLots
        '
        Me.lesLots.HeaderText = "Lots"
        Me.lesLots.Name = "lesLots"
        Me.lesLots.ReadOnly = True
        '
        'cptNumLoc
        '
        Me.cptNumLoc.FillWeight = 80.0!
        Me.cptNumLoc.HeaderText = "N° Compte"
        Me.cptNumLoc.Name = "cptNumLoc"
        Me.cptNumLoc.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Compte"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'F_SocieteSuivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1148, 582)
        Me.ControlBox = False
        Me.Controls.Add(Me.kSociete)
        Me.Controls.Add(Me.lSociete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.oOnglet)
        Me.Name = "F_SocieteSuivi"
        Me.Text = "Société"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.oOnglet.ResumeLayout(False)
        Me.Compta.ResumeLayout(False)
        Me.Compta.PerformLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bien.ResumeLayout(False)
        CType(Me.gLot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Document.ResumeLayout(False)
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gSociete.ResumeLayout(False)
        Me.gSociete.PerformLayout()
        Me.PlanCompta.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gPlanC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gPlanLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents oOnglet As System.Windows.Forms.TabControl
    Friend WithEvents Bien As System.Windows.Forms.TabPage
    Friend WithEvents gLot As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bWord As System.Windows.Forms.ToolStripButton
    Friend WithEvents bXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents lSociete As System.Windows.Forms.ComboBox
    Friend WithEvents Document As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents gDoc As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateCrea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docPath As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Compta As System.Windows.Forms.TabPage
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents bsuppEcrit As System.Windows.Forms.Button
    Friend WithEvents kSociete As System.Windows.Forms.LinkLabel
    Friend WithEvents bEditFActure As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tModeleFacture As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents oDial As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gSociete As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents dEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tModeleAppel As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lotId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coproId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Copro As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents batiment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typeLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lot As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents niveau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents soldeLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents locId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Locataire As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tRechCat As System.Windows.Forms.TextBox
    Friend WithEvents lAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents PlanCompta As TabPage
    Friend WithEvents bDelCpt As Button
    Friend WithEvents bAddCpt As Button
    Friend WithEvents gPlanC As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents dateEcr As DataGridViewTextBoxColumn
    Friend WithEvents DateEch As DataGridViewTextBoxColumn
    Friend WithEvents Compte As DataGridViewTextBoxColumn
    Friend WithEvents Tiers As DataGridViewTextBoxColumn
    Friend WithEvents Cat As DataGridViewTextBoxColumn
    Friend WithEvents lots As DataGridViewTextBoxColumn
    Friend WithEvents NumFacture As DataGridViewTextBoxColumn
    Friend WithEvents Libelle As DataGridViewTextBoxColumn
    Friend WithEvents MontantHT As DataGridViewTextBoxColumn
    Friend WithEvents numfact As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents gPlanLoc As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents pcid As DataGridViewTextBoxColumn
    Friend WithEvents Rubrique As DataGridViewTextBoxColumn
    Friend WithEvents LeTiers As DataGridViewTextBoxColumn
    Friend WithEvents TypeTiers As DataGridViewTextBoxColumn
    Friend WithEvents cptnum As DataGridViewTextBoxColumn
    Friend WithEvents cptnom As DataGridViewTextBoxColumn
    Friend WithEvents pcidloc As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TTiers As DataGridViewTextBoxColumn
    Friend WithEvents lesLots As DataGridViewTextBoxColumn
    Friend WithEvents cptNumLoc As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
