<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ClientContrat
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
        Me.components = New System.ComponentModel.Container()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bEnreg = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dEntre = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dSortie = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gListe = New System.Windows.Forms.DataGridView()
        Me.Empid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tMontantTTC = New System.Windows.Forms.TextBox()
        Me.tMontantHT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tTVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.tCliId = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(14, 190)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 2
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bEnreg
        '
        Me.bEnreg.Location = New System.Drawing.Point(308, 190)
        Me.bEnreg.Name = "bEnreg"
        Me.bEnreg.Size = New System.Drawing.Size(78, 31)
        Me.bEnreg.TabIndex = 1
        Me.bEnreg.Text = "OK"
        Me.bEnreg.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dEntre
        '
        Me.dEntre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEntre.Location = New System.Drawing.Point(93, 11)
        Me.dEntre.Name = "dEntre"
        Me.dEntre.Size = New System.Drawing.Size(101, 20)
        Me.dEntre.TabIndex = 33
        Me.dEntre.Tag = "dateDebut"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Début"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Fin prévue"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(93, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 35
        Me.DateTimePicker1.Tag = "datefinprev"
        '
        'dSortie
        '
        Me.dSortie.Checked = False
        Me.dSortie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortie.Location = New System.Drawing.Point(93, 62)
        Me.dSortie.Name = "dSortie"
        Me.dSortie.ShowCheckBox = True
        Me.dSortie.Size = New System.Drawing.Size(101, 20)
        Me.dSortie.TabIndex = 70
        Me.dSortie.Tag = "datefin"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(38, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Fin réelle"
        '
        'gListe
        '
        Me.gListe.AllowUserToAddRows = False
        Me.gListe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gListe.BackgroundColor = System.Drawing.Color.White
        Me.gListe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gListe.ColumnHeadersHeight = 22
        Me.gListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empid, Me.Emplacement})
        Me.gListe.Location = New System.Drawing.Point(214, 11)
        Me.gListe.MultiSelect = False
        Me.gListe.Name = "gListe"
        Me.gListe.ReadOnly = True
        Me.gListe.RowHeadersVisible = False
        Me.gListe.RowHeadersWidth = 21
        Me.gListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gListe.Size = New System.Drawing.Size(136, 149)
        Me.gListe.TabIndex = 72
        '
        'Empid
        '
        Me.Empid.FillWeight = 60.0!
        Me.Empid.HeaderText = "Id"
        Me.Empid.Name = "Empid"
        Me.Empid.ReadOnly = True
        Me.Empid.Visible = False
        '
        'Emplacement
        '
        Me.Emplacement.HeaderText = "Emplacement"
        Me.Emplacement.Name = "Emplacement"
        Me.Emplacement.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Montant Mensuel TTC"
        '
        'tMontantTTC
        '
        Me.tMontantTTC.BackColor = System.Drawing.Color.White
        Me.tMontantTTC.Location = New System.Drawing.Point(136, 141)
        Me.tMontantTTC.Name = "tMontantTTC"
        Me.tMontantTTC.ReadOnly = True
        Me.tMontantTTC.Size = New System.Drawing.Size(58, 20)
        Me.tMontantTTC.TabIndex = 76
        Me.tMontantTTC.Tag = "MontantTTC,no"
        Me.tMontantTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tMontantHT
        '
        Me.tMontantHT.BackColor = System.Drawing.Color.White
        Me.tMontantHT.Location = New System.Drawing.Point(136, 89)
        Me.tMontantHT.Name = "tMontantHT"
        Me.tMontantHT.Size = New System.Drawing.Size(58, 20)
        Me.tMontantHT.TabIndex = 75
        Me.tMontantHT.Tag = "MontantHT,no"
        Me.tMontantHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Montant Mensuel  HT"
        '
        'tTVA
        '
        Me.tTVA.BackColor = System.Drawing.Color.White
        Me.tTVA.Location = New System.Drawing.Point(136, 115)
        Me.tTVA.Name = "tTVA"
        Me.tTVA.Size = New System.Drawing.Size(58, 20)
        Me.tTVA.TabIndex = 79
        Me.tTVA.Tag = "TauxTVA,no"
        Me.tTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Taux TVA %"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MultiLoc.My.Resources.Resources.Cancelled
        Me.Button1.Location = New System.Drawing.Point(356, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 23)
        Me.Button1.TabIndex = 74
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.MultiLoc.My.Resources.Resources.smallplus
        Me.Button6.Location = New System.Drawing.Point(356, 11)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(29, 23)
        Me.Button6.TabIndex = 73
        Me.Button6.TabStop = False
        Me.Button6.UseVisualStyleBackColor = True
        '
        'tCliId
        '
        Me.tCliId.BackColor = System.Drawing.Color.White
        Me.tCliId.Location = New System.Drawing.Point(139, 201)
        Me.tCliId.Name = "tCliId"
        Me.tCliId.ReadOnly = True
        Me.tCliId.Size = New System.Drawing.Size(35, 20)
        Me.tCliId.TabIndex = 81
        Me.tCliId.Tag = "cliId,n"
        Me.tCliId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tCliId.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(180, 201)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(35, 20)
        Me.TextBox2.TabIndex = 82
        Me.TextBox2.Tag = "contratid,k"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox2.Visible = False
        '
        'F_ClientContrat
        '
        Me.AcceptButton = Me.bEnreg
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(398, 239)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tCliId)
        Me.Controls.Add(Me.tTVA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tMontantTTC)
        Me.Controls.Add(Me.tMontantHT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.gListe)
        Me.Controls.Add(Me.dSortie)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dEntre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bEnreg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_ClientContrat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrat"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bEnreg As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dSortie As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents gListe As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Empid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Emplacement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tMontantTTC As System.Windows.Forms.TextBox
    Friend WithEvents tMontantHT As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tCliId As System.Windows.Forms.TextBox
End Class
