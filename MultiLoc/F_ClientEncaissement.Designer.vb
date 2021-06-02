<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ClientEncaissement
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tLib = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.dReglt = New System.Windows.Forms.DateTimePicker()
        Me.lCptBk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sTTC = New System.Windows.Forms.TextBox()
        Me.tTTC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tTVA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tHT = New System.Windows.Forms.TextBox()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.sTVA = New System.Windows.Forms.TextBox()
        Me.sHT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lSociete = New System.Windows.Forms.ComboBox()
        Me.choix = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dateEcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numFacture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'tLib
        '
        Me.tLib.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tLib.BackColor = System.Drawing.Color.White
        Me.tLib.Location = New System.Drawing.Point(194, 300)
        Me.tLib.Name = "tLib"
        Me.tLib.Size = New System.Drawing.Size(586, 20)
        Me.tLib.TabIndex = 2
        Me.tLib.Tag = "ecrLib,to"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(151, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Libellé"
        '
        'bAnnul
        '
        Me.bAnnul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(23, 337)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 4
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bOK.Location = New System.Drawing.Point(705, 337)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 3
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'dReglt
        '
        Me.dReglt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dReglt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dReglt.Location = New System.Drawing.Point(194, 247)
        Me.dReglt.Name = "dReglt"
        Me.dReglt.Size = New System.Drawing.Size(101, 20)
        Me.dReglt.TabIndex = 0
        Me.dReglt.Tag = "ecrDate"
        '
        'lCptBk
        '
        Me.lCptBk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lCptBk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCptBk.FormattingEnabled = True
        Me.lCptBk.Location = New System.Drawing.Point(194, 273)
        Me.lCptBk.Name = "lCptBk"
        Me.lCptBk.Size = New System.Drawing.Size(586, 21)
        Me.lCptBk.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Compte Bancaire"
        '
        'sTTC
        '
        Me.sTTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sTTC.Location = New System.Drawing.Point(692, 210)
        Me.sTTC.Name = "sTTC"
        Me.sTTC.ReadOnly = True
        Me.sTTC.Size = New System.Drawing.Size(88, 20)
        Me.sTTC.TabIndex = 108
        Me.sTTC.TabStop = False
        Me.sTTC.Tag = ""
        Me.sTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tTTC
        '
        Me.tTTC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tTTC.Location = New System.Drawing.Point(692, 249)
        Me.tTTC.Name = "tTTC"
        Me.tTTC.Size = New System.Drawing.Size(88, 20)
        Me.tTTC.TabIndex = 100
        Me.tTTC.Tag = ""
        Me.tTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(625, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "TVA"
        '
        'tTVA
        '
        Me.tTVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tTVA.Location = New System.Drawing.Point(600, 249)
        Me.tTVA.Name = "tTVA"
        Me.tTVA.Size = New System.Drawing.Size(86, 20)
        Me.tTVA.TabIndex = 102
        Me.tTVA.Tag = ""
        Me.tTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(430, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Encaissement"
        '
        'tHT
        '
        Me.tHT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tHT.Location = New System.Drawing.Point(509, 249)
        Me.tHT.Name = "tHT"
        Me.tHT.Size = New System.Drawing.Size(85, 20)
        Me.tHT.TabIndex = 101
        Me.tHT.Tag = ""
        Me.tHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gCompta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.gCompta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.choix, Me.dateEcr, Me.numFacture, Me.Libelle, Me.HT, Me.TVA, Me.TTC})
        Me.gCompta.Location = New System.Drawing.Point(20, 43)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(758, 161)
        Me.gCompta.TabIndex = 112
        '
        'sTVA
        '
        Me.sTVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sTVA.Location = New System.Drawing.Point(600, 210)
        Me.sTVA.Name = "sTVA"
        Me.sTVA.ReadOnly = True
        Me.sTVA.Size = New System.Drawing.Size(86, 20)
        Me.sTVA.TabIndex = 113
        Me.sTVA.TabStop = False
        Me.sTVA.Tag = ""
        Me.sTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sHT
        '
        Me.sHT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sHT.Location = New System.Drawing.Point(509, 210)
        Me.sHT.Name = "sHT"
        Me.sHT.ReadOnly = True
        Me.sHT.Size = New System.Drawing.Size(85, 20)
        Me.sHT.TabIndex = 114
        Me.sHT.TabStop = False
        Me.sHT.Tag = ""
        Me.sHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(721, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "TTC"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(542, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "HT"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Société"
        '
        'lSociete
        '
        Me.lSociete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lSociete.FormattingEnabled = True
        Me.lSociete.Location = New System.Drawing.Point(69, 17)
        Me.lSociete.Name = "lSociete"
        Me.lSociete.Size = New System.Drawing.Size(213, 21)
        Me.lSociete.TabIndex = 118
        '
        'choix
        '
        Me.choix.FillWeight = 20.0!
        Me.choix.HeaderText = "Sel."
        Me.choix.Name = "choix"
        '
        'dateEcr
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dateEcr.DefaultCellStyle = DataGridViewCellStyle7
        Me.dateEcr.FillWeight = 40.0!
        Me.dateEcr.HeaderText = "Date"
        Me.dateEcr.Name = "dateEcr"
        Me.dateEcr.ReadOnly = True
        '
        'numFacture
        '
        Me.numFacture.FillWeight = 50.0!
        Me.numFacture.HeaderText = "Facture"
        Me.numFacture.Name = "numFacture"
        Me.numFacture.ReadOnly = True
        '
        'Libelle
        '
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        '
        'HT
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.HT.DefaultCellStyle = DataGridViewCellStyle8
        Me.HT.FillWeight = 40.0!
        Me.HT.HeaderText = "HT"
        Me.HT.Name = "HT"
        Me.HT.ReadOnly = True
        '
        'TVA
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.TVA.DefaultCellStyle = DataGridViewCellStyle9
        Me.TVA.FillWeight = 40.0!
        Me.TVA.HeaderText = "TVA"
        Me.TVA.Name = "TVA"
        '
        'TTC
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.TTC.DefaultCellStyle = DataGridViewCellStyle10
        Me.TTC.FillWeight = 40.0!
        Me.TTC.HeaderText = "TTC"
        Me.TTC.Name = "TTC"
        '
        'F_ClientEncaissement
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(790, 380)
        Me.ControlBox = False
        Me.Controls.Add(Me.lSociete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sHT)
        Me.Controls.Add(Me.sTVA)
        Me.Controls.Add(Me.gCompta)
        Me.Controls.Add(Me.sTTC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tTTC)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tTVA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tHT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lCptBk)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tLib)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dReglt)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_ClientEncaissement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encaissement Client"
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLib As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents dReglt As System.Windows.Forms.DateTimePicker
    Friend WithEvents lCptBk As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sTTC As TextBox
    Friend WithEvents tTTC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tTVA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tHT As TextBox
    Friend WithEvents gCompta As DataGridView
    Friend WithEvents sTVA As TextBox
    Friend WithEvents sHT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents choix As DataGridViewCheckBoxColumn
    Friend WithEvents dateEcr As DataGridViewTextBoxColumn
    Friend WithEvents numFacture As DataGridViewTextBoxColumn
    Friend WithEvents Libelle As DataGridViewTextBoxColumn
    Friend WithEvents HT As DataGridViewTextBoxColumn
    Friend WithEvents TVA As DataGridViewTextBoxColumn
    Friend WithEvents TTC As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents lSociete As ComboBox
End Class
