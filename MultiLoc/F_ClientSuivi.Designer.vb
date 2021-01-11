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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ClientSuivi))
        Me.oOnglet = New System.Windows.Forms.TabControl()
        Me.Compte = New System.Windows.Forms.TabPage()
        Me.bEditFActure = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
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
        Me.Document = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.gDoc = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docPath = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.gClient = New System.Windows.Forms.GroupBox()
        Me.tPersId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tCompte = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
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
        Me.Document.SuspendLayout()
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.gClient.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'oOnglet
        '
        Me.oOnglet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oOnglet.Controls.Add(Me.Compte)
        Me.oOnglet.Controls.Add(Me.Document)
        Me.oOnglet.Controls.Add(Me.TabPage1)
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
        Me.bEditFActure.Location = New System.Drawing.Point(815, 49)
        Me.bEditFActure.Name = "bEditFActure"
        Me.bEditFActure.Size = New System.Drawing.Size(93, 38)
        Me.bEditFActure.TabIndex = 19
        Me.bEditFActure.Text = "Edition Facture"
        Me.bEditFActure.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(815, 6)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(93, 37)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "Facture"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Location = New System.Drawing.Point(815, 306)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(93, 34)
        Me.bsuppEcrit.TabIndex = 16
        Me.bsuppEcrit.Text = "Supprimer Ecrit."
        Me.bsuppEcrit.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(815, 104)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(93, 40)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "Règlement Facture"
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
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.gClient)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(914, 346)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Paramètres"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = Global.MultiLoc.My.Resources.Resources.MC_MiniSave
        Me.Button7.Location = New System.Drawing.Point(180, 10)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(97, 41)
        Me.Button7.TabIndex = 19
        Me.Button7.UseVisualStyleBackColor = True
        '
        'gClient
        '
        Me.gClient.Controls.Add(Me.tPersId)
        Me.gClient.Controls.Add(Me.Label1)
        Me.gClient.Controls.Add(Me.tCompte)
        Me.gClient.Controls.Add(Me.TextBox3)
        Me.gClient.Location = New System.Drawing.Point(3, 3)
        Me.gClient.Name = "gClient"
        Me.gClient.Size = New System.Drawing.Size(171, 88)
        Me.gClient.TabIndex = 2
        Me.gClient.TabStop = False
        '
        'tPersId
        '
        Me.tPersId.Location = New System.Drawing.Point(74, 40)
        Me.tPersId.Name = "tPersId"
        Me.tPersId.ReadOnly = True
        Me.tPersId.Size = New System.Drawing.Size(16, 20)
        Me.tPersId.TabIndex = 73
        Me.tPersId.Tag = "PersId,n"
        Me.tPersId.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Suffixe Compte"
        '
        'tCompte
        '
        Me.tCompte.Location = New System.Drawing.Point(96, 14)
        Me.tCompte.Name = "tCompte"
        Me.tCompte.Size = New System.Drawing.Size(52, 20)
        Me.tCompte.TabIndex = 17
        Me.tCompte.Tag = "CptSuffixe,t"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(23, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(16, 20)
        Me.TextBox3.TabIndex = 43
        Me.TextBox3.Tag = "Locid,k"
        Me.TextBox3.Visible = False
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
        Me.tRech.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(946, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.kLocataire)
        Me.Controls.Add(Me.lCLient)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.oOnglet)
        Me.Name = "F_ClientSuivi"
        Me.Tag = "nbMoisDG,no"
        Me.Text = "Client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.oOnglet.ResumeLayout(False)
        Me.Compte.ResumeLayout(False)
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Document.ResumeLayout(False)
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.gClient.ResumeLayout(False)
        Me.gClient.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents oOnglet As System.Windows.Forms.TabControl
    Friend WithEvents Compte As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bWord As System.Windows.Forms.ToolStripButton
    Friend WithEvents bXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents lCLient As System.Windows.Forms.ComboBox
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents tRech As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bRech As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuNouveau As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents bEditFActure As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gClient As GroupBox
    Friend WithEvents tPersId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tCompte As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button7 As Button
End Class
