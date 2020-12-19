<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CoproCharge
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
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tMontantTTC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tTauxTVA = New System.Windows.Forms.TextBox()
        Me.lBudget = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lCat = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tChId = New System.Windows.Forms.TextBox()
        Me.lRubrique = New System.Windows.Forms.ComboBox()
        Me.tCoproId = New System.Windows.Forms.TextBox()
        Me.tMontantTVA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Montant réel HT"
        '
        'tMontantHT
        '
        Me.tMontantHT.Location = New System.Drawing.Point(119, 160)
        Me.tMontantHT.Name = "tMontantHT"
        Me.tMontantHT.Size = New System.Drawing.Size(81, 20)
        Me.tMontantHT.TabIndex = 5
        Me.tMontantHT.Tag = "ChMontantHT,n"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Budget"
        '
        'lCleRepart
        '
        Me.lCleRepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCleRepart.FormattingEnabled = True
        Me.lCleRepart.Location = New System.Drawing.Point(119, 92)
        Me.lCleRepart.Name = "lCleRepart"
        Me.lCleRepart.Size = New System.Drawing.Size(272, 21)
        Me.lCleRepart.TabIndex = 3
        Me.lCleRepart.Tag = "cleId,no"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(15, 202)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 8
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bOK.Location = New System.Drawing.Point(316, 202)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 7
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tMontantTTC
        '
        Me.tMontantTTC.BackColor = System.Drawing.Color.White
        Me.tMontantTTC.Location = New System.Drawing.Point(324, 160)
        Me.tMontantTTC.Name = "tMontantTTC"
        Me.tMontantTTC.ReadOnly = True
        Me.tMontantTTC.Size = New System.Drawing.Size(67, 20)
        Me.tMontantTTC.TabIndex = 6
        Me.tMontantTTC.Tag = "ChMontantTTC,n"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "TTC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(203, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "TVA"
        '
        'tTauxTVA
        '
        Me.tTauxTVA.BackColor = System.Drawing.Color.White
        Me.tTauxTVA.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tTauxTVA.Location = New System.Drawing.Point(237, 160)
        Me.tTauxTVA.Name = "tTauxTVA"
        Me.tTauxTVA.Size = New System.Drawing.Size(44, 20)
        Me.tTauxTVA.TabIndex = 10
        Me.tTauxTVA.Tag = ""
        '
        'lBudget
        '
        Me.lBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lBudget.FormattingEnabled = True
        Me.lBudget.Location = New System.Drawing.Point(119, 12)
        Me.lBudget.Name = "lBudget"
        Me.lBudget.Size = New System.Drawing.Size(121, 21)
        Me.lBudget.TabIndex = 0
        Me.lBudget.Tag = "budid,no"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Catégorie"
        '
        'lCat
        '
        Me.lCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCat.FormattingEnabled = True
        Me.lCat.Location = New System.Drawing.Point(119, 39)
        Me.lCat.Name = "lCat"
        Me.lCat.Size = New System.Drawing.Size(272, 21)
        Me.lCat.TabIndex = 1
        Me.lCat.Tag = "tChCatId,co"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Clé Répartition"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Rubrique"
        '
        'tChId
        '
        Me.tChId.Location = New System.Drawing.Point(230, 202)
        Me.tChId.Name = "tChId"
        Me.tChId.ReadOnly = True
        Me.tChId.Size = New System.Drawing.Size(37, 20)
        Me.tChId.TabIndex = 90
        Me.tChId.Tag = "Chid,k"
        Me.tChId.Visible = False
        '
        'lRubrique
        '
        Me.lRubrique.FormattingEnabled = True
        Me.lRubrique.Location = New System.Drawing.Point(119, 66)
        Me.lRubrique.Name = "lRubrique"
        Me.lRubrique.Size = New System.Drawing.Size(272, 21)
        Me.lRubrique.TabIndex = 2
        Me.lRubrique.Tag = "chLib,to"
        '
        'tCoproId
        '
        Me.tCoproId.Location = New System.Drawing.Point(273, 202)
        Me.tCoproId.Name = "tCoproId"
        Me.tCoproId.ReadOnly = True
        Me.tCoproId.Size = New System.Drawing.Size(37, 20)
        Me.tCoproId.TabIndex = 92
        Me.tCoproId.Tag = "CoproID,n"
        Me.tCoproId.Visible = False
        '
        'tMontantTVA
        '
        Me.tMontantTVA.BackColor = System.Drawing.Color.White
        Me.tMontantTVA.Location = New System.Drawing.Point(160, 202)
        Me.tMontantTVA.Name = "tMontantTVA"
        Me.tMontantTVA.ReadOnly = True
        Me.tMontantTVA.Size = New System.Drawing.Size(67, 20)
        Me.tMontantTVA.TabIndex = 93
        Me.tMontantTVA.Tag = "ChMontantTVA,n"
        Me.tMontantTVA.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Montant Budget HT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Tag = "ChMontantBudgetHT,n"
        '
        'F_CoproCharge
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(409, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tMontantTVA)
        Me.Controls.Add(Me.tCoproId)
        Me.Controls.Add(Me.lRubrique)
        Me.Controls.Add(Me.tChId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lCat)
        Me.Controls.Add(Me.lBudget)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tTauxTVA)
        Me.Controls.Add(Me.tMontantTTC)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.lCleRepart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tMontantHT)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_CoproCharge"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge Copro"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lCleRepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tMontantHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tMontantTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tTauxTVA As System.Windows.Forms.TextBox
    Friend WithEvents lBudget As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tChId As System.Windows.Forms.TextBox
    Friend WithEvents lRubrique As System.Windows.Forms.ComboBox
    Friend WithEvents tCoproId As System.Windows.Forms.TextBox
    Friend WithEvents tMontantTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
