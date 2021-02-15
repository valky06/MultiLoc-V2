<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaAvoir
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
        Me.gBail = New System.Windows.Forms.GroupBox()
        Me.tSocId = New System.Windows.Forms.TextBox()
        Me.dSortie = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dSortiePrev = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tLoyerActu = New System.Windows.Forms.TextBox()
        Me.tChargeActu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tLocId = New System.Windows.Forms.TextBox()
        Me.bFactInterne = New System.Windows.Forms.Button()
        Me.bChargeExterne = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categorie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dFacture = New System.Windows.Forms.DateTimePicker()
        Me.dFin = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dDeb = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dEcheance = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tNumpiece = New System.Windows.Forms.TextBox()
        Me.gBail.SuspendLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gBail
        '
        Me.gBail.Controls.Add(Me.tSocId)
        Me.gBail.Controls.Add(Me.dSortie)
        Me.gBail.Controls.Add(Me.Label14)
        Me.gBail.Controls.Add(Me.dSortiePrev)
        Me.gBail.Controls.Add(Me.Label13)
        Me.gBail.Controls.Add(Me.Label11)
        Me.gBail.Controls.Add(Me.tLoyerActu)
        Me.gBail.Controls.Add(Me.tChargeActu)
        Me.gBail.Controls.Add(Me.Label7)
        Me.gBail.Controls.Add(Me.tLocId)
        Me.gBail.Location = New System.Drawing.Point(10, 64)
        Me.gBail.Name = "gBail"
        Me.gBail.Size = New System.Drawing.Size(600, 78)
        Me.gBail.TabIndex = 2
        Me.gBail.TabStop = False
        '
        'tSocId
        '
        Me.tSocId.Location = New System.Drawing.Point(252, 52)
        Me.tSocId.Name = "tSocId"
        Me.tSocId.ReadOnly = True
        Me.tSocId.Size = New System.Drawing.Size(17, 20)
        Me.tSocId.TabIndex = 70
        Me.tSocId.Tag = "socId,n"
        Me.tSocId.Visible = False
        '
        'dSortie
        '
        Me.dSortie.Enabled = False
        Me.dSortie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortie.Location = New System.Drawing.Point(484, 49)
        Me.dSortie.Name = "dSortie"
        Me.dSortie.ShowCheckBox = True
        Me.dSortie.Size = New System.Drawing.Size(101, 20)
        Me.dSortie.TabIndex = 13
        Me.dSortie.Tag = "dateSortie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(416, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Sortie réelle"
        '
        'dSortiePrev
        '
        Me.dSortiePrev.Enabled = False
        Me.dSortiePrev.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortiePrev.Location = New System.Drawing.Point(484, 23)
        Me.dSortiePrev.Name = "dSortiePrev"
        Me.dSortiePrev.ShowCheckBox = True
        Me.dSortiePrev.Size = New System.Drawing.Size(101, 20)
        Me.dSortiePrev.TabIndex = 12
        Me.dSortiePrev.Tag = "dateSortiePrev"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(419, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Sortie Prèv"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Loyer Actu / An"
        '
        'tLoyerActu
        '
        Me.tLoyerActu.BackColor = System.Drawing.Color.White
        Me.tLoyerActu.Location = New System.Drawing.Point(103, 19)
        Me.tLoyerActu.Name = "tLoyerActu"
        Me.tLoyerActu.ReadOnly = True
        Me.tLoyerActu.Size = New System.Drawing.Size(71, 20)
        Me.tLoyerActu.TabIndex = 9
        Me.tLoyerActu.Tag = "loyerActu,no"
        Me.tLoyerActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tChargeActu
        '
        Me.tChargeActu.BackColor = System.Drawing.Color.White
        Me.tChargeActu.Location = New System.Drawing.Point(103, 45)
        Me.tChargeActu.Name = "tChargeActu"
        Me.tChargeActu.ReadOnly = True
        Me.tChargeActu.Size = New System.Drawing.Size(71, 20)
        Me.tChargeActu.TabIndex = 10
        Me.tChargeActu.Tag = "chargeActu,no"
        Me.tChargeActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Charges / An"
        '
        'tLocId
        '
        Me.tLocId.Location = New System.Drawing.Point(230, 52)
        Me.tLocId.Name = "tLocId"
        Me.tLocId.ReadOnly = True
        Me.tLocId.Size = New System.Drawing.Size(16, 20)
        Me.tLocId.TabIndex = 43
        Me.tLocId.Tag = "Locid,k"
        Me.tLocId.Visible = False
        '
        'bFactInterne
        '
        Me.bFactInterne.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bFactInterne.BackColor = System.Drawing.Color.Transparent
        Me.bFactInterne.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bFactInterne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bFactInterne.Location = New System.Drawing.Point(510, 280)
        Me.bFactInterne.Name = "bFactInterne"
        Me.bFactInterne.Size = New System.Drawing.Size(100, 39)
        Me.bFactInterne.TabIndex = 27
        Me.bFactInterne.Text = "Avoir Charge Interne"
        Me.bFactInterne.UseVisualStyleBackColor = False
        Me.bFactInterne.Visible = False
        '
        'bChargeExterne
        '
        Me.bChargeExterne.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bChargeExterne.BackColor = System.Drawing.Color.Transparent
        Me.bChargeExterne.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bChargeExterne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bChargeExterne.Location = New System.Drawing.Point(510, 235)
        Me.bChargeExterne.Name = "bChargeExterne"
        Me.bChargeExterne.Size = New System.Drawing.Size(100, 39)
        Me.bChargeExterne.TabIndex = 26
        Me.bChargeExterne.Text = "Avoir Charge Externe"
        Me.bChargeExterne.UseVisualStyleBackColor = False
        Me.bChargeExterne.Visible = False
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(510, 148)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 38)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "Avoir Loyer + Charges"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(510, 192)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 37)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Avoir Appel Dépôt Garantie"
        Me.Button8.UseVisualStyleBackColor = False
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
        Me.gCompta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.numPiece, Me.journal, Me.Libelle, Me.debit, Me.credit, Me.categorie})
        Me.gCompta.Location = New System.Drawing.Point(10, 148)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(494, 254)
        Me.gCompta.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'numPiece
        '
        Me.numPiece.HeaderText = "numPiece"
        Me.numPiece.Name = "numPiece"
        Me.numPiece.ReadOnly = True
        Me.numPiece.Visible = False
        '
        'journal
        '
        Me.journal.HeaderText = "journal"
        Me.journal.Name = "journal"
        Me.journal.ReadOnly = True
        Me.journal.Visible = False
        '
        'Libelle
        '
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        '
        'debit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle2
        Me.debit.FillWeight = 40.0!
        Me.debit.HeaderText = "Débit H.T."
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        '
        'credit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.credit.DefaultCellStyle = DataGridViewCellStyle3
        Me.credit.FillWeight = 40.0!
        Me.credit.HeaderText = "Crédit H.T."
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        '
        'categorie
        '
        Me.categorie.HeaderText = "categorie"
        Me.categorie.Name = "categorie"
        Me.categorie.ReadOnly = True
        Me.categorie.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Total H.T."
        '
        'tTotal
        '
        Me.tTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tTotal.BackColor = System.Drawing.Color.White
        Me.tTotal.Location = New System.Drawing.Point(382, 420)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.ReadOnly = True
        Me.tTotal.Size = New System.Drawing.Size(122, 20)
        Me.tTotal.TabIndex = 31
        Me.tTotal.Text = "0"
        Me.tTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(510, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(12, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 29)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Location = New System.Drawing.Point(510, 375)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(100, 27)
        Me.bsuppEcrit.TabIndex = 34
        Me.bsuppEcrit.Text = "Supprimer Ligne"
        Me.bsuppEcrit.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Date Avoir"
        '
        'dFacture
        '
        Me.dFacture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFacture.Location = New System.Drawing.Point(83, 12)
        Me.dFacture.Name = "dFacture"
        Me.dFacture.Size = New System.Drawing.Size(101, 20)
        Me.dFacture.TabIndex = 79
        Me.dFacture.Tag = "dateEntree"
        '
        'dFin
        '
        Me.dFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFin.Location = New System.Drawing.Point(515, 12)
        Me.dFin.Name = "dFin"
        Me.dFin.Size = New System.Drawing.Size(81, 20)
        Me.dFin.TabIndex = 82
        Me.dFin.Tag = "ecrDate"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(490, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 13)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "au"
        '
        'dDeb
        '
        Me.dDeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDeb.Location = New System.Drawing.Point(354, 12)
        Me.dDeb.Name = "dDeb"
        Me.dDeb.Size = New System.Drawing.Size(81, 20)
        Me.dDeb.TabIndex = 81
        Me.dDeb.Tag = "ecrDate"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(315, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Du"
        '
        'dEcheance
        '
        Me.dEcheance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEcheance.Location = New System.Drawing.Point(515, 38)
        Me.dEcheance.Name = "dEcheance"
        Me.dEcheance.Size = New System.Drawing.Size(81, 20)
        Me.dEcheance.TabIndex = 88
        Me.dEcheance.Tag = "ecrDate"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(305, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "N°Pièce"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(447, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Echéanche"
        '
        'tNumpiece
        '
        Me.tNumpiece.BackColor = System.Drawing.Color.White
        Me.tNumpiece.Location = New System.Drawing.Point(354, 38)
        Me.tNumpiece.Name = "tNumpiece"
        Me.tNumpiece.Size = New System.Drawing.Size(82, 20)
        Me.tNumpiece.TabIndex = 91
        Me.tNumpiece.Tag = ""
        '
        'F_LocaAvoir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 456)
        Me.Controls.Add(Me.tNumpiece)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dEcheance)
        Me.Controls.Add(Me.dFin)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dDeb)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dFacture)
        Me.Controls.Add(Me.bsuppEcrit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bFactInterne)
        Me.Controls.Add(Me.bChargeExterne)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.gCompta)
        Me.Controls.Add(Me.gBail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_LocaAvoir"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Avoir Appel Loyer"
        Me.gBail.ResumeLayout(False)
        Me.gBail.PerformLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gBail As System.Windows.Forms.GroupBox
    Friend WithEvents dSortie As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dSortiePrev As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tLoyerActu As System.Windows.Forms.TextBox
    Friend WithEvents tChargeActu As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tLocId As System.Windows.Forms.TextBox
    Friend WithEvents bFactInterne As System.Windows.Forms.Button
    Friend WithEvents bChargeExterne As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bsuppEcrit As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dFacture As System.Windows.Forms.DateTimePicker
    Friend WithEvents dFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dDeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dEcheance As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tNumpiece As System.Windows.Forms.TextBox
    Friend WithEvents tSocId As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numPiece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents categorie As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
