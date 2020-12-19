<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Lot
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
        Me.gLot = New System.Windows.Forms.GroupBox()
        Me.tCoproId = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.tSocId = New System.Windows.Forms.TextBox()
        Me.tBatiment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tLotId = New System.Windows.Forms.TextBox()
        Me.lTypeLocal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tLot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gLot.SuspendLayout()
        Me.SuspendLayout()
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(13, 186)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 1
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bEnreg
        '
        Me.bEnreg.Location = New System.Drawing.Point(253, 186)
        Me.bEnreg.Name = "bEnreg"
        Me.bEnreg.Size = New System.Drawing.Size(75, 31)
        Me.bEnreg.TabIndex = 0
        Me.bEnreg.Text = "Enregistrer"
        Me.bEnreg.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'gLot
        '
        Me.gLot.Controls.Add(Me.tCoproId)
        Me.gLot.Controls.Add(Me.LinkLabel2)
        Me.gLot.Controls.Add(Me.tSocId)
        Me.gLot.Controls.Add(Me.tBatiment)
        Me.gLot.Controls.Add(Me.Label8)
        Me.gLot.Controls.Add(Me.tLotId)
        Me.gLot.Controls.Add(Me.lTypeLocal)
        Me.gLot.Controls.Add(Me.Label4)
        Me.gLot.Controls.Add(Me.Label2)
        Me.gLot.Controls.Add(Me.Label1)
        Me.gLot.Controls.Add(Me.TextBox4)
        Me.gLot.Controls.Add(Me.TextBox3)
        Me.gLot.Controls.Add(Me.TextBox2)
        Me.gLot.Controls.Add(Me.tLot)
        Me.gLot.Controls.Add(Me.Label3)
        Me.gLot.Location = New System.Drawing.Point(13, 12)
        Me.gLot.Name = "gLot"
        Me.gLot.Size = New System.Drawing.Size(315, 158)
        Me.gLot.TabIndex = 9
        Me.gLot.TabStop = False
        '
        'tCoproId
        '
        Me.tCoproId.Location = New System.Drawing.Point(207, 120)
        Me.tCoproId.Name = "tCoproId"
        Me.tCoproId.ReadOnly = True
        Me.tCoproId.Size = New System.Drawing.Size(37, 20)
        Me.tCoproId.TabIndex = 47
        Me.tCoproId.Tag = "coproId,n"
        Me.tCoproId.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(7, 74)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel2.TabIndex = 46
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Type Local"
        '
        'tSocId
        '
        Me.tSocId.Location = New System.Drawing.Point(164, 120)
        Me.tSocId.Name = "tSocId"
        Me.tSocId.ReadOnly = True
        Me.tSocId.Size = New System.Drawing.Size(37, 20)
        Me.tSocId.TabIndex = 24
        Me.tSocId.Tag = "socId,t"
        Me.tSocId.Visible = False
        '
        'tBatiment
        '
        Me.tBatiment.Location = New System.Drawing.Point(73, 19)
        Me.tBatiment.Name = "tBatiment"
        Me.tBatiment.Size = New System.Drawing.Size(227, 20)
        Me.tBatiment.TabIndex = 0
        Me.tBatiment.Tag = "batiment,t"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Batiment"
        '
        'tLotId
        '
        Me.tLotId.Location = New System.Drawing.Point(263, 120)
        Me.tLotId.Name = "tLotId"
        Me.tLotId.ReadOnly = True
        Me.tLotId.Size = New System.Drawing.Size(37, 20)
        Me.tLotId.TabIndex = 17
        Me.tLotId.Tag = "lotid,k"
        Me.tLotId.Visible = False
        '
        'lTypeLocal
        '
        Me.lTypeLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lTypeLocal.FormattingEnabled = True
        Me.lTypeLocal.Location = New System.Drawing.Point(73, 71)
        Me.lTypeLocal.Name = "lTypeLocal"
        Me.lTypeLocal.Size = New System.Drawing.Size(227, 21)
        Me.lTypeLocal.Sorted = True
        Me.lTypeLocal.TabIndex = 3
        Me.lTypeLocal.Tag = "TlocalId,no"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Niveau"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Surface"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Millième"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(241, 46)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(59, 20)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Tag = "niveau,t"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(73, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(61, 20)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Tag = "milliemes,n"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(73, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(61, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Tag = "surface,n"
        '
        'tLot
        '
        Me.tLot.Location = New System.Drawing.Point(73, 45)
        Me.tLot.Name = "tLot"
        Me.tLot.Size = New System.Drawing.Size(101, 20)
        Me.tLot.TabIndex = 1
        Me.tLot.Tag = "lotnom,to"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lot"
        '
        'F_lot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 232)
        Me.Controls.Add(Me.gLot)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bEnreg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_lot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lot"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gLot.ResumeLayout(False)
        Me.gLot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bEnreg As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents gLot As System.Windows.Forms.GroupBox
    Friend WithEvents tSocId As System.Windows.Forms.TextBox
    Friend WithEvents tBatiment As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tLotId As System.Windows.Forms.TextBox
    Friend WithEvents lTypeLocal As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tLot As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents tCoproId As System.Windows.Forms.TextBox
End Class
