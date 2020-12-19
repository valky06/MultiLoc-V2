<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaLot
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
        Me.tLocatID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dEntre = New System.Windows.Forms.DateTimePicker()
        Me.tLotNom = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tLotId = New System.Windows.Forms.TextBox()
        Me.dSortie = New System.Windows.Forms.DateTimePicker()
        Me.tSurface = New System.Windows.Forms.TextBox()
        Me.lSurface = New System.Windows.Forms.Label()
        Me.tSurftot = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tLocatID
        '
        Me.tLocatID.Location = New System.Drawing.Point(248, 68)
        Me.tLocatID.Name = "tLocatID"
        Me.tLocatID.ReadOnly = True
        Me.tLocatID.Size = New System.Drawing.Size(91, 20)
        Me.tLocatID.TabIndex = 31
        Me.tLocatID.Tag = ""
        Me.tLocatID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Entrée"
        '
        'dEntre
        '
        Me.dEntre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEntre.Location = New System.Drawing.Point(70, 45)
        Me.dEntre.Name = "dEntre"
        Me.dEntre.Size = New System.Drawing.Size(101, 20)
        Me.dEntre.TabIndex = 18
        Me.dEntre.Tag = ""
        '
        'tLotNom
        '
        Me.tLotNom.BackColor = System.Drawing.Color.White
        Me.tLotNom.Location = New System.Drawing.Point(70, 16)
        Me.tLotNom.Name = "tLotNom"
        Me.tLotNom.ReadOnly = True
        Me.tLotNom.Size = New System.Drawing.Size(272, 20)
        Me.tLotNom.TabIndex = 1
        Me.tLotNom.TabStop = False
        Me.tLotNom.Tag = ""
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(29, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 31)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Enregistrer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(35, 19)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(22, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Lot"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Sortie"
        '
        'tLotId
        '
        Me.tLotId.Location = New System.Drawing.Point(242, 19)
        Me.tLotId.Name = "tLotId"
        Me.tLotId.Size = New System.Drawing.Size(100, 20)
        Me.tLotId.TabIndex = 66
        Me.tLotId.Tag = ""
        Me.tLotId.Visible = False
        '
        'dSortie
        '
        Me.dSortie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dSortie.Location = New System.Drawing.Point(70, 73)
        Me.dSortie.Name = "dSortie"
        Me.dSortie.ShowCheckBox = True
        Me.dSortie.Size = New System.Drawing.Size(101, 20)
        Me.dSortie.TabIndex = 67
        Me.dSortie.Tag = ""
        '
        'tSurface
        '
        Me.tSurface.Location = New System.Drawing.Point(71, 99)
        Me.tSurface.Name = "tSurface"
        Me.tSurface.Size = New System.Drawing.Size(100, 20)
        Me.tSurface.TabIndex = 68
        Me.tSurface.Tag = ""
        Me.tSurface.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lSurface
        '
        Me.lSurface.AutoSize = True
        Me.lSurface.Location = New System.Drawing.Point(20, 102)
        Me.lSurface.Name = "lSurface"
        Me.lSurface.Size = New System.Drawing.Size(44, 13)
        Me.lSurface.TabIndex = 69
        Me.lSurface.Text = "Surface"
        '
        'tSurftot
        '
        Me.tSurftot.AutoSize = True
        Me.tSurftot.Location = New System.Drawing.Point(177, 102)
        Me.tSurftot.Name = "tSurftot"
        Me.tSurftot.Size = New System.Drawing.Size(21, 13)
        Me.tSurftot.TabIndex = 70
        Me.tSurftot.Text = "m2"
        '
        'F_LocaLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 189)
        Me.Controls.Add(Me.tSurftot)
        Me.Controls.Add(Me.lSurface)
        Me.Controls.Add(Me.tSurface)
        Me.Controls.Add(Me.dSortie)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tLocatID)
        Me.Controls.Add(Me.tLotNom)
        Me.Controls.Add(Me.dEntre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tLotId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_LocaLot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location - Lot"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLotNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dEntre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tLocatID As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tLotId As System.Windows.Forms.TextBox
    Friend WithEvents dSortie As System.Windows.Forms.DateTimePicker
    Friend WithEvents lSurface As System.Windows.Forms.Label
    Friend WithEvents tSurface As System.Windows.Forms.TextBox
    Friend WithEvents tSurftot As System.Windows.Forms.Label
End Class
