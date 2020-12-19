<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AppelMensuel
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tXL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tAn = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tMois = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bEnreg = New System.Windows.Forms.ToolStripButton()
        Me.gAppel = New System.Windows.Forms.DataGridView()
        Me.cliId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantInit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nbjour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantAppHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TauxTVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantAppTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.gAppel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliId, Me.Societe, Me.contrat, Me.MontantInit, Me.debut, Me.fin, Me.nbjour, Me.MontantAppHT, Me.TauxTVA, Me.MontantAppTTC})
        Me.gAppel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.gAppel.Location = New System.Drawing.Point(12, 31)
        Me.gAppel.MultiSelect = False
        Me.gAppel.Name = "gAppel"
        Me.gAppel.RowHeadersVisible = False
        Me.gAppel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gAppel.Size = New System.Drawing.Size(865, 465)
        Me.gAppel.TabIndex = 2
        '
        'cliId
        '
        Me.cliId.FillWeight = 60.0!
        Me.cliId.HeaderText = "Id"
        Me.cliId.Name = "cliId"
        Me.cliId.ReadOnly = True
        Me.cliId.Visible = False
        '
        'Societe
        '
        Me.Societe.FillWeight = 150.0!
        Me.Societe.HeaderText = "Nom"
        Me.Societe.Name = "Societe"
        Me.Societe.ReadOnly = True
        '
        'contrat
        '
        Me.contrat.HeaderText = "Contrat"
        Me.contrat.Name = "contrat"
        Me.contrat.ReadOnly = True
        '
        'MontantInit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.MontantInit.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontantInit.FillWeight = 60.0!
        Me.MontantInit.HeaderText = "Montant HT"
        Me.MontantInit.Name = "MontantInit"
        Me.MontantInit.ReadOnly = True
        '
        'debut
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.debut.DefaultCellStyle = DataGridViewCellStyle3
        Me.debut.FillWeight = 60.0!
        Me.debut.HeaderText = "Début"
        Me.debut.Name = "debut"
        Me.debut.ReadOnly = True
        '
        'fin
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        Me.fin.DefaultCellStyle = DataGridViewCellStyle4
        Me.fin.FillWeight = 60.0!
        Me.fin.HeaderText = "Fin"
        Me.fin.Name = "fin"
        Me.fin.ReadOnly = True
        '
        'nbjour
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nbjour.DefaultCellStyle = DataGridViewCellStyle5
        Me.nbjour.FillWeight = 40.0!
        Me.nbjour.HeaderText = "Nb Jours"
        Me.nbjour.Name = "nbjour"
        '
        'MontantAppHT
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.MontantAppHT.DefaultCellStyle = DataGridViewCellStyle6
        Me.MontantAppHT.FillWeight = 60.0!
        Me.MontantAppHT.HeaderText = "Montant App HT"
        Me.MontantAppHT.Name = "MontantAppHT"
        Me.MontantAppHT.ReadOnly = True
        '
        'TauxTVA
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.TauxTVA.DefaultCellStyle = DataGridViewCellStyle7
        Me.TauxTVA.FillWeight = 50.0!
        Me.TauxTVA.HeaderText = "Taux TVA"
        Me.TauxTVA.Name = "TauxTVA"
        Me.TauxTVA.ReadOnly = True
        '
        'MontantAppTTC
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.MontantAppTTC.DefaultCellStyle = DataGridViewCellStyle8
        Me.MontantAppTTC.FillWeight = 60.0!
        Me.MontantAppTTC.HeaderText = "Montant App TTC"
        Me.MontantAppTTC.Name = "MontantAppTTC"
        Me.MontantAppTTC.ReadOnly = True
        '
        'F_AppelMensuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.gAppel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "F_AppelMensuel"
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
    Friend WithEvents cliId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Societe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contrat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantInit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nbjour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantAppHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TauxTVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantAppTTC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
