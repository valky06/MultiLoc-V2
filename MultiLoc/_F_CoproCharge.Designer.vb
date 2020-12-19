<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CoproCharge_old
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
        Me.lCleRepart = New System.Windows.Forms.ComboBox()
        Me.tlibelle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dDate = New System.Windows.Forms.DateTimePicker()
        Me.dEcheance = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tMontantTTC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lCompte = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tNumFacture = New System.Windows.Forms.TextBox()
        Me.rLocataire = New System.Windows.Forms.RadioButton()
        Me.rProprio = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.tFourId = New System.Windows.Forms.TextBox()
        Me.liFour = New System.Windows.Forms.LinkLabel()
        Me.tFourNom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lBudget = New System.Windows.Forms.ComboBox()
        Me.tNUmFactureINterne = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Montant HT"
        '
        'tMontantHT
        '
        Me.tMontantHT.Location = New System.Drawing.Point(98, 197)
        Me.tMontantHT.Name = "tMontantHT"
        Me.tMontantHT.Size = New System.Drawing.Size(81, 20)
        Me.tMontantHT.TabIndex = 9
        Me.tMontantHT.Tag = "ecrMontantHT,no"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'lCleRepart
        '
        Me.lCleRepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCleRepart.FormattingEnabled = True
        Me.lCleRepart.Location = New System.Drawing.Point(98, 118)
        Me.lCleRepart.Name = "lCleRepart"
        Me.lCleRepart.Size = New System.Drawing.Size(272, 21)
        Me.lCleRepart.TabIndex = 5
        Me.lCleRepart.Tag = "cleId,no"
        '
        'tlibelle
        '
        Me.tlibelle.BackColor = System.Drawing.Color.White
        Me.tlibelle.Location = New System.Drawing.Point(98, 171)
        Me.tlibelle.Name = "tlibelle"
        Me.tlibelle.Size = New System.Drawing.Size(272, 20)
        Me.tlibelle.TabIndex = 8
        Me.tlibelle.Tag = "ecrLib,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Libellé"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(17, 232)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 13
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(295, 232)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 12
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dDate
        '
        Me.dDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDate.Location = New System.Drawing.Point(98, 38)
        Me.dDate.Name = "dDate"
        Me.dDate.Size = New System.Drawing.Size(101, 20)
        Me.dDate.TabIndex = 2
        Me.dDate.Tag = "ecrDate"
        '
        'dEcheance
        '
        Me.dEcheance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEcheance.Location = New System.Drawing.Point(268, 38)
        Me.dEcheance.Name = "dEcheance"
        Me.dEcheance.Size = New System.Drawing.Size(101, 20)
        Me.dEcheance.TabIndex = 3
        Me.dEcheance.Tag = "ecrEcheance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Echéance"
        '
        'tMontantTTC
        '
        Me.tMontantTTC.BackColor = System.Drawing.Color.White
        Me.tMontantTTC.Location = New System.Drawing.Point(303, 197)
        Me.tMontantTTC.Name = "tMontantTTC"
        Me.tMontantTTC.ReadOnly = True
        Me.tMontantTTC.Size = New System.Drawing.Size(67, 20)
        Me.tMontantTTC.TabIndex = 11
        Me.tMontantTTC.Tag = "ecrMontantTTC,no"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Type Charge"
        '
        'lCompte
        '
        Me.lCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCompte.FormattingEnabled = True
        Me.lCompte.Location = New System.Drawing.Point(98, 91)
        Me.lCompte.Name = "lCompte"
        Me.lCompte.Size = New System.Drawing.Size(272, 21)
        Me.lCompte.TabIndex = 4
        Me.lCompte.Tag = "cptId,no"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(14, 121)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(76, 13)
        Me.LinkLabel1.TabIndex = 60
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Clé Répartition"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Tag = ""
        Me.Label12.Text = "N° Facture"
        '
        'tNumFacture
        '
        Me.tNumFacture.Location = New System.Drawing.Point(98, 12)
        Me.tNumFacture.Name = "tNumFacture"
        Me.tNumFacture.Size = New System.Drawing.Size(99, 20)
        Me.tNumFacture.TabIndex = 1
        Me.tNumFacture.Tag = "numFacture,t"
        '
        'rLocataire
        '
        Me.rLocataire.AutoSize = True
        Me.rLocataire.Checked = True
        Me.rLocataire.Location = New System.Drawing.Point(98, 146)
        Me.rLocataire.Name = "rLocataire"
        Me.rLocataire.Size = New System.Drawing.Size(69, 17)
        Me.rLocataire.TabIndex = 6
        Me.rLocataire.TabStop = True
        Me.rLocataire.Text = "Locataire"
        Me.rLocataire.UseVisualStyleBackColor = True
        '
        'rProprio
        '
        Me.rProprio.AutoSize = True
        Me.rProprio.Location = New System.Drawing.Point(206, 146)
        Me.rProprio.Name = "rProprio"
        Me.rProprio.Size = New System.Drawing.Size(78, 17)
        Me.rProprio.TabIndex = 7
        Me.rProprio.Text = "Propriétaire"
        Me.rProprio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "TTC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "TVA"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tTauxTVA.Location = New System.Drawing.Point(216, 197)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(44, 20)
        Me.tTauxTVA.TabIndex = 10
        Me.tTauxTVA.Tag = ""
        '
        'tFourId
        '
        Me.tFourId.Location = New System.Drawing.Point(338, 269)
        Me.tFourId.Name = "tFourId"
        Me.tFourId.ReadOnly = True
        Me.tFourId.Size = New System.Drawing.Size(21, 20)
        Me.tFourId.TabIndex = 82
        Me.tFourId.Tag = ""
        Me.tFourId.Visible = False
        '
        'liFour
        '
        Me.liFour.AutoSize = True
        Me.liFour.Location = New System.Drawing.Point(20, 272)
        Me.liFour.Name = "liFour"
        Me.liFour.Size = New System.Drawing.Size(61, 13)
        Me.liFour.TabIndex = 80
        Me.liFour.TabStop = True
        Me.liFour.Text = "Fournisseur"
        Me.liFour.Visible = False
        '
        'tFourNom
        '
        Me.tFourNom.BackColor = System.Drawing.Color.White
        Me.tFourNom.Location = New System.Drawing.Point(87, 269)
        Me.tFourNom.Name = "tFourNom"
        Me.tFourNom.ReadOnly = True
        Me.tFourNom.Size = New System.Drawing.Size(245, 20)
        Me.tFourNom.TabIndex = 81
        Me.tFourNom.TabStop = False
        Me.tFourNom.Tag = ""
        Me.tFourNom.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Rubrique Budget"
        '
        'lBudget
        '
        Me.lBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lBudget.FormattingEnabled = True
        Me.lBudget.Location = New System.Drawing.Point(98, 64)
        Me.lBudget.Name = "lBudget"
        Me.lBudget.Size = New System.Drawing.Size(272, 21)
        Me.lBudget.TabIndex = 83
        Me.lBudget.Tag = ""
        '
        'tNUmFactureINterne
        '
        Me.tNUmFactureINterne.Location = New System.Drawing.Point(269, 12)
        Me.tNUmFactureINterne.Name = "tNUmFactureINterne"
        Me.tNUmFactureINterne.Size = New System.Drawing.Size(99, 20)
        Me.tNUmFactureINterne.TabIndex = 85
        Me.tNUmFactureINterne.Tag = "numFactureInterne,t"
        Me.tNUmFactureINterne.Visible = False
        '
        'F_CoproCharge
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(392, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.tNUmFactureINterne)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lBudget)
        Me.Controls.Add(Me.tFourNom)
        Me.Controls.Add(Me.tFourId)
        Me.Controls.Add(Me.liFour)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tTauxTVA)
        Me.Controls.Add(Me.rProprio)
        Me.Controls.Add(Me.rLocataire)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tNumFacture)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lCompte)
        Me.Controls.Add(Me.tMontantTTC)
        Me.Controls.Add(Me.dEcheance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tlibelle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lCleRepart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dDate)
        Me.Controls.Add(Me.tMontantHT)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_CoproCharge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge Copro"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlibelle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lCleRepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tMontantHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tMontantTTC As System.Windows.Forms.TextBox
    Friend WithEvents dEcheance As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lCompte As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tNumFacture As System.Windows.Forms.TextBox
    Friend WithEvents rProprio As System.Windows.Forms.RadioButton
    Friend WithEvents rLocataire As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents tFourId As System.Windows.Forms.TextBox
    Friend WithEvents liFour As System.Windows.Forms.LinkLabel
    Friend WithEvents tFourNom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lBudget As System.Windows.Forms.ComboBox
    Friend WithEvents tNUmFactureINterne As System.Windows.Forms.TextBox
End Class
