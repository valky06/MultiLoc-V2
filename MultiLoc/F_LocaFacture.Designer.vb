<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaFacture
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gBail = New System.Windows.Forms.GroupBox()
        Me.tIndiceNum = New System.Windows.Forms.TextBox()
        Me.tIndiceValeur = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.treglement = New System.Windows.Forms.TextBox()
        Me.tperiode = New System.Windows.Forms.TextBox()
        Me.tindice = New System.Windows.Forms.TextBox()
        Me.tbail = New System.Windows.Forms.TextBox()
        Me.dRevision = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cDGTVA = New System.Windows.Forms.CheckBox()
        Me.tIndiceAnnee = New System.Windows.Forms.TextBox()
        Me.tIndiceNom = New System.Windows.Forms.TextBox()
        Me.tPersId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tNbMoisDG = New System.Windows.Forms.TextBox()
        Me.tSocId = New System.Windows.Forms.TextBox()
        Me.dSortie = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dSortiePrev = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dEntree = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tLoyerActu = New System.Windows.Forms.TextBox()
        Me.tChargeActu = New System.Windows.Forms.TextBox()
        Me.tLoyer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cLoyerTVA = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.tLocId = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.bFactInterne = New System.Windows.Forms.Button()
        Me.bChargeExterne = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.gCompta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.journal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bsuppEcrit = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dFacture = New System.Windows.Forms.DateTimePicker()
        Me.gBail.SuspendLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gBail
        '
        Me.gBail.Controls.Add(Me.tIndiceNum)
        Me.gBail.Controls.Add(Me.tIndiceValeur)
        Me.gBail.Controls.Add(Me.Label10)
        Me.gBail.Controls.Add(Me.Label8)
        Me.gBail.Controls.Add(Me.Label6)
        Me.gBail.Controls.Add(Me.Label5)
        Me.gBail.Controls.Add(Me.treglement)
        Me.gBail.Controls.Add(Me.tperiode)
        Me.gBail.Controls.Add(Me.tindice)
        Me.gBail.Controls.Add(Me.tbail)
        Me.gBail.Controls.Add(Me.dRevision)
        Me.gBail.Controls.Add(Me.Label4)
        Me.gBail.Controls.Add(Me.cDGTVA)
        Me.gBail.Controls.Add(Me.tIndiceAnnee)
        Me.gBail.Controls.Add(Me.tIndiceNom)
        Me.gBail.Controls.Add(Me.tPersId)
        Me.gBail.Controls.Add(Me.Label1)
        Me.gBail.Controls.Add(Me.tNbMoisDG)
        Me.gBail.Controls.Add(Me.tSocId)
        Me.gBail.Controls.Add(Me.dSortie)
        Me.gBail.Controls.Add(Me.Label14)
        Me.gBail.Controls.Add(Me.dSortiePrev)
        Me.gBail.Controls.Add(Me.Label13)
        Me.gBail.Controls.Add(Me.dEntree)
        Me.gBail.Controls.Add(Me.Label12)
        Me.gBail.Controls.Add(Me.Label11)
        Me.gBail.Controls.Add(Me.tLoyerActu)
        Me.gBail.Controls.Add(Me.tChargeActu)
        Me.gBail.Controls.Add(Me.tLoyer)
        Me.gBail.Controls.Add(Me.Label7)
        Me.gBail.Controls.Add(Me.Label9)
        Me.gBail.Controls.Add(Me.cLoyerTVA)
        Me.gBail.Controls.Add(Me.Label2)
        Me.gBail.Controls.Add(Me.tTauxTVA)
        Me.gBail.Controls.Add(Me.tLocId)
        Me.gBail.Location = New System.Drawing.Point(11, 45)
        Me.gBail.Name = "gBail"
        Me.gBail.Size = New System.Drawing.Size(704, 130)
        Me.gBail.TabIndex = 2
        Me.gBail.TabStop = False
        '
        'tIndiceNum
        '
        Me.tIndiceNum.Location = New System.Drawing.Point(523, 101)
        Me.tIndiceNum.Name = "tIndiceNum"
        Me.tIndiceNum.ReadOnly = True
        Me.tIndiceNum.Size = New System.Drawing.Size(16, 20)
        Me.tIndiceNum.TabIndex = 84
        Me.tIndiceNum.Tag = "trimestreNum,n"
        Me.tIndiceNum.Visible = False
        '
        'tIndiceValeur
        '
        Me.tIndiceValeur.Location = New System.Drawing.Point(501, 101)
        Me.tIndiceValeur.Name = "tIndiceValeur"
        Me.tIndiceValeur.ReadOnly = True
        Me.tIndiceValeur.Size = New System.Drawing.Size(16, 20)
        Me.tIndiceValeur.TabIndex = 83
        Me.tIndiceValeur.Tag = "indice,n"
        Me.tIndiceValeur.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Règlement"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Période"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Indice"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Type Bail"
        '
        'treglement
        '
        Me.treglement.BackColor = System.Drawing.Color.White
        Me.treglement.Location = New System.Drawing.Point(72, 97)
        Me.treglement.Name = "treglement"
        Me.treglement.ReadOnly = True
        Me.treglement.Size = New System.Drawing.Size(132, 20)
        Me.treglement.TabIndex = 77
        Me.treglement.Tag = "Trgtnom,t"
        '
        'tperiode
        '
        Me.tperiode.BackColor = System.Drawing.Color.White
        Me.tperiode.Location = New System.Drawing.Point(72, 71)
        Me.tperiode.Name = "tperiode"
        Me.tperiode.ReadOnly = True
        Me.tperiode.Size = New System.Drawing.Size(132, 20)
        Me.tperiode.TabIndex = 77
        Me.tperiode.Tag = "TperNom,t"
        '
        'tindice
        '
        Me.tindice.BackColor = System.Drawing.Color.White
        Me.tindice.Location = New System.Drawing.Point(72, 45)
        Me.tindice.Name = "tindice"
        Me.tindice.ReadOnly = True
        Me.tindice.Size = New System.Drawing.Size(132, 20)
        Me.tindice.TabIndex = 77
        Me.tindice.Tag = ""
        '
        'tbail
        '
        Me.tbail.BackColor = System.Drawing.Color.White
        Me.tbail.Location = New System.Drawing.Point(72, 17)
        Me.tbail.Name = "tbail"
        Me.tbail.ReadOnly = True
        Me.tbail.Size = New System.Drawing.Size(132, 20)
        Me.tbail.TabIndex = 77
        Me.tbail.Tag = "TbailNom,t"
        '
        'dRevision
        '
        Me.dRevision.Enabled = False
        Me.dRevision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dRevision.Location = New System.Drawing.Point(590, 44)
        Me.dRevision.Name = "dRevision"
        Me.dRevision.Size = New System.Drawing.Size(101, 20)
        Me.dRevision.TabIndex = 75
        Me.dRevision.Tag = "dateRevision"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(520, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Date du bail"
        '
        'cDGTVA
        '
        Me.cDGTVA.AutoSize = True
        Me.cDGTVA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cDGTVA.Enabled = False
        Me.cDGTVA.Location = New System.Drawing.Point(384, 18)
        Me.cDGTVA.Name = "cDGTVA"
        Me.cDGTVA.Size = New System.Drawing.Size(114, 17)
        Me.cDGTVA.TabIndex = 74
        Me.cDGTVA.Tag = "DGsoumisTVA,c"
        Me.cDGTVA.Text = "Dépôt soumis TVA"
        Me.cDGTVA.UseVisualStyleBackColor = True
        '
        'tIndiceAnnee
        '
        Me.tIndiceAnnee.Location = New System.Drawing.Point(479, 100)
        Me.tIndiceAnnee.Name = "tIndiceAnnee"
        Me.tIndiceAnnee.ReadOnly = True
        Me.tIndiceAnnee.Size = New System.Drawing.Size(16, 20)
        Me.tIndiceAnnee.TabIndex = 73
        Me.tIndiceAnnee.Tag = "annee,n"
        Me.tIndiceAnnee.Visible = False
        '
        'tIndiceNom
        '
        Me.tIndiceNom.Location = New System.Drawing.Point(454, 100)
        Me.tIndiceNom.Name = "tIndiceNom"
        Me.tIndiceNom.ReadOnly = True
        Me.tIndiceNom.Size = New System.Drawing.Size(16, 20)
        Me.tIndiceNom.TabIndex = 73
        Me.tIndiceNom.Tag = "TrimestreNom,t"
        Me.tIndiceNom.Visible = False
        '
        'tPersId
        '
        Me.tPersId.Location = New System.Drawing.Point(432, 101)
        Me.tPersId.Name = "tPersId"
        Me.tPersId.ReadOnly = True
        Me.tPersId.Size = New System.Drawing.Size(16, 20)
        Me.tPersId.TabIndex = 73
        Me.tPersId.Tag = "PersId,n"
        Me.tPersId.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "NB Mois Depot Gar."
        '
        'tNbMoisDG
        '
        Me.tNbMoisDG.BackColor = System.Drawing.Color.White
        Me.tNbMoisDG.Location = New System.Drawing.Point(351, 98)
        Me.tNbMoisDG.Name = "tNbMoisDG"
        Me.tNbMoisDG.ReadOnly = True
        Me.tNbMoisDG.Size = New System.Drawing.Size(26, 20)
        Me.tNbMoisDG.TabIndex = 71
        Me.tNbMoisDG.Tag = "nbMoisDG,no"
        Me.tNbMoisDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tSocId
        '
        Me.tSocId.Location = New System.Drawing.Point(409, 101)
        Me.tSocId.Name = "tSocId"
        Me.tSocId.ReadOnly = True
        Me.tSocId.Size = New System.Drawing.Size(17, 20)
        Me.tSocId.TabIndex = 70
        Me.tSocId.Tag = "socId,n"
        Me.tSocId.Visible = False
        '
        'dSortie
        '
        Me.dSortie.Enabled = False
        Me.dSortie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortie.Location = New System.Drawing.Point(590, 97)
        Me.dSortie.Name = "dSortie"
        Me.dSortie.ShowCheckBox = True
        Me.dSortie.Size = New System.Drawing.Size(101, 20)
        Me.dSortie.TabIndex = 13
        Me.dSortie.Tag = "dateSortie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(550, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Sortie"
        '
        'dSortiePrev
        '
        Me.dSortiePrev.Enabled = False
        Me.dSortiePrev.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortiePrev.Location = New System.Drawing.Point(590, 70)
        Me.dSortiePrev.Name = "dSortiePrev"
        Me.dSortiePrev.ShowCheckBox = True
        Me.dSortiePrev.Size = New System.Drawing.Size(101, 20)
        Me.dSortiePrev.TabIndex = 12
        Me.dSortiePrev.Tag = "dateSortiePrev"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(525, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Sortie Prèv"
        '
        'dEntree
        '
        Me.dEntree.Enabled = False
        Me.dEntree.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEntree.Location = New System.Drawing.Point(590, 16)
        Me.dEntree.Name = "dEntree"
        Me.dEntree.Size = New System.Drawing.Size(101, 20)
        Me.dEntree.TabIndex = 11
        Me.dEntree.Tag = "dateEntree"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(515, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Date révision"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(218, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Loyer Actu / An"
        '
        'tLoyerActu
        '
        Me.tLoyerActu.BackColor = System.Drawing.Color.White
        Me.tLoyerActu.Location = New System.Drawing.Point(306, 46)
        Me.tLoyerActu.Name = "tLoyerActu"
        Me.tLoyerActu.ReadOnly = True
        Me.tLoyerActu.Size = New System.Drawing.Size(71, 20)
        Me.tLoyerActu.TabIndex = 9
        Me.tLoyerActu.Tag = "loyerActu,no"
        Me.tLoyerActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tChargeActu
        '
        Me.tChargeActu.BackColor = System.Drawing.Color.White
        Me.tChargeActu.Location = New System.Drawing.Point(306, 71)
        Me.tChargeActu.Name = "tChargeActu"
        Me.tChargeActu.ReadOnly = True
        Me.tChargeActu.Size = New System.Drawing.Size(71, 20)
        Me.tChargeActu.TabIndex = 10
        Me.tChargeActu.Tag = "chargeActu,no"
        Me.tChargeActu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tLoyer
        '
        Me.tLoyer.BackColor = System.Drawing.Color.White
        Me.tLoyer.Location = New System.Drawing.Point(306, 18)
        Me.tLoyer.Name = "tLoyer"
        Me.tLoyer.ReadOnly = True
        Me.tLoyer.Size = New System.Drawing.Size(71, 20)
        Me.tLoyer.TabIndex = 7
        Me.tLoyer.Tag = "loyerInit,no"
        Me.tLoyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Charges / An"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(223, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Loyer Bail / An"
        '
        'cLoyerTVA
        '
        Me.cLoyerTVA.AutoSize = True
        Me.cLoyerTVA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cLoyerTVA.Enabled = False
        Me.cLoyerTVA.Location = New System.Drawing.Point(387, 46)
        Me.cLoyerTVA.Name = "cLoyerTVA"
        Me.cLoyerTVA.Size = New System.Drawing.Size(111, 17)
        Me.cLoyerTVA.TabIndex = 5
        Me.cLoyerTVA.Tag = "loyerSoumisTVA,c"
        Me.cLoyerTVA.Text = "Loyer soumis TVA"
        Me.cLoyerTVA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(421, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Taux"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.Location = New System.Drawing.Point(458, 71)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.ReadOnly = True
        Me.tTauxTVA.Size = New System.Drawing.Size(40, 20)
        Me.tTauxTVA.TabIndex = 6
        Me.tTauxTVA.Tag = "tauxTVA,n"
        Me.tTauxTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tLocId
        '
        Me.tLocId.Location = New System.Drawing.Point(387, 98)
        Me.tLocId.Name = "tLocId"
        Me.tLocId.ReadOnly = True
        Me.tLocId.Size = New System.Drawing.Size(16, 20)
        Me.tLocId.TabIndex = 43
        Me.tLocId.Tag = "Locid,k"
        Me.tLocId.Visible = False
        '
        'Button13
        '
        Me.Button13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(617, 323)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(98, 37)
        Me.Button13.TabIndex = 28
        Me.Button13.Text = "Reprise Dépôt Garantie"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'bFactInterne
        '
        Me.bFactInterne.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bFactInterne.BackColor = System.Drawing.Color.Transparent
        Me.bFactInterne.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bFactInterne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bFactInterne.Location = New System.Drawing.Point(617, 247)
        Me.bFactInterne.Name = "bFactInterne"
        Me.bFactInterne.Size = New System.Drawing.Size(98, 27)
        Me.bFactInterne.TabIndex = 27
        Me.bFactInterne.Text = "Facture Interne"
        Me.bFactInterne.UseVisualStyleBackColor = False
        '
        'bChargeExterne
        '
        Me.bChargeExterne.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bChargeExterne.BackColor = System.Drawing.Color.Transparent
        Me.bChargeExterne.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bChargeExterne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bChargeExterne.Location = New System.Drawing.Point(617, 214)
        Me.bChargeExterne.Name = "bChargeExterne"
        Me.bChargeExterne.Size = New System.Drawing.Size(98, 27)
        Me.bChargeExterne.TabIndex = 26
        Me.bChargeExterne.Text = "Charge Externe"
        Me.bChargeExterne.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(617, 181)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(98, 27)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "Appel Loyer"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(617, 280)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 37)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Appel Dépôt Garantie"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'gCompta
        '
        Me.gCompta.AllowUserToAddRows = False
        Me.gCompta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.gCompta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.numPiece, Me.journal, Me.Libelle, Me.debit, Me.credit})
        Me.gCompta.Location = New System.Drawing.Point(12, 181)
        Me.gCompta.MultiSelect = False
        Me.gCompta.Name = "gCompta"
        Me.gCompta.ReadOnly = True
        Me.gCompta.RowHeadersVisible = False
        Me.gCompta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gCompta.Size = New System.Drawing.Size(599, 251)
        Me.gCompta.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'numPiece
        '
        Me.numPiece.HeaderText = "numPiece"
        Me.numPiece.Name = "numPiece"
        Me.numPiece.ReadOnly = True
        Me.numPiece.Visible = False
        '
        'journal
        '
        Me.journal.HeaderText = "journal"
        Me.journal.Name = "journal"
        Me.journal.ReadOnly = True
        Me.journal.Visible = False
        '
        'Libelle
        '
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        '
        'debit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.debit.DefaultCellStyle = DataGridViewCellStyle2
        Me.debit.FillWeight = 40.0!
        Me.debit.HeaderText = "Débit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        '
        'credit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.credit.DefaultCellStyle = DataGridViewCellStyle3
        Me.credit.FillWeight = 40.0!
        Me.credit.HeaderText = "Crédit"
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(452, 450)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Total"
        '
        'tTotal
        '
        Me.tTotal.BackColor = System.Drawing.Color.White
        Me.tTotal.Location = New System.Drawing.Point(489, 447)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.ReadOnly = True
        Me.tTotal.Size = New System.Drawing.Size(122, 20)
        Me.tTotal.TabIndex = 31
        Me.tTotal.Text = "0"
        Me.tTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(617, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 29)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(12, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 29)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bsuppEcrit
        '
        Me.bsuppEcrit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bsuppEcrit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bsuppEcrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsuppEcrit.Location = New System.Drawing.Point(617, 382)
        Me.bsuppEcrit.Name = "bsuppEcrit"
        Me.bsuppEcrit.Size = New System.Drawing.Size(98, 36)
        Me.bsuppEcrit.TabIndex = 34
        Me.bsuppEcrit.Text = "Supprimer Ecrit."
        Me.bsuppEcrit.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Date Facture"
        '
        'dFacture
        '
        Me.dFacture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dFacture.Location = New System.Drawing.Point(83, 19)
        Me.dFacture.Name = "dFacture"
        Me.dFacture.Size = New System.Drawing.Size(101, 20)
        Me.dFacture.TabIndex = 79
        Me.dFacture.Tag = "dateEntree"
        '
        'F_LocaFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 481)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dFacture)
        Me.Controls.Add(Me.bsuppEcrit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.bFactInterne)
        Me.Controls.Add(Me.bChargeExterne)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.gCompta)
        Me.Controls.Add(Me.gBail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_LocaFacture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Facture Locataire"
        Me.gBail.ResumeLayout(False)
        Me.gBail.PerformLayout()
        CType(Me.gCompta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gBail As System.Windows.Forms.GroupBox
    Friend WithEvents dRevision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cDGTVA As System.Windows.Forms.CheckBox
    Friend WithEvents tPersId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tNbMoisDG As System.Windows.Forms.TextBox
    Friend WithEvents tSocId As System.Windows.Forms.TextBox
    Friend WithEvents dSortie As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dSortiePrev As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dEntree As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tLoyerActu As System.Windows.Forms.TextBox
    Friend WithEvents tChargeActu As System.Windows.Forms.TextBox
    Friend WithEvents tLoyer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cLoyerTVA As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents tLocId As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents bFactInterne As System.Windows.Forms.Button
    Friend WithEvents bChargeExterne As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents gCompta As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numPiece As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents journal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents treglement As System.Windows.Forms.TextBox
    Friend WithEvents tperiode As System.Windows.Forms.TextBox
    Friend WithEvents tindice As System.Windows.Forms.TextBox
    Friend WithEvents tbail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bsuppEcrit As System.Windows.Forms.Button
    Friend WithEvents tIndiceAnnee As System.Windows.Forms.TextBox
    Friend WithEvents tIndiceNom As System.Windows.Forms.TextBox
    Friend WithEvents tIndiceValeur As System.Windows.Forms.TextBox
    Friend WithEvents tIndiceNum As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dFacture As System.Windows.Forms.DateTimePicker
End Class
