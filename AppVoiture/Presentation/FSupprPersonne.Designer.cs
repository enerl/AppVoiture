namespace Presentation
{
    partial class FSupprPersonne
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
            this.BTN_FSP_Fermer = new System.Windows.Forms.Button();
            this.BTN_FSP_Supprimer = new System.Windows.Forms.Button();
            this.TB_FSP_Prenom = new System.Windows.Forms.TextBox();
            this.TB_FSP_Ville = new System.Windows.Forms.TextBox();
            this.TB_FSP_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_FSP_Personne = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_FSP_Fermer
            // 
            this.BTN_FSP_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FSP_Fermer.Location = new System.Drawing.Point(325, 339);
            this.BTN_FSP_Fermer.Name = "BTN_FSP_Fermer";
            this.BTN_FSP_Fermer.Size = new System.Drawing.Size(90, 33);
            this.BTN_FSP_Fermer.TabIndex = 17;
            this.BTN_FSP_Fermer.Text = "Fermer";
            this.BTN_FSP_Fermer.UseVisualStyleBackColor = true;
            this.BTN_FSP_Fermer.Click += new System.EventHandler(this.BTN_FSP_Fermer_Click);
            // 
            // BTN_FSP_Supprimer
            // 
            this.BTN_FSP_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FSP_Supprimer.Location = new System.Drawing.Point(171, 339);
            this.BTN_FSP_Supprimer.Name = "BTN_FSP_Supprimer";
            this.BTN_FSP_Supprimer.Size = new System.Drawing.Size(114, 33);
            this.BTN_FSP_Supprimer.TabIndex = 16;
            this.BTN_FSP_Supprimer.Text = "Supprimer";
            this.BTN_FSP_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_FSP_Supprimer.Click += new System.EventHandler(this.BTN_FSP_Supprimer_Click);
            // 
            // TB_FSP_Prenom
            // 
            this.TB_FSP_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FSP_Prenom.Location = new System.Drawing.Point(228, 221);
            this.TB_FSP_Prenom.Name = "TB_FSP_Prenom";
            this.TB_FSP_Prenom.Size = new System.Drawing.Size(187, 26);
            this.TB_FSP_Prenom.TabIndex = 15;
            // 
            // TB_FSP_Ville
            // 
            this.TB_FSP_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FSP_Ville.Location = new System.Drawing.Point(228, 277);
            this.TB_FSP_Ville.Name = "TB_FSP_Ville";
            this.TB_FSP_Ville.Size = new System.Drawing.Size(187, 26);
            this.TB_FSP_Ville.TabIndex = 14;
            // 
            // TB_FSP_Nom
            // 
            this.TB_FSP_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FSP_Nom.Location = new System.Drawing.Point(228, 163);
            this.TB_FSP_Nom.Name = "TB_FSP_Nom";
            this.TB_FSP_Nom.Size = new System.Drawing.Size(187, 26);
            this.TB_FSP_Nom.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ville :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Supprimer une personne";
            // 
            // CB_FSP_Personne
            // 
            this.CB_FSP_Personne.FormattingEnabled = true;
            this.CB_FSP_Personne.Location = new System.Drawing.Point(228, 88);
            this.CB_FSP_Personne.Name = "CB_FSP_Personne";
            this.CB_FSP_Personne.Size = new System.Drawing.Size(187, 21);
            this.CB_FSP_Personne.TabIndex = 18;
            this.CB_FSP_Personne.SelectedIndexChanged += new System.EventHandler(this.CB_FSP_Personne_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Personne :";
            // 
            // FSupprPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_FSP_Personne);
            this.Controls.Add(this.BTN_FSP_Fermer);
            this.Controls.Add(this.BTN_FSP_Supprimer);
            this.Controls.Add(this.TB_FSP_Prenom);
            this.Controls.Add(this.TB_FSP_Ville);
            this.Controls.Add(this.TB_FSP_Nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FSupprPersonne";
            this.Text = "FSupprPersonne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_FSP_Fermer;
        private System.Windows.Forms.Button BTN_FSP_Supprimer;
        private System.Windows.Forms.TextBox TB_FSP_Prenom;
        private System.Windows.Forms.TextBox TB_FSP_Ville;
        private System.Windows.Forms.TextBox TB_FSP_Nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_FSP_Personne;
        private System.Windows.Forms.Label label6;
    }
}