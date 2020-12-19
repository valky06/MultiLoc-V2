<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_LocaListe))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tRech = New System.Windows.Forms.ToolStripTextBox()
        Me.bRech = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tWord = New System.Windows.Forms.ToolStripButton()
        Me.tXL = New System.Windows.Forms.ToolStripButton()
        Me.gAnnuaire = New System.Windows.Forms.DataGridView()
        Me.LocId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ville = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telBureau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gAnnuaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tRech, Me.bRech, Me.ToolStripButton1, Me.ToolStripButton2, Me.tWord, Me.tXL})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(721, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tRech
        '
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
        Me.bRech.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'tWord
        '
        Me.tWord.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tWord.Image = Global.MultiLoc.My.Resources.Resources.word
        Me.tWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tWord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tWord.Name = "tWord"
        Me.tWord.Size = New System.Drawing.Size(25, 25)
        Me.tWord.Text = "ToolStripButton3"
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
        'gAnnuaire
        '
        Me.gAnnuaire.AllowUserToAddRows = False
        Me.gAnnuaire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gAnnuaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gAnnuaire.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gAnnuaire.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gAnnuaire.ColumnHeadersHeight = 30
        Me.gAnnuaire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocId, Me.Societe, Me.Adresse, Me.CP, Me.ville, Me.telBureau, Me.fax, Me.email})
        Me.gAnnuaire.Location = New System.Drawing.Point(12, 40)
        Me.gAnnuaire.MultiSelect = False
        Me.gAnnuaire.Name = "gAnnuaire"
        Me.gAnnuaire.ReadOnly = True
        Me.gAnnuaire.RowHeadersVisible = False
        Me.gAnnuaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gAnnuaire.Size = New System.Drawing.Size(697, 456)
        Me.gAnnuaire.TabIndex = 2
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
        Me.Societe.HeaderText = "Nom"
        Me.Societe.Name = "Societe"
        Me.Societe.ReadOnly = True
        '
        'Adresse
        '
        Me.Adresse.HeaderText = "Adresse"
        Me.Adresse.Name = "Adresse"
        Me.Adresse.ReadOnly = True
        '
        'CP
        '
        Me.CP.FillWeight = 50.0!
        Me.CP.HeaderText = "CP"
        Me.CP.Name = "CP"
        Me.CP.ReadOnly = True
        '
        'ville
        '
        Me.ville.HeaderText = "Localite"
        Me.ville.Name = "ville"
        Me.ville.ReadOnly = True
        '
        'telBureau
        '
        Me.telBureau.FillWeight = 60.0!
        Me.telBureau.HeaderText = "Bureau"
        Me.telBureau.Name = "telBureau"
        Me.telBureau.ReadOnly = True
        '
        'fax
        '
        Me.fax.FillWeight = 60.0!
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
        'F_LocataireListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.gAnnuaire)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "F_LocataireListe"
        Me.Text = "Locataires"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gAnnuaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tRech As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bRech As System.Windows.Forms.ToolStripButton
    Friend WithEvents gAnnuaire As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tWord As System.Windows.Forms.ToolStripButton
    Friend WithEvents tXL As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Societe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ville As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telBureau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewLinkColumn
End Class
