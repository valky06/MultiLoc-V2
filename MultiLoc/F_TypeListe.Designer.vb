<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_TypeListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_TypeListe))
        Me.gListe = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bModif = New System.Windows.Forms.Button()
        Me.bNouveau = New System.Windows.Forms.Button()
        Me.bSupprime = New System.Windows.Forms.Button()
        CType(Me.gListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gListe
        '
        Me.gListe.AllowUserToAddRows = False
        Me.gListe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gListe.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gListe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gListe.ColumnHeadersHeight = 30
        Me.gListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nom})
        Me.gListe.Location = New System.Drawing.Point(12, 39)
        Me.gListe.MultiSelect = False
        Me.gListe.Name = "gListe"
        Me.gListe.ReadOnly = True
        Me.gListe.RowHeadersVisible = False
        Me.gListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gListe.Size = New System.Drawing.Size(292, 320)
        Me.gListe.TabIndex = 3
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
        'bModif
        '
        Me.bModif.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bModif.Image = CType(resources.GetObject("bModif.Image"), System.Drawing.Image)
        Me.bModif.Location = New System.Drawing.Point(114, 7)
        Me.bModif.Name = "bModif"
        Me.bModif.Size = New System.Drawing.Size(89, 26)
        Me.bModif.TabIndex = 35
        Me.bModif.Text = "Modifier"
        Me.bModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bModif.UseVisualStyleBackColor = True
        '
        'bNouveau
        '
        Me.bNouveau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bNouveau.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.bNouveau.Location = New System.Drawing.Point(223, 7)
        Me.bNouveau.Name = "bNouveau"
        Me.bNouveau.Size = New System.Drawing.Size(81, 26)
        Me.bNouveau.TabIndex = 34
        Me.bNouveau.Text = "Nouveau"
        Me.bNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bNouveau.UseVisualStyleBackColor = True
        '
        'bSupprime
        '
        Me.bSupprime.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.bSupprime.Location = New System.Drawing.Point(12, 7)
        Me.bSupprime.Name = "bSupprime"
        Me.bSupprime.Size = New System.Drawing.Size(82, 26)
        Me.bSupprime.TabIndex = 33
        Me.bSupprime.Text = "Supprimer"
        Me.bSupprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSupprime.UseVisualStyleBackColor = True
        '
        'F_TypeListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 371)
        Me.Controls.Add(Me.bModif)
        Me.Controls.Add(Me.bNouveau)
        Me.Controls.Add(Me.bSupprime)
        Me.Controls.Add(Me.gListe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_TypeListe"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Type"
        CType(Me.gListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bSupprime As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents gListe As System.Windows.Forms.DataGridView
    Friend WithEvents bNouveau As System.Windows.Forms.Button
    Friend WithEvents bModif As System.Windows.Forms.Button
End Class
