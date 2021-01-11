<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_main))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.sLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mProprio = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoproToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLocataire = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnuaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppelDeLoyerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturesMensuellesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.GrandLivreLocataireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandLiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RèglementFournisseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilanLocataireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompteDépôtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FinDeBailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubriqueComptableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTBail = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeChargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeAdresseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTLocal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTPeriode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTRgt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTSociete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mParam = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiseÀJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturationSociétéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1136, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'sLabel
        '
        Me.sLabel.Name = "sLabel"
        Me.sLabel.Size = New System.Drawing.Size(27, 17)
        Me.sLabel.Text = "État"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mProprio, Me.CoproToolStripMenuItem, Me.mnuLot, Me.mnuLocataire, Me.AnnuaireToolStripMenuItem, Me.ClientMnu, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1136, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mProprio
        '
        Me.mProprio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mProprio.Name = "mProprio"
        Me.mProprio.Size = New System.Drawing.Size(62, 20)
        Me.mProprio.Text = "Sociétés"
        '
        'CoproToolStripMenuItem
        '
        Me.CoproToolStripMenuItem.Name = "CoproToolStripMenuItem"
        Me.CoproToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CoproToolStripMenuItem.Text = "Immeubles"
        '
        'mnuLot
        '
        Me.mnuLot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuLot.Name = "mnuLot"
        Me.mnuLot.Size = New System.Drawing.Size(41, 20)
        Me.mnuLot.Text = "Lots"
        '
        'mnuLocataire
        '
        Me.mnuLocataire.Name = "mnuLocataire"
        Me.mnuLocataire.Size = New System.Drawing.Size(72, 20)
        Me.mnuLocataire.Text = "Locataires"
        '
        'AnnuaireToolStripMenuItem
        '
        Me.AnnuaireToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AnnuaireToolStripMenuItem.Name = "AnnuaireToolStripMenuItem"
        Me.AnnuaireToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AnnuaireToolStripMenuItem.Text = "Annuaire"
        '
        'ClientMnu
        '
        Me.ClientMnu.Name = "ClientMnu"
        Me.ClientMnu.Size = New System.Drawing.Size(50, 20)
        Me.ClientMnu.Text = "Client"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppelDeLoyerToolStripMenuItem, Me.FacturationSociétéToolStripMenuItem, Me.FacturesMensuellesToolStripMenuItem, Me.ToolStripSeparator4, Me.GrandLivreLocataireToolStripMenuItem, Me.GrandLiToolStripMenuItem, Me.ToolStripSeparator3, Me.RèglementFournisseurToolStripMenuItem, Me.BilanLocataireToolStripMenuItem, Me.CompteDépôtToolStripMenuItem, Me.ToolStripSeparator2, Me.FinDeBailToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(87, 20)
        Me.ToolStripMenuItem2.Text = "Consultation"
        '
        'AppelDeLoyerToolStripMenuItem
        '
        Me.AppelDeLoyerToolStripMenuItem.Name = "AppelDeLoyerToolStripMenuItem"
        Me.AppelDeLoyerToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AppelDeLoyerToolStripMenuItem.Text = "Appels de Loyer"
        '
        'FacturesMensuellesToolStripMenuItem
        '
        Me.FacturesMensuellesToolStripMenuItem.Name = "FacturesMensuellesToolStripMenuItem"
        Me.FacturesMensuellesToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.FacturesMensuellesToolStripMenuItem.Text = "Facturation Locataire / Client"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(224, 6)
        '
        'GrandLivreLocataireToolStripMenuItem
        '
        Me.GrandLivreLocataireToolStripMenuItem.Name = "GrandLivreLocataireToolStripMenuItem"
        Me.GrandLivreLocataireToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.GrandLivreLocataireToolStripMenuItem.Text = "Grand Livre Locataire"
        '
        'GrandLiToolStripMenuItem
        '
        Me.GrandLiToolStripMenuItem.Name = "GrandLiToolStripMenuItem"
        Me.GrandLiToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.GrandLiToolStripMenuItem.Text = "Grand Livre Dépôt"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(224, 6)
        '
        'RèglementFournisseurToolStripMenuItem
        '
        Me.RèglementFournisseurToolStripMenuItem.Name = "RèglementFournisseurToolStripMenuItem"
        Me.RèglementFournisseurToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.RèglementFournisseurToolStripMenuItem.Text = "Balance Fournisseurs"
        '
        'BilanLocataireToolStripMenuItem
        '
        Me.BilanLocataireToolStripMenuItem.Name = "BilanLocataireToolStripMenuItem"
        Me.BilanLocataireToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.BilanLocataireToolStripMenuItem.Text = "Balance Clients / Locataires"
        '
        'CompteDépôtToolStripMenuItem
        '
        Me.CompteDépôtToolStripMenuItem.Name = "CompteDépôtToolStripMenuItem"
        Me.CompteDépôtToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.CompteDépôtToolStripMenuItem.Text = "Balance Dépôt Gar."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(224, 6)
        '
        'FinDeBailToolStripMenuItem
        '
        Me.FinDeBailToolStripMenuItem.Name = "FinDeBailToolStripMenuItem"
        Me.FinDeBailToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.FinDeBailToolStripMenuItem.Text = "Fin de Bail"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndicesToolStripMenuItem, Me.RubriqueComptableToolStripMenuItem, Me.mnuTBail, Me.TypeChargeToolStripMenuItem, Me.TypeAdresseToolStripMenuItem, Me.mnuTLocal, Me.mnuTPeriode, Me.mnuTRgt, Me.mnuTSociete, Me.ToolStripSeparator1, Me.mParam, Me.MiseÀJourToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(78, 20)
        Me.ToolStripMenuItem1.Text = "Paramètres"
        '
        'IndicesToolStripMenuItem
        '
        Me.IndicesToolStripMenuItem.Name = "IndicesToolStripMenuItem"
        Me.IndicesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.IndicesToolStripMenuItem.Text = "Indices"
        '
        'RubriqueComptableToolStripMenuItem
        '
        Me.RubriqueComptableToolStripMenuItem.Name = "RubriqueComptableToolStripMenuItem"
        Me.RubriqueComptableToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RubriqueComptableToolStripMenuItem.Text = "Catégorie Comptable"
        '
        'mnuTBail
        '
        Me.mnuTBail.Name = "mnuTBail"
        Me.mnuTBail.Size = New System.Drawing.Size(187, 22)
        Me.mnuTBail.Text = "Type Bail"
        '
        'TypeChargeToolStripMenuItem
        '
        Me.TypeChargeToolStripMenuItem.Name = "TypeChargeToolStripMenuItem"
        Me.TypeChargeToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TypeChargeToolStripMenuItem.Text = "Type Charge Copro"
        '
        'TypeAdresseToolStripMenuItem
        '
        Me.TypeAdresseToolStripMenuItem.Name = "TypeAdresseToolStripMenuItem"
        Me.TypeAdresseToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TypeAdresseToolStripMenuItem.Text = "Type Contact"
        '
        'mnuTLocal
        '
        Me.mnuTLocal.Name = "mnuTLocal"
        Me.mnuTLocal.Size = New System.Drawing.Size(187, 22)
        Me.mnuTLocal.Text = "Type Local"
        '
        'mnuTPeriode
        '
        Me.mnuTPeriode.Name = "mnuTPeriode"
        Me.mnuTPeriode.Size = New System.Drawing.Size(187, 22)
        Me.mnuTPeriode.Text = "Type Période"
        '
        'mnuTRgt
        '
        Me.mnuTRgt.Name = "mnuTRgt"
        Me.mnuTRgt.Size = New System.Drawing.Size(187, 22)
        Me.mnuTRgt.Text = "Type Règlement"
        '
        'mnuTSociete
        '
        Me.mnuTSociete.Name = "mnuTSociete"
        Me.mnuTSociete.Size = New System.Drawing.Size(187, 22)
        Me.mnuTSociete.Text = "Type Société"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'mParam
        '
        Me.mParam.Image = Global.MultiLoc.My.Resources.Resources.param
        Me.mParam.Name = "mParam"
        Me.mParam.Size = New System.Drawing.Size(187, 22)
        Me.mParam.Text = "Paramètres"
        '
        'MiseÀJourToolStripMenuItem
        '
        Me.MiseÀJourToolStripMenuItem.Name = "MiseÀJourToolStripMenuItem"
        Me.MiseÀJourToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.MiseÀJourToolStripMenuItem.Text = "Mise à jour"
        '
        'FacturationSociétéToolStripMenuItem
        '
        Me.FacturationSociétéToolStripMenuItem.Name = "FacturationSociétéToolStripMenuItem"
        Me.FacturationSociétéToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.FacturationSociétéToolStripMenuItem.Text = "Facturation Société"
        '
        'F_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1136, 536)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_main"
        Me.Text = "MultiLoc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents sLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mProprio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLot As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLocataire As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnuaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppelDeLoyerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoproToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTBail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTSociete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTLocal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mParam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTPeriode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTRgt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IndicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RèglementFournisseurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClientMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompteDépôtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BilanLocataireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacturesMensuellesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrandLiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiseÀJourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrandLivreLocataireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeAdresseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeChargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubriqueComptableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FinDeBailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturationSociétéToolStripMenuItem As ToolStripMenuItem
End Class
