<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_ComptaPlan
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tNumCpt = New System.Windows.Forms.TextBox()
        Me.lRubrique = New System.Windows.Forms.ComboBox()
        Me.tPCID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tNomCpt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tSocId = New System.Windows.Forms.TextBox()
        Me.lTiers = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "N° Compte"
        '
        'tNumCpt
        '
        Me.tNumCpt.Location = New System.Drawing.Point(86, 66)
        Me.tNumCpt.Name = "tNumCpt"
        Me.tNumCpt.Size = New System.Drawing.Size(165, 20)
        Me.tNumCpt.TabIndex = 100
        Me.tNumCpt.Tag = "cptnum,to"
        '
        'lRubrique
        '
        Me.lRubrique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lRubrique.FormattingEnabled = True
        Me.lRubrique.Location = New System.Drawing.Point(86, 39)
        Me.lRubrique.Name = "lRubrique"
        Me.lRubrique.Size = New System.Drawing.Size(165, 21)
        Me.lRubrique.TabIndex = 98
        Me.lRubrique.Tag = "rubid,co"
        '
        'tPCID
        '
        Me.tPCID.Location = New System.Drawing.Point(223, 128)
        Me.tPCID.Name = "tPCID"
        Me.tPCID.ReadOnly = True
        Me.tPCID.Size = New System.Drawing.Size(37, 20)
        Me.tPCID.TabIndex = 113
        Me.tPCID.Tag = "pcid,k"
        Me.tPCID.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Rubrique"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(28, 128)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 104
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bOK.Location = New System.Drawing.Point(309, 128)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 103
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Nom Compte"
        '
        'tNomCpt
        '
        Me.tNomCpt.Location = New System.Drawing.Point(86, 92)
        Me.tNomCpt.Name = "tNomCpt"
        Me.tNomCpt.Size = New System.Drawing.Size(298, 20)
        Me.tNomCpt.TabIndex = 101
        Me.tNomCpt.Tag = "cptnom,to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Tiers"
        '
        'tSocId
        '
        Me.tSocId.Location = New System.Drawing.Point(266, 128)
        Me.tSocId.Name = "tSocId"
        Me.tSocId.ReadOnly = True
        Me.tSocId.Size = New System.Drawing.Size(37, 20)
        Me.tSocId.TabIndex = 114
        Me.tSocId.Tag = "socid,n"
        Me.tSocId.Visible = False
        '
        'lTiers
        '
        Me.lTiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTiers.FormattingEnabled = True
        Me.lTiers.Location = New System.Drawing.Point(86, 12)
        Me.lTiers.Name = "lTiers"
        Me.lTiers.Size = New System.Drawing.Size(298, 21)
        Me.lTiers.TabIndex = 117
        Me.lTiers.Tag = "locid,co"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'f_ComptaPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 174)
        Me.Controls.Add(Me.lTiers)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tNumCpt)
        Me.Controls.Add(Me.tSocId)
        Me.Controls.Add(Me.lRubrique)
        Me.Controls.Add(Me.tPCID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tNomCpt)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "f_ComptaPlan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan Comptable"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents tNumCpt As TextBox
    Friend WithEvents lRubrique As ComboBox
    Friend WithEvents tPCID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bAnnul As Button
    Friend WithEvents bOK As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tNomCpt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tSocId As TextBox
    Friend WithEvents lTiers As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
