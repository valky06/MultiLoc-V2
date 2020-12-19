<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DepotRevision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DepotRevision))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tXL = New System.Windows.Forms.ToolStripButton()
        Me.bCalcul = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.gRevision = New System.Windows.Forms.DataGridView()
        Me.dEntre = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.locId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.socID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depotActuHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depotActuTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loyActu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbMois = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tauxTVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepotHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depotTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EcartHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ecartTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gRevision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tXL, Me.bCalcul, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(885, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'bCalcul
        '
        Me.bCalcul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.bCalcul.Image = CType(resources.GetObject("bCalcul.Image"), System.Drawing.Image)
        Me.bCalcul.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bCalcul.Name = "bCalcul"
        Me.bCalcul.Size = New System.Drawing.Size(44, 25)
        Me.bCalcul.Text = "Calcul"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(67, 25)
        Me.ToolStripButton1.Text = "Enregistrer"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gRevision.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gRevision.ColumnHeadersHeight = 41
        Me.gRevision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.locId, Me.socID, Me.Societe, Me.Adresse, Me.depotActuHT, Me.depotActuTTC, Me.loyActu, Me.NbMois, Me.tauxTVA, Me.DepotHT, Me.depotTTC, Me.EcartHT, Me.ecartTTC})
        Me.gRevision.Location = New System.Drawing.Point(12, 57)
        Me.gRevision.MultiSelect = False
        Me.gRevision.Name = "gRevision"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gRevision.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.gRevision.RowHeadersVisible = False
        Me.gRevision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gRevision.Size = New System.Drawing.Size(861, 439)
        Me.gRevision.TabIndex = 2
        '
        'dEntre
        '
        Me.dEntre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEntre.Location = New System.Drawing.Point(48, 31)
        Me.dEntre.Name = "dEntre"
        Me.dEntre.Size = New System.Drawing.Size(101, 20)
        Me.dEntre.TabIndex = 33
        Me.dEntre.Tag = "ecrDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Date"
        '
        'locId
        '
        Me.locId.FillWeight = 60.0!
        Me.locId.HeaderText = "Id"
        Me.locId.Name = "locId"
        Me.locId.ReadOnly = True
        Me.locId.Visible = False
        '
        'socID
        '
        Me.socID.HeaderText = "socId"
        Me.socID.Name = "socID"
        Me.socID.Visible = False
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
        'depotActuHT
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.depotActuHT.DefaultCellStyle = DataGridViewCellStyle2
        Me.depotActuHT.HeaderText = "Dépôt Actu HT"
        Me.depotActuHT.Name = "depotActuHT"
        Me.depotActuHT.ReadOnly = True
        '
        'depotActuTTC
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.depotActuTTC.DefaultCellStyle = DataGridViewCellStyle3
        Me.depotActuTTC.HeaderText = "Dépôt Actu TTC"
        Me.depotActuTTC.Name = "depotActuTTC"
        Me.depotActuTTC.ReadOnly = True
        '
        'loyActu
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.loyActu.DefaultCellStyle = DataGridViewCellStyle4
        Me.loyActu.HeaderText = "Loyer Actu HT Mois"
        Me.loyActu.Name = "loyActu"
        Me.loyActu.ReadOnly = True
        '
        'NbMois
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NbMois.DefaultCellStyle = DataGridViewCellStyle5
        Me.NbMois.FillWeight = 40.0!
        Me.NbMois.HeaderText = "Nb Mois"
        Me.NbMois.Name = "NbMois"
        Me.NbMois.ReadOnly = True
        '
        'tauxTVA
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.tauxTVA.DefaultCellStyle = DataGridViewCellStyle6
        Me.tauxTVA.FillWeight = 60.0!
        Me.tauxTVA.HeaderText = "Taux TVA"
        Me.tauxTVA.Name = "tauxTVA"
        '
        'DepotHT
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DepotHT.DefaultCellStyle = DataGridViewCellStyle7
        Me.DepotHT.HeaderText = "Dépôt HT"
        Me.DepotHT.Name = "DepotHT"
        '
        'depotTTC
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.depotTTC.DefaultCellStyle = DataGridViewCellStyle8
        Me.depotTTC.HeaderText = "Dépôt TTC"
        Me.depotTTC.Name = "depotTTC"
        Me.depotTTC.ReadOnly = True
        '
        'EcartHT
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.EcartHT.DefaultCellStyle = DataGridViewCellStyle9
        Me.EcartHT.HeaderText = "Ecart HT"
        Me.EcartHT.Name = "EcartHT"
        Me.EcartHT.ReadOnly = True
        '
        'ecartTTC
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.ecartTTC.DefaultCellStyle = DataGridViewCellStyle10
        Me.ecartTTC.HeaderText = "Ecart TTC"
        Me.ecartTTC.Name = "ecartTTC"
        '
        'F_DepotRevision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.dEntre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gRevision)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "F_DepotRevision"
        Me.Text = "Révision Dépôt Garantie"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gRevision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents gRevision As System.Windows.Forms.DataGridView
    Friend WithEvents tXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents bCalcul As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents locId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents socID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Societe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depotActuHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depotActuTTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loyActu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NbMois As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tauxTVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepotHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depotTTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EcartHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ecartTTC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
