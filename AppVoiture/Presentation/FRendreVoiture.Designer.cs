namespace Presentation
{
    partial class FRendreVoiture
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
            this.CB_FRV_VoitureARendre = new System.Windows.Forms.ComboBox();
            this.BTN_FRV_Fermer = new System.Windows.Forms.Button();
            this.BTN_FRV_Valider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_FRV_VoitureARendre
            // 
            this.CB_FRV_VoitureARendre.FormattingEnabled = true;
            this.CB_FRV_VoitureARendre.Location = new System.Drawing.Point(207, 111);
            this.CB_FRV_VoitureARendre.Name = "CB_FRV_VoitureARendre";
            this.CB_FRV_VoitureARendre.Size = new System.Drawing.Size(195, 21);
            this.CB_FRV_VoitureARendre.TabIndex = 25;
            // 
            // BTN_FRV_Fermer
            // 
            this.BTN_FRV_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FRV_Fermer.Location = new System.Drawing.Point(303, 175);
            this.BTN_FRV_Fermer.Name = "BTN_FRV_Fermer";
            this.BTN_FRV_Fermer.Size = new System.Drawing.Size(90, 33);
            this.BTN_FRV_Fermer.TabIndex = 24;
            this.BTN_FRV_Fermer.Text = "Fermer";
            this.BTN_FRV_Fermer.UseVisualStyleBackColor = true;
            // 
            // BTN_FRV_Valider
            // 
            this.BTN_FRV_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FRV_Valider.Location = new System.Drawing.Point(149, 175);
            this.BTN_FRV_Valider.Name = "BTN_FRV_Valider";
            this.BTN_FRV_Valider.Size = new System.Drawing.Size(90, 33);
            this.BTN_FRV_Valider.TabIndex = 23;
            this.BTN_FRV_Valider.Text = "Valider";
            this.BTN_FRV_Valider.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Voiture à rendre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rendre une voiture";
            // 
            // FRendreVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 262);
            this.Controls.Add(this.CB_FRV_VoitureARendre);
            this.Controls.Add(this.BTN_FRV_Fermer);
            this.Controls.Add(this.BTN_FRV_Valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRendreVoiture";
            this.Text = "FRendreVoiture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_FRV_VoitureARendre;
        private System.Windows.Forms.Button BTN_FRV_Fermer;
        private System.Windows.Forms.Button BTN_FRV_Valider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}