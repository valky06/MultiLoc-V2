<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BanqueSuivi
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
        Me.oOnglet = New System.Windows.Forms.TabControl()
        Me.Compta = New System.Windows.Forms.TabPage()
        Me.dEcheance = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numPIece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeTiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateEcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coord = New System.Windows.Forms.TabPage()
        Me.gRIB = New System.Windows.Forms.GroupBox()
        Me.tpersId = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.tLoyer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tCharge = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.gContact = New System.Windows.Forms.DataGridView()
        Me.contId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telFixe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telMob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bXL = New System.Windows.Forms.ToolStripButton()
        Me.tNouveau = New System.Windows.Forms.ToolStripButton()
        Me.lCptBk = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.oOnglet.SuspendLayout()
        Me.Compta.SuspendLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Coord.SuspendLayout()
        Me.gRIB.SuspendLayout()
        Me.gCoord.SuspendLayout()
        CType(Me.gContact, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.oOnglet.Location = New System.Drawing.Point(12, 58)
        Me.oOnglet.Name = "oOnglet"
        Me.oOnglet.SelectedIndex = 0
        Me.oOnglet.Size = New System.Drawing.Size(790, 270)
        Me.oOnglet.TabIndex = 2
        '
        'Compta
        '
        Me.Compta.Controls.Add(Me.dEcheance)
        Me.Compta.Controls.Add(Me.Label1)
        Me.Compta.Controls.Add(Me.dDate)
        Me.Compta.Controls.Add(Me.Label2)
        Me.Compta.Controls.Add(Me.bsuppEcrit)
        Me.Compta.Controls.Add(Me.gCompta)
        Me.Compta.Location = New System.Drawing.Point(4, 22)
        Me.Compta.Name = "Compta"
        Me.Compta.Size = New System.Drawing.Size(782, 244)
        Me.Compta.TabIndex = 3
        Me.Compta.Text = "Ecritures"
        Me.Compta.UseVisualStyleBackColor = True
        '
        'dEcheance
        '
        Me.dEcheance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dEcheance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEcheance.Location = New System.Drawing.Point(673, 58)
        Me.dEcheance.Name = "dEcheance"
        Me.dEcheance.Size = New System.Drawing.Size(90, 20)
        Me.dEcheance.TabIndex = 52
        Me.dEcheance.Tag = "ecrEcheance"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(674, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Au"
        '
        'dDate
        '
        Me.dDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDate.Location = New System.Drawing.Point(673, 19)
        Me.dDate.Name = "dDate"
        Me.dDate.Size = New System.Drawing.Size(90, 20)
        Me.dDate.TabIndex = 51
        Me.dDate.Tag = "ecrDate"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(673, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Du"
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Location = New System.Drawing.Point(673, 203)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(90, 38)
        Me.bsuppEcrit.TabIndex = 17
        Me.bsuppEcrit.Text = "Supprimer Ecrit."
        Me.bsuppEcrit.UseVisualStyleBackColor = True
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
        Me.gCompta.ColumnHeadersHeight = 25
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.numPIece, Me.TypeTiers, Me.Tiers, Me.dateEcr, Me.Libelle, Me.debit, Me.credit, Me.Solde})
        Me.gCompta.Location = New System.Drawing.Point(6, 3)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(661, 238)
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
        'TypeTiers
        '
        Me.TypeTiers.FillWeight = 80.0!
        Me.TypeTiers.HeaderText = "Type Tiers"
        Me.TypeTiers.Name = "TypeTiers"
        Me.TypeTiers.ReadOnly = True
        '
        'Tiers
        '
        Me.Tiers.FillWeight = 80.0!
        Me.Tiers.HeaderText = "Tiers"
        Me.Tiers.Name = "Tiers"
        Me.Tiers.ReadOnly = True
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
        Me.Coord.Controls.Add(Me.gRIB)
        Me.Coord.Controls.Add(Me.gCoord)
        Me.Coord.Controls.Add(Me.gContact)
        Me.Coord.Location = New System.Drawing.Point(4, 22)
        Me.Coord.Name = "Coord"
        Me.Coord.Padding = New System.Windows.Forms.Padding(3)
        Me.Coord.Size = New System.Drawing.Size(782, 244)
        Me.Coord.TabIndex = 1
        Me.Coord.Text = "Coordonnées"
        '
        'gRIB
        '
        Me.gRIB.Controls.Add(Me.tpersId)
        Me.gRIB.Controls.Add(Me.Button2)
        Me.gRIB.Controls.Add(Me.TextBox10)
        Me.gRIB.Controls.Add(Me.Label7)
        Me.gRIB.Controls.Add(Me.TextBox7)
        Me.gRIB.Controls.Add(Me.Label8)
        Me.gRIB.Controls.Add(Me.TextBox8)
        Me.gRIB.Controls.Add(Me.Label9)
        Me.gRIB.Controls.Add(Me.tTauxTVA)
        Me.gRIB.Controls.Add(Me.Label10)
        Me.gRIB.Controls.Add(Me.TextBox9)
        Me.gRIB.Controls.Add(Me.tLoyer)
        Me.gRIB.Controls.Add(Me.Label11)
        Me.gRIB.Controls.Add(Me.tCharge)
        Me.gRIB.Controls.Add(Me.Label12)
        Me.gRIB.Location = New System.Drawing.Point(365, 6)
        Me.gRIB.Name = "gRIB"
        Me.gRIB.Size = New System.Drawing.Size(408, 138)
        Me.gRIB.TabIndex = 7
        Me.gRIB.TabStop = False
        '
        'tpersId
        '
        Me.tpersId.Location = New System.Drawing.Point(347, 19)
        Me.tpersId.Name = "tpersId"
        Me.tpersId.ReadOnly = True
        Me.tpersId.Size = New System.Drawing.Size(37, 20)
        Me.tpersId.TabIndex = 77
        Me.tpersId.Tag = "persId,t"
        Me.tpersId.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.MultiLoc.My.Resources.Resources.MC_MiniSave
        Me.Button2.Location = New System.Drawing.Point(347, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 34)
        Me.Button2.TabIndex = 76
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(275, 100)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(37, 20)
        Me.TextBox10.TabIndex = 75
        Me.TextBox10.Tag = "cptBkId,k"
        Me.TextBox10.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "IBAN"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(94, 19)
        Me.TextBox7.MaxLength = 30
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(218, 20)
        Me.TextBox7.TabIndex = 63
        Me.TextBox7.Tag = "cptBkIBAN,t"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "N° Compte"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(94, 71)
        Me.TextBox8.MaxLength = 20
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(150, 20)
        Me.TextBox8.TabIndex = 66
        Me.TextBox8.Tag = "cptBkCompte,t"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Clé"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.Location = New System.Drawing.Point(283, 71)
        Me.tTauxTVA.MaxLength = 2
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(29, 20)
        Me.tTauxTVA.TabIndex = 67
        Me.tTauxTVA.Tag = "cptBkCle,t"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Code SWIFT"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(94, 97)
        Me.TextBox9.MaxLength = 20
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(150, 20)
        Me.TextBox9.TabIndex = 68
        Me.TextBox9.Tag = "cptBkswift,t"
        '
        'tLoyer
        '
        Me.tLoyer.BackColor = System.Drawing.Color.White
        Me.tLoyer.Location = New System.Drawing.Point(94, 45)
        Me.tLoyer.MaxLength = 5
        Me.tLoyer.Name = "tLoyer"
        Me.tLoyer.Size = New System.Drawing.Size(59, 20)
        Me.tLoyer.TabIndex = 64
        Me.tLoyer.Tag = "cptBkEtab,t"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(177, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Code guichet"
        '
        'tCharge
        '
        Me.tCharge.BackColor = System.Drawing.Color.White
        Me.tCharge.Location = New System.Drawing.Point(253, 45)
        Me.tCharge.MaxLength = 5
        Me.tCharge.Name = "tCharge"
        Me.tCharge.Size = New System.Drawing.Size(59, 20)
        Me.tCharge.TabIndex = 65
        Me.tCharge.Tag = "cptBkGuichet,t"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Etablissement"
        '
        'gCoord
        '
        Me.gCoord.Controls.Add(Me.TextBox6)
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
        Me.gCoord.Size = New System.Drawing.Size(336, 138)
        Me.gCoord.TabIndex = 6
        Me.gCoord.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(208, 111)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(116, 20)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Tag = "fax"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(57, 111)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(115, 20)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Tag = "telbureau"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(178, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tél."
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(118, 82)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(206, 20)
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
        Me.TextBox2.Size = New System.Drawing.Size(267, 37)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Tag = "adr1,t"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(267, 20)
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
        Me.gContact.Location = New System.Drawing.Point(9, 150)
        Me.gContact.MultiSelect = False
        Me.gContact.Name = "gContact"
        Me.gContact.ReadOnly = True
        Me.gContact.RowHeadersVisible = False
        Me.gContact.Size = New System.Drawing.Size(767, 88)
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bXL, Me.tNouveau})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(814, 28)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'tNouveau
        '
        Me.tNouveau.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.tNouveau.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tNouveau.Name = "tNouveau"
        Me.tNouveau.Size = New System.Drawing.Size(75, 25)
        Me.tNouveau.Text = "Nouveau"
        '
        'lCptBk
        '
        Me.lCptBk.FormattingEnabled = True
        Me.lCptBk.Location = New System.Drawing.Point(103, 31)
        Me.lCptBk.Name = "lCptBk"
        Me.lCptBk.Size = New System.Drawing.Size(271, 21)
        Me.lCptBk.TabIndex = 9
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 34)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Compte Bancaire"
        '
        'F_BanqueSuivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(814, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lCptBk)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.oOnglet)
        Me.Name = "F_BanqueSuivi"
        Me.Text = "Banque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.oOnglet.ResumeLayout(False)
        Me.Compta.ResumeLayout(False)
        Me.Compta.PerformLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Coord.ResumeLayout(False)
        Me.gRIB.ResumeLayout(False)
        Me.gRIB.PerformLayout()
        Me.gCoord.ResumeLayout(False)
        Me.gCoord.PerformLayout()
        CType(Me.gContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents oOnglet As System.Windows.Forms.TabControl
    Friend WithEvents Coord As System.Windows.Forms.TabPage
    Friend WithEvents gContact As System.Windows.Forms.DataGridView
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
    Friend WithEvents bXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents Compta As System.Windows.Forms.TabPage
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents bsuppEcrit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numPIece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeTiers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tiers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateEcr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dEcheance As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tNouveau As System.Windows.Forms.ToolStripButton
    Friend WithEvents lCptBk As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents gRIB As System.Windows.Forms.GroupBox
    Friend WithEvents tpersId As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents tLoyer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
