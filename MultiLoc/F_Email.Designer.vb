<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Email
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
        Me.cDest = New System.Windows.Forms.ComboBox()
        Me.tCorps = New System.Windows.Forms.TextBox()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bEnvoi = New System.Windows.Forms.Button()
        Me.lkPiece = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'cDest
        '
        Me.cDest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cDest.FormattingEnabled = True
        Me.cDest.Location = New System.Drawing.Point(13, 13)
        Me.cDest.Name = "cDest"
        Me.cDest.Size = New System.Drawing.Size(297, 21)
        Me.cDest.TabIndex = 0
        '
        'tCorps
        '
        Me.tCorps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tCorps.Location = New System.Drawing.Point(13, 70)
        Me.tCorps.Multiline = True
        Me.tCorps.Name = "tCorps"
        Me.tCorps.Size = New System.Drawing.Size(297, 220)
        Me.tCorps.TabIndex = 1
        '
        'bAnnul
        '
        Me.bAnnul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bAnnul.Location = New System.Drawing.Point(13, 296)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 26)
        Me.bAnnul.TabIndex = 2
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bEnvoi
        '
        Me.bEnvoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bEnvoi.Location = New System.Drawing.Point(235, 296)
        Me.bEnvoi.Name = "bEnvoi"
        Me.bEnvoi.Size = New System.Drawing.Size(75, 25)
        Me.bEnvoi.TabIndex = 3
        Me.bEnvoi.Text = "Envoyer"
        Me.bEnvoi.UseVisualStyleBackColor = True
        '
        'lkPiece
        '
        Me.lkPiece.AutoSize = True
        Me.lkPiece.Location = New System.Drawing.Point(13, 41)
        Me.lkPiece.Name = "lkPiece"
        Me.lkPiece.Size = New System.Drawing.Size(34, 13)
        Me.lkPiece.TabIndex = 4
        Me.lkPiece.TabStop = True
        Me.lkPiece.Text = "Pièce"
        '
        'F_Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 328)
        Me.Controls.Add(Me.lkPiece)
        Me.Controls.Add(Me.bEnvoi)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.tCorps)
        Me.Controls.Add(Me.cDest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "F_Email"
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cDest As System.Windows.Forms.ComboBox
    Friend WithEvents tCorps As System.Windows.Forms.TextBox
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bEnvoi As System.Windows.Forms.Button
    Friend WithEvents lkPiece As System.Windows.Forms.LinkLabel
End Class
