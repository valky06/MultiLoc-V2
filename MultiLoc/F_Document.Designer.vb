<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Document
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bEnreg = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tPath = New System.Windows.Forms.TextBox()
        Me.ldoc = New System.Windows.Forms.LinkLabel()
        Me.tNom = New System.Windows.Forms.TextBox()
        Me.tId = New System.Windows.Forms.TextBox()
        Me.tDOcId = New System.Windows.Forms.TextBox()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.tDateCrea = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nom"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(19, 86)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 3
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bEnreg
        '
        Me.bEnreg.Location = New System.Drawing.Point(459, 86)
        Me.bEnreg.Name = "bEnreg"
        Me.bEnreg.Size = New System.Drawing.Size(75, 31)
        Me.bEnreg.TabIndex = 2
        Me.bEnreg.Text = "Enregistrer"
        Me.bEnreg.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'tPath
        '
        Me.tPath.BackColor = System.Drawing.Color.White
        Me.tPath.Location = New System.Drawing.Point(100, 44)
        Me.tPath.Name = "tPath"
        Me.tPath.ReadOnly = True
        Me.tPath.Size = New System.Drawing.Size(434, 20)
        Me.tPath.TabIndex = 1
        Me.tPath.Tag = "docPath,t"
        '
        'ldoc
        '
        Me.ldoc.AutoSize = True
        Me.ldoc.Location = New System.Drawing.Point(38, 47)
        Me.ldoc.Name = "ldoc"
        Me.ldoc.Size = New System.Drawing.Size(56, 13)
        Me.ldoc.TabIndex = 45
        Me.ldoc.TabStop = True
        Me.ldoc.Text = "Document"
        '
        'tNom
        '
        Me.tNom.BackColor = System.Drawing.Color.White
        Me.tNom.Location = New System.Drawing.Point(100, 18)
        Me.tNom.MaxLength = 255
        Me.tNom.Name = "tNom"
        Me.tNom.Size = New System.Drawing.Size(434, 20)
        Me.tNom.TabIndex = 0
        Me.tNom.Tag = "DocNom,to"
        '
        'tId
        '
        Me.tId.Location = New System.Drawing.Point(151, 73)
        Me.tId.Name = "tId"
        Me.tId.ReadOnly = True
        Me.tId.Size = New System.Drawing.Size(37, 20)
        Me.tId.TabIndex = 46
        Me.tId.Tag = "locId,n"
        Me.tId.Visible = False
        '
        'tDOcId
        '
        Me.tDOcId.Location = New System.Drawing.Point(108, 73)
        Me.tDOcId.Name = "tDOcId"
        Me.tDOcId.ReadOnly = True
        Me.tDOcId.Size = New System.Drawing.Size(37, 20)
        Me.tDOcId.TabIndex = 49
        Me.tDOcId.Tag = "docId,k"
        Me.tDOcId.Visible = False
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'tDateCrea
        '
        Me.tDateCrea.Location = New System.Drawing.Point(194, 73)
        Me.tDateCrea.Name = "tDateCrea"
        Me.tDateCrea.ReadOnly = True
        Me.tDateCrea.Size = New System.Drawing.Size(37, 20)
        Me.tDateCrea.TabIndex = 50
        Me.tDateCrea.Tag = "dateCRea,d"
        Me.tDateCrea.Visible = False
        '
        'F_Document
        '
        Me.AcceptButton = Me.bEnreg
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(551, 133)
        Me.Controls.Add(Me.tDateCrea)
        Me.Controls.Add(Me.tDOcId)
        Me.Controls.Add(Me.tNom)
        Me.Controls.Add(Me.tId)
        Me.Controls.Add(Me.ldoc)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bEnreg)
        Me.Controls.Add(Me.tPath)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_Document"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bEnreg As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ldoc As System.Windows.Forms.LinkLabel
    Friend WithEvents tPath As System.Windows.Forms.TextBox
    Friend WithEvents tNom As System.Windows.Forms.TextBox
    Friend WithEvents tId As System.Windows.Forms.TextBox
    Friend WithEvents tDOcId As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tDateCrea As System.Windows.Forms.TextBox
End Class
