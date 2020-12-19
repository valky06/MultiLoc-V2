<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LotSuivi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_LotSuivi))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeCopro = New System.Windows.Forms.TreeView()
        Me.gLot = New System.Windows.Forms.GroupBox()
        Me.tCoproId = New System.Windows.Forms.TextBox()
        Me.tSocId = New System.Windows.Forms.TextBox()
        Me.tLotId = New System.Windows.Forms.TextBox()
        Me.lProprio = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.tBatiment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lTypeLocal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tLot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.oOnglet = New System.Windows.Forms.TabControl()
        Me.Locataires = New System.Windows.Forms.TabPage()
        Me.gLocataire = New System.Windows.Forms.DataGridView()
        Me.locId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.locataire = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Documents = New System.Windows.Forms.TabPage()
        Me.bDocSupp = New System.Windows.Forms.Button()
        Me.bDocAjout = New System.Windows.Forms.Button()
        Me.gDoc = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateCrea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docPath = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.imListe = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gLot.SuspendLayout()
        Me.oOnglet.SuspendLayout()
        Me.Locataires.SuspendLayout()
        CType(Me.gLocataire, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeCopro)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gLot)
        Me.SplitContainer1.Panel2.Controls.Add(Me.oOnglet)
        Me.SplitContainer1.Size = New System.Drawing.Size(871, 377)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeCopro
        '
        Me.TreeCopro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeCopro.Location = New System.Drawing.Point(3, 3)
        Me.TreeCopro.Name = "TreeCopro"
        Me.TreeCopro.Size = New System.Drawing.Size(186, 371)
        Me.TreeCopro.TabIndex = 0
        '
        'gLot
        '
        Me.gLot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gLot.Controls.Add(Me.tCoproId)
        Me.gLot.Controls.Add(Me.tSocId)
        Me.gLot.Controls.Add(Me.tLotId)
        Me.gLot.Controls.Add(Me.lProprio)
        Me.gLot.Controls.Add(Me.Button1)
        Me.gLot.Controls.Add(Me.LinkLabel2)
        Me.gLot.Controls.Add(Me.tBatiment)
        Me.gLot.Controls.Add(Me.Label8)
        Me.gLot.Controls.Add(Me.TextBox7)
        Me.gLot.Controls.Add(Me.lTypeLocal)
        Me.gLot.Controls.Add(Me.Label4)
        Me.gLot.Controls.Add(Me.Label2)
        Me.gLot.Controls.Add(Me.Label1)
        Me.gLot.Controls.Add(Me.TextBox4)
        Me.gLot.Controls.Add(Me.TextBox3)
        Me.gLot.Controls.Add(Me.TextBox2)
        Me.gLot.Controls.Add(Me.tLot)
        Me.gLot.Controls.Add(Me.Label3)
        Me.gLot.Location = New System.Drawing.Point(4, 3)
        Me.gLot.Name = "gLot"
        Me.gLot.Size = New System.Drawing.Size(664, 127)
        Me.gLot.TabIndex = 8
        Me.gLot.TabStop = False
        '
        'tCoproId
        '
        Me.tCoproId.Location = New System.Drawing.Point(434, 14)
        Me.tCoproId.Name = "tCoproId"
        Me.tCoproId.ReadOnly = True
        Me.tCoproId.Size = New System.Drawing.Size(37, 20)
        Me.tCoproId.TabIndex = 60
        Me.tCoproId.Tag = "coproId,n"
        Me.tCoproId.Visible = False
        '
        'tSocId
        '
        Me.tSocId.Location = New System.Drawing.Point(391, 14)
        Me.tSocId.Name = "tSocId"
        Me.tSocId.ReadOnly = True
        Me.tSocId.Size = New System.Drawing.Size(37, 20)
        Me.tSocId.TabIndex = 59
        Me.tSocId.Tag = "socId,t"
        Me.tSocId.Visible = False
        '
        'tLotId
        '
        Me.tLotId.Location = New System.Drawing.Point(477, 14)
        Me.tLotId.Name = "tLotId"
        Me.tLotId.ReadOnly = True
        Me.tLotId.Size = New System.Drawing.Size(37, 20)
        Me.tLotId.TabIndex = 58
        Me.tLotId.Tag = "lotid,k"
        Me.tLotId.Visible = False
        '
        'lProprio
        '
        Me.lProprio.AutoSize = True
        Me.lProprio.Location = New System.Drawing.Point(23, 17)
        Me.lProprio.Name = "lProprio"
        Me.lProprio.Size = New System.Drawing.Size(43, 13)
        Me.lProprio.TabIndex = 57
        Me.lProprio.TabStop = True
        Me.lProprio.Text = "Société"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MultiLoc.My.Resources.Resources.MC_MiniSave
        Me.Button1.Location = New System.Drawing.Point(423, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 32)
        Me.Button1.TabIndex = 56
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 43)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel2.TabIndex = 25
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Type Local"
        '
        'tBatiment
        '
        Me.tBatiment.Location = New System.Drawing.Point(205, 70)
        Me.tBatiment.Name = "tBatiment"
        Me.tBatiment.Size = New System.Drawing.Size(176, 20)
        Me.tBatiment.TabIndex = 22
        Me.tBatiment.Tag = "batiment,t"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(151, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Batiment"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(72, 14)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(309, 20)
        Me.TextBox7.TabIndex = 20
        Me.TextBox7.Tag = "nom"
        '
        'lTypeLocal
        '
        Me.lTypeLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypeLocal.FormattingEnabled = True
        Me.lTypeLocal.Location = New System.Drawing.Point(72, 40)
        Me.lTypeLocal.Name = "lTypeLocal"
        Me.lTypeLocal.Size = New System.Drawing.Size(101, 21)
        Me.lTypeLocal.TabIndex = 14
        Me.lTypeLocal.Tag = "TlocalId,n"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Niveau"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Surface"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Millième"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(336, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(45, 20)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.Tag = "niveau,t"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(205, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(59, 20)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Tag = "milliemes,n"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(72, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(61, 20)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Tag = "surface,n"
        '
        'tLot
        '
        Me.tLot.Location = New System.Drawing.Point(72, 70)
        Me.tLot.Name = "tLot"
        Me.tLot.Size = New System.Drawing.Size(73, 20)
        Me.tLot.TabIndex = 1
        Me.tLot.Tag = "lotnom,t"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lot"
        '
        'oOnglet
        '
        Me.oOnglet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oOnglet.Controls.Add(Me.Locataires)
        Me.oOnglet.Controls.Add(Me.Documents)
        Me.oOnglet.Enabled = False
        Me.oOnglet.Location = New System.Drawing.Point(4, 136)
        Me.oOnglet.Name = "oOnglet"
        Me.oOnglet.SelectedIndex = 0
        Me.oOnglet.Size = New System.Drawing.Size(665, 236)
        Me.oOnglet.TabIndex = 3
        '
        'Locataires
        '
        Me.Locataires.Controls.Add(Me.gLocataire)
        Me.Locataires.Location = New System.Drawing.Point(4, 22)
        Me.Locataires.Name = "Locataires"
        Me.Locataires.Padding = New System.Windows.Forms.Padding(3)
        Me.Locataires.Size = New System.Drawing.Size(657, 210)
        Me.Locataires.TabIndex = 1
        Me.Locataires.Text = "Locataires"
        Me.Locataires.UseVisualStyleBackColor = True
        '
        'gLocataire
        '
        Me.gLocataire.AllowUserToAddRows = False
        Me.gLocataire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gLocataire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gLocataire.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gLocataire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gLocataire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.locId, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.locataire})
        Me.gLocataire.Location = New System.Drawing.Point(4, 3)
        Me.gLocataire.MultiSelect = False
        Me.gLocataire.Name = "gLocataire"
        Me.gLocataire.ReadOnly = True
        Me.gLocataire.RowHeadersVisible = False
        Me.gLocataire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gLocataire.Size = New System.Drawing.Size(647, 209)
        Me.gLocataire.TabIndex = 3
        '
        'locId
        '
        Me.locId.HeaderText = "Id"
        Me.locId.Name = "locId"
        Me.locId.ReadOnly = True
        Me.locId.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Entrée"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle2.Format = "d"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sortie"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'locataire
        '
        Me.locataire.HeaderText = "Locataire"
        Me.locataire.Name = "locataire"
        Me.locataire.ReadOnly = True
        Me.locataire.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.locataire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Documents
        '
        Me.Documents.Controls.Add(Me.bDocSupp)
        Me.Documents.Controls.Add(Me.bDocAjout)
        Me.Documents.Controls.Add(Me.gDoc)
        Me.Documents.Location = New System.Drawing.Point(4, 22)
        Me.Documents.Name = "Documents"
        Me.Documents.Padding = New System.Windows.Forms.Padding(3)
        Me.Documents.Size = New System.Drawing.Size(657, 210)
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
        Me.bDocSupp.Location = New System.Drawing.Point(569, 57)
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
        Me.bDocAjout.Location = New System.Drawing.Point(569, 6)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gDoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dateCrea, Me.docNom, Me.docPath})
        Me.gDoc.Location = New System.Drawing.Point(6, 6)
        Me.gDoc.MultiSelect = False
        Me.gDoc.Name = "gDoc"
        Me.gDoc.ReadOnly = True
        Me.gDoc.RowHeadersVisible = False
        Me.gDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gDoc.Size = New System.Drawing.Size(560, 203)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.dateCrea.DefaultCellStyle = DataGridViewCellStyle4
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
        'F_LotSuivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "F_LotSuivi"
        Me.Text = "Lots"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gLot.ResumeLayout(False)
        Me.gLot.PerformLayout()
        Me.oOnglet.ResumeLayout(False)
        Me.Locataires.ResumeLayout(False)
        CType(Me.gLocataire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Documents.ResumeLayout(False)
        CType(Me.gDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeCopro As System.Windows.Forms.TreeView
    Friend WithEvents oOnglet As System.Windows.Forms.TabControl
    Friend WithEvents Locataires As System.Windows.Forms.TabPage
    Friend WithEvents gLot As System.Windows.Forms.GroupBox
    Friend WithEvents tLot As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lTypeLocal As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents gLocataire As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents tBatiment As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents imListe As System.Windows.Forms.ImageList
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Documents As System.Windows.Forms.TabPage
    Friend WithEvents bDocSupp As System.Windows.Forms.Button
    Friend WithEvents bDocAjout As System.Windows.Forms.Button
    Friend WithEvents gDoc As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateCrea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docPath As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lProprio As System.Windows.Forms.LinkLabel
    Friend WithEvents locId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents locataire As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents tCoproId As System.Windows.Forms.TextBox
    Friend WithEvents tSocId As System.Windows.Forms.TextBox
    Friend WithEvents tLotId As System.Windows.Forms.TextBox
End Class
