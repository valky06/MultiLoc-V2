<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaAppLoyer
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
        Me.tLoyerActu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dDeb = New System.Windows.Forms.DateTimePicker()
        Me.tChargeActu = New System.Windows.Forms.TextBox()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tChargeAppTTC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tLoyerAppHT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tLoyerAppTTC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tChargeAppHT = New System.Windows.Forms.TextBox()
        Me.dFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lJour = New System.Windows.Forms.Label()
        Me.gRevision = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tIndiceActu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tIndiceDepart = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tLoyerDepart = New System.Windows.Forms.TextBox()
        Me.tLoyerNew = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gRevision.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Loyer actu / an"
        '
        'tLoyerActu
        '
        Me.tLoyerActu.BackColor = System.Drawing.Color.White
        Me.tLoyerActu.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerActu.Location = New System.Drawing.Point(108, 12)
        Me.tLoyerActu.Name = "tLoyerActu"
        Me.tLoyerActu.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerActu.TabIndex = 0
        Me.tLoyerActu.Tag = ""
        Me.tLoyerActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Du"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(24, 290)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 10
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(305, 290)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 9
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
        Me.dDeb.Location = New System.Drawing.Point(108, 173)
        Me.dDeb.Name = "dDeb"
        Me.dDeb.Size = New System.Drawing.Size(81, 20)
        Me.dDeb.TabIndex = 3
        Me.dDeb.Tag = "ecrDate"
        '
        'tChargeActu
        '
        Me.tChargeActu.BackColor = System.Drawing.Color.White
        Me.tChargeActu.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tChargeActu.Location = New System.Drawing.Point(299, 12)
        Me.tChargeActu.Name = "tChargeActu"
        Me.tChargeActu.Size = New System.Drawing.Size(81, 20)
        Me.tChargeActu.TabIndex = 1
        Me.tChargeActu.Tag = ""
        Me.tChargeActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tTauxTVA.Location = New System.Drawing.Point(108, 38)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(39, 20)
        Me.tTauxTVA.TabIndex = 2
        Me.tTauxTVA.Tag = ""
        Me.tTauxTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Charges actu / an"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Taux TVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Appel Charges TTC"
        '
        'tChargeAppTTC
        '
        Me.tChargeAppTTC.BackColor = System.Drawing.Color.White
        Me.tChargeAppTTC.Location = New System.Drawing.Point(299, 255)
        Me.tChargeAppTTC.Name = "tChargeAppTTC"
        Me.tChargeAppTTC.ReadOnly = True
        Me.tChargeAppTTC.Size = New System.Drawing.Size(81, 20)
        Me.tChargeAppTTC.TabIndex = 8
        Me.tChargeAppTTC.Tag = ""
        Me.tChargeAppTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Appel Loyer HT"
        '
        'tLoyerAppHT
        '
        Me.tLoyerAppHT.BackColor = System.Drawing.Color.White
        Me.tLoyerAppHT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerAppHT.Location = New System.Drawing.Point(108, 229)
        Me.tLoyerAppHT.Name = "tLoyerAppHT"
        Me.tLoyerAppHT.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppHT.TabIndex = 5
        Me.tLoyerAppHT.Tag = ""
        Me.tLoyerAppHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Appel Loyer TTC"
        '
        'tLoyerAppTTC
        '
        Me.tLoyerAppTTC.BackColor = System.Drawing.Color.White
        Me.tLoyerAppTTC.Location = New System.Drawing.Point(108, 255)
        Me.tLoyerAppTTC.Name = "tLoyerAppTTC"
        Me.tLoyerAppTTC.ReadOnly = True
        Me.tLoyerAppTTC.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppTTC.TabIndex = 7
        Me.tLoyerAppTTC.Tag = ""
        Me.tLoyerAppTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Appel Charges HT"
        '
        'tChargeAppHT
        '
        Me.tChargeAppHT.Location = New System.Drawing.Point(299, 229)
        Me.tChargeAppHT.Name = "tChargeAppHT"
        Me.tChargeAppHT.Size = New System.Drawing.Size(81, 20)
        Me.tChargeAppHT.TabIndex = 6
        Me.tChargeAppHT.Tag = ""
        Me.tChargeAppHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dFin
        '
        Me.dFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFin.Location = New System.Drawing.Point(299, 173)
        Me.dFin.Name = "dFin"
        Me.dFin.Size = New System.Drawing.Size(81, 20)
        Me.dFin.TabIndex = 66
        Me.dFin.Tag = "ecrDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "au"
        '
        'lJour
        '
        Me.lJour.AutoSize = True
        Me.lJour.Location = New System.Drawing.Point(105, 207)
        Me.lJour.Name = "lJour"
        Me.lJour.Size = New System.Drawing.Size(38, 13)
        Me.lJour.TabIndex = 68
        Me.lJour.Text = "0 jours"
        '
        'gRevision
        '
        Me.gRevision.Controls.Add(Me.Label11)
        Me.gRevision.Controls.Add(Me.tIndiceActu)
        Me.gRevision.Controls.Add(Me.Label10)
        Me.gRevision.Controls.Add(Me.tIndiceDepart)
        Me.gRevision.Controls.Add(Me.Label13)
        Me.gRevision.Controls.Add(Me.Label12)
        Me.gRevision.Controls.Add(Me.tLoyerDepart)
        Me.gRevision.Controls.Add(Me.tLoyerNew)
        Me.gRevision.Enabled = False
        Me.gRevision.Location = New System.Drawing.Point(12, 68)
        Me.gRevision.Name = "gRevision"
        Me.gRevision.Size = New System.Drawing.Size(382, 91)
        Me.gRevision.TabIndex = 77
        Me.gRevision.TabStop = False
        Me.gRevision.Text = "Révision Loyer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(208, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Nouvel Indice"
        '
        'tIndiceActu
        '
        Me.tIndiceActu.BackColor = System.Drawing.Color.White
        Me.tIndiceActu.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tIndiceActu.Location = New System.Drawing.Point(287, 30)
        Me.tIndiceActu.Name = "tIndiceActu"
        Me.tIndiceActu.Size = New System.Drawing.Size(81, 20)
        Me.tIndiceActu.TabIndex = 81
        Me.tIndiceActu.Tag = ""
        Me.tIndiceActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Indice Départ"
        '
        'tIndiceDepart
        '
        Me.tIndiceDepart.BackColor = System.Drawing.Color.White
        Me.tIndiceDepart.Enabled = False
        Me.tIndiceDepart.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tIndiceDepart.Location = New System.Drawing.Point(96, 30)
        Me.tIndiceDepart.Name = "tIndiceDepart"
        Me.tIndiceDepart.Size = New System.Drawing.Size(81, 20)
        Me.tIndiceDepart.TabIndex = 79
        Me.tIndiceDepart.Tag = ""
        Me.tIndiceDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Loyer départ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(202, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Nouveau loyer"
        '
        'tLoyerDepart
        '
        Me.tLoyerDepart.BackColor = System.Drawing.Color.White
        Me.tLoyerDepart.Enabled = False
        Me.tLoyerDepart.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerDepart.Location = New System.Drawing.Point(96, 56)
        Me.tLoyerDepart.Name = "tLoyerDepart"
        Me.tLoyerDepart.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerDepart.TabIndex = 77
        Me.tLoyerDepart.Tag = ""
        Me.tLoyerDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tLoyerNew
        '
        Me.tLoyerNew.BackColor = System.Drawing.Color.White
        Me.tLoyerNew.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerNew.Location = New System.Drawing.Point(287, 56)
        Me.tLoyerNew.Name = "tLoyerNew"
        Me.tLoyerNew.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerNew.TabIndex = 77
        Me.tLoyerNew.Tag = ""
        Me.tLoyerNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'F_LocaAppLoyer
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(405, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.gRevision)
        Me.Controls.Add(Me.lJour)
        Me.Controls.Add(Me.dFin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tChargeAppHT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tLoyerAppTTC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tChargeAppTTC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tLoyerAppHT)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_LocaAppLoyer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appel de Loyer"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gRevision.ResumeLayout(False)
        Me.gRevision.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tLoyerActu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dDeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents tChargeActu As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tLoyerAppTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tChargeAppTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tLoyerAppHT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tChargeAppHT As System.Windows.Forms.TextBox
    Friend WithEvents dFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lJour As System.Windows.Forms.Label
    Friend WithEvents gRevision As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tIndiceActu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tIndiceDepart As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tLoyerNew As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tLoyerDepart As System.Windows.Forms.TextBox
End Class
