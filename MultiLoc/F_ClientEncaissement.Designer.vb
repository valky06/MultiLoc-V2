<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ClientEncaissement
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tLib = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bAnnul = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.dReglt = New System.Windows.Forms.DateTimePicker()
        Me.lCptBk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lFacture = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sTTC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sTVA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sHT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tTTC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tTVA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tHT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Montant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date"
        '
        'tLib
        '
        Me.tLib.BackColor = System.Drawing.Color.White
        Me.tLib.Location = New System.Drawing.Point(106, 147)
        Me.tLib.Name = "tLib"
        Me.tLib.Size = New System.Drawing.Size(341, 20)
        Me.tLib.TabIndex = 2
        Me.tLib.Tag = "ecrLib,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Libellé"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(25, 184)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 4
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Location = New System.Drawing.Point(372, 184)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 3
        Me.bOK.Text = "Enregistrer"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'dReglt
        '
        Me.dReglt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dReglt.Location = New System.Drawing.Point(106, 121)
        Me.dReglt.Name = "dReglt"
        Me.dReglt.Size = New System.Drawing.Size(101, 20)
        Me.dReglt.TabIndex = 0
        Me.dReglt.Tag = "ecrDate"
        '
        'lCptBk
        '
        Me.lCptBk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lCptBk.FormattingEnabled = True
        Me.lCptBk.Location = New System.Drawing.Point(106, 94)
        Me.lCptBk.Name = "lCptBk"
        Me.lCptBk.Size = New System.Drawing.Size(341, 21)
        Me.lCptBk.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Compte Bancaire"
        '
        'lFacture
        '
        Me.lFacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lFacture.FormattingEnabled = True
        Me.lFacture.Location = New System.Drawing.Point(105, 12)
        Me.lFacture.Name = "lFacture"
        Me.lFacture.Size = New System.Drawing.Size(215, 21)
        Me.lFacture.TabIndex = 98
        Me.lFacture.Tag = "socid,co"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Facture"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "TTC"
        '
        'sTTC
        '
        Me.sTTC.Location = New System.Drawing.Point(360, 39)
        Me.sTTC.Name = "sTTC"
        Me.sTTC.ReadOnly = True
        Me.sTTC.Size = New System.Drawing.Size(87, 20)
        Me.sTTC.TabIndex = 108
        Me.sTTC.TabStop = False
        Me.sTTC.Tag = ""
        Me.sTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "TVA"
        '
        'sTVA
        '
        Me.sTVA.Location = New System.Drawing.Point(232, 39)
        Me.sTVA.Name = "sTVA"
        Me.sTVA.ReadOnly = True
        Me.sTVA.Size = New System.Drawing.Size(88, 20)
        Me.sTVA.TabIndex = 107
        Me.sTVA.TabStop = False
        Me.sTVA.Tag = ""
        Me.sTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Solde HT"
        '
        'sHT
        '
        Me.sHT.Location = New System.Drawing.Point(106, 39)
        Me.sHT.Name = "sHT"
        Me.sHT.ReadOnly = True
        Me.sHT.Size = New System.Drawing.Size(88, 20)
        Me.sHT.TabIndex = 106
        Me.sHT.TabStop = False
        Me.sHT.Tag = ""
        Me.sHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "TTC"
        '
        'tTTC
        '
        Me.tTTC.Location = New System.Drawing.Point(360, 68)
        Me.tTTC.Name = "tTTC"
        Me.tTTC.Size = New System.Drawing.Size(87, 20)
        Me.tTTC.TabIndex = 100
        Me.tTTC.Tag = ""
        Me.tTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "TVA"
        '
        'tTVA
        '
        Me.tTVA.Location = New System.Drawing.Point(232, 68)
        Me.tTVA.Name = "tTVA"
        Me.tTVA.Size = New System.Drawing.Size(88, 20)
        Me.tTVA.TabIndex = 102
        Me.tTVA.Tag = ""
        Me.tTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Encaissement HT"
        '
        'tHT
        '
        Me.tHT.Location = New System.Drawing.Point(106, 68)
        Me.tHT.Name = "tHT"
        Me.tHT.Size = New System.Drawing.Size(88, 20)
        Me.tHT.TabIndex = 101
        Me.tHT.Tag = ""
        Me.tHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'F_ClientEncaissement
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(481, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sTTC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sTVA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.sHT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tTTC)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tTVA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tHT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lFacture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lCptBk)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tLib)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dReglt)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_ClientEncaissement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encaissement Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tLib As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bAnnul As System.Windows.Forms.Button
    Friend WithEvents bOK As System.Windows.Forms.Button
    Friend WithEvents dReglt As System.Windows.Forms.DateTimePicker
    Friend WithEvents lCptBk As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lFacture As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sTTC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents sTVA As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents sHT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tTTC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tTVA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tHT As TextBox
End Class
