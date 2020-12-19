<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_IndiceListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_IndiceListe))
        Me.gIndice = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeInd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.annee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trimestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePAru = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valeur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bModif = New System.Windows.Forms.Button()
        Me.bNouveau = New System.Windows.Forms.Button()
        Me.bSupprime = New System.Windows.Forms.Button()
        CType(Me.gIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gIndice
        '
        Me.gIndice.AllowUserToAddRows = False
        Me.gIndice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gIndice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gIndice.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gIndice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gIndice.ColumnHeadersHeight = 30
        Me.gIndice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.TypeInd, Me.annee, Me.trimestre, Me.DatePAru, Me.valeur})
        Me.gIndice.Location = New System.Drawing.Point(12, 39)
        Me.gIndice.MultiSelect = False
        Me.gIndice.Name = "gIndice"
        Me.gIndice.ReadOnly = True
        Me.gIndice.RowHeadersVisible = False
        Me.gIndice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gIndice.Size = New System.Drawing.Size(442, 320)
        Me.gIndice.TabIndex = 3
        '
        'id
        '
        Me.id.FillWeight = 60.0!
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'TypeInd
        '
        Me.TypeInd.HeaderText = "Type"
        Me.TypeInd.Name = "TypeInd"
        Me.TypeInd.ReadOnly = True
        '
        'annee
        '
        Me.annee.FillWeight = 80.0!
        Me.annee.HeaderText = "Année"
        Me.annee.Name = "annee"
        Me.annee.ReadOnly = True
        '
        'trimestre
        '
        Me.trimestre.FillWeight = 80.0!
        Me.trimestre.HeaderText = "Trimestre"
        Me.trimestre.Name = "trimestre"
        Me.trimestre.ReadOnly = True
        '
        'DatePAru
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DatePAru.DefaultCellStyle = DataGridViewCellStyle1
        Me.DatePAru.HeaderText = "Date Par."
        Me.DatePAru.Name = "DatePAru"
        Me.DatePAru.ReadOnly = True
        '
        'valeur
        '
        Me.valeur.HeaderText = "Valeur"
        Me.valeur.Name = "valeur"
        Me.valeur.ReadOnly = True
        '
        'bModif
        '
        Me.bModif.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bModif.Image = CType(resources.GetObject("bModif.Image"), System.Drawing.Image)
        Me.bModif.Location = New System.Drawing.Point(12, 7)
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
        Me.bNouveau.Location = New System.Drawing.Point(373, 7)
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
        Me.bSupprime.Location = New System.Drawing.Point(196, 7)
        Me.bSupprime.Name = "bSupprime"
        Me.bSupprime.Size = New System.Drawing.Size(82, 26)
        Me.bSupprime.TabIndex = 33
        Me.bSupprime.Text = "Supprimer"
        Me.bSupprime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bSupprime.UseVisualStyleBackColor = True
        Me.bSupprime.Visible = False
        '
        'F_IndiceListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 371)
        Me.Controls.Add(Me.bModif)
        Me.Controls.Add(Me.bNouveau)
        Me.Controls.Add(Me.bSupprime)
        Me.Controls.Add(Me.gIndice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_IndiceListe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indice"
        CType(Me.gIndice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bSupprime As System.Windows.Forms.Button
    Private WithEvents gIndice As System.Windows.Forms.DataGridView
    Friend WithEvents bNouveau As System.Windows.Forms.Button
    Friend WithEvents bModif As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeInd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents annee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trimestre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePAru As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valeur As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
