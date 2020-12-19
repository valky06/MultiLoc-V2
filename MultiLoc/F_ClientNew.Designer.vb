<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ClientNew
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
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lTypePer = New System.Windows.Forms.ComboBox()
        Me.lTypeRgt = New System.Windows.Forms.ComboBox()
        Me.tPersNom = New System.Windows.Forms.TextBox()
        Me.tPersId = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(29, 77)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel3.TabIndex = 47
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Type Règlement"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(71, 50)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel2.TabIndex = 46
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Période"
        '
        'lTypePer
        '
        Me.lTypePer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypePer.FormattingEnabled = True
        Me.lTypePer.Location = New System.Drawing.Point(120, 47)
        Me.lTypePer.Name = "lTypePer"
        Me.lTypePer.Size = New System.Drawing.Size(146, 21)
        Me.lTypePer.TabIndex = 7
        Me.lTypePer.Tag = "TperId,no"
        '
        'lTypeRgt
        '
        Me.lTypeRgt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypeRgt.FormattingEnabled = True
        Me.lTypeRgt.Location = New System.Drawing.Point(120, 74)
        Me.lTypeRgt.Name = "lTypeRgt"
        Me.lTypeRgt.Size = New System.Drawing.Size(146, 21)
        Me.lTypeRgt.TabIndex = 8
        Me.lTypeRgt.Tag = "TRgtId,no"
        '
        'tPersNom
        '
        Me.tPersNom.BackColor = System.Drawing.Color.White
        Me.tPersNom.Location = New System.Drawing.Point(120, 21)
        Me.tPersNom.Name = "tPersNom"
        Me.tPersNom.ReadOnly = True
        Me.tPersNom.Size = New System.Drawing.Size(273, 20)
        Me.tPersNom.TabIndex = 24
        Me.tPersNom.TabStop = False
        Me.tPersNom.Tag = "nom"
        '
        'tPersId
        '
        Me.tPersId.Location = New System.Drawing.Point(166, 142)
        Me.tPersId.Name = "tPersId"
        Me.tPersId.ReadOnly = True
        Me.tPersId.Size = New System.Drawing.Size(37, 20)
        Me.tPersId.TabIndex = 30
        Me.tPersId.Tag = "persId,no"
        Me.tPersId.Visible = False
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(30, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(318, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 31)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Enregistrer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(85, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel1.TabIndex = 58
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Suffixe Compte"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 101)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(40, 20)
        Me.TextBox3.TabIndex = 61
        Me.TextBox3.Tag = "CptSuffixe,t"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(37, 20)
        Me.TextBox1.TabIndex = 31
        Me.TextBox1.Tag = "cliId,k"
        Me.TextBox1.Visible = False
        '
        'F_ClientNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 189)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tPersNom)
        Me.Controls.Add(Me.tPersId)
        Me.Controls.Add(Me.lTypePer)
        Me.Controls.Add(Me.lTypeRgt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_ClientNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tPersNom As System.Windows.Forms.TextBox
    Friend WithEvents lTypePer As System.Windows.Forms.ComboBox
    Friend WithEvents lTypeRgt As System.Windows.Forms.ComboBox
    Friend WithEvents tPersId As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
