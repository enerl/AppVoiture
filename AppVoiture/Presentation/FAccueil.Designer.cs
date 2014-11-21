namespace Presentation
{
    partial class FAccueil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnePersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnePersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.louerUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendreUneVoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesVoituresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toutesLesPersonnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(139, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue dans l\'agence VOITURE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(33, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.voiture;
            this.pictureBox1.Location = new System.Drawing.Point(159, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 322);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voituresToolStripMenuItem,
            this.personnesToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // voituresToolStripMenuItem
            // 
            this.voituresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneVoitureToolStripMenuItem,
            this.supprimerUneVoitureToolStripMenuItem});
            this.voituresToolStripMenuItem.Name = "voituresToolStripMenuItem";
            this.voituresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.voituresToolStripMenuItem.Text = "Voitures";
            // 
            // ajouterUneVoitureToolStripMenuItem
            // 
            this.ajouterUneVoitureToolStripMenuItem.Name = "ajouterUneVoitureToolStripMenuItem";
            this.ajouterUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUneVoitureToolStripMenuItem.Text = "Ajouter une voiture";
            this.ajouterUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneVoitureToolStripMenuItem_Click);
            // 
            // supprimerUneVoitureToolStripMenuItem
            // 
            this.supprimerUneVoitureToolStripMenuItem.Name = "supprimerUneVoitureToolStripMenuItem";
            this.supprimerUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.supprimerUneVoitureToolStripMenuItem.Text = "Supprimer une voiture";
            this.supprimerUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneVoitureToolStripMenuItem_Click);
            // 
            // personnesToolStripMenuItem
            // 
            this.personnesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnePersonneToolStripMenuItem,
            this.supprimerUnePersonneToolStripMenuItem});
            this.personnesToolStripMenuItem.Name = "personnesToolStripMenuItem";
            this.personnesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personnesToolStripMenuItem.Text = "Personnes";
            // 
            // ajouterUnePersonneToolStripMenuItem
            // 
            this.ajouterUnePersonneToolStripMenuItem.Name = "ajouterUnePersonneToolStripMenuItem";
            this.ajouterUnePersonneToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ajouterUnePersonneToolStripMenuItem.Text = "Ajouter une personne";
            this.ajouterUnePersonneToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnePersonneToolStripMenuItem_Click);
            // 
            // supprimerUnePersonneToolStripMenuItem
            // 
            this.supprimerUnePersonneToolStripMenuItem.Name = "supprimerUnePersonneToolStripMenuItem";
            this.supprimerUnePersonneToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.supprimerUnePersonneToolStripMenuItem.Text = "Supprimer une personne";
            this.supprimerUnePersonneToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnePersonneToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.louerUneVoitureToolStripMenuItem,
            this.rendreUneVoitureToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // louerUneVoitureToolStripMenuItem
            // 
            this.louerUneVoitureToolStripMenuItem.Name = "louerUneVoitureToolStripMenuItem";
            this.louerUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.louerUneVoitureToolStripMenuItem.Text = "Louer une voiture";
            this.louerUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.louerUneVoitureToolStripMenuItem_Click);
            // 
            // rendreUneVoitureToolStripMenuItem
            // 
            this.rendreUneVoitureToolStripMenuItem.Name = "rendreUneVoitureToolStripMenuItem";
            this.rendreUneVoitureToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rendreUneVoitureToolStripMenuItem.Text = "Rendre une voiture";
            this.rendreUneVoitureToolStripMenuItem.Click += new System.EventHandler(this.rendreUneVoitureToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toutesLesVoituresToolStripMenuItem,
            this.toutesLesPersonnesToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // toutesLesVoituresToolStripMenuItem
            // 
            this.toutesLesVoituresToolStripMenuItem.Name = "toutesLesVoituresToolStripMenuItem";
            this.toutesLesVoituresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.toutesLesVoituresToolStripMenuItem.Text = "Toutes les voitures";
            this.toutesLesVoituresToolStripMenuItem.Click += new System.EventHandler(this.toutesLesVoituresToolStripMenuItem_Click);
            // 
            // toutesLesPersonnesToolStripMenuItem
            // 
            this.toutesLesPersonnesToolStripMenuItem.Name = "toutesLesPersonnesToolStripMenuItem";
            this.toutesLesPersonnesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.toutesLesPersonnesToolStripMenuItem.Text = "Toutes les personnes";
            this.toutesLesPersonnesToolStripMenuItem.Click += new System.EventHandler(this.toutesLesPersonnesToolStripMenuItem_Click);
            // 
            // FAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAccueil";
            this.Text = "FAccueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnePersonneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnePersonneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem louerUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendreUneVoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesVoituresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toutesLesPersonnesToolStripMenuItem;
    }
}

