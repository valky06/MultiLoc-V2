<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaAppelLoyer
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
        Me.tLoyerAppHT1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tLoyerAppTTC1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tChargeAppHT = New System.Windows.Forms.TextBox()
        Me.dFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tJour1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tNouvelIndice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tIndiceDepart = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tLoyerDepart = New System.Windows.Forms.TextBox()
        Me.tLoyerNew = New System.Windows.Forms.TextBox()
        Me.tJour2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tLoyerAppTTC2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tLoyerAppHT2 = New System.Windows.Forms.TextBox()
        Me.tJour3 = New System.Windows.Forms.Label()
        Me.dFIn1 = New System.Windows.Forms.DateTimePicker()
        Me.dDeb2 = New System.Windows.Forms.DateTimePicker()
        Me.gRegul = New System.Windows.Forms.GroupBox()
        Me.lRegul = New System.Windows.Forms.Label()
        Me.lRegulTTC = New System.Windows.Forms.Label()
        Me.tRegulTTC = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tRegulHT = New System.Windows.Forms.TextBox()
        Me.dRegulFin = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dRegulDeb = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tRegulAppPro = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tRegulNouvPro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gRevision = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gRegul.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gRevision.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.bAnnul.Location = New System.Drawing.Point(15, 411)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(81, 31)
        Me.bAnnul.TabIndex = 12
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(430, 411)
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
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tTauxTVA.Location = New System.Drawing.Point(472, 41)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(39, 20)
        Me.tTauxTVA.TabIndex = 4
        Me.tTauxTVA.Tag = ""
        Me.tTauxTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 44)
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
        Me.Label7.Location = New System.Drawing.Point(217, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Charges TTC"
        '
        'tChargeAppTTC
        '
        Me.tChargeAppTTC.BackColor = System.Drawing.Color.White
        Me.tChargeAppTTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tChargeAppTTC.Location = New System.Drawing.Point(293, 19)
        Me.tChargeAppTTC.Name = "tChargeAppTTC"
        Me.tChargeAppTTC.ReadOnly = True
        Me.tChargeAppTTC.Size = New System.Drawing.Size(81, 20)
        Me.tChargeAppTTC.TabIndex = 10
        Me.tChargeAppTTC.Tag = ""
        Me.tChargeAppTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(13, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Avant rév. HT"
        '
        'tLoyerAppHT1
        '
        Me.tLoyerAppHT1.BackColor = System.Drawing.Color.White
        Me.tLoyerAppHT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLoyerAppHT1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerAppHT1.Location = New System.Drawing.Point(93, 19)
        Me.tLoyerAppHT1.Name = "tLoyerAppHT1"
        Me.tLoyerAppHT1.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppHT1.TabIndex = 5
        Me.tLoyerAppHT1.Tag = ""
        Me.tLoyerAppHT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(207, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Avant rév. TTC"
        '
        'tLoyerAppTTC1
        '
        Me.tLoyerAppTTC1.BackColor = System.Drawing.Color.White
        Me.tLoyerAppTTC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLoyerAppTTC1.Location = New System.Drawing.Point(293, 19)
        Me.tLoyerAppTTC1.Name = "tLoyerAppTTC1"
        Me.tLoyerAppTTC1.ReadOnly = True
        Me.tLoyerAppTTC1.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppTTC1.TabIndex = 6
        Me.tLoyerAppTTC1.Tag = ""
        Me.tLoyerAppTTC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(23, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Charges HT"
        '
        'tChargeAppHT
        '
        Me.tChargeAppHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tChargeAppHT.Location = New System.Drawing.Point(93, 19)
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
        'tJour1
        '
        Me.tJour1.AutoSize = True
        Me.tJour1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJour1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tJour1.Location = New System.Drawing.Point(380, 22)
        Me.tJour1.Name = "tJour1"
        Me.tJour1.Size = New System.Drawing.Size(33, 13)
        Me.tJour1.TabIndex = 68
        Me.tJour1.Text = "0 jour"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(205, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Nouvel Indice"
        '
        'tNouvelIndice
        '
        Me.tNouvelIndice.BackColor = System.Drawing.Color.White
        Me.tNouvelIndice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tNouvelIndice.Location = New System.Drawing.Point(293, 19)
        Me.tNouvelIndice.Name = "tNouvelIndice"
        Me.tNouvelIndice.ReadOnly = True
        Me.tNouvelIndice.Size = New System.Drawing.Size(81, 20)
        Me.tNouvelIndice.TabIndex = 1
        Me.tNouvelIndice.Tag = ""
        Me.tNouvelIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 22)
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
        Me.tIndiceDepart.Location = New System.Drawing.Point(93, 19)
        Me.tIndiceDepart.Name = "tIndiceDepart"
        Me.tIndiceDepart.Size = New System.Drawing.Size(81, 20)
        Me.tIndiceDepart.TabIndex = 0
        Me.tIndiceDepart.Tag = ""
        Me.tIndiceDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Loyer départ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(202, 48)
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
        Me.tLoyerDepart.Location = New System.Drawing.Point(93, 45)
        Me.tLoyerDepart.Name = "tLoyerDepart"
        Me.tLoyerDepart.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerDepart.TabIndex = 2
        Me.tLoyerDepart.Tag = ""
        Me.tLoyerDepart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tLoyerNew
        '
        Me.tLoyerNew.BackColor = System.Drawing.Color.White
        Me.tLoyerNew.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerNew.Location = New System.Drawing.Point(293, 45)
        Me.tLoyerNew.Name = "tLoyerNew"
        Me.tLoyerNew.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerNew.TabIndex = 3
        Me.tLoyerNew.Tag = ""
        Me.tLoyerNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tJour2
        '
        Me.tJour2.AutoSize = True
        Me.tJour2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJour2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tJour2.Location = New System.Drawing.Point(380, 48)
        Me.tJour2.Name = "tJour2"
        Me.tJour2.Size = New System.Drawing.Size(33, 13)
        Me.tJour2.TabIndex = 78
        Me.tJour2.Text = "0 jour"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(208, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Après rév. TTC"
        '
        'tLoyerAppTTC2
        '
        Me.tLoyerAppTTC2.BackColor = System.Drawing.Color.White
        Me.tLoyerAppTTC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLoyerAppTTC2.Location = New System.Drawing.Point(293, 45)
        Me.tLoyerAppTTC2.Name = "tLoyerAppTTC2"
        Me.tLoyerAppTTC2.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppTTC2.TabIndex = 8
        Me.tLoyerAppTTC2.Tag = ""
        Me.tLoyerAppTTC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(14, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Après rév. HT"
        '
        'tLoyerAppHT2
        '
        Me.tLoyerAppHT2.BackColor = System.Drawing.Color.White
        Me.tLoyerAppHT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLoyerAppHT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLoyerAppHT2.Location = New System.Drawing.Point(93, 45)
        Me.tLoyerAppHT2.Name = "tLoyerAppHT2"
        Me.tLoyerAppHT2.Size = New System.Drawing.Size(81, 20)
        Me.tLoyerAppHT2.TabIndex = 7
        Me.tLoyerAppHT2.Tag = ""
        Me.tLoyerAppHT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tJour3
        '
        Me.tJour3.AutoSize = True
        Me.tJour3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJour3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tJour3.Location = New System.Drawing.Point(380, 23)
        Me.tJour3.Name = "tJour3"
        Me.tJour3.Size = New System.Drawing.Size(38, 13)
        Me.tJour3.TabIndex = 83
        Me.tJour3.Text = "0 jours"
        '
        'dFIn1
        '
        Me.dFIn1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFIn1.Location = New System.Drawing.Point(461, 12)
        Me.dFIn1.Name = "dFIn1"
        Me.dFIn1.Size = New System.Drawing.Size(81, 20)
        Me.dFIn1.TabIndex = 84
        Me.dFIn1.Tag = "ecrDate"
        Me.dFIn1.Visible = False
        '
        'dDeb2
        '
        Me.dDeb2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDeb2.Location = New System.Drawing.Point(405, 12)
        Me.dDeb2.Name = "dDeb2"
        Me.dDeb2.Size = New System.Drawing.Size(52, 20)
        Me.dDeb2.TabIndex = 85
        Me.dDeb2.Tag = "ecrDate"
        Me.dDeb2.Visible = False
        '
        'gRegul
        '
        Me.gRegul.Controls.Add(Me.lRegul)
        Me.gRegul.Controls.Add(Me.lRegulTTC)
        Me.gRegul.Controls.Add(Me.tRegulTTC)
        Me.gRegul.Controls.Add(Me.Label16)
        Me.gRegul.Controls.Add(Me.Label22)
        Me.gRegul.Controls.Add(Me.tRegulHT)
        Me.gRegul.Controls.Add(Me.dRegulFin)
        Me.gRegul.Controls.Add(Me.Label20)
        Me.gRegul.Controls.Add(Me.dRegulDeb)
        Me.gRegul.Controls.Add(Me.Label21)
        Me.gRegul.Controls.Add(Me.tRegulAppPro)
        Me.gRegul.Controls.Add(Me.Label19)
        Me.gRegul.Controls.Add(Me.tRegulNouvPro)
        Me.gRegul.Enabled = False
        Me.gRegul.Location = New System.Drawing.Point(15, 151)
        Me.gRegul.Name = "gRegul"
        Me.gRegul.Size = New System.Drawing.Size(496, 98)
        Me.gRegul.TabIndex = 86
        Me.gRegul.TabStop = False
        Me.gRegul.Text = "Régularisation de Loyer"
        '
        'lRegul
        '
        Me.lRegul.AutoSize = True
        Me.lRegul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lRegul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lRegul.Location = New System.Drawing.Point(380, 48)
        Me.lRegul.Name = "lRegul"
        Me.lRegul.Size = New System.Drawing.Size(33, 13)
        Me.lRegul.TabIndex = 92
        Me.lRegul.Text = "0 jour"
        '
        'lRegulTTC
        '
        Me.lRegulTTC.AutoSize = True
        Me.lRegulTTC.Location = New System.Drawing.Point(228, 74)
        Me.lRegulTTC.Name = "lRegulTTC"
        Me.lRegulTTC.Size = New System.Drawing.Size(59, 13)
        Me.lRegulTTC.TabIndex = 91
        Me.lRegulTTC.Text = "Régul TTC"
        '
        'tRegulTTC
        '
        Me.tRegulTTC.BackColor = System.Drawing.Color.White
        Me.tRegulTTC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tRegulTTC.Location = New System.Drawing.Point(293, 71)
        Me.tRegulTTC.Name = "tRegulTTC"
        Me.tRegulTTC.Size = New System.Drawing.Size(81, 20)
        Me.tRegulTTC.TabIndex = 90
        Me.tRegulTTC.Tag = ""
        Me.tRegulTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Ancien Loyer"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(34, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "Régul HT"
        '
        'tRegulHT
        '
        Me.tRegulHT.BackColor = System.Drawing.Color.White
        Me.tRegulHT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tRegulHT.Location = New System.Drawing.Point(93, 71)
        Me.tRegulHT.Name = "tRegulHT"
        Me.tRegulHT.Size = New System.Drawing.Size(81, 20)
        Me.tRegulHT.TabIndex = 87
        Me.tRegulHT.Tag = ""
        Me.tRegulHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dRegulFin
        '
        Me.dRegulFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dRegulFin.Location = New System.Drawing.Point(293, 19)
        Me.dRegulFin.Name = "dRegulFin"
        Me.dRegulFin.Size = New System.Drawing.Size(81, 20)
        Me.dRegulFin.TabIndex = 84
        Me.dRegulFin.Tag = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(268, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "au"
        '
        'dRegulDeb
        '
        Me.dRegulDeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dRegulDeb.Location = New System.Drawing.Point(93, 19)
        Me.dRegulDeb.Name = "dRegulDeb"
        Me.dRegulDeb.Size = New System.Drawing.Size(81, 20)
        Me.dRegulDeb.TabIndex = 83
        Me.dRegulDeb.Tag = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(66, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Du"
        '
        'tRegulAppPro
        '
        Me.tRegulAppPro.BackColor = System.Drawing.Color.White
        Me.tRegulAppPro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tRegulAppPro.Location = New System.Drawing.Point(93, 45)
        Me.tRegulAppPro.Name = "tRegulAppPro"
        Me.tRegulAppPro.Size = New System.Drawing.Size(81, 20)
        Me.tRegulAppPro.TabIndex = 1
        Me.tRegulAppPro.Tag = ""
        Me.tRegulAppPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(211, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Nouveau loyer"
        '
        'tRegulNouvPro
        '
        Me.tRegulNouvPro.BackColor = System.Drawing.Color.White
        Me.tRegulNouvPro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tRegulNouvPro.Location = New System.Drawing.Point(293, 45)
        Me.tRegulNouvPro.Name = "tRegulNouvPro"
        Me.tRegulNouvPro.Size = New System.Drawing.Size(81, 20)
        Me.tRegulNouvPro.TabIndex = 3
        Me.tRegulNouvPro.Tag = ""
        Me.tRegulNouvPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tChargeAppTTC)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tChargeAppHT)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tJour3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(15, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 49)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'gRevision
        '
        Me.gRevision.Controls.Add(Me.Label11)
        Me.gRevision.Controls.Add(Me.tNouvelIndice)
        Me.gRevision.Controls.Add(Me.Label10)
        Me.gRevision.Controls.Add(Me.tIndiceDepart)
        Me.gRevision.Controls.Add(Me.Label13)
        Me.gRevision.Controls.Add(Me.Label12)
        Me.gRevision.Controls.Add(Me.tLoyerDepart)
        Me.gRevision.Controls.Add(Me.tLoyerNew)
        Me.gRevision.Enabled = False
        Me.gRevision.Location = New System.Drawing.Point(15, 67)
        Me.gRevision.Name = "gRevision"
        Me.gRevision.Size = New System.Drawing.Size(496, 78)
        Me.gRevision.TabIndex = 77
        Me.gRevision.TabStop = False
        Me.gRevision.Text = "Révision Loyer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tLoyerAppHT1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tLoyerAppTTC1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.tJour1)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.tJour2)
        Me.GroupBox3.Controls.Add(Me.tLoyerAppTTC2)
        Me.GroupBox3.Controls.Add(Me.tLoyerAppHT2)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(15, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(496, 77)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loyers"
        '
        'F_LocaAppelLoyer
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(525, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gRegul)
        Me.Controls.Add(Me.dDeb2)
        Me.Controls.Add(Me.dFIn1)
        Me.Controls.Add(Me.gRevision)
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
        Me.Name = "F_LocaAppelLoyer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appel de Loyer"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gRegul.ResumeLayout(False)
        Me.gRegul.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gRevision.ResumeLayout(False)
        Me.gRevision.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents tLoyerAppTTC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tChargeAppTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tLoyerAppHT1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tChargeAppHT As System.Windows.Forms.TextBox
    Friend WithEvents dFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tJour1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tNouvelIndice As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tIndiceDepart As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tLoyerNew As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tLoyerDepart As System.Windows.Forms.TextBox
    Friend WithEvents tJour2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tLoyerAppTTC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tLoyerAppHT2 As System.Windows.Forms.TextBox
    Friend WithEvents tJour3 As System.Windows.Forms.Label
    Friend WithEvents dDeb2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dFIn1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents gRegul As System.Windows.Forms.GroupBox
    Friend WithEvents dRegulFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dRegulDeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tRegulAppPro As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tRegulNouvPro As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tRegulHT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gRevision As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lRegulTTC As System.Windows.Forms.Label
    Friend WithEvents tRegulTTC As System.Windows.Forms.TextBox
    Friend WithEvents lRegul As System.Windows.Forms.Label
End Class
