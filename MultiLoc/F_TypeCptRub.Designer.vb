<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_TypeCptRub
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
        Me.bEnreg = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tNom = New System.Windows.Forms.TextBox()
        Me.tId = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(22, 64)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 2
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bEnreg
        '
        Me.bEnreg.Location = New System.Drawing.Point(236, 64)
        Me.bEnreg.Name = "bEnreg"
        Me.bEnreg.Size = New System.Drawing.Size(75, 31)
        Me.bEnreg.TabIndex = 1
        Me.bEnreg.Text = "Enregistrer"
        Me.bEnreg.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Catégorie"
        '
        'tNom
        '
        Me.tNom.BackColor = System.Drawing.Color.White
        Me.tNom.Location = New System.Drawing.Point(88, 12)
        Me.tNom.Name = "tNom"
        Me.tNom.Size = New System.Drawing.Size(223, 20)
        Me.tNom.TabIndex = 0
        Me.tNom.Tag = "RubNom,to"
        '
        'tId
        '
        Me.tId.Location = New System.Drawing.Point(274, 38)
        Me.tId.Name = "tId"
        Me.tId.ReadOnly = True
        Me.tId.Size = New System.Drawing.Size(37, 20)
        Me.tId.TabIndex = 31
        Me.tId.Tag = "RubId,k"
        Me.tId.Visible = False
        '
        'F_TypeCptRub
        '
        Me.AcceptButton = Me.bEnreg
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(338, 110)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bEnreg)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.tNom)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_TypeCptRub"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "ComptaRubrique"
        Me.Text = "Catégorie Comptable"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bEnreg As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tId As System.Windows.Forms.TextBox
    Friend WithEvents tNom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
