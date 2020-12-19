<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ClientSuivi
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ClientSuivi))
        Me.oOnglet = New System.Windows.Forms.TabControl()
        Me.Compte = New System.Windows.Forms.TabPage()
        Me.bEditFActure = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateEcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numFacture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.solde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contrats = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.gBail = New System.Windows.Forms.GroupBox()
        Me.tPersId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.tLocId = New System.Windows.Forms.TextBox()
        Me.lTypePer = New System.Windows.Forms.ComboBox()
        Me.lTypeRgt = New System.Windows.Forms.ComboBox()
        Me.gContrat = New System.Windows.Forms.DataGridView()
        Me.contratId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contratNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDebut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateFinPrev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NBEmplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Document = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.gDoc = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docPath = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bWord = New System.Windows.Forms.ToolStripButton()
        Me.bXL = New System.Windows.Forms.ToolStripButton()
        Me.tRech = New System.Windows.Forms.ToolStripTextBox()
        Me.bRech = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.lCLient = New System.Windows.Forms.ComboBox()
        Me.kLocataire = New System.Windows.Forms.LinkLabel()
        Me.oOnglet.SuspendLayout()
        Me.Compte.SuspendLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contrats.SuspendLayout()
        Me.gBail.SuspendLayout()
        CType(Me.gContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Document.SuspendLayout()
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'oOnglet
        '
        Me.oOnglet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oOnglet.Controls.Add(Me.Compte)
        Me.oOnglet.Controls.Add(Me.Contrats)
        Me.oOnglet.Controls.Add(Me.Document)
        Me.oOnglet.Enabled = False
        Me.oOnglet.Location = New System.Drawing.Point(12, 67)
        Me.oOnglet.Name = "oOnglet"
        Me.oOnglet.SelectedIndex = 0
        Me.oOnglet.Size = New System.Drawing.Size(922, 372)
        Me.oOnglet.TabIndex = 2
        '
        'Compte
        '
        Me.Compte.Controls.Add(Me.bEditFActure)
        Me.Compte.Controls.Add(Me.Button9)
        Me.Compte.Controls.Add(Me.bsuppEcrit)
        Me.Compte.Controls.Add(Me.Button12)
        Me.Compte.Controls.Add(Me.Button7)
        Me.Compte.Controls.Add(Me.Button11)
        Me.Compte.Controls.Add(Me.gCompta)
        Me.Compte.Location = New System.Drawing.Point(4, 22)
        Me.Compte.Name = "Compte"
        Me.Compte.Padding = New System.Windows.Forms.Padding(3)
        Me.Compte.Size = New System.Drawing.Size(914, 346)
        Me.Compte.TabIndex = 0
        Me.Compte.Text = "Ecritures"
        Me.Compte.UseVisualStyleBackColor = True
        '
        'bEditFActure
        '
        Me.bEditFActure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEditFActure.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bEditFActure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEditFActure.Location = New System.Drawing.Point(815, 95)
        Me.bEditFActure.Name = "bEditFActure"
        Me.bEditFActure.Size = New System.Drawing.Size(93, 28)
        Me.bEditFActure.TabIndex = 19
        Me.bEditFActure.Text = "Edition Facture"
        Me.bEditFActure.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(815, 52)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(93, 37)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "Facture Interne"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Location = New System.Drawing.Point(815, 312)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(93, 28)
        Me.bsuppEcrit.TabIndex = 16
        Me.bsuppEcrit.Text = "Supprimer Ecrit."
        Me.bsuppEcrit.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.Enabled = False
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(815, 246)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(93, 38)
        Me.Button12.TabIndex = 15
        Me.Button12.Text = "Relance Impayé"
        Me.Button12.UseVisualStyleBackColor = False
        Me.Button12.Visible = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Enabled = False
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(815, 202)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(93, 38)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Reprise de solde"
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(815, 6)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(93, 40)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "Encaissement"
        Me.Button11.UseVisualStyleBackColor = False
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
        Me.gCompta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.numPiece, Me.dateEcr, Me.numFacture, Me.Libelle, Me.debit, Me.credit, Me.solde})
        Me.gCompta.Location = New System.Drawing.Point(6, 6)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(798, 334)
        Me.gCompta.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'numPiece
        '
        Me.numPiece.HeaderText = "numPiece"
        Me.numPiece.Name = "numPiece"
        Me.numPiece.ReadOnly = True
        Me.numPiece.Visible = False
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
        'numFacture
        '
        Me.numFacture.FillWeight = 50.0!
        Me.numFacture.HeaderText = "Facture"
        Me.numFacture.Name = "numFacture"
        Me.numFacture.ReadOnly = True
        '
        'Libelle
        '
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        '
        'debit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle3
        Me.debit.FillWeight = 40.0!
        Me.debit.HeaderText = "Débit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        '
        'credit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.credit.DefaultCellStyle = DataGridViewCellStyle4
        Me.credit.FillWeight = 40.0!
        Me.credit.HeaderText = "Crédit"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        '
        'solde
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.solde.DefaultCellStyle = DataGridViewCellStyle5
        Me.solde.FillWeight = 40.0!
        Me.solde.HeaderText = "Solde"
        Me.solde.Name = "solde"
        Me.solde.ReadOnly = True
        '
        'Contrats
        '
        Me.Contrats.Controls.Add(Me.Button10)
        Me.Contrats.Controls.Add(Me.Button8)
        Me.Contrats.Controls.Add(Me.gBail)
        Me.Contrats.Controls.Add(Me.gContrat)
        Me.Contrats.Controls.Add(Me.Button5)
        Me.Contrats.Controls.Add(Me.Button4)
        Me.Contrats.Controls.Add(Me.Button1)
        Me.Contrats.Location = New System.Drawing.Point(4, 22)
        Me.Contrats.Name = "Contrats"
        Me.Contrats.Size = New System.Drawing.Size(914, 346)
        Me.Contrats.TabIndex = 2
        Me.Contrats.Text = "Contrats"
        Me.Contrats.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(818, 287)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(85, 35)
        Me.Button10.TabIndex = 50
        Me.Button10.Text = "Etiquette"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(818, 168)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 40)
        Me.Button8.TabIndex = 49
        Me.Button8.Text = "Facture Mensuelle"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'gBail
        '
        Me.gBail.Controls.Add(Me.tPersId)
        Me.gBail.Controls.Add(Me.Label3)
        Me.gBail.Controls.Add(Me.TextBox1)
        Me.gBail.Controls.Add(Me.Button2)
        Me.gBail.Controls.Add(Me.LinkLabel3)
        Me.gBail.Controls.Add(Me.LinkLabel2)
        Me.gBail.Controls.Add(Me.tLocId)
        Me.gBail.Controls.Add(Me.lTypePer)
        Me.gBail.Controls.Add(Me.lTypeRgt)
        Me.gBail.Location = New System.Drawing.Point(3, 9)
        Me.gBail.Name = "gBail"
        Me.gBail.Size = New System.Drawing.Size(799, 54)
        Me.gBail.TabIndex = 48
        Me.gBail.TabStop = False
        '
        'tPersId
        '
        Me.tPersId.Location = New System.Drawing.Point(531, 19)
        Me.tPersId.Name = "tPersId"
        Me.tPersId.ReadOnly = True
        Me.tPersId.Size = New System.Drawing.Size(16, 20)
        Me.tPersId.TabIndex = 73
        Me.tPersId.Tag = "PersId,n"
        Me.tPersId.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Suffixe Compte"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(472, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 20)
        Me.TextBox1.TabIndex = 71
        Me.TextBox1.Tag = "CptSuffixe,t"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.MultiLoc.My.Resources.Resources.MC_MiniSave
        Me.Button2.Location = New System.Drawing.Point(707, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 31)
        Me.Button2.TabIndex = 44
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(209, 23)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(58, 13)
        Me.LinkLabel3.TabIndex = 52
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Règlement"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(11, 23)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel2.TabIndex = 51
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Période"
        '
        'tLocId
        '
        Me.tLocId.Location = New System.Drawing.Point(553, 19)
        Me.tLocId.Name = "tLocId"
        Me.tLocId.ReadOnly = True
        Me.tLocId.Size = New System.Drawing.Size(16, 20)
        Me.tLocId.TabIndex = 43
        Me.tLocId.Tag = "cliid,k"
        Me.tLocId.Visible = False
        '
        'lTypePer
        '
        Me.lTypePer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypePer.FormattingEnabled = True
        Me.lTypePer.Location = New System.Drawing.Point(60, 20)
        Me.lTypePer.Name = "lTypePer"
        Me.lTypePer.Size = New System.Drawing.Size(126, 21)
        Me.lTypePer.TabIndex = 2
        Me.lTypePer.Tag = "TperId,no"
        '
        'lTypeRgt
        '
        Me.lTypeRgt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypeRgt.FormattingEnabled = True
        Me.lTypeRgt.Location = New System.Drawing.Point(273, 20)
        Me.lTypeRgt.Name = "lTypeRgt"
        Me.lTypeRgt.Size = New System.Drawing.Size(101, 21)
        Me.lTypeRgt.TabIndex = 4
        Me.lTypeRgt.Tag = "TRgtId,no"
        '
        'gContrat
        '
        Me.gContrat.AllowUserToAddRows = False
        Me.gContrat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gContrat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gContrat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gContrat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gContrat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.contratId, Me.contratNom, Me.DateDebut, Me.dateFinPrev, Me.dateFin, Me.MontantHT, Me.NBEmplacement})
        Me.gContrat.Location = New System.Drawing.Point(3, 69)
        Me.gContrat.MultiSelect = False
        Me.gContrat.Name = "gContrat"
        Me.gContrat.ReadOnly = True
        Me.gContrat.RowHeadersVisible = False
        Me.gContrat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gContrat.Size = New System.Drawing.Size(799, 274)
        Me.gContrat.TabIndex = 2
        '
        'contratId
        '
        Me.contratId.HeaderText = "Id"
        Me.contratId.Name = "contratId"
        Me.contratId.ReadOnly = True
        Me.contratId.Visible = False
        '
        'contratNom
        '
        Me.contratNom.HeaderText = "Contrat"
        Me.contratNom.Name = "contratNom"
        Me.contratNom.ReadOnly = True
        '
        'DateDebut
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DateDebut.DefaultCellStyle = DataGridViewCellStyle6
        Me.DateDebut.HeaderText = "Début"
        Me.DateDebut.Name = "DateDebut"
        Me.DateDebut.ReadOnly = True
        '
        'dateFinPrev
        '
        DataGridViewCellStyle7.Format = "d"
        Me.dateFinPrev.DefaultCellStyle = DataGridViewCellStyle7
        Me.dateFinPrev.HeaderText = "Fin Prév"
        Me.dateFinPrev.Name = "dateFinPrev"
        Me.dateFinPrev.ReadOnly = True
        '
        'dateFin
        '
        DataGridViewCellStyle8.Format = "d"
        Me.dateFin.DefaultCellStyle = DataGridViewCellStyle8
        Me.dateFin.HeaderText = "Fin"
        Me.dateFin.Name = "dateFin"
        Me.dateFin.ReadOnly = True
        '
        'MontantHT
        '
        Me.MontantHT.HeaderText = "Montant HT"
        Me.MontantHT.Name = "MontantHT"
        Me.MontantHT.ReadOnly = True
        '
        'NBEmplacement
        '
        Me.NBEmplacement.HeaderText = "Nb Emplacements"
        Me.NBEmplacement.Name = "NBEmplacement"
        Me.NBEmplacement.ReadOnly = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.Button5.Location = New System.Drawing.Point(818, 109)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 34)
        Me.Button5.TabIndex = 46
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button4.Location = New System.Drawing.Point(818, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 34)
        Me.Button4.TabIndex = 45
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MultiLoc.My.Resources.Resources.word
        Me.Button1.Location = New System.Drawing.Point(818, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 35)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Contrat"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Document
        '
        Me.Document.Controls.Add(Me.Button3)
        Me.Document.Controls.Add(Me.Button6)
        Me.Document.Controls.Add(Me.gDoc)
        Me.Document.Location = New System.Drawing.Point(4, 22)
        Me.Document.Name = "Document"
        Me.Document.Padding = New System.Windows.Forms.Padding(3)
        Me.Document.Size = New System.Drawing.Size(914, 346)
        Me.Document.TabIndex = 3
        Me.Document.Text = "Documents"
        Me.Document.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.Button3.Location = New System.Drawing.Point(879, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 23)
        Me.Button3.TabIndex = 48
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button6.Location = New System.Drawing.Point(879, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(29, 23)
        Me.Button6.TabIndex = 47
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gDoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.gDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dateCrea, Me.docNom, Me.docPath})
        Me.gDoc.Location = New System.Drawing.Point(6, 6)
        Me.gDoc.MultiSelect = False
        Me.gDoc.Name = "gDoc"
        Me.gDoc.ReadOnly = True
        Me.gDoc.RowHeadersVisible = False
        Me.gDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gDoc.Size = New System.Drawing.Size(867, 257)
        Me.gDoc.TabIndex = 4
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.dateCrea.DefaultCellStyle = DataGridViewCellStyle10
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bWord, Me.bXL, Me.tRech, Me.bRech, Me.ToolStripSeparator1, Me.mnuNouveau})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(946, 28)
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
        Me.bWord.Text = "Word"
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
        Me.bXL.Text = "Export XL"
        '
        'tRech
        '
        Me.tRech.Name = "tRech"
        Me.tRech.Size = New System.Drawing.Size(100, 28)
        '
        'bRech
        '
        Me.bRech.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bRech.Image = CType(resources.GetObject("bRech.Image"), System.Drawing.Image)
        Me.bRech.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bRech.Name = "bRech"
        Me.bRech.Size = New System.Drawing.Size(23, 25)
        Me.bRech.Text = "Rechercher"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'mnuNouveau
        '
        Me.mnuNouveau.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.mnuNouveau.Name = "mnuNouveau"
        Me.mnuNouveau.Size = New System.Drawing.Size(83, 28)
        Me.mnuNouveau.Text = "Nouveau"
        '
        'lCLient
        '
        Me.lCLient.FormattingEnabled = True
        Me.lCLient.Location = New System.Drawing.Point(69, 37)
        Me.lCLient.Name = "lCLient"
        Me.lCLient.Size = New System.Drawing.Size(324, 21)
        Me.lCLient.Sorted = True
        Me.lCLient.TabIndex = 10
        '
        'kLocataire
        '
        Me.kLocataire.AutoSize = True
        Me.kLocataire.Location = New System.Drawing.Point(12, 40)
        Me.kLocataire.Name = "kLocataire"
        Me.kLocataire.Size = New System.Drawing.Size(33, 13)
        Me.kLocataire.TabIndex = 11
        Me.kLocataire.TabStop = True
        Me.kLocataire.Text = "Client"
        '
        'F_ClientSuivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.ClientSize = New System.Drawing.Size(946, 451)
        Me.ControlBox = false
        Me.Controls.Add(Me.kLocataire)
        Me.Controls.Add(Me.lCLient)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.oOnglet)
        Me.Name = "F_ClientSuivi"
        Me.Tag = "nbMoisDG,no"
        Me.Text = "Client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.oOnglet.ResumeLayout(false)
        Me.Compte.ResumeLayout(false)
        CType(Me.gCompta,System.ComponentModel.ISupportInitialize).EndInit
        Me.Contrats.ResumeLayout(false)
        Me.gBail.ResumeLayout(false)
        Me.gBail.PerformLayout
        CType(Me.gContrat,System.ComponentModel.ISupportInitialize).EndInit
        Me.Document.ResumeLayout(false)
        CType(Me.gDoc,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents oOnglet As System.Windows.Forms.TabControl
    Friend WithEvents Compte As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bWord As System.Windows.Forms.ToolStripButton
    Friend WithEvents bXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents lCLient As System.Windows.Forms.ComboBox
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents Contrats As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gContrat As System.Windows.Forms.DataGridView
    Friend WithEvents tRech As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bRech As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuNouveau As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Document As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents gDoc As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateCrea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docPath As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents kLocataire As System.Windows.Forms.LinkLabel
    Friend WithEvents bsuppEcrit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numPiece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateEcr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numFacture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents solde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gBail As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents tLocId As System.Windows.Forms.TextBox
    Friend WithEvents lTypePer As System.Windows.Forms.ComboBox
    Friend WithEvents lTypeRgt As System.Windows.Forms.ComboBox
    Friend WithEvents tPersId As System.Windows.Forms.TextBox
    Friend WithEvents contratId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contratNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDebut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateFinPrev As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NBEmplacement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents bEditFActure As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class
