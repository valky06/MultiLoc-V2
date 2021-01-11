<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_FacturationSociete
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
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.dDebut = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dFin = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateEcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFacture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ecrLib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categorie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantTVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gCompta.ColumnHeadersHeight = 46
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.societe, Me.Tiers, Me.cpt, Me.dateEcr, Me.NumFacture, Me.ecrLib, Me.categorie, Me.Compte, Me.MontantHT, Me.MontantTVA, Me.MontantTTC})
        Me.gCompta.Location = New System.Drawing.Point(12, 39)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(910, 450)
        Me.gCompta.TabIndex = 9
        '
        'dDebut
        '
        Me.dDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDebut.Location = New System.Drawing.Point(50, 13)
        Me.dDebut.Name = "dDebut"
        Me.dDebut.Size = New System.Drawing.Size(103, 20)
        Me.dDebut.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Du"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "au"
        '
        'dFin
        '
        Me.dFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFin.Location = New System.Drawing.Point(193, 13)
        Me.dFin.Name = "dFin"
        Me.dFin.Size = New System.Drawing.Size(103, 20)
        Me.dFin.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MultiLoc.My.Resources.Resources.xl1
        Me.Button1.Location = New System.Drawing.Point(888, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.MultiLoc.My.Resources.Resources.smallupdate
        Me.Button2.Location = New System.Drawing.Point(715, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 29)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Export Compta"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'societe
        '
        Me.societe.FillWeight = 80.0!
        Me.societe.HeaderText = "Société"
        Me.societe.Name = "societe"
        Me.societe.ReadOnly = True
        '
        'Tiers
        '
        Me.Tiers.HeaderText = "Tiers"
        Me.Tiers.Name = "Tiers"
        Me.Tiers.ReadOnly = True
        '
        'cpt
        '
        Me.cpt.FillWeight = 20.0!
        Me.cpt.HeaderText = "Cpt"
        Me.cpt.Name = "cpt"
        Me.cpt.ReadOnly = True
        '
        'dateEcr
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dateEcr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dateEcr.FillWeight = 40.0!
        Me.dateEcr.HeaderText = "Date"
        Me.dateEcr.Name = "dateEcr"
        Me.dateEcr.ReadOnly = True
        '
        'NumFacture
        '
        Me.NumFacture.FillWeight = 50.0!
        Me.NumFacture.HeaderText = "Facture"
        Me.NumFacture.Name = "NumFacture"
        Me.NumFacture.ReadOnly = True
        '
        'ecrLib
        '
        Me.ecrLib.HeaderText = "libellé"
        Me.ecrLib.Name = "ecrLib"
        Me.ecrLib.ReadOnly = True
        '
        'categorie
        '
        Me.categorie.FillWeight = 50.0!
        Me.categorie.HeaderText = "Catégorie"
        Me.categorie.Name = "categorie"
        Me.categorie.ReadOnly = True
        '
        'Compte
        '
        Me.Compte.FillWeight = 50.0!
        Me.Compte.HeaderText = "Compte"
        Me.Compte.Name = "Compte"
        Me.Compte.ReadOnly = True
        '
        'MontantHT
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.MontantHT.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontantHT.FillWeight = 50.0!
        Me.MontantHT.HeaderText = "MontantHT"
        Me.MontantHT.Name = "MontantHT"
        Me.MontantHT.ReadOnly = True
        '
        'MontantTVA
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.MontantTVA.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontantTVA.FillWeight = 50.0!
        Me.MontantTVA.HeaderText = "Montant TVA"
        Me.MontantTVA.Name = "MontantTVA"
        Me.MontantTVA.ReadOnly = True
        '
        'MontantTTC
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.MontantTTC.DefaultCellStyle = DataGridViewCellStyle5
        Me.MontantTTC.FillWeight = 50.0!
        Me.MontantTTC.HeaderText = "Montant TTC"
        Me.MontantTTC.Name = "MontantTTC"
        Me.MontantTTC.ReadOnly = True
        '
        'F_FactureSociete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(934, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dDebut)
        Me.Controls.Add(Me.gCompta)
        Me.Name = "F_FactureSociete"
        Me.Text = "Facturation Societé"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents dDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents societe As DataGridViewTextBoxColumn
    Friend WithEvents Tiers As DataGridViewTextBoxColumn
    Friend WithEvents cpt As DataGridViewTextBoxColumn
    Friend WithEvents dateEcr As DataGridViewTextBoxColumn
    Friend WithEvents NumFacture As DataGridViewTextBoxColumn
    Friend WithEvents ecrLib As DataGridViewTextBoxColumn
    Friend WithEvents categorie As DataGridViewTextBoxColumn
    Friend WithEvents Compte As DataGridViewTextBoxColumn
    Friend WithEvents MontantHT As DataGridViewTextBoxColumn
    Friend WithEvents MontantTVA As DataGridViewTextBoxColumn
    Friend WithEvents MontantTTC As DataGridViewTextBoxColumn
End Class
