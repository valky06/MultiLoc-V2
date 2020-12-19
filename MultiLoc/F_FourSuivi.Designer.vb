<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_FourSuivi
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
        Me.oOnglet = New System.Windows.Forms.TabControl()
        Me.Compta = New System.Windows.Forms.TabPage()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numPIece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateEcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numfacture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.echeance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coord = New System.Windows.Forms.TabPage()
        Me.gCoord = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kPersId = New System.Windows.Forms.Label()
        Me.gContact = New System.Windows.Forms.DataGridView()
        Me.contId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telFixe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telMob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewLinkColumn()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lFour = New System.Windows.Forms.ComboBox()
        Me.oOnglet.SuspendLayout()
        Me.Compta.SuspendLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Coord.SuspendLayout()
        Me.gCoord.SuspendLayout()
        CType(Me.gContact, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.oOnglet.Controls.Add(Me.Compta)
        Me.oOnglet.Controls.Add(Me.Coord)
        Me.oOnglet.Controls.Add(Me.Document)
        Me.oOnglet.Enabled = False
        Me.oOnglet.Location = New System.Drawing.Point(12, 67)
        Me.oOnglet.Name = "oOnglet"
        Me.oOnglet.SelectedIndex = 0
        Me.oOnglet.Size = New System.Drawing.Size(668, 251)
        Me.oOnglet.TabIndex = 2
        '
        'Compta
        '
        Me.Compta.Controls.Add(Me.bsuppEcrit)
        Me.Compta.Controls.Add(Me.Button9)
        Me.Compta.Controls.Add(Me.gCompta)
        Me.Compta.Location = New System.Drawing.Point(4, 22)
        Me.Compta.Name = "Compta"
        Me.Compta.Size = New System.Drawing.Size(660, 225)
        Me.Compta.TabIndex = 3
        Me.Compta.Text = "Ecritures"
        Me.Compta.UseVisualStyleBackColor = True
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Location = New System.Drawing.Point(561, 90)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(93, 28)
        Me.bsuppEcrit.TabIndex = 17
        Me.bsuppEcrit.Text = "Supprimer Ecrit."
        Me.bsuppEcrit.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(561, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(93, 41)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Règlement Fournisseur"
        Me.Button9.UseVisualStyleBackColor = True
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
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.numPIece, Me.dateEcr, Me.numfacture, Me.echeance, Me.Libelle, Me.debit, Me.credit, Me.Solde})
        Me.gCompta.Location = New System.Drawing.Point(6, 12)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(549, 200)
        Me.gCompta.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'numPIece
        '
        Me.numPIece.HeaderText = "numPiece"
        Me.numPIece.Name = "numPIece"
        Me.numPIece.ReadOnly = True
        Me.numPIece.Visible = False
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
        'numfacture
        '
        Me.numfacture.FillWeight = 60.0!
        Me.numfacture.HeaderText = "Facture"
        Me.numfacture.Name = "numfacture"
        Me.numfacture.ReadOnly = True
        '
        'echeance
        '
        Me.echeance.FillWeight = 40.0!
        Me.echeance.HeaderText = "Echéance"
        Me.echeance.Name = "echeance"
        Me.echeance.ReadOnly = True
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
        'Solde
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.Solde.DefaultCellStyle = DataGridViewCellStyle5
        Me.Solde.FillWeight = 40.0!
        Me.Solde.HeaderText = "Solde"
        Me.Solde.Name = "Solde"
        Me.Solde.ReadOnly = True
        '
        'Coord
        '
        Me.Coord.BackColor = System.Drawing.Color.White
        Me.Coord.Controls.Add(Me.gCoord)
        Me.Coord.Controls.Add(Me.gContact)
        Me.Coord.Location = New System.Drawing.Point(4, 22)
        Me.Coord.Name = "Coord"
        Me.Coord.Padding = New System.Windows.Forms.Padding(3)
        Me.Coord.Size = New System.Drawing.Size(660, 225)
        Me.Coord.TabIndex = 1
        Me.Coord.Text = "Coordonnées"
        '
        'gCoord
        '
        Me.gCoord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gCoord.Controls.Add(Me.TextBox6)
        Me.gCoord.Controls.Add(Me.kPersId)
        Me.gCoord.Controls.Add(Me.TextBox5)
        Me.gCoord.Controls.Add(Me.Label6)
        Me.gCoord.Controls.Add(Me.Label5)
        Me.gCoord.Controls.Add(Me.TextBox4)
        Me.gCoord.Controls.Add(Me.TextBox3)
        Me.gCoord.Controls.Add(Me.Label4)
        Me.gCoord.Controls.Add(Me.TextBox2)
        Me.gCoord.Controls.Add(Me.TextBox1)
        Me.gCoord.Controls.Add(Me.Label3)
        Me.gCoord.Location = New System.Drawing.Point(9, 6)
        Me.gCoord.Name = "gCoord"
        Me.gCoord.Size = New System.Drawing.Size(645, 114)
        Me.gCoord.TabIndex = 6
        Me.gCoord.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(473, 39)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(116, 20)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Tag = "fax"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(473, 13)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(116, 20)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Tag = "telbureau"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Téléphone"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(118, 82)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(257, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Tag = "localite,t"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(57, 82)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(55, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Tag = "codepostal,t"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Adresse"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(57, 39)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(318, 37)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Tag = "adr1,t"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(318, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Tag = "nom,t"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nom"
        '
        'kPersId
        '
        Me.kPersId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kPersId.AutoSize = True
        Me.kPersId.Location = New System.Drawing.Point(470, 82)
        Me.kPersId.Name = "kPersId"
        Me.kPersId.Size = New System.Drawing.Size(36, 13)
        Me.kPersId.TabIndex = 4
        Me.kPersId.Tag = "persid"
        Me.kPersId.Text = "persId"
        '
        'gContact
        '
        Me.gContact.AllowUserToAddRows = False
        Me.gContact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gContact.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gContact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.contId, Me.Contact, Me.telFixe, Me.telMob, Me.fax, Me.email})
        Me.gContact.Location = New System.Drawing.Point(9, 125)
        Me.gContact.MultiSelect = False
        Me.gContact.Name = "gContact"
        Me.gContact.ReadOnly = True
        Me.gContact.RowHeadersVisible = False
        Me.gContact.Size = New System.Drawing.Size(645, 94)
        Me.gContact.TabIndex = 0
        '
        'contId
        '
        Me.contId.HeaderText = "Id"
        Me.contId.Name = "contId"
        Me.contId.ReadOnly = True
        Me.contId.Visible = False
        '
        'Contact
        '
        Me.Contact.HeaderText = "contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        '
        'telFixe
        '
        Me.telFixe.FillWeight = 50.0!
        Me.telFixe.HeaderText = "Tel Fixe"
        Me.telFixe.Name = "telFixe"
        Me.telFixe.ReadOnly = True
        '
        'telMob
        '
        Me.telMob.FillWeight = 50.0!
        Me.telMob.HeaderText = "Mobile"
        Me.telMob.Name = "telMob"
        Me.telMob.ReadOnly = True
        '
        'fax
        '
        Me.fax.FillWeight = 50.0!
        Me.fax.HeaderText = "Fax"
        Me.fax.Name = "fax"
        Me.fax.ReadOnly = True
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'Document
        '
        Me.Document.Controls.Add(Me.Button3)
        Me.Document.Controls.Add(Me.Button6)
        Me.Document.Controls.Add(Me.gDoc)
        Me.Document.Location = New System.Drawing.Point(4, 22)
        Me.Document.Name = "Document"
        Me.Document.Padding = New System.Windows.Forms.Padding(3)
        Me.Document.Size = New System.Drawing.Size(660, 225)
        Me.Document.TabIndex = 2
        Me.Document.Text = "Documents"
        Me.Document.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.Button3.Location = New System.Drawing.Point(623, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 23)
        Me.Button3.TabIndex = 51
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button6.Location = New System.Drawing.Point(623, 6)
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
        Me.gDoc.Size = New System.Drawing.Size(611, 213)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bWord, Me.bXL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(692, 28)
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
        Me.bWord.Visible = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fournisseur"
        '
        'lFour
        '
        Me.lFour.FormattingEnabled = True
        Me.lFour.Location = New System.Drawing.Point(79, 32)
        Me.lFour.Name = "lFour"
        Me.lFour.Size = New System.Drawing.Size(354, 21)
        Me.lFour.TabIndex = 10
        '
        'F_FourSuivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(692, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.lFour)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.oOnglet)
        Me.Name = "F_FourSuivi"
        Me.Text = "Fournisseur"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.oOnglet.ResumeLayout(False)
        Me.Compta.ResumeLayout(False)
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Coord.ResumeLayout(False)
        Me.gCoord.ResumeLayout(False)
        Me.gCoord.PerformLayout()
        CType(Me.gContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Document.ResumeLayout(False)
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents oOnglet As System.Windows.Forms.TabControl
    Friend WithEvents Coord As System.Windows.Forms.TabPage
    Friend WithEvents gContact As System.Windows.Forms.DataGridView
    Friend WithEvents kPersId As System.Windows.Forms.Label
    Friend WithEvents gCoord As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents contId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telFixe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telMob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bWord As System.Windows.Forms.ToolStripButton
    Friend WithEvents bXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lFour As System.Windows.Forms.ComboBox
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
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents bsuppEcrit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numPIece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateEcr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numfacture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents echeance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solde As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
