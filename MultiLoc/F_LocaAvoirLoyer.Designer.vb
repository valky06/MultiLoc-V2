<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaAvoirLoyer
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
        Me.tLoyerActu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dDeb = New System.Windows.Forms.DateTimePicker()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tChargeAppTTC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tChargeAppHT = New System.Windows.Forms.TextBox()
        Me.dFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tLoyerAppHT2 = New System.Windows.Forms.TextBox()
        Me.tLoyerAppTTC2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tChargeActu = New System.Windows.Forms.TextBox()
        Me.tJour1 = New System.Windows.Forms.Label()
        Me.tJour2 = New System.Windows.Forms.Label()
        Me.tLib = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tLoyerActu
        '
        Me.tLoyerActu.BackColor = System.Drawing.Color.White
        Me.tLoyerActu.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerActu.Location = New System.Drawing.Point(108, 41)
        Me.tLoyerActu.Name = "tLoyerActu"
        Me.tLoyerActu.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerActu.TabIndex = 0
        Me.tLoyerActu.Tag = ""
        Me.tLoyerActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Du"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(12, 197)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(81, 31)
        Me.bAnnul.TabIndex = 12
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(308, 197)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(81, 31)
        Me.bOK.TabIndex = 11
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dDeb
        '
        Me.dDeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDeb.Location = New System.Drawing.Point(108, 12)
        Me.dDeb.Name = "dDeb"
        Me.dDeb.Size = New System.Drawing.Size(81, 20)
        Me.dDeb.TabIndex = 2
        Me.dDeb.Tag = "ecrDate"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tTauxTVA.Location = New System.Drawing.Point(108, 67)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(39, 20)
        Me.tTauxTVA.TabIndex = 4
        Me.tTauxTVA.Tag = ""
        Me.tTauxTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Taux TVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(234, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Charges TTC"
        '
        'tChargeAppTTC
        '
        Me.tChargeAppTTC.BackColor = System.Drawing.Color.White
        Me.tChargeAppTTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tChargeAppTTC.Location = New System.Drawing.Point(308, 126)
        Me.tChargeAppTTC.Name = "tChargeAppTTC"
        Me.tChargeAppTTC.ReadOnly = True
        Me.tChargeAppTTC.Size = New System.Drawing.Size(81, 20)
        Me.tChargeAppTTC.TabIndex = 10
        Me.tChargeAppTTC.Tag = ""
        Me.tChargeAppTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(38, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Charges HT"
        '
        'tChargeAppHT
        '
        Me.tChargeAppHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tChargeAppHT.Location = New System.Drawing.Point(108, 126)
        Me.tChargeAppHT.Name = "tChargeAppHT"
        Me.tChargeAppHT.Size = New System.Drawing.Size(81, 20)
        Me.tChargeAppHT.TabIndex = 9
        Me.tChargeAppHT.Tag = ""
        Me.tChargeAppHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dFin
        '
        Me.dFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFin.Location = New System.Drawing.Point(308, 12)
        Me.dFin.Name = "dFin"
        Me.dFin.Size = New System.Drawing.Size(81, 20)
        Me.dFin.TabIndex = 3
        Me.dFin.Tag = "ecrDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "au"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Loyer actu / an"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(51, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Loyer HT"
        '
        'tLoyerAppHT2
        '
        Me.tLoyerAppHT2.BackColor = System.Drawing.Color.White
        Me.tLoyerAppHT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLoyerAppHT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerAppHT2.Location = New System.Drawing.Point(108, 100)
        Me.tLoyerAppHT2.Name = "tLoyerAppHT2"
        Me.tLoyerAppHT2.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppHT2.TabIndex = 7
        Me.tLoyerAppHT2.Tag = ""
        Me.tLoyerAppHT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tLoyerAppTTC2
        '
        Me.tLoyerAppTTC2.BackColor = System.Drawing.Color.White
        Me.tLoyerAppTTC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLoyerAppTTC2.Location = New System.Drawing.Point(308, 99)
        Me.tLoyerAppTTC2.Name = "tLoyerAppTTC2"
        Me.tLoyerAppTTC2.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppTTC2.TabIndex = 8
        Me.tLoyerAppTTC2.Tag = ""
        Me.tLoyerAppTTC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(245, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Loyer TTC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Charges actu / an"
        '
        'tChargeActu
        '
        Me.tChargeActu.BackColor = System.Drawing.Color.White
        Me.tChargeActu.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tChargeActu.Location = New System.Drawing.Point(308, 41)
        Me.tChargeActu.Name = "tChargeActu"
        Me.tChargeActu.Size = New System.Drawing.Size(81, 20)
        Me.tChargeActu.TabIndex = 1
        Me.tChargeActu.Tag = ""
        Me.tChargeActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tJour1
        '
        Me.tJour1.AutoSize = True
        Me.tJour1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJour1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tJour1.Location = New System.Drawing.Point(395, 102)
        Me.tJour1.Name = "tJour1"
        Me.tJour1.Size = New System.Drawing.Size(33, 13)
        Me.tJour1.TabIndex = 93
        Me.tJour1.Text = "0 jour"
        '
        'tJour2
        '
        Me.tJour2.AutoSize = True
        Me.tJour2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJour2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tJour2.Location = New System.Drawing.Point(395, 129)
        Me.tJour2.Name = "tJour2"
        Me.tJour2.Size = New System.Drawing.Size(33, 13)
        Me.tJour2.TabIndex = 94
        Me.tJour2.Text = "0 jour"
        '
        'tLib
        '
        Me.tLib.BackColor = System.Drawing.Color.White
        Me.tLib.Location = New System.Drawing.Point(108, 152)
        Me.tLib.Name = "tLib"
        Me.tLib.Size = New System.Drawing.Size(281, 20)
        Me.tLib.TabIndex = 95
        Me.tLib.TabStop = False
        Me.tLib.Tag = "ecrLib,to"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Libellé"
        '
        'F_LocaAvoirLoyer
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(473, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.tLib)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tJour1)
        Me.Controls.Add(Me.tJour2)
        Me.Controls.Add(Me.tChargeAppTTC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tChargeAppHT)
        Me.Controls.Add(Me.tLoyerAppTTC2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tLoyerAppHT2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dFin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tTauxTVA)
        Me.Controls.Add(Me.tChargeActu)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dDeb)
        Me.Controls.Add(Me.tLoyerActu)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_LocaAvoirLoyer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avoir sur Loyer"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLoyerActu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dDeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tChargeAppTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tChargeAppHT As System.Windows.Forms.TextBox
    Friend WithEvents dFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tLoyerAppTTC2 As System.Windows.Forms.TextBox
    Friend WithEvents tLoyerAppHT2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tChargeActu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tJour1 As System.Windows.Forms.Label
    Friend WithEvents tJour2 As System.Windows.Forms.Label
    Friend WithEvents tLib As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
