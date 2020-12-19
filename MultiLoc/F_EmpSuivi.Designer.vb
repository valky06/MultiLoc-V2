<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_EmpSuivi
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
        Me.components = New System.ComponentModel.Container()
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_EmpSuivi))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gEmp = New System.Windows.Forms.DataGridView()
        Me.empId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tRech = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateEcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFacture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.oOnglet = New System.Windows.Forms.TabControl()
        Me.Locataires = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.tEmplacement = New System.Windows.Forms.Label()
        Me.gContrat = New System.Windows.Forms.DataGridView()
        Me.contratId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Client = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documents = New System.Windows.Forms.TabPage()
        Me.bDocSupp = New System.Windows.Forms.Button()
        Me.bDocAjout = New System.Windows.Forms.Button()
        Me.gDoc = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docPath = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.imListe = New System.Windows.Forms.ImageList(Me.components)
        Me.bSUppEmp = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.oOnglet.SuspendLayout()
        Me.Locataires.SuspendLayout()
        CType(Me.gContrat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Documents.SuspendLayout()
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gEmp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gCompta)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.oOnglet)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 377)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 0
        '
        'gEmp
        '
        Me.gEmp.AllowUserToAddRows = False
        Me.gEmp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gEmp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gEmp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empId, Me.emplacement})
        Me.gEmp.Location = New System.Drawing.Point(3, 28)
        Me.gEmp.MultiSelect = False
        Me.gEmp.Name = "gEmp"
        Me.gEmp.ReadOnly = True
        Me.gEmp.RowHeadersVisible = False
        Me.gEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gEmp.Size = New System.Drawing.Size(222, 344)
        Me.gEmp.TabIndex = 6
        '
        'empId
        '
        Me.empId.HeaderText = "Id"
        Me.empId.Name = "empId"
        Me.empId.ReadOnly = True
        Me.empId.Visible = False
        '
        'emplacement
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.NullValue = Nothing
        Me.emplacement.DefaultCellStyle = DataGridViewCellStyle2
        Me.emplacement.HeaderText = "Emplacement"
        Me.emplacement.Name = "emplacement"
        Me.emplacement.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tRech, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.bSUppEmp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(228, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tRech
        '
        Me.tRech.Name = "tRech"
        Me.tRech.Size = New System.Drawing.Size(70, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.MultiLoc.My.Resources.Resources.smallsearch
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton1.Text = "Ajout"
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gCompta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gCompta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.dateEcr, Me.numPiece, Me.NumFacture, Me.Libelle, Me.debit, Me.credit, Me.Solde})
        Me.gCompta.Location = New System.Drawing.Point(3, 190)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(558, 182)
        Me.gCompta.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'dateEcr
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dateEcr.DefaultCellStyle = DataGridViewCellStyle4
        Me.dateEcr.FillWeight = 40.0!
        Me.dateEcr.HeaderText = "Date"
        Me.dateEcr.Name = "dateEcr"
        Me.dateEcr.ReadOnly = True
        '
        'numPiece
        '
        Me.numPiece.HeaderText = "numPIece"
        Me.numPiece.Name = "numPiece"
        Me.numPiece.ReadOnly = True
        Me.numPiece.Visible = False
        '
        'NumFacture
        '
        Me.NumFacture.FillWeight = 40.0!
        Me.NumFacture.HeaderText = "Facture"
        Me.NumFacture.Name = "NumFacture"
        Me.NumFacture.ReadOnly = True
        '
        'Libelle
        '
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        '
        'debit
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle5
        Me.debit.FillWeight = 40.0!
        Me.debit.HeaderText = "Débit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        '
        'credit
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.credit.DefaultCellStyle = DataGridViewCellStyle6
        Me.credit.FillWeight = 40.0!
        Me.credit.HeaderText = "Crédit"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        '
        'Solde
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.Solde.DefaultCellStyle = DataGridViewCellStyle7
        Me.Solde.FillWeight = 40.0!
        Me.Solde.HeaderText = "Solde"
        Me.Solde.Name = "Solde"
        Me.Solde.ReadOnly = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(568, 25)
        Me.ToolStrip2.TabIndex = 9
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.MultiLoc.My.Resources.Resources.xl1
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'oOnglet
        '
        Me.oOnglet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oOnglet.Controls.Add(Me.Locataires)
        Me.oOnglet.Controls.Add(Me.Documents)
        Me.oOnglet.Location = New System.Drawing.Point(3, 28)
        Me.oOnglet.Name = "oOnglet"
        Me.oOnglet.SelectedIndex = 0
        Me.oOnglet.Size = New System.Drawing.Size(562, 144)
        Me.oOnglet.TabIndex = 3
        '
        'Locataires
        '
        Me.Locataires.Controls.Add(Me.LinkLabel1)
        Me.Locataires.Controls.Add(Me.tEmplacement)
        Me.Locataires.Controls.Add(Me.gContrat)
        Me.Locataires.Location = New System.Drawing.Point(4, 22)
        Me.Locataires.Name = "Locataires"
        Me.Locataires.Padding = New System.Windows.Forms.Padding(3)
        Me.Locataires.Size = New System.Drawing.Size(554, 118)
        Me.Locataires.TabIndex = 1
        Me.Locataires.Text = "Clients"
        Me.Locataires.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Emplacement"
        '
        'tEmplacement
        '
        Me.tEmplacement.AutoSize = True
        Me.tEmplacement.Location = New System.Drawing.Point(80, 10)
        Me.tEmplacement.Name = "tEmplacement"
        Me.tEmplacement.Size = New System.Drawing.Size(0, 13)
        Me.tEmplacement.TabIndex = 5
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
        Me.gContrat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.contratId, Me.cliId, Me.Contrat, Me.Client, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.gContrat.Location = New System.Drawing.Point(4, 31)
        Me.gContrat.MultiSelect = False
        Me.gContrat.Name = "gContrat"
        Me.gContrat.ReadOnly = True
        Me.gContrat.RowHeadersVisible = False
        Me.gContrat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gContrat.Size = New System.Drawing.Size(544, 84)
        Me.gContrat.TabIndex = 3
        '
        'contratId
        '
        Me.contratId.HeaderText = "Id"
        Me.contratId.Name = "contratId"
        Me.contratId.ReadOnly = True
        Me.contratId.Visible = False
        '
        'cliId
        '
        Me.cliId.HeaderText = "cliID"
        Me.cliId.Name = "cliId"
        Me.cliId.ReadOnly = True
        Me.cliId.Visible = False
        '
        'Contrat
        '
        Me.Contrat.FillWeight = 50.0!
        Me.Contrat.HeaderText = "Contrat"
        Me.Contrat.Name = "Contrat"
        Me.Contrat.ReadOnly = True
        '
        'Client
        '
        Me.Client.HeaderText = "Client"
        Me.Client.Name = "Client"
        Me.Client.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Début"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle9.Format = "d"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fin"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Documents
        '
        Me.Documents.Controls.Add(Me.bDocSupp)
        Me.Documents.Controls.Add(Me.bDocAjout)
        Me.Documents.Controls.Add(Me.gDoc)
        Me.Documents.Location = New System.Drawing.Point(4, 22)
        Me.Documents.Name = "Documents"
        Me.Documents.Padding = New System.Windows.Forms.Padding(3)
        Me.Documents.Size = New System.Drawing.Size(554, 118)
        Me.Documents.TabIndex = 2
        Me.Documents.Text = "Documents"
        Me.Documents.UseVisualStyleBackColor = True
        '
        'bDocSupp
        '
        Me.bDocSupp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDocSupp.FlatAppearance.BorderSize = 0
        Me.bDocSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDocSupp.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.bDocSupp.Location = New System.Drawing.Point(519, 62)
        Me.bDocSupp.Name = "bDocSupp"
        Me.bDocSupp.Size = New System.Drawing.Size(29, 23)
        Me.bDocSupp.TabIndex = 54
        Me.bDocSupp.TabStop = False
        Me.bDocSupp.UseVisualStyleBackColor = True
        '
        'bDocAjout
        '
        Me.bDocAjout.AccessibleDescription = ""
        Me.bDocAjout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDocAjout.FlatAppearance.BorderSize = 0
        Me.bDocAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDocAjout.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.bDocAjout.Location = New System.Drawing.Point(519, 11)
        Me.bDocAjout.Name = "bDocAjout"
        Me.bDocAjout.Size = New System.Drawing.Size(29, 23)
        Me.bDocAjout.TabIndex = 53
        Me.bDocAjout.TabStop = False
        Me.bDocAjout.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gDoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.gDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dateCrea, Me.docNom, Me.docPath})
        Me.gDoc.Location = New System.Drawing.Point(6, 6)
        Me.gDoc.MultiSelect = False
        Me.gDoc.Name = "gDoc"
        Me.gDoc.ReadOnly = True
        Me.gDoc.RowHeadersVisible = False
        Me.gDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gDoc.Size = New System.Drawing.Size(507, 109)
        Me.gDoc.TabIndex = 52
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.dateCrea.DefaultCellStyle = DataGridViewCellStyle11
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
        'imListe
        '
        Me.imListe.ImageStream = CType(resources.GetObject("imListe.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imListe.TransparentColor = System.Drawing.Color.Transparent
        Me.imListe.Images.SetKeyName(0, "mCopro.gif")
        Me.imListe.Images.SetKeyName(1, "mOccupe.gif")
        Me.imListe.Images.SetKeyName(2, "mPreavis.gif")
        Me.imListe.Images.SetKeyName(3, "mCopro.gif")
        Me.imListe.Images.SetKeyName(4, "mSelect.gif")
        '
        'bSUppEmp
        '
        Me.bSUppEmp.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.bSUppEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bSUppEmp.Name = "bSUppEmp"
        Me.bSUppEmp.Size = New System.Drawing.Size(82, 22)
        Me.bSUppEmp.Text = "Supprimer"
        '
        'F_EmpSuivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "F_EmpSuivi"
        Me.Text = "Stockage"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.oOnglet.ResumeLayout(False)
        Me.Locataires.ResumeLayout(False)
        Me.Locataires.PerformLayout()
        CType(Me.gContrat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Documents.ResumeLayout(False)
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents oOnglet As System.Windows.Forms.TabControl
    Friend WithEvents Locataires As System.Windows.Forms.TabPage
    Friend WithEvents gContrat As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents imListe As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents Documents As System.Windows.Forms.TabPage
    Friend WithEvents bDocSupp As System.Windows.Forms.Button
    Friend WithEvents bDocAjout As System.Windows.Forms.Button
    Friend WithEvents gDoc As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateCrea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docPath As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents gEmp As System.Windows.Forms.DataGridView
    Friend WithEvents tRech As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateEcr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numPiece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFacture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contratId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contrat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Client As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emplacement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tEmplacement As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents bSUppEmp As System.Windows.Forms.ToolStripButton
End Class
