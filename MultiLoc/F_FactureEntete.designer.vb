<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_FactureEntete
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bAjout = New System.Windows.Forms.Button()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantTTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tTotal = New System.Windows.Forms.TextBox()
        Me.bEnreg = New System.Windows.Forms.Button()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
        Me.tNum = New System.Windows.Forms.TextBox()
        Me.lClient = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tNumFacture = New System.Windows.Forms.TextBox()
        Me.dEcheance = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tLibFact = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bAjout
        '
        Me.bAjout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAjout.BackColor = System.Drawing.Color.Transparent
        Me.bAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAjout.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.bAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAjout.Location = New System.Drawing.Point(594, 91)
        Me.bAjout.Name = "bAjout"
        Me.bAjout.Size = New System.Drawing.Size(101, 38)
        Me.bAjout.TabIndex = 23
        Me.bAjout.Text = "Ajouter Ligne"
        Me.bAjout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bAjout.UseVisualStyleBackColor = False
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
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Libelle, Me.MontantHT, Me.TVA, Me.MontantTTC})
        Me.gCompta.Location = New System.Drawing.Point(13, 91)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(575, 246)
        Me.gCompta.TabIndex = 21
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Libelle
        '
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        '
        'MontantHT
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.MontantHT.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontantHT.FillWeight = 40.0!
        Me.MontantHT.HeaderText = "Montant HT"
        Me.MontantHT.Name = "MontantHT"
        Me.MontantHT.ReadOnly = True
        '
        'TVA
        '
        Me.TVA.FillWeight = 40.0!
        Me.TVA.HeaderText = "TVA"
        Me.TVA.Name = "TVA"
        Me.TVA.ReadOnly = True
        '
        'MontantTTC
        '
        Me.MontantTTC.FillWeight = 40.0!
        Me.MontantTTC.HeaderText = "Montant TTC"
        Me.MontantTTC.Name = "MontantTTC"
        Me.MontantTTC.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(399, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Total H.T."
        '
        'tTotal
        '
        Me.tTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tTotal.BackColor = System.Drawing.Color.White
        Me.tTotal.Location = New System.Drawing.Point(460, 352)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.ReadOnly = True
        Me.tTotal.Size = New System.Drawing.Size(122, 20)
        Me.tTotal.TabIndex = 31
        Me.tTotal.Text = "0"
        Me.tTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bEnreg
        '
        Me.bEnreg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEnreg.BackColor = System.Drawing.Color.Transparent
        Me.bEnreg.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bEnreg.Location = New System.Drawing.Point(594, 347)
        Me.bEnreg.Name = "bEnreg"
        Me.bEnreg.Size = New System.Drawing.Size(100, 29)
        Me.bEnreg.TabIndex = 32
        Me.bEnreg.Text = "Enregistrer"
        Me.bEnreg.UseVisualStyleBackColor = False
        '
        'bAnnul
        '
        Me.bAnnul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAnnul.BackColor = System.Drawing.Color.Transparent
        Me.bAnnul.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bAnnul.Location = New System.Drawing.Point(12, 347)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(98, 29)
        Me.bAnnul.TabIndex = 33
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = False
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.bsuppEcrit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bsuppEcrit.Location = New System.Drawing.Point(594, 135)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(101, 36)
        Me.bsuppEcrit.TabIndex = 34
        Me.bsuppEcrit.Text = "Suppr. Ligne"
        Me.bsuppEcrit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bsuppEcrit.UseVisualStyleBackColor = True
        '
        'tNum
        '
        Me.tNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tNum.Location = New System.Drawing.Point(233, 39)
        Me.tNum.Name = "tNum"
        Me.tNum.ReadOnly = True
        Me.tNum.Size = New System.Drawing.Size(113, 20)
        Me.tNum.TabIndex = 101
        Me.tNum.Tag = ""
        Me.tNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tNum.Visible = False
        '
        'lClient
        '
        Me.lClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lClient.FormattingEnabled = True
        Me.lClient.Location = New System.Drawing.Point(74, 12)
        Me.lClient.Name = "lClient"
        Me.lClient.Size = New System.Drawing.Size(272, 21)
        Me.lClient.TabIndex = 99
        Me.lClient.Tag = "socid,co"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Client"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "N° Facture"
        '
        'tNumFacture
        '
        Me.tNumFacture.Location = New System.Drawing.Point(74, 39)
        Me.tNumFacture.Name = "tNumFacture"
        Me.tNumFacture.ReadOnly = True
        Me.tNumFacture.Size = New System.Drawing.Size(153, 20)
        Me.tNumFacture.TabIndex = 97
        Me.tNumFacture.Tag = ""
        '
        'dEcheance
        '
        Me.dEcheance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEcheance.Location = New System.Drawing.Point(487, 39)
        Me.dEcheance.Name = "dEcheance"
        Me.dEcheance.Size = New System.Drawing.Size(101, 20)
        Me.dEcheance.TabIndex = 103
        Me.dEcheance.Tag = "ecrEcheance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Echéance"
        '
        'dDate
        '
        Me.dDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDate.Location = New System.Drawing.Point(487, 12)
        Me.dDate.Name = "dDate"
        Me.dDate.Size = New System.Drawing.Size(101, 20)
        Me.dDate.TabIndex = 102
        Me.dDate.Tag = "ecrDate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Date"
        '
        'tLibFact
        '
        Me.tLibFact.Location = New System.Drawing.Point(74, 65)
        Me.tLibFact.MaxLength = 500
        Me.tLibFact.Name = "tLibFact"
        Me.tLibFact.Size = New System.Drawing.Size(514, 20)
        Me.tLibFact.TabIndex = 106
        Me.tLibFact.Tag = ""
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(10, 68)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(37, 13)
        Me.label11.TabIndex = 107
        Me.label11.Text = "Libellé"
        '
        'F_FactureEntete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.tLibFact)
        Me.Controls.Add(Me.dEcheance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tNum)
        Me.Controls.Add(Me.lClient)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tNumFacture)
        Me.Controls.Add(Me.bsuppEcrit)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bEnreg)
        Me.Controls.Add(Me.tTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bAjout)
        Me.Controls.Add(Me.gCompta)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_FactureEntete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Facturation"
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAjout As System.Windows.Forms.Button
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents bEnreg As System.Windows.Forms.Button
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bsuppEcrit As System.Windows.Forms.Button
    Friend WithEvents tNum As TextBox
    Friend WithEvents lClient As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tNumFacture As TextBox
    Friend WithEvents dEcheance As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents tLibFact As TextBox
    Friend WithEvents label11 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Libelle As DataGridViewTextBoxColumn
    Friend WithEvents MontantHT As DataGridViewTextBoxColumn
    Friend WithEvents TVA As DataGridViewTextBoxColumn
    Friend WithEvents MontantTTC As DataGridViewTextBoxColumn
End Class
