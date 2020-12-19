<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_locaPreavis
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dPreavis = New System.Windows.Forms.DateTimePicker()
        Me.dSortiePrev = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.bCourrier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recu le"
        '
        'dPreavis
        '
        Me.dPreavis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dPreavis.Location = New System.Drawing.Point(111, 23)
        Me.dPreavis.Name = "dPreavis"
        Me.dPreavis.ShowCheckBox = True
        Me.dPreavis.Size = New System.Drawing.Size(119, 20)
        Me.dPreavis.TabIndex = 4
        Me.dPreavis.Tag = ""
        '
        'dSortiePrev
        '
        Me.dSortiePrev.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortiePrev.Location = New System.Drawing.Point(111, 49)
        Me.dSortiePrev.Name = "dSortiePrev"
        Me.dSortiePrev.ShowCheckBox = True
        Me.dSortiePrev.Size = New System.Drawing.Size(119, 20)
        Me.dSortiePrev.TabIndex = 5
        Me.dSortiePrev.Tag = "dSortiePrev"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sortie prévue le"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(12, 137)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 7
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(155, 137)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 7
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'bCourrier
        '
        Me.bCourrier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bCourrier.FlatAppearance.BorderSize = 0
        Me.bCourrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCourrier.Image = Global.MultiLoc.My.Resources.Resources.word
        Me.bCourrier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bCourrier.Location = New System.Drawing.Point(80, 84)
        Me.bCourrier.Name = "bCourrier"
        Me.bCourrier.Size = New System.Drawing.Size(90, 35)
        Me.bCourrier.TabIndex = 43
        Me.bCourrier.Text = "Courrier"
        Me.bCourrier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bCourrier.UseVisualStyleBackColor = True
        '
        'F_locPreavis
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(248, 182)
        Me.Controls.Add(Me.bCourrier)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dSortiePrev)
        Me.Controls.Add(Me.dPreavis)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_locPreavis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Préavis Locataire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dPreavis As System.Windows.Forms.DateTimePicker
    Friend WithEvents dSortiePrev As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents bCourrier As System.Windows.Forms.Button
End Class
