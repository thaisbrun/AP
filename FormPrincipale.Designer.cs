namespace AP3_FormaFlix
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnAdministrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFormationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToutesLesFormationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommentairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerTousLesCommentairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendrePublicUnCommentaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.gestionDesFormationsToolStripMenuItem,
            this.gestionDesCommentairesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.reconnecterToolStripMenuItem,
            this.ajouterUnAdministrateurToolStripMenuItem,
            this.ajouterUnUtilisateurToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.connexionToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.DeconnexionToolStripMenuItem_Click);
            // 
            // reconnecterToolStripMenuItem
            // 
            this.reconnecterToolStripMenuItem.Name = "reconnecterToolStripMenuItem";
            this.reconnecterToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.reconnecterToolStripMenuItem.Text = "Reconnecter";
            this.reconnecterToolStripMenuItem.Click += new System.EventHandler(this.ReconnecterToolStripMenuItem_Click);
            // 
            // ajouterUnAdministrateurToolStripMenuItem
            // 
            this.ajouterUnAdministrateurToolStripMenuItem.Name = "ajouterUnAdministrateurToolStripMenuItem";
            this.ajouterUnAdministrateurToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.ajouterUnAdministrateurToolStripMenuItem.Text = "Ajouter un administrateur";
            this.ajouterUnAdministrateurToolStripMenuItem.Visible = false;
            this.ajouterUnAdministrateurToolStripMenuItem.Click += new System.EventHandler(this.AjouterUnAdministrateurToolStripMenuItem_Click);
            // 
            // gestionDesFormationsToolStripMenuItem
            // 
            this.gestionDesFormationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listerToutesLesFormationsToolStripMenuItem,
            this.ajouterUneFormationToolStripMenuItem,
            this.modifierUneFormationToolStripMenuItem});
            this.gestionDesFormationsToolStripMenuItem.Name = "gestionDesFormationsToolStripMenuItem";
            this.gestionDesFormationsToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.gestionDesFormationsToolStripMenuItem.Text = "Gestion des Formations";
            // 
            // listerToutesLesFormationsToolStripMenuItem
            // 
            this.listerToutesLesFormationsToolStripMenuItem.Name = "listerToutesLesFormationsToolStripMenuItem";
            this.listerToutesLesFormationsToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.listerToutesLesFormationsToolStripMenuItem.Text = "Lister toutes les formations";
            this.listerToutesLesFormationsToolStripMenuItem.Click += new System.EventHandler(this.ListerToutesLesFormationsToolStripMenuItem_Click);
            // 
            // ajouterUneFormationToolStripMenuItem
            // 
            this.ajouterUneFormationToolStripMenuItem.Name = "ajouterUneFormationToolStripMenuItem";
            this.ajouterUneFormationToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.ajouterUneFormationToolStripMenuItem.Text = "Ajouter une formation";
            this.ajouterUneFormationToolStripMenuItem.Click += new System.EventHandler(this.AjouterUneFormationToolStripMenuItem_Click);
            // 
            // modifierUneFormationToolStripMenuItem
            // 
            this.modifierUneFormationToolStripMenuItem.Name = "modifierUneFormationToolStripMenuItem";
            this.modifierUneFormationToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.modifierUneFormationToolStripMenuItem.Text = "Modifier/Supprimer une formation";
            this.modifierUneFormationToolStripMenuItem.Click += new System.EventHandler(this.ModifierSupprimerUneFormationToolStripMenuItem_Click);
            // 
            // gestionDesCommentairesToolStripMenuItem
            // 
            this.gestionDesCommentairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listerTousLesCommentairesToolStripMenuItem,
            this.rendrePublicUnCommentaireToolStripMenuItem});
            this.gestionDesCommentairesToolStripMenuItem.Name = "gestionDesCommentairesToolStripMenuItem";
            this.gestionDesCommentairesToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.gestionDesCommentairesToolStripMenuItem.Text = "Gestion des commentaires";
            // 
            // listerTousLesCommentairesToolStripMenuItem
            // 
            this.listerTousLesCommentairesToolStripMenuItem.Name = "listerTousLesCommentairesToolStripMenuItem";
            this.listerTousLesCommentairesToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.listerTousLesCommentairesToolStripMenuItem.Text = "Lister tous les commentaires";
            this.listerTousLesCommentairesToolStripMenuItem.Click += new System.EventHandler(this.listerTousLesCommentairesToolStripMenuItem_Click);
            // 
            // rendrePublicUnCommentaireToolStripMenuItem
            // 
            this.rendrePublicUnCommentaireToolStripMenuItem.Name = "rendrePublicUnCommentaireToolStripMenuItem";
            this.rendrePublicUnCommentaireToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.rendrePublicUnCommentaireToolStripMenuItem.Text = "Rendre public un commentaire";
            this.rendrePublicUnCommentaireToolStripMenuItem.Click += new System.EventHandler(this.rendrePublicUnCommentaireToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // ajouterUnUtilisateurToolStripMenuItem
            // 
            this.ajouterUnUtilisateurToolStripMenuItem.Name = "ajouterUnUtilisateurToolStripMenuItem";
            this.ajouterUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.ajouterUnUtilisateurToolStripMenuItem.Text = "Ajouter un utilisateur";
            this.ajouterUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnUtilisateurToolStripMenuItem_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMA\'FLIX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFormationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToutesLesFormationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommentairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerTousLesCommentairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendrePublicUnCommentaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnAdministrateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnUtilisateurToolStripMenuItem;
    }
}

