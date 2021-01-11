<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_FactureSociete
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tMontantHT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tLibelle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dDate = New System.Windows.Forms.DateTimePicker()
        Me.dEcheance = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tMontantTTC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.lRubrique = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tNumFacture = New System.Windows.Forms.TextBox()
        Me.lClient = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tNum = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Montant HT"
        '
        'tMontantHT
        '
        Me.tMontantHT.Location = New System.Drawing.Point(77, 121)
        Me.tMontantHT.Name = "tMontantHT"
        Me.tMontantHT.Size = New System.Drawing.Size(68, 20)
        Me.tMontantHT.TabIndex = 5
        Me.tMontantHT.Tag = "ecrMontantHT,no"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'tLibelle
        '
        Me.tLibelle.AcceptsReturn = True
        Me.tLibelle.AcceptsTab = True
        Me.tLibelle.BackColor = System.Drawing.Color.White
        Me.tLibelle.Location = New System.Drawing.Point(77, 147)
        Me.tLibelle.MaxLength = 2000
        Me.tLibelle.Multiline = True
        Me.tLibelle.Name = "tLibelle"
        Me.tLibelle.Size = New System.Drawing.Size(272, 114)
        Me.tLibelle.TabIndex = 4
        Me.tLibelle.Tag = "ecrLib,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Libellé"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(16, 276)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 9
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(274, 276)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 8
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
        Me.dDate.Location = New System.Drawing.Point(77, 95)
        Me.dDate.Name = "dDate"
        Me.dDate.Size = New System.Drawing.Size(101, 20)
        Me.dDate.TabIndex = 2
        Me.dDate.Tag = "ecrDate"
        '
        'dEcheance
        '
        Me.dEcheance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEcheance.Location = New System.Drawing.Point(248, 95)
        Me.dEcheance.Name = "dEcheance"
        Me.dEcheance.Size = New System.Drawing.Size(101, 20)
        Me.dEcheance.TabIndex = 3
        Me.dEcheance.Tag = "ecrEcheance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Echéance"
        '
        'tMontantTTC
        '
        Me.tMontantTTC.BackColor = System.Drawing.Color.White
        Me.tMontantTTC.Location = New System.Drawing.Point(270, 121)
        Me.tMontantTTC.Name = "tMontantTTC"
        Me.tMontantTTC.ReadOnly = True
        Me.tMontantTTC.Size = New System.Drawing.Size(79, 20)
        Me.tMontantTTC.TabIndex = 7
        Me.tMontantTTC.Tag = "ecrMontantTVA,no"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "TTC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "TVA"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tTauxTVA.Location = New System.Drawing.Point(186, 121)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(44, 20)
        Me.tTauxTVA.TabIndex = 6
        Me.tTauxTVA.Tag = ""
        '
        'lRubrique
        '
        Me.lRubrique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lRubrique.FormattingEnabled = True
        Me.lRubrique.Location = New System.Drawing.Point(77, 65)
        Me.lRubrique.Name = "lRubrique"
        Me.lRubrique.Size = New System.Drawing.Size(272, 21)
        Me.lRubrique.TabIndex = 90
        Me.lRubrique.Tag = "chLib,to"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Rubrique"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "N° Facture"
        '
        'tNumFacture
        '
        Me.tNumFacture.Location = New System.Drawing.Point(77, 39)
        Me.tNumFacture.Name = "tNumFacture"
        Me.tNumFacture.ReadOnly = True
        Me.tNumFacture.Size = New System.Drawing.Size(153, 20)
        Me.tNumFacture.TabIndex = 92
        Me.tNumFacture.Tag = ""
        '
        'lClient
        '
        Me.lClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lClient.FormattingEnabled = True
        Me.lClient.Location = New System.Drawing.Point(77, 12)
        Me.lClient.Name = "lClient"
        Me.lClient.Size = New System.Drawing.Size(272, 21)
        Me.lClient.TabIndex = 94
        Me.lClient.Tag = "socid,co"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Client"
        '
        'tNum
        '
        Me.tNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tNum.Enabled = False
        Me.tNum.Location = New System.Drawing.Point(236, 39)
        Me.tNum.Name = "tNum"
        Me.tNum.ReadOnly = True
        Me.tNum.Size = New System.Drawing.Size(113, 20)
        Me.tNum.TabIndex = 96
        Me.tNum.Tag = ""
        Me.tNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tNum.Visible = False
        '
        'F_FactureSociete
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(367, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.tNum)
        Me.Controls.Add(Me.lClient)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tNumFacture)
        Me.Controls.Add(Me.lRubrique)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tTauxTVA)
        Me.Controls.Add(Me.tMontantTTC)
        Me.Controls.Add(Me.dEcheance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tLibelle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dDate)
        Me.Controls.Add(Me.tMontantHT)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_FactureSociete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturation"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLibelle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents lRubrique As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tNumFacture As TextBox
    Friend WithEvents lClient As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tNum As TextBox
End Class
