<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AppelLoyer
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tXL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tAn = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tMois = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bEnreg = New System.Windows.Forms.ToolStripButton()
        Me.gAppel = New System.Windows.Forms.DataGridView()
        Me.LocId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loyerInit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chargeInit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entree = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sortie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nbjour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loyerAppHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chargeAppHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TauxTVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loyerAppTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chargeAppTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.socId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nbmois = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gAppel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tXL, Me.ToolStripLabel1, Me.tAn, Me.ToolStripLabel2, Me.tMois, Me.ToolStripSeparator1, Me.bEnreg})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(889, 28)
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(41, 25)
        Me.ToolStripLabel1.Text = "Année"
        '
        'tAn
        '
        Me.tAn.Name = "tAn"
        Me.tAn.Size = New System.Drawing.Size(50, 28)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(33, 25)
        Me.ToolStripLabel2.Text = "Mois"
        '
        'tMois
        '
        Me.tMois.Name = "tMois"
        Me.tMois.Size = New System.Drawing.Size(30, 28)
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
        'gAppel
        '
        Me.gAppel.AllowUserToAddRows = False
        Me.gAppel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gAppel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gAppel.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gAppel.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gAppel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gAppel.ColumnHeadersHeight = 40
        Me.gAppel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocId, Me.Societe, Me.Periode, Me.loyerInit, Me.chargeInit, Me.entree, Me.sortie, Me.nbjour, Me.loyerAppHT, Me.chargeAppHT, Me.TauxTVA, Me.loyerAppTTC, Me.chargeAppTTC, Me.socId, Me.nbmois})
        Me.gAppel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.gAppel.Location = New System.Drawing.Point(12, 42)
        Me.gAppel.MultiSelect = False
        Me.gAppel.Name = "gAppel"
        Me.gAppel.RowHeadersVisible = False
        Me.gAppel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gAppel.Size = New System.Drawing.Size(865, 454)
        Me.gAppel.TabIndex = 2
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
        'Periode
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Periode.DefaultCellStyle = DataGridViewCellStyle2
        Me.Periode.FillWeight = 30.0!
        Me.Periode.HeaderText = "Pér."
        Me.Periode.Name = "Periode"
        Me.Periode.ReadOnly = True
        '
        'loyerInit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.loyerInit.DefaultCellStyle = DataGridViewCellStyle3
        Me.loyerInit.FillWeight = 60.0!
        Me.loyerInit.HeaderText = "Loyer Actu Per."
        Me.loyerInit.Name = "loyerInit"
        Me.loyerInit.ReadOnly = True
        '
        'chargeInit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.chargeInit.DefaultCellStyle = DataGridViewCellStyle4
        Me.chargeInit.FillWeight = 60.0!
        Me.chargeInit.HeaderText = "Charges Actu Per."
        Me.chargeInit.Name = "chargeInit"
        Me.chargeInit.ReadOnly = True
        '
        'entree
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.entree.DefaultCellStyle = DataGridViewCellStyle5
        Me.entree.FillWeight = 60.0!
        Me.entree.HeaderText = "Entrée"
        Me.entree.Name = "entree"
        Me.entree.ReadOnly = True
        '
        'sortie
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "d"
        Me.sortie.DefaultCellStyle = DataGridViewCellStyle6
        Me.sortie.FillWeight = 60.0!
        Me.sortie.HeaderText = "Sortie"
        Me.sortie.Name = "sortie"
        Me.sortie.ReadOnly = True
        '
        'nbjour
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nbjour.DefaultCellStyle = DataGridViewCellStyle7
        Me.nbjour.FillWeight = 40.0!
        Me.nbjour.HeaderText = "Nb Jours"
        Me.nbjour.Name = "nbjour"
        '
        'loyerAppHT
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.loyerAppHT.DefaultCellStyle = DataGridViewCellStyle8
        Me.loyerAppHT.FillWeight = 60.0!
        Me.loyerAppHT.HeaderText = "Loyer App HT"
        Me.loyerAppHT.Name = "loyerAppHT"
        Me.loyerAppHT.ReadOnly = True
        '
        'chargeAppHT
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.chargeAppHT.DefaultCellStyle = DataGridViewCellStyle9
        Me.chargeAppHT.FillWeight = 60.0!
        Me.chargeAppHT.HeaderText = "Charges App HT"
        Me.chargeAppHT.Name = "chargeAppHT"
        Me.chargeAppHT.ReadOnly = True
        '
        'TauxTVA
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.TauxTVA.DefaultCellStyle = DataGridViewCellStyle10
        Me.TauxTVA.FillWeight = 50.0!
        Me.TauxTVA.HeaderText = "Taux TVA"
        Me.TauxTVA.Name = "TauxTVA"
        Me.TauxTVA.ReadOnly = True
        '
        'loyerAppTTC
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.loyerAppTTC.DefaultCellStyle = DataGridViewCellStyle11
        Me.loyerAppTTC.FillWeight = 60.0!
        Me.loyerAppTTC.HeaderText = "Loyer App TTC"
        Me.loyerAppTTC.Name = "loyerAppTTC"
        Me.loyerAppTTC.ReadOnly = True
        '
        'chargeAppTTC
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.chargeAppTTC.DefaultCellStyle = DataGridViewCellStyle12
        Me.chargeAppTTC.FillWeight = 60.0!
        Me.chargeAppTTC.HeaderText = "Charges App TTC"
        Me.chargeAppTTC.Name = "chargeAppTTC"
        Me.chargeAppTTC.ReadOnly = True
        '
        'socId
        '
        Me.socId.HeaderText = "socId"
        Me.socId.Name = "socId"
        Me.socId.Visible = False
        '
        'nbmois
        '
        Me.nbmois.HeaderText = "nbmois"
        Me.nbmois.Name = "nbmois"
        Me.nbmois.Visible = False
        '
        'F_AppelLoyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.gAppel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "F_AppelLoyer"
        Me.Text = "Appel Loyer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gAppel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents gAppel As System.Windows.Forms.DataGridView
    Friend WithEvents tXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents bEnreg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tAn As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tMois As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LocId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Societe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Periode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loyerInit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chargeInit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents entree As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sortie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nbjour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loyerAppHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chargeAppHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TauxTVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loyerAppTTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chargeAppTTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents socId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nbmois As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
