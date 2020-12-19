<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_locaEncaissement
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tHT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tLib = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.dDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lCptBk = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tTVA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tTTC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sTVA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sHT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sTTC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Encaissement HT"
        '
        'tHT
        '
        Me.tHT.Location = New System.Drawing.Point(109, 133)
        Me.tHT.Name = "tHT"
        Me.tHT.Size = New System.Drawing.Size(88, 20)
        Me.tHT.TabIndex = 3
        Me.tHT.Tag = ""
        Me.tHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'tLib
        '
        Me.tLib.BackColor = System.Drawing.Color.White
        Me.tLib.Location = New System.Drawing.Point(106, 65)
        Me.tLib.Name = "tLib"
        Me.tLib.Size = New System.Drawing.Size(344, 20)
        Me.tLib.TabIndex = 2
        Me.tLib.Tag = "ecrLib,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Libellé"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(15, 178)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 7
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(375, 178)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 4
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'dDate
        '
        Me.dDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dDate.Location = New System.Drawing.Point(106, 39)
        Me.dDate.Name = "dDate"
        Me.dDate.Size = New System.Drawing.Size(101, 20)
        Me.dDate.TabIndex = 1
        Me.dDate.Tag = "ecrDate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Compte Bancaire"
        '
        'lCptBk
        '
        Me.lCptBk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCptBk.FormattingEnabled = True
        Me.lCptBk.Location = New System.Drawing.Point(106, 12)
        Me.lCptBk.Name = "lCptBk"
        Me.lCptBk.Size = New System.Drawing.Size(344, 21)
        Me.lCptBk.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "TVA"
        '
        'tTVA
        '
        Me.tTVA.Location = New System.Drawing.Point(235, 133)
        Me.tTVA.Name = "tTVA"
        Me.tTVA.Size = New System.Drawing.Size(88, 20)
        Me.tTVA.TabIndex = 4
        Me.tTVA.Tag = ""
        Me.tTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "TTC"
        '
        'tTTC
        '
        Me.tTTC.Location = New System.Drawing.Point(363, 133)
        Me.tTTC.Name = "tTTC"
        Me.tTTC.Size = New System.Drawing.Size(87, 20)
        Me.tTTC.TabIndex = 3
        Me.tTTC.Tag = ""
        Me.tTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(203, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "TVA"
        '
        'sTVA
        '
        Me.sTVA.Location = New System.Drawing.Point(235, 104)
        Me.sTVA.Name = "sTVA"
        Me.sTVA.ReadOnly = True
        Me.sTVA.Size = New System.Drawing.Size(88, 20)
        Me.sTVA.TabIndex = 45
        Me.sTVA.TabStop = False
        Me.sTVA.Tag = ""
        Me.sTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Solde HT"
        '
        'sHT
        '
        Me.sHT.Location = New System.Drawing.Point(109, 104)
        Me.sHT.Name = "sHT"
        Me.sHT.ReadOnly = True
        Me.sHT.Size = New System.Drawing.Size(88, 20)
        Me.sHT.TabIndex = 44
        Me.sHT.TabStop = False
        Me.sHT.Tag = ""
        Me.sHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "TTC"
        '
        'sTTC
        '
        Me.sTTC.Location = New System.Drawing.Point(363, 104)
        Me.sTTC.Name = "sTTC"
        Me.sTTC.ReadOnly = True
        Me.sTTC.Size = New System.Drawing.Size(87, 20)
        Me.sTTC.TabIndex = 46
        Me.sTTC.TabStop = False
        Me.sTTC.Tag = ""
        Me.sTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_locaEncaissement
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(472, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sTTC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sTVA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.sHT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tTTC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tTVA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lCptBk)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tLib)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dDate)
        Me.Controls.Add(Me.tHT)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_locaEncaissement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encaissement Locataire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLib As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents dDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lCptBk As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents sHT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sTTC As System.Windows.Forms.TextBox
End Class
