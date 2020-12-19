<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BudgetLigne
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
        Me.tLib = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tEcrId = New System.Windows.Forms.TextBox()
        Me.tBudId = New System.Windows.Forms.TextBox()
        Me.cCat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Montant HT"
        '
        'tMontantHT
        '
        Me.tMontantHT.Location = New System.Drawing.Point(97, 74)
        Me.tMontantHT.Name = "tMontantHT"
        Me.tMontantHT.Size = New System.Drawing.Size(81, 20)
        Me.tMontantHT.TabIndex = 6
        Me.tMontantHT.Tag = "MontantHT,no"
        '
        'tLib
        '
        Me.tLib.BackColor = System.Drawing.Color.White
        Me.tLib.Location = New System.Drawing.Point(97, 48)
        Me.tLib.Name = "tLib"
        Me.tLib.Size = New System.Drawing.Size(272, 20)
        Me.tLib.TabIndex = 5
        Me.tLib.TabStop = False
        Me.tLib.Tag = "bliText,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Rubrique"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(16, 108)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 9
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(294, 108)
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
        'tEcrId
        '
        Me.tEcrId.Location = New System.Drawing.Point(258, 74)
        Me.tEcrId.Name = "tEcrId"
        Me.tEcrId.ReadOnly = True
        Me.tEcrId.Size = New System.Drawing.Size(37, 20)
        Me.tEcrId.TabIndex = 31
        Me.tEcrId.TabStop = False
        Me.tEcrId.Tag = "bliId,k"
        Me.tEcrId.Visible = False
        '
        'tBudId
        '
        Me.tBudId.Location = New System.Drawing.Point(215, 74)
        Me.tBudId.Name = "tBudId"
        Me.tBudId.ReadOnly = True
        Me.tBudId.Size = New System.Drawing.Size(37, 20)
        Me.tBudId.TabIndex = 59
        Me.tBudId.TabStop = False
        Me.tBudId.Tag = "budId,no"
        Me.tBudId.Visible = False
        '
        'cCat
        '
        Me.cCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCat.FormattingEnabled = True
        Me.cCat.Location = New System.Drawing.Point(97, 21)
        Me.cCat.Name = "cCat"
        Me.cCat.Size = New System.Drawing.Size(272, 21)
        Me.cCat.TabIndex = 60
        Me.cCat.Tag = "tChCatId,co"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Catégorie"
        '
        'F_BudgetLigne
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(389, 159)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cCat)
        Me.Controls.Add(Me.tBudId)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tEcrId)
        Me.Controls.Add(Me.tLib)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tMontantHT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_BudgetLigne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ligne Budget"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLib As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tMontantHT As System.Windows.Forms.TextBox
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tEcrId As System.Windows.Forms.TextBox
    Friend WithEvents tBudId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cCat As System.Windows.Forms.ComboBox
End Class
