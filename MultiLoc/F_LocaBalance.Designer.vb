<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaBalance
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
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bWord = New System.Windows.Forms.ToolStripButton()
        Me.bXL = New System.Windows.Forms.ToolStripButton()
        Me.societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Typepers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.societe, Me.Typepers, Me.Tiers, Me.debit, Me.credit})
        Me.gCompta.Location = New System.Drawing.Point(12, 31)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(668, 287)
        Me.gCompta.TabIndex = 9
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
        'societe
        '
        Me.societe.HeaderText = "Société"
        Me.societe.Name = "societe"
        Me.societe.ReadOnly = True
        '
        'Typepers
        '
        Me.Typepers.FillWeight = 60.0!
        Me.Typepers.HeaderText = "Type"
        Me.Typepers.Name = "Typepers"
        Me.Typepers.ReadOnly = True
        '
        'Tiers
        '
        Me.Tiers.HeaderText = "Tiers"
        Me.Tiers.Name = "Tiers"
        Me.Tiers.ReadOnly = True
        '
        'debit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle2
        Me.debit.FillWeight = 40.0!
        Me.debit.HeaderText = "Débit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        '
        'credit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.credit.DefaultCellStyle = DataGridViewCellStyle3
        Me.credit.FillWeight = 40.0!
        Me.credit.HeaderText = "Crédit"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        '
        'F_LocaBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(692, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gCompta)
        Me.Name = "F_LocaBalance"
        Me.Text = "Balance Locataire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents bWord As System.Windows.Forms.ToolStripButton
    Friend WithEvents bXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents societe As DataGridViewTextBoxColumn
    Friend WithEvents Typepers As DataGridViewTextBoxColumn
    Friend WithEvents Tiers As DataGridViewTextBoxColumn
    Friend WithEvents debit As DataGridViewTextBoxColumn
    Friend WithEvents credit As DataGridViewTextBoxColumn
End Class
