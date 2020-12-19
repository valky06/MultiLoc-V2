<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ClientAppMensuel
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tMontantHT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dEntre = New System.Windows.Forms.DateTimePicker()
        Me.tNbJour = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tMontantAppTTC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tMontantAppHT = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Montant Mensuel HT"
        '
        'tMontantHT
        '
        Me.tMontantHT.BackColor = System.Drawing.Color.White
        Me.tMontantHT.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tMontantHT.Location = New System.Drawing.Point(134, 12)
        Me.tMontantHT.Name = "tMontantHT"
        Me.tMontantHT.ReadOnly = True
        Me.tMontantHT.Size = New System.Drawing.Size(69, 20)
        Me.tMontantHT.TabIndex = 0
        Me.tMontantHT.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(24, 115)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 7
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(322, 115)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 6
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dEntre
        '
        Me.dEntre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEntre.Location = New System.Drawing.Point(134, 38)
        Me.dEntre.Name = "dEntre"
        Me.dEntre.Size = New System.Drawing.Size(101, 20)
        Me.dEntre.TabIndex = 1
        Me.dEntre.Tag = "ecrDate"
        '
        'tNbJour
        '
        Me.tNbJour.BackColor = System.Drawing.Color.White
        Me.tNbJour.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tNbJour.Location = New System.Drawing.Point(327, 38)
        Me.tNbJour.Name = "tNbJour"
        Me.tNbJour.ReadOnly = True
        Me.tNbJour.Size = New System.Drawing.Size(35, 20)
        Me.tNbJour.TabIndex = 2
        Me.tNbJour.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nb Jours"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tTauxTVA.Location = New System.Drawing.Point(243, 64)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.ReadOnly = True
        Me.tTauxTVA.Size = New System.Drawing.Size(44, 20)
        Me.tTauxTVA.TabIndex = 4
        Me.tTauxTVA.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "TVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "TTC"
        '
        'tMontantAppTTC
        '
        Me.tMontantAppTTC.BackColor = System.Drawing.Color.White
        Me.tMontantAppTTC.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tMontantAppTTC.Location = New System.Drawing.Point(327, 64)
        Me.tMontantAppTTC.Name = "tMontantAppTTC"
        Me.tMontantAppTTC.ReadOnly = True
        Me.tMontantAppTTC.Size = New System.Drawing.Size(70, 20)
        Me.tMontantAppTTC.TabIndex = 5
        Me.tMontantAppTTC.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Montant App HT"
        '
        'tMontantAppHT
        '
        Me.tMontantAppHT.BackColor = System.Drawing.Color.White
        Me.tMontantAppHT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tMontantAppHT.Location = New System.Drawing.Point(134, 64)
        Me.tMontantAppHT.Name = "tMontantAppHT"
        Me.tMontantAppHT.Size = New System.Drawing.Size(69, 20)
        Me.tMontantAppHT.TabIndex = 3
        Me.tMontantAppHT.Tag = ""
        '
        'F_ClientAppMensuel
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(419, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tMontantAppTTC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tMontantAppHT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tTauxTVA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tNbJour)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dEntre)
        Me.Controls.Add(Me.tMontantHT)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_ClientAppMensuel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturation Mensuel"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tMontantHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tNbJour As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tMontantAppTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tMontantAppHT As System.Windows.Forms.TextBox
End Class
