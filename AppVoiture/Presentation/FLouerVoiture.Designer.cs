namespace Presentation
{
    partial class FLouerVoiture
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
            this.BTN_FLV_Fermer = new System.Windows.Forms.Button();
            this.BTN_FLV_Valider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_FLV_Voiture = new System.Windows.Forms.ComboBox();
            this.CB_FLV_Personne = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BTN_FLV_Fermer
            // 
            this.BTN_FLV_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FLV_Fermer.Location = new System.Drawing.Point(333, 216);
            this.BTN_FLV_Fermer.Name = "BTN_FLV_Fermer";
            this.BTN_FLV_Fermer.Size = new System.Drawing.Size(90, 33);
            this.BTN_FLV_Fermer.TabIndex = 17;
            this.BTN_FLV_Fermer.Text = "Fermer";
            this.BTN_FLV_Fermer.UseVisualStyleBackColor = true;
            // 
            // BTN_FLV_Valider
            // 
            this.BTN_FLV_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FLV_Valider.Location = new System.Drawing.Point(179, 216);
            this.BTN_FLV_Valider.Name = "BTN_FLV_Valider";
            this.BTN_FLV_Valider.Size = new System.Drawing.Size(90, 33);
            this.BTN_FLV_Valider.TabIndex = 16;
            this.BTN_FLV_Valider.Text = "Valider";
            this.BTN_FLV_Valider.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Voiture :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Louer une voiture";
            // 
            // CB_FLV_Voiture
            // 
            this.CB_FLV_Voiture.FormattingEnabled = true;
            this.CB_FLV_Voiture.Location = new System.Drawing.Point(228, 102);
            this.CB_FLV_Voiture.Name = "CB_FLV_Voiture";
            this.CB_FLV_Voiture.Size = new System.Drawing.Size(195, 21);
            this.CB_FLV_Voiture.TabIndex = 18;
            // 
            // CB_FLV_Personne
            // 
            this.CB_FLV_Personne.FormattingEnabled = true;
            this.CB_FLV_Personne.Location = new System.Drawing.Point(228, 157);
            this.CB_FLV_Personne.Name = "CB_FLV_Personne";
            this.CB_FLV_Personne.Size = new System.Drawing.Size(195, 21);
            this.CB_FLV_Personne.TabIndex = 19;
            // 
            // FLouerVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 300);
            this.Controls.Add(this.CB_FLV_Personne);
            this.Controls.Add(this.CB_FLV_Voiture);
            this.Controls.Add(this.BTN_FLV_Fermer);
            this.Controls.Add(this.BTN_FLV_Valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FLouerVoiture";
            this.Text = "FLouerVoiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_FLV_Fermer;
        private System.Windows.Forms.Button BTN_FLV_Valider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_FLV_Voiture;
        private System.Windows.Forms.ComboBox CB_FLV_Personne;
    }
}