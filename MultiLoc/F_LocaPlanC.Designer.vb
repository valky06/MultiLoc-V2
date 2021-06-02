<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaPlanC
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
        Me.tLibelle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tPCId = New System.Windows.Forms.TextBox()
        Me.lRubrique = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tLocId = New System.Windows.Forms.TextBox()
        Me.tSocId = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Libellé"
        '
        'tMontantHT
        '
        Me.tMontantHT.Location = New System.Drawing.Point(97, 64)
        Me.tMontantHT.Name = "tMontantHT"
        Me.tMontantHT.Size = New System.Drawing.Size(272, 20)
        Me.tMontantHT.TabIndex = 5
        Me.tMontantHT.Tag = "cptnom,to"
        '
        'tLibelle
        '
        Me.tLibelle.BackColor = System.Drawing.Color.White
        Me.tLibelle.Location = New System.Drawing.Point(97, 38)
        Me.tLibelle.Name = "tLibelle"
        Me.tLibelle.Size = New System.Drawing.Size(272, 20)
        Me.tLibelle.TabIndex = 4
        Me.tLibelle.Tag = "cptnum,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Numéro"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(16, 112)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 9
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(294, 112)
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
        'tPCId
        '
        Me.tPCId.Location = New System.Drawing.Point(375, 12)
        Me.tPCId.Name = "tPCId"
        Me.tPCId.ReadOnly = True
        Me.tPCId.Size = New System.Drawing.Size(21, 20)
        Me.tPCId.TabIndex = 76
        Me.tPCId.Tag = "PCId,k"
        Me.tPCId.Visible = False
        '
        'lRubrique
        '
        Me.lRubrique.Enabled = False
        Me.lRubrique.FormattingEnabled = True
        Me.lRubrique.Location = New System.Drawing.Point(97, 12)
        Me.lRubrique.Name = "lRubrique"
        Me.lRubrique.Size = New System.Drawing.Size(272, 21)
        Me.lRubrique.TabIndex = 92
        Me.lRubrique.Tag = "rubid,n"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Rubrique"
        '
        'tLocId
        '
        Me.tLocId.Location = New System.Drawing.Point(188, 103)
        Me.tLocId.Name = "tLocId"
        Me.tLocId.ReadOnly = True
        Me.tLocId.Size = New System.Drawing.Size(21, 20)
        Me.tLocId.TabIndex = 94
        Me.tLocId.Tag = "locid,n"
        Me.tLocId.Visible = False
        '
        'tSocId
        '
        Me.tSocId.Location = New System.Drawing.Point(226, 103)
        Me.tSocId.Name = "tSocId"
        Me.tSocId.ReadOnly = True
        Me.tSocId.Size = New System.Drawing.Size(21, 20)
        Me.tSocId.TabIndex = 95
        Me.tSocId.Tag = "Socid,n"
        Me.tSocId.Visible = False
        '
        'F_LocaPlanC
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(399, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.tSocId)
        Me.Controls.Add(Me.tLocId)
        Me.Controls.Add(Me.lRubrique)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tPCId)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tLibelle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tMontantHT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_LocaPlanC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan Comptable"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLibelle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tMontantHT As System.Windows.Forms.TextBox
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tPCId As System.Windows.Forms.TextBox
    Friend WithEvents lRubrique As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tLocId As System.Windows.Forms.TextBox
    Friend WithEvents tSocId As TextBox
End Class
