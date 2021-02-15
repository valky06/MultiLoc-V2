<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LocaDG
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tLib = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tDGHT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tDGTTC = New System.Windows.Forms.TextBox()
        Me.tLoyer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tNbMois = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tTVA = New System.Windows.Forms.TextBox()
        Me.tLoyerHTTTC = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'tLib
        '
        Me.tLib.BackColor = System.Drawing.Color.White
        Me.tLib.Location = New System.Drawing.Point(97, 38)
        Me.tLib.Name = "tLib"
        Me.tLib.Size = New System.Drawing.Size(253, 20)
        Me.tLib.TabIndex = 1
        Me.tLib.TabStop = False
        Me.tLib.Tag = "ecrLib,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Libellé"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(30, 190)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 9
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bOK.Location = New System.Drawing.Point(275, 190)
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
        'dDate
        '
        Me.dDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDate.Location = New System.Drawing.Point(97, 12)
        Me.dDate.Name = "dDate"
        Me.dDate.Size = New System.Drawing.Size(101, 20)
        Me.dDate.TabIndex = 0
        Me.dDate.Tag = "ecrDate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Montant HT"
        '
        'tDGHT
        '
        Me.tDGHT.Location = New System.Drawing.Point(97, 142)
        Me.tDGHT.Name = "tDGHT"
        Me.tDGHT.Size = New System.Drawing.Size(81, 20)
        Me.tDGHT.TabIndex = 6
        Me.tDGHT.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Montant TTC"
        '
        'tDGTTC
        '
        Me.tDGTTC.Location = New System.Drawing.Point(269, 145)
        Me.tDGTTC.Name = "tDGTTC"
        Me.tDGTTC.ReadOnly = True
        Me.tDGTTC.Size = New System.Drawing.Size(81, 20)
        Me.tDGTTC.TabIndex = 7
        Me.tDGTTC.Tag = ""
        '
        'tLoyer
        '
        Me.tLoyer.Location = New System.Drawing.Point(97, 64)
        Me.tLoyer.Name = "tLoyer"
        Me.tLoyer.Size = New System.Drawing.Size(81, 20)
        Me.tLoyer.TabIndex = 2
        Me.tLoyer.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Loyer/ An"
        '
        'tNbMois
        '
        Me.tNbMois.Location = New System.Drawing.Point(97, 90)
        Me.tNbMois.Name = "tNbMois"
        Me.tNbMois.Size = New System.Drawing.Size(42, 20)
        Me.tNbMois.TabIndex = 3
        Me.tNbMois.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Nb Mois"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Taux TVA"
        '
        'tTVA
        '
        Me.tTVA.Location = New System.Drawing.Point(97, 116)
        Me.tTVA.Name = "tTVA"
        Me.tTVA.Size = New System.Drawing.Size(43, 20)
        Me.tTVA.TabIndex = 4
        Me.tTVA.Tag = ""
        '
        'tLoyerHTTTC
        '
        Me.tLoyerHTTTC.AutoSize = True
        Me.tLoyerHTTTC.Location = New System.Drawing.Point(184, 67)
        Me.tLoyerHTTTC.Name = "tLoyerHTTTC"
        Me.tLoyerHTTTC.Size = New System.Drawing.Size(22, 13)
        Me.tLoyerHTTTC.TabIndex = 72
        Me.tLoyerHTTTC.Text = "HT"
        '
        'F_LocaDG
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(385, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.tLoyerHTTTC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tTVA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tNbMois)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tLoyer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tDGHT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tDGTTC)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tLib)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dDate)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_LocaDG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dépôt Garantie"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLib As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tDGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tDGTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tNbMois As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tLoyer As System.Windows.Forms.TextBox
    Friend WithEvents tLoyerHTTTC As System.Windows.Forms.Label
End Class
