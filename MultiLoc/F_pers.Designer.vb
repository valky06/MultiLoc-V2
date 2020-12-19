<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_pers
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
        Me.gCoord = New System.Windows.Forms.GroupBox()
        Me.cTypeAdr = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cTypeSoc = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tnom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gAdress = New System.Windows.Forms.DataGridView()
        Me.contId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.civilite = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telFixe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telMob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bOK = New System.Windows.Forms.Button()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bSuppr = New System.Windows.Forms.Button()
        Me.gCoord.SuspendLayout()
        CType(Me.gAdress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gCoord
        '
        Me.gCoord.Controls.Add(Me.cTypeAdr)
        Me.gCoord.Controls.Add(Me.Label2)
        Me.gCoord.Controls.Add(Me.TextBox1)
        Me.gCoord.Controls.Add(Me.cTypeSoc)
        Me.gCoord.Controls.Add(Me.TextBox6)
        Me.gCoord.Controls.Add(Me.TextBox5)
        Me.gCoord.Controls.Add(Me.Label6)
        Me.gCoord.Controls.Add(Me.Label5)
        Me.gCoord.Controls.Add(Me.TextBox4)
        Me.gCoord.Controls.Add(Me.TextBox3)
        Me.gCoord.Controls.Add(Me.Label4)
        Me.gCoord.Controls.Add(Me.TextBox2)
        Me.gCoord.Controls.Add(Me.tnom)
        Me.gCoord.Controls.Add(Me.Label1)
        Me.gCoord.Controls.Add(Me.Label3)
        Me.gCoord.Location = New System.Drawing.Point(12, 12)
        Me.gCoord.Name = "gCoord"
        Me.gCoord.Size = New System.Drawing.Size(708, 155)
        Me.gCoord.TabIndex = 8
        Me.gCoord.TabStop = False
        '
        'cTypeAdr
        '
        Me.cTypeAdr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTypeAdr.FormattingEnabled = True
        Me.cTypeAdr.Location = New System.Drawing.Point(480, 19)
        Me.cTypeAdr.Name = "cTypeAdr"
        Me.cTypeAdr.Size = New System.Drawing.Size(116, 21)
        Me.cTypeAdr.TabIndex = 13
        Me.cTypeAdr.Tag = "tContactid,n"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Type Contact"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(621, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(69, 20)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Tag = "persid,k"
        Me.TextBox1.Visible = False
        '
        'cTypeSoc
        '
        Me.cTypeSoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTypeSoc.FormattingEnabled = True
        Me.cTypeSoc.Location = New System.Drawing.Point(64, 19)
        Me.cTypeSoc.Name = "cTypeSoc"
        Me.cTypeSoc.Size = New System.Drawing.Size(121, 21)
        Me.cTypeSoc.TabIndex = 10
        Me.cTypeSoc.Tag = "typesociete,n"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(480, 72)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(116, 20)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.Tag = "fax,t"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(480, 46)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(116, 20)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Tag = "telbureau,t"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Téléphone"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(125, 115)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(257, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Tag = "localite,t"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(64, 115)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(55, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Tag = "codepostal,t"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Adresse"
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.Location = New System.Drawing.Point(64, 72)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(318, 37)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Tag = "adr1,t"
        '
        'tnom
        '
        Me.tnom.Location = New System.Drawing.Point(64, 46)
        Me.tnom.Name = "tnom"
        Me.tnom.Size = New System.Drawing.Size(318, 20)
        Me.tnom.TabIndex = 1
        Me.tnom.Tag = "nom,to"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Société"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nom"
        '
        'gAdress
        '
        Me.gAdress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gAdress.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gAdress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gAdress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gAdress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.contId, Me.civilite, Me.Contact, Me.telFixe, Me.telMob, Me.fax, Me.email})
        Me.gAdress.Location = New System.Drawing.Point(12, 173)
        Me.gAdress.MultiSelect = False
        Me.gAdress.Name = "gAdress"
        Me.gAdress.RowHeadersWidth = 25
        Me.gAdress.Size = New System.Drawing.Size(708, 123)
        Me.gAdress.TabIndex = 7
        '
        'contId
        '
        Me.contId.HeaderText = "Id"
        Me.contId.Name = "contId"
        Me.contId.Visible = False
        '
        'civilite
        '
        Me.civilite.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.civilite.FillWeight = 40.0!
        Me.civilite.HeaderText = "civilité"
        Me.civilite.Items.AddRange(New Object() {"M", "MME", "MLE"})
        Me.civilite.Name = "civilite"
        '
        'Contact
        '
        Me.Contact.HeaderText = "contact"
        Me.Contact.Name = "Contact"
        '
        'telFixe
        '
        Me.telFixe.FillWeight = 50.0!
        Me.telFixe.HeaderText = "Tel Fixe"
        Me.telFixe.Name = "telFixe"
        '
        'telMob
        '
        Me.telMob.FillWeight = 50.0!
        Me.telMob.HeaderText = "Mobile"
        Me.telMob.Name = "telMob"
        '
        'fax
        '
        Me.fax.FillWeight = 50.0!
        Me.fax.HeaderText = "Fax"
        Me.fax.Name = "fax"
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(645, 302)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 9
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(12, 302)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 9
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'bSuppr
        '
        Me.bSuppr.Location = New System.Drawing.Point(319, 302)
        Me.bSuppr.Name = "bSuppr"
        Me.bSuppr.Size = New System.Drawing.Size(75, 31)
        Me.bSuppr.TabIndex = 10
        Me.bSuppr.Text = "Supprimer"
        Me.bSuppr.UseVisualStyleBackColor = True
        '
        'F_pers
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(732, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.bSuppr)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.gCoord)
        Me.Controls.Add(Me.gAdress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_pers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entité"
        Me.gCoord.ResumeLayout(False)
        Me.gCoord.PerformLayout()
        CType(Me.gAdress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gCoord As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tnom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gAdress As System.Windows.Forms.DataGridView
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents cTypeSoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents contId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents civilite As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telFixe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telMob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents bSuppr As System.Windows.Forms.Button
    Friend WithEvents cTypeAdr As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
