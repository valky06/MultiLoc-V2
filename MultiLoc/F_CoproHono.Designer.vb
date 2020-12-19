<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CoproHono
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
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cRepartLoc = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cLotZero = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grCloture = New System.Windows.Forms.GroupBox()
        Me.grBudget = New System.Windows.Forms.GroupBox()
        Me.cBudget = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grCloture.SuspendLayout()
        Me.grBudget.SuspendLayout()
        Me.SuspendLayout()
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(9, 235)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 2
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(240, 235)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 1
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(50, 20)
        Me.TextBox1.TabIndex = 3
        '
        'cRepartLoc
        '
        Me.cRepartLoc.AutoSize = True
        Me.cRepartLoc.Checked = True
        Me.cRepartLoc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cRepartLoc.Location = New System.Drawing.Point(85, 60)
        Me.cRepartLoc.Name = "cRepartLoc"
        Me.cRepartLoc.Size = New System.Drawing.Size(174, 17)
        Me.cRepartLoc.TabIndex = 5
        Me.cRepartLoc.Text = "Affiche Répartition par locataire"
        Me.cRepartLoc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Honoraires"
        '
        'cLotZero
        '
        Me.cLotZero.AutoSize = True
        Me.cLotZero.Location = New System.Drawing.Point(85, 83)
        Me.cLotZero.Name = "cLotZero"
        Me.cLotZero.Size = New System.Drawing.Size(165, 17)
        Me.cLotZero.TabIndex = 6
        Me.cLotZero.Text = "Affiche les lots sans montants"
        Me.cLotZero.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "% ( 0 = sans honoraires)"
        '
        'grCloture
        '
        Me.grCloture.Controls.Add(Me.Label2)
        Me.grCloture.Controls.Add(Me.cLotZero)
        Me.grCloture.Controls.Add(Me.Label1)
        Me.grCloture.Controls.Add(Me.cRepartLoc)
        Me.grCloture.Controls.Add(Me.TextBox1)
        Me.grCloture.Location = New System.Drawing.Point(12, 12)
        Me.grCloture.Name = "grCloture"
        Me.grCloture.Size = New System.Drawing.Size(303, 113)
        Me.grCloture.TabIndex = 7
        Me.grCloture.TabStop = False
        Me.grCloture.Text = "Cloture"
        '
        'grBudget
        '
        Me.grBudget.Controls.Add(Me.cBudget)
        Me.grBudget.Location = New System.Drawing.Point(12, 131)
        Me.grBudget.Name = "grBudget"
        Me.grBudget.Size = New System.Drawing.Size(303, 82)
        Me.grBudget.TabIndex = 8
        Me.grBudget.TabStop = False
        Me.grBudget.Text = "Budget"
        '
        'cBudget
        '
        Me.cBudget.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cBudget.Location = New System.Drawing.Point(85, 19)
        Me.cBudget.Name = "cBudget"
        Me.cBudget.Size = New System.Drawing.Size(212, 47)
        Me.cBudget.TabIndex = 6
        Me.cBudget.Text = "Réparition pour budget ( sans solde de charges, honoraires estimés sur loyer actu" & _
    "el )"
        Me.cBudget.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cBudget.UseVisualStyleBackColor = True
        '
        'F_CoproHono
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(327, 279)
        Me.Controls.Add(Me.grBudget)
        Me.Controls.Add(Me.grCloture)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.bAnnul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_CoproHono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Répartition Charges"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grCloture.ResumeLayout(False)
        Me.grCloture.PerformLayout()
        Me.grBudget.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grBudget As System.Windows.Forms.GroupBox
    Friend WithEvents cBudget As System.Windows.Forms.CheckBox
    Friend WithEvents grCloture As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cLotZero As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cRepartLoc As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
