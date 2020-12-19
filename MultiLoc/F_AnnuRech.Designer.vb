<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AnnuRech
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
        Me.gAnnuaire = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ville = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trech = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.gAnnuaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gAnnuaire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nom, Me.Adresse, Me.CP, Me.ville})
        Me.gAnnuaire.Location = New System.Drawing.Point(12, 39)
        Me.gAnnuaire.MultiSelect = False
        Me.gAnnuaire.Name = "gAnnuaire"
        Me.gAnnuaire.ReadOnly = True
        Me.gAnnuaire.RowHeadersVisible = False
        Me.gAnnuaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gAnnuaire.Size = New System.Drawing.Size(677, 320)
        Me.gAnnuaire.TabIndex = 2
        '
        'id
        '
        Me.id.FillWeight = 60.0!
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nom
        '
        Me.nom.HeaderText = "Nom"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
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
        'trech
        '
        Me.trech.Location = New System.Drawing.Point(46, 7)
        Me.trech.Name = "trech"
        Me.trech.Size = New System.Drawing.Size(200, 20)
        Me.trech.TabIndex = 0
        Me.trech.Tag = "societe,t"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nom"
        '
        'Button2
        '
        Me.Button2.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button2.Location = New System.Drawing.Point(600, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Nouveau"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MultiLoc.My.Resources.Resources.smallsearch
        Me.Button1.Location = New System.Drawing.Point(252, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.MultiLoc.My.Resources.Resources.Edit1
        Me.Button3.Location = New System.Drawing.Point(466, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 26)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Modifier"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'F_AnnuRech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 371)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.trech)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gAnnuaire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_AnnuRech"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche"
        CType(Me.gAnnuaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gAnnuaire As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents trech As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Adresse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ville As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
