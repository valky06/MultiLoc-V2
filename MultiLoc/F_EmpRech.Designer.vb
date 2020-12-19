<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_EmpRech
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
        Me.trech = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gLot = New System.Windows.Forms.DataGridView()
        Me.empId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emplacement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gLot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trech
        '
        Me.trech.Location = New System.Drawing.Point(46, 7)
        Me.trech.Name = "trech"
        Me.trech.Size = New System.Drawing.Size(121, 20)
        Me.trech.TabIndex = 31
        Me.trech.Tag = "nom,t"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Nom"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.MultiLoc.My.Resources.Resources.smallsearch
        Me.Button1.Location = New System.Drawing.Point(173, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gLot
        '
        Me.gLot.AllowUserToAddRows = False
        Me.gLot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gLot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gLot.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gLot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gLot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gLot.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empId, Me.Emplacement})
        Me.gLot.Location = New System.Drawing.Point(14, 39)
        Me.gLot.MultiSelect = False
        Me.gLot.Name = "gLot"
        Me.gLot.ReadOnly = True
        Me.gLot.RowHeadersVisible = False
        Me.gLot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gLot.Size = New System.Drawing.Size(198, 320)
        Me.gLot.TabIndex = 34
        '
        'empId
        '
        Me.empId.HeaderText = "Id"
        Me.empId.Name = "empId"
        Me.empId.ReadOnly = True
        Me.empId.Visible = False
        '
        'Emplacement
        '
        Me.Emplacement.HeaderText = "Emplacement"
        Me.Emplacement.Name = "Emplacement"
        Me.Emplacement.ReadOnly = True
        '
        'F_EmpRech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 371)
        Me.Controls.Add(Me.gLot)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.trech)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "F_EmpRech"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche"
        CType(Me.gLot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents trech As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gLot As System.Windows.Forms.DataGridView
    Friend WithEvents proprioId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Emplacement As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
