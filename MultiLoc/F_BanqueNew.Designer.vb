﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BanqueNew
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
        Me.tId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tCharge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tLoyer = New System.Windows.Forms.TextBox()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bEnreg = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lSociete = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tId
        '
        Me.tId.Location = New System.Drawing.Point(163, 240)
        Me.tId.Name = "tId"
        Me.tId.ReadOnly = True
        Me.tId.Size = New System.Drawing.Size(37, 20)
        Me.tId.TabIndex = 31
        Me.tId.Tag = "cptBkId,k"
        Me.tId.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Code SWIFT"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(100, 148)
        Me.TextBox6.MaxLength = 20
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 20)
        Me.TextBox6.TabIndex = 7
        Me.TextBox6.Tag = "cptBkswift,t"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Code guichet"
        '
        'tCharge
        '
        Me.tCharge.BackColor = System.Drawing.Color.White
        Me.tCharge.Location = New System.Drawing.Point(259, 96)
        Me.tCharge.MaxLength = 5
        Me.tCharge.Name = "tCharge"
        Me.tCharge.Size = New System.Drawing.Size(59, 20)
        Me.tCharge.TabIndex = 4
        Me.tCharge.Tag = "cptBkGuichet,t"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Etablissement"
        '
        'tLoyer
        '
        Me.tLoyer.BackColor = System.Drawing.Color.White
        Me.tLoyer.Location = New System.Drawing.Point(100, 96)
        Me.tLoyer.MaxLength = 5
        Me.tLoyer.Name = "tLoyer"
        Me.tLoyer.Size = New System.Drawing.Size(59, 20)
        Me.tLoyer.TabIndex = 3
        Me.tLoyer.Tag = "cptBkEtab,t"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(22, 240)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 9
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bEnreg
        '
        Me.bEnreg.Location = New System.Drawing.Point(243, 240)
        Me.bEnreg.Name = "bEnreg"
        Me.bEnreg.Size = New System.Drawing.Size(75, 31)
        Me.bEnreg.TabIndex = 8
        Me.bEnreg.Text = "Enregistrer"
        Me.bEnreg.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tTauxTVA
        '
        Me.tTauxTVA.Location = New System.Drawing.Point(289, 122)
        Me.tTauxTVA.MaxLength = 2
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(29, 20)
        Me.tTauxTVA.TabIndex = 6
        Me.tTauxTVA.Tag = "cptBkCle,t"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Clé"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "N° Compte"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(100, 122)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Tag = "cptBkCompte,t"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "IBAN"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(100, 70)
        Me.TextBox3.MaxLength = 30
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(218, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Tag = "cptBkIBAN,t"
        '
        'tNom
        '
        Me.tNom.BackColor = System.Drawing.Color.White
        Me.tNom.Location = New System.Drawing.Point(100, 44)
        Me.tNom.MaxLength = 50
        Me.tNom.Name = "tNom"
        Me.tNom.Size = New System.Drawing.Size(218, 20)
        Me.tNom.TabIndex = 1
        Me.tNom.Tag = "cptbknom,to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Nom"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "N° Comptable"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(100, 174)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 20)
        Me.TextBox5.TabIndex = 65
        Me.TextBox5.Tag = "ComptaNum,t"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Nom Comptable"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 200)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 67
        Me.TextBox1.Tag = "ComptaNom,t"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Société"
        '
        'lSociete
        '
        Me.lSociete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lSociete.FormattingEnabled = True
        Me.lSociete.Location = New System.Drawing.Point(100, 17)
        Me.lSociete.Name = "lSociete"
        Me.lSociete.Size = New System.Drawing.Size(218, 21)
        Me.lSociete.TabIndex = 119
        Me.lSociete.Tag = "socid,no"
        '
        'F_BanqueNew
        '
        Me.AcceptButton = Me.bEnreg
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(335, 283)
        Me.Controls.Add(Me.lSociete)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tNom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tTauxTVA)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bEnreg)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.tLoyer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tCharge)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_BanqueNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CompteBancaire"
        Me.Text = "Compte Bancaire"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tLoyer As System.Windows.Forms.TextBox
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bEnreg As System.Windows.Forms.Button
    Friend WithEvents tId As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tNom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lSociete As ComboBox
End Class
