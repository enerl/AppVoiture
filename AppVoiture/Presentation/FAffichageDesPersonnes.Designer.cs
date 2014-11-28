namespace Presentation
{
    partial class FAffichageDesPersonnes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_FADP = new System.Windows.Forms.DataGridView();
            this.CB_FADP_Trier = new System.Windows.Forms.ComboBox();
            this.CB_FADP_Personne = new System.Windows.Forms.ComboBox();
            this.BTN_FADP_Fermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FADP)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_FADP
            // 
            this.DGV_FADP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_FADP.Location = new System.Drawing.Point(30, 94);
            this.DGV_FADP.Name = "DGV_FADP";
            this.DGV_FADP.Size = new System.Drawing.Size(765, 245);
            this.DGV_FADP.TabIndex = 34;
            // 
            // CB_FADP_Trier
            // 
            this.CB_FADP_Trier.FormattingEnabled = true;
            this.CB_FADP_Trier.Location = new System.Drawing.Point(584, 58);
            this.CB_FADP_Trier.Name = "CB_FADP_Trier";
            this.CB_FADP_Trier.Size = new System.Drawing.Size(195, 21);
            this.CB_FADP_Trier.TabIndex = 33;
            // 
            // CB_FADP_Personne
            // 
            this.CB_FADP_Personne.FormattingEnabled = true;
            this.CB_FADP_Personne.Location = new System.Drawing.Point(228, 58);
            this.CB_FADP_Personne.Name = "CB_FADP_Personne";
            this.CB_FADP_Personne.Size = new System.Drawing.Size(195, 21);
            this.CB_FADP_Personne.TabIndex = 32;
            // 
            // BTN_FADP_Fermer
            // 
            this.BTN_FADP_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FADP_Fermer.Location = new System.Drawing.Point(316, 345);
            this.BTN_FADP_Fermer.Name = "BTN_FADP_Fermer";
            this.BTN_FADP_Fermer.Size = new System.Drawing.Size(90, 33);
            this.BTN_FADP_Fermer.TabIndex = 31;
            this.BTN_FADP_Fermer.Text = "Fermer";
            this.BTN_FADP_Fermer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Trier sur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nom de la personne :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Affichage des personnes";
            // 
            // FAffichageDesPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 388);
            this.Controls.Add(this.DGV_FADP);
            this.Controls.Add(this.CB_FADP_Trier);
            this.Controls.Add(this.CB_FADP_Personne);
            this.Controls.Add(this.BTN_FADP_Fermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAffichageDesPersonne";
            this.Text = "FAffichageDesPersonne";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FADP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_FADP;
        private System.Windows.Forms.ComboBox CB_FADP_Trier;
        private System.Windows.Forms.ComboBox CB_FADP_Personne;
        private System.Windows.Forms.Button BTN_FADP_Fermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}