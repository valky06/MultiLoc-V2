<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaNew
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
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.bTypeBail = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lTypePer = New System.Windows.Forms.ComboBox()
        Me.lTypeRgt = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dEntre = New System.Windows.Forms.DateTimePicker()
        Me.tLoyer = New System.Windows.Forms.TextBox()
        Me.lIndice = New System.Windows.Forms.ComboBox()
        Me.lTypeBail = New System.Windows.Forms.ComboBox()
        Me.tPersNom = New System.Windows.Forms.TextBox()
        Me.tPersId = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.tLoyerActu = New System.Windows.Forms.TextBox()
        Me.tChargeActu = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cDGTva = New System.Windows.Forms.CheckBox()
        Me.dRevision = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cLoyerReduc = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tIndActuId = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(61, 130)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(36, 13)
        Me.LinkLabel4.TabIndex = 8
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Indice"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(9, 101)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel3.TabIndex = 6
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Type Règlement"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(51, 74)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Période"
        '
        'bTypeBail
        '
        Me.bTypeBail.AutoSize = True
        Me.bTypeBail.Location = New System.Drawing.Point(43, 47)
        Me.bTypeBail.Name = "bTypeBail"
        Me.bTypeBail.Size = New System.Drawing.Size(51, 13)
        Me.bTypeBail.TabIndex = 2
        Me.bTypeBail.TabStop = True
        Me.bTypeBail.Text = "Type Bail"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(308, 252)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(37, 20)
        Me.TextBox1.TabIndex = 31
        Me.TextBox1.Tag = "locid,k"
        Me.TextBox1.Visible = False
        '
        'lTypePer
        '
        Me.lTypePer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypePer.FormattingEnabled = True
        Me.lTypePer.Location = New System.Drawing.Point(100, 71)
        Me.lTypePer.Name = "lTypePer"
        Me.lTypePer.Size = New System.Drawing.Size(146, 21)
        Me.lTypePer.TabIndex = 5
        Me.lTypePer.Tag = "TperId,no"
        '
        'lTypeRgt
        '
        Me.lTypeRgt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypeRgt.FormattingEnabled = True
        Me.lTypeRgt.Location = New System.Drawing.Point(100, 98)
        Me.lTypeRgt.Name = "lTypeRgt"
        Me.lTypeRgt.Size = New System.Drawing.Size(146, 21)
        Me.lTypeRgt.TabIndex = 7
        Me.lTypeRgt.Tag = "TRgtId,no"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Régime fiscal"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(100, 152)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 20)
        Me.TextBox6.TabIndex = 11
        Me.TextBox6.Tag = "regimefiscal,t"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Loyer Départ An"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Entrée"
        '
        'dEntre
        '
        Me.dEntre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEntre.Location = New System.Drawing.Point(347, 71)
        Me.dEntre.Name = "dEntre"
        Me.dEntre.Size = New System.Drawing.Size(101, 20)
        Me.dEntre.TabIndex = 18
        Me.dEntre.Tag = "dateEntree"
        '
        'tLoyer
        '
        Me.tLoyer.BackColor = System.Drawing.Color.White
        Me.tLoyer.Location = New System.Drawing.Point(389, 123)
        Me.tLoyer.Name = "tLoyer"
        Me.tLoyer.Size = New System.Drawing.Size(59, 20)
        Me.tLoyer.TabIndex = 20
        Me.tLoyer.Tag = "LoyerInit,no"
        Me.tLoyer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lIndice
        '
        Me.lIndice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lIndice.FormattingEnabled = True
        Me.lIndice.Location = New System.Drawing.Point(100, 125)
        Me.lIndice.Name = "lIndice"
        Me.lIndice.Size = New System.Drawing.Size(146, 21)
        Me.lIndice.TabIndex = 9
        Me.lIndice.Tag = "indId,no"
        '
        'lTypeBail
        '
        Me.lTypeBail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypeBail.FormattingEnabled = True
        Me.lTypeBail.Location = New System.Drawing.Point(100, 44)
        Me.lTypeBail.Name = "lTypeBail"
        Me.lTypeBail.Size = New System.Drawing.Size(146, 21)
        Me.lTypeBail.TabIndex = 3
        Me.lTypeBail.Tag = "tbailId,no"
        '
        'tPersNom
        '
        Me.tPersNom.BackColor = System.Drawing.Color.White
        Me.tPersNom.Location = New System.Drawing.Point(100, 18)
        Me.tPersNom.Name = "tPersNom"
        Me.tPersNom.ReadOnly = True
        Me.tPersNom.Size = New System.Drawing.Size(348, 20)
        Me.tPersNom.TabIndex = 1
        Me.tPersNom.TabStop = False
        Me.tPersNom.Tag = "nom"
        '
        'tPersId
        '
        Me.tPersId.Location = New System.Drawing.Point(265, 252)
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
        Me.Button2.Location = New System.Drawing.Point(22, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(373, 246)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 31)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Enregistrer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(31, 178)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Tag = "loyerSoumisTVA,c"
        Me.CheckBox1.Text = "Loyer Soumis a TVA"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'tTauxTVA
        '
        Me.tTauxTVA.Location = New System.Drawing.Point(205, 176)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(33, 20)
        Me.tTauxTVA.TabIndex = 15
        Me.tTauxTVA.Tag = "tauxTVA,n"
        '
        'tLoyerActu
        '
        Me.tLoyerActu.BackColor = System.Drawing.Color.White
        Me.tLoyerActu.Location = New System.Drawing.Point(145, 252)
        Me.tLoyerActu.Name = "tLoyerActu"
        Me.tLoyerActu.Size = New System.Drawing.Size(54, 20)
        Me.tLoyerActu.TabIndex = 56
        Me.tLoyerActu.Tag = "LoyerActu,no"
        Me.tLoyerActu.Visible = False
        '
        'tChargeActu
        '
        Me.tChargeActu.BackColor = System.Drawing.Color.White
        Me.tChargeActu.Location = New System.Drawing.Point(205, 252)
        Me.tChargeActu.Name = "tChargeActu"
        Me.tChargeActu.Size = New System.Drawing.Size(54, 20)
        Me.tChargeActu.TabIndex = 57
        Me.tChargeActu.Tag = "chargeActu,n"
        Me.tChargeActu.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(65, 21)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Nb Mois Depot Garantie"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(408, 152)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 20)
        Me.TextBox2.TabIndex = 21
        Me.TextBox2.Tag = "NbMoisDG,n"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Suffixe Compte"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(408, 44)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(40, 20)
        Me.TextBox3.TabIndex = 17
        Me.TextBox3.Tag = "CptSuffixe,t"
        '
        'cDGTva
        '
        Me.cDGTva.AutoSize = True
        Me.cDGTva.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cDGTva.Location = New System.Drawing.Point(30, 202)
        Me.cDGTva.Name = "cDGTva"
        Me.cDGTva.Size = New System.Drawing.Size(123, 17)
        Me.cDGTva.TabIndex = 16
        Me.cDGTva.Tag = "DGSoumisTVA,c"
        Me.cDGTva.Text = "Dépôt soumis a TVA"
        Me.cDGTva.UseVisualStyleBackColor = True
        '
        'dRevision
        '
        Me.dRevision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dRevision.Location = New System.Drawing.Point(347, 99)
        Me.dRevision.Name = "dRevision"
        Me.dRevision.Size = New System.Drawing.Size(101, 20)
        Me.dRevision.TabIndex = 19
        Me.dRevision.Tag = "dateRevision"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Date révision"
        '
        'cLoyerReduc
        '
        Me.cLoyerReduc.AutoSize = True
        Me.cLoyerReduc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cLoyerReduc.Location = New System.Drawing.Point(307, 180)
        Me.cLoyerReduc.Name = "cLoyerReduc"
        Me.cLoyerReduc.Size = New System.Drawing.Size(141, 17)
        Me.cLoyerReduc.TabIndex = 22
        Me.cLoyerReduc.Tag = "LoyerReduction,c"
        Me.cLoyerReduc.Text = "Réduction loyer possible"
        Me.cLoyerReduc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Taux"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "%"
        '
        'tIndActuId
        '
        Me.tIndActuId.Location = New System.Drawing.Point(265, 226)
        Me.tIndActuId.Name = "tIndActuId"
        Me.tIndActuId.ReadOnly = True
        Me.tIndActuId.Size = New System.Drawing.Size(37, 20)
        Me.tIndActuId.TabIndex = 68
        Me.tIndActuId.Tag = "indActuId,n"
        Me.tIndActuId.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Location = New System.Drawing.Point(341, 202)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox2.TabIndex = 69
        Me.CheckBox2.Tag = "CautionBanc,c"
        Me.CheckBox2.Text = "Caution Bancaire"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'F_LocaNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 294)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.tIndActuId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cLoyerReduc)
        Me.Controls.Add(Me.dRevision)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cDGTva)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.tLoyerActu)
        Me.Controls.Add(Me.tChargeActu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.tTauxTVA)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.bTypeBail)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tPersNom)
        Me.Controls.Add(Me.tPersId)
        Me.Controls.Add(Me.lTypePer)
        Me.Controls.Add(Me.lTypeBail)
        Me.Controls.Add(Me.lTypeRgt)
        Me.Controls.Add(Me.lIndice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.tLoyer)
        Me.Controls.Add(Me.dEntre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_LocaNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locataire"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tPersNom As System.Windows.Forms.TextBox
    Friend WithEvents lIndice As System.Windows.Forms.ComboBox
    Friend WithEvents lTypeBail As System.Windows.Forms.ComboBox
    Friend WithEvents lTypePer As System.Windows.Forms.ComboBox
    Friend WithEvents lTypeRgt As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents tLoyer As System.Windows.Forms.TextBox
    Friend WithEvents tPersId As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents bTypeBail As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents tLoyerActu As System.Windows.Forms.TextBox
    Friend WithEvents tChargeActu As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents cDGTva As System.Windows.Forms.CheckBox
    Friend WithEvents dRevision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cLoyerReduc As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tIndActuId As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
