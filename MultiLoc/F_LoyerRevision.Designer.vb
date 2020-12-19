<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LoyerRevision
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tXL = New System.Windows.Forms.ToolStripButton()
        Me.lIndice = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bEnreg = New System.Windows.Forms.ToolStripButton()
        Me.gRevision = New System.Windows.Forms.DataGridView()
        Me.LocId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loyDepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeindice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Annee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trimestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.indiceActu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loyFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enreg = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cTout = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gRevision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tXL, Me.lIndice, Me.ToolStripSeparator1, Me.bEnreg})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(796, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 25)
        Me.ToolStripLabel1.Text = "Indice"
        '
        'tXL
        '
        Me.tXL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tXL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tXL.Image = Global.MultiLoc.My.Resources.Resources.xl1
        Me.tXL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tXL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tXL.Name = "tXL"
        Me.tXL.Size = New System.Drawing.Size(25, 25)
        Me.tXL.Text = "ToolStripButton3"
        '
        'lIndice
        '
        Me.lIndice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lIndice.Name = "lIndice"
        Me.lIndice.Size = New System.Drawing.Size(200, 28)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'bEnreg
        '
        Me.bEnreg.Image = Global.MultiLoc.My.Resources.Resources.MC_MiniSave
        Me.bEnreg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bEnreg.Name = "bEnreg"
        Me.bEnreg.Size = New System.Drawing.Size(83, 25)
        Me.bEnreg.Text = "Enregistrer"
        '
        'gRevision
        '
        Me.gRevision.AllowUserToAddRows = False
        Me.gRevision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gRevision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gRevision.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gRevision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gRevision.ColumnHeadersHeight = 41
        Me.gRevision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocId, Me.Societe, Me.Adresse, Me.loyDepart, Me.typeindice, Me.Annee, Me.Trimestre, Me.indice, Me.indiceActu, Me.loyFin, Me.Enreg})
        Me.gRevision.Location = New System.Drawing.Point(12, 58)
        Me.gRevision.MultiSelect = False
        Me.gRevision.Name = "gRevision"
        Me.gRevision.RowHeadersVisible = False
        Me.gRevision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gRevision.Size = New System.Drawing.Size(772, 438)
        Me.gRevision.TabIndex = 2
        '
        'LocId
        '
        Me.LocId.FillWeight = 60.0!
        Me.LocId.HeaderText = "Id"
        Me.LocId.Name = "LocId"
        Me.LocId.ReadOnly = True
        Me.LocId.Visible = False
        '
        'Societe
        '
        Me.Societe.FillWeight = 150.0!
        Me.Societe.HeaderText = "Nom"
        Me.Societe.Name = "Societe"
        Me.Societe.ReadOnly = True
        '
        'Adresse
        '
        Me.Adresse.FillWeight = 150.0!
        Me.Adresse.HeaderText = "Adresse"
        Me.Adresse.Name = "Adresse"
        Me.Adresse.ReadOnly = True
        '
        'loyDepart
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.loyDepart.DefaultCellStyle = DataGridViewCellStyle1
        Me.loyDepart.HeaderText = "Loyer Départ"
        Me.loyDepart.Name = "loyDepart"
        Me.loyDepart.ReadOnly = True
        '
        'typeindice
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.typeindice.DefaultCellStyle = DataGridViewCellStyle2
        Me.typeindice.FillWeight = 60.0!
        Me.typeindice.HeaderText = "Type Indice"
        Me.typeindice.Name = "typeindice"
        Me.typeindice.ReadOnly = True
        '
        'Annee
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Annee.DefaultCellStyle = DataGridViewCellStyle3
        Me.Annee.FillWeight = 60.0!
        Me.Annee.HeaderText = "Année"
        Me.Annee.Name = "Annee"
        Me.Annee.ReadOnly = True
        '
        'Trimestre
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Trimestre.DefaultCellStyle = DataGridViewCellStyle4
        Me.Trimestre.FillWeight = 60.0!
        Me.Trimestre.HeaderText = "Trimestre"
        Me.Trimestre.Name = "Trimestre"
        Me.Trimestre.ReadOnly = True
        '
        'indice
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.indice.DefaultCellStyle = DataGridViewCellStyle5
        Me.indice.FillWeight = 60.0!
        Me.indice.HeaderText = "Indice Départ"
        Me.indice.Name = "indice"
        Me.indice.ReadOnly = True
        '
        'indiceActu
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.indiceActu.DefaultCellStyle = DataGridViewCellStyle6
        Me.indiceActu.FillWeight = 60.0!
        Me.indiceActu.HeaderText = "Indice Actuel"
        Me.indiceActu.Name = "indiceActu"
        Me.indiceActu.ReadOnly = True
        '
        'loyFin
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.loyFin.DefaultCellStyle = DataGridViewCellStyle7
        Me.loyFin.FillWeight = 60.0!
        Me.loyFin.HeaderText = "Nouveau Loyer"
        Me.loyFin.Name = "loyFin"
        '
        'Enreg
        '
        Me.Enreg.FalseValue = "0"
        Me.Enreg.FillWeight = 20.0!
        Me.Enreg.HeaderText = "OK"
        Me.Enreg.Name = "Enreg"
        Me.Enreg.TrueValue = "1"
        '
        'cTout
        '
        Me.cTout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cTout.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cTout.Location = New System.Drawing.Point(727, 35)
        Me.cTout.Name = "cTout"
        Me.cTout.Size = New System.Drawing.Size(48, 17)
        Me.cTout.TabIndex = 3
        Me.cTout.Text = "Tout"
        Me.cTout.UseVisualStyleBackColor = True
        '
        'F_LoyerRevision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.cTout)
        Me.Controls.Add(Me.gRevision)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "F_LoyerRevision"
        Me.Text = "Révision Loyer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gRevision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents gRevision As System.Windows.Forms.DataGridView
    Friend WithEvents tXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents lIndice As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents bEnreg As System.Windows.Forms.ToolStripButton
    Friend WithEvents cTout As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LocId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Societe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loyDepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents typeindice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Annee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Trimestre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents indice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents indiceActu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loyFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Enreg As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
