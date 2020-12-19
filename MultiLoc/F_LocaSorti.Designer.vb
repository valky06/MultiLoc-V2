<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaSorti
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
        Me.dSortie = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.bCourrier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dSortie
        '
        Me.dSortie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortie.Location = New System.Drawing.Point(97, 21)
        Me.dSortie.Name = "dSortie"
        Me.dSortie.ShowCheckBox = True
        Me.dSortie.Size = New System.Drawing.Size(119, 20)
        Me.dSortie.TabIndex = 5
        Me.dSortie.Tag = "dateSortie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sortie le"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(12, 118)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 7
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(155, 118)
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
        Me.bCourrier.Location = New System.Drawing.Point(86, 64)
        Me.bCourrier.Name = "bCourrier"
        Me.bCourrier.Size = New System.Drawing.Size(90, 35)
        Me.bCourrier.TabIndex = 43
        Me.bCourrier.Text = "Courrier"
        Me.bCourrier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.bCourrier.UseVisualStyleBackColor = True
        '
        'F_locSorti
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(251, 164)
        Me.Controls.Add(Me.bCourrier)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dSortie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_locSorti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sortie Locataire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dSortie As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents bCourrier As System.Windows.Forms.Button
End Class
