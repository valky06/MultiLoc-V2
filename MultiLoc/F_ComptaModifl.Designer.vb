<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ComptaModif
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
        Me.tMontTVA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tMontHT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tMontTTC = New System.Windows.Forms.TextBox()
        Me.cCategorie = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tAnneeEff = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dEcheance = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tnumpiece = New System.Windows.Forms.TextBox()
        Me.tINdexPiece = New System.Windows.Forms.TextBox()
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
        Me.tLib.Location = New System.Drawing.Point(97, 64)
        Me.tLib.Name = "tLib"
        Me.tLib.Size = New System.Drawing.Size(253, 20)
        Me.tLib.TabIndex = 2
        Me.tLib.TabStop = False
        Me.tLib.Tag = "ecrLib,to"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Libellé"
        '
        'bAnnul
        '
        Me.bAnnul.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bAnnul.Location = New System.Drawing.Point(30, 186)
        Me.bAnnul.Name = "bAnnul"
        Me.bAnnul.Size = New System.Drawing.Size(75, 31)
        Me.bAnnul.TabIndex = 8
        Me.bAnnul.Text = "Annuler"
        Me.bAnnul.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bOK.Location = New System.Drawing.Point(275, 186)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(75, 31)
        Me.bOK.TabIndex = 7
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
        Me.Label9.Location = New System.Drawing.Point(122, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "HT"
        '
        'tMontTVA
        '
        Me.tMontTVA.Location = New System.Drawing.Point(182, 139)
        Me.tMontTVA.Name = "tMontTVA"
        Me.tMontTVA.Size = New System.Drawing.Size(81, 20)
        Me.tMontTVA.TabIndex = 5
        Me.tMontTVA.Tag = "ecrMontantTVA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Montant"
        '
        'tMontHT
        '
        Me.tMontHT.Location = New System.Drawing.Point(95, 138)
        Me.tMontHT.Name = "tMontHT"
        Me.tMontHT.Size = New System.Drawing.Size(81, 20)
        Me.tMontHT.TabIndex = 6
        Me.tMontHT.Tag = "ecrMontantHT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(297, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "TTC"
        '
        'tMontTTC
        '
        Me.tMontTTC.Location = New System.Drawing.Point(269, 139)
        Me.tMontTTC.Name = "tMontTTC"
        Me.tMontTTC.Size = New System.Drawing.Size(81, 20)
        Me.tMontTTC.TabIndex = 4
        Me.tMontTTC.Tag = "ecrMontantTTC"
        '
        'cCategorie
        '
        Me.cCategorie.FormattingEnabled = True
        Me.cCategorie.Items.AddRange(New Object() {"APPELDG", "AVOIRDG", "CHARGE", "DECAISSEMENT", "ENCAISSEMENT", "LOYER", "PROVCHARGE", "REGULPROV", "REGULREEL", "REPRISEDG"})
        Me.cCategorie.Location = New System.Drawing.Point(97, 91)
        Me.cCategorie.Name = "cCategorie"
        Me.cCategorie.Size = New System.Drawing.Size(253, 21)
        Me.cCategorie.TabIndex = 3
        Me.cCategorie.Tag = "Categorie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Catégorie"
        '
        'tAnneeEff
        '
        Me.tAnneeEff.Location = New System.Drawing.Point(289, 13)
        Me.tAnneeEff.Name = "tAnneeEff"
        Me.tAnneeEff.Size = New System.Drawing.Size(61, 20)
        Me.tAnneeEff.TabIndex = 1
        Me.tAnneeEff.Tag = "anneeEffet,to"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Année Effet"
        '
        'dEcheance
        '
        Me.dEcheance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dEcheance.Location = New System.Drawing.Point(97, 38)
        Me.dEcheance.Name = "dEcheance"
        Me.dEcheance.Size = New System.Drawing.Size(101, 20)
        Me.dEcheance.TabIndex = 76
        Me.dEcheance.Tag = "ecrEcheance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Echéance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "TVA"
        '
        'tnumpiece
        '
        Me.tnumpiece.Location = New System.Drawing.Point(125, 177)
        Me.tnumpiece.Name = "tnumpiece"
        Me.tnumpiece.Size = New System.Drawing.Size(112, 20)
        Me.tnumpiece.TabIndex = 79
        Me.tnumpiece.Tag = "Numpiece"
        Me.tnumpiece.Visible = False
        '
        'tINdexPiece
        '
        Me.tINdexPiece.Location = New System.Drawing.Point(125, 203)
        Me.tINdexPiece.Name = "tINdexPiece"
        Me.tINdexPiece.Size = New System.Drawing.Size(61, 20)
        Me.tINdexPiece.TabIndex = 80
        Me.tINdexPiece.Tag = "indexpiece"
        Me.tINdexPiece.Visible = False
        '
        'F_ComptaModif
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bAnnul
        Me.ClientSize = New System.Drawing.Size(385, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.tINdexPiece)
        Me.Controls.Add(Me.tnumpiece)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dEcheance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tAnneeEff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cCategorie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tMontTTC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tMontTVA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tMontHT)
        Me.Controls.Add(Me.bAnnul)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.tLib)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dDate)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "F_ComptaModif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modification Compta"
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
    Friend WithEvents tMontTVA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tMontHT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tMontTTC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tAnneeEff As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cCategorie As System.Windows.Forms.ComboBox
    Friend WithEvents dEcheance As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tINdexPiece As System.Windows.Forms.TextBox
    Friend WithEvents tnumpiece As System.Windows.Forms.TextBox
End Class
