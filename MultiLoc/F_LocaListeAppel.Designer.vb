<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaListeAppel
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
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.societe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Echeance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lots = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumFacture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoyerHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOYCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dDebut = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dFin = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bSousTotal = New System.Windows.Forms.CheckBox()
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
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.societe, Me.Echeance, Me.Compte, Me.Tiers, Me.lots, Me.NumFacture, Me.LoyerHT, Me.ChargeHT, Me.LOYCH, Me.TVA, Me.TotalTTC})
        Me.gCompta.Location = New System.Drawing.Point(12, 39)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(762, 444)
        Me.gCompta.TabIndex = 9
        '
        'societe
        '
        Me.societe.HeaderText = "Société"
        Me.societe.Name = "societe"
        Me.societe.ReadOnly = True
        '
        'Echeance
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Echeance.DefaultCellStyle = DataGridViewCellStyle2
        Me.Echeance.FillWeight = 40.0!
        Me.Echeance.HeaderText = "Echéance"
        Me.Echeance.Name = "Echeance"
        Me.Echeance.ReadOnly = True
        '
        'Compte
        '
        Me.Compte.FillWeight = 50.0!
        Me.Compte.HeaderText = "Compte"
        Me.Compte.Name = "Compte"
        Me.Compte.ReadOnly = True
        '
        'Tiers
        '
        Me.Tiers.HeaderText = "Tiers"
        Me.Tiers.Name = "Tiers"
        Me.Tiers.ReadOnly = True
        '
        'lots
        '
        Me.lots.HeaderText = "Lots"
        Me.lots.Name = "lots"
        Me.lots.ReadOnly = True
        '
        'NumFacture
        '
        Me.NumFacture.FillWeight = 50.0!
        Me.NumFacture.HeaderText = "N°Facture"
        Me.NumFacture.Name = "NumFacture"
        Me.NumFacture.ReadOnly = True
        '
        'LoyerHT
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.LoyerHT.DefaultCellStyle = DataGridViewCellStyle3
        Me.LoyerHT.FillWeight = 50.0!
        Me.LoyerHT.HeaderText = "Loyer HT"
        Me.LoyerHT.Name = "LoyerHT"
        Me.LoyerHT.ReadOnly = True
        '
        'ChargeHT
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.ChargeHT.DefaultCellStyle = DataGridViewCellStyle4
        Me.ChargeHT.FillWeight = 50.0!
        Me.ChargeHT.HeaderText = "Charges HT"
        Me.ChargeHT.Name = "ChargeHT"
        Me.ChargeHT.ReadOnly = True
        '
        'LOYCH
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.LOYCH.DefaultCellStyle = DataGridViewCellStyle5
        Me.LOYCH.FillWeight = 50.0!
        Me.LOYCH.HeaderText = "Loy.+Ch. HT"
        Me.LOYCH.Name = "LOYCH"
        Me.LOYCH.ReadOnly = True
        '
        'TVA
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.TVA.DefaultCellStyle = DataGridViewCellStyle6
        Me.TVA.FillWeight = 50.0!
        Me.TVA.HeaderText = "Montant TVA"
        Me.TVA.Name = "TVA"
        Me.TVA.ReadOnly = True
        '
        'TotalTTC
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.TotalTTC.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalTTC.FillWeight = 50.0!
        Me.TotalTTC.HeaderText = "Total TTC"
        Me.TotalTTC.Name = "TotalTTC"
        Me.TotalTTC.ReadOnly = True
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
        Me.Button1.Location = New System.Drawing.Point(740, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bSousTotal
        '
        Me.bSousTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSousTotal.AutoSize = True
        Me.bSousTotal.Checked = True
        Me.bSousTotal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.bSousTotal.Location = New System.Drawing.Point(631, 11)
        Me.bSousTotal.Name = "bSousTotal"
        Me.bSousTotal.Size = New System.Drawing.Size(103, 17)
        Me.bSousTotal.TabIndex = 17
        Me.bSousTotal.Text = "Sous Total Tiers"
        Me.bSousTotal.UseVisualStyleBackColor = True
        '
        'F_LocaListeAppel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(786, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.bSousTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dDebut)
        Me.Controls.Add(Me.gCompta)
        Me.Name = "F_LocaListeAppel"
        Me.Text = "Liste des Appels"
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
    Friend WithEvents societe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Echeance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tiers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lots As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumFacture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoyerHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOYCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalTTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bSousTotal As System.Windows.Forms.CheckBox
End Class
