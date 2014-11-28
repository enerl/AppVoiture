namespace Presentation
{
    partial class FAffichageDesVoiture
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
            this.CB_FADV_Trier = new System.Windows.Forms.ComboBox();
            this.CB_FADV_Voiture = new System.Windows.Forms.ComboBox();
            this.BTN_FADV_Fermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_FADV = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.louee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FADV)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_FADV_Trier
            // 
            this.CB_FADV_Trier.FormattingEnabled = true;
            this.CB_FADV_Trier.Location = new System.Drawing.Point(570, 71);
            this.CB_FADV_Trier.Name = "CB_FADV_Trier";
            this.CB_FADV_Trier.Size = new System.Drawing.Size(195, 21);
            this.CB_FADV_Trier.TabIndex = 26;
            // 
            // CB_FADV_Voiture
            // 
            this.CB_FADV_Voiture.FormattingEnabled = true;
            this.CB_FADV_Voiture.Location = new System.Drawing.Point(214, 71);
            this.CB_FADV_Voiture.Name = "CB_FADV_Voiture";
            this.CB_FADV_Voiture.Size = new System.Drawing.Size(195, 21);
            this.CB_FADV_Voiture.TabIndex = 25;
            // 
            // BTN_FADV_Fermer
            // 
            this.BTN_FADV_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FADV_Fermer.Location = new System.Drawing.Point(368, 358);
            this.BTN_FADV_Fermer.Name = "BTN_FADV_Fermer";
            this.BTN_FADV_Fermer.Size = new System.Drawing.Size(90, 33);
            this.BTN_FADV_Fermer.TabIndex = 24;
            this.BTN_FADV_Fermer.Text = "Fermer";
            this.BTN_FADV_Fermer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Trier sur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom de la voiture :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Affichage des voitures";
            // 
            // DGV_FADV
            // 
            this.DGV_FADV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_FADV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.immat,
            this.puissance,
            this.dateServ,
            this.categ,
            this.louee});
            this.DGV_FADV.Location = new System.Drawing.Point(16, 107);
            this.DGV_FADV.Name = "DGV_FADV";
            this.DGV_FADV.Size = new System.Drawing.Size(673, 245);
            this.DGV_FADV.TabIndex = 27;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // immat
            // 
            this.immat.HeaderText = "Immatriculation";
            this.immat.Name = "immat";
            // 
            // puissance
            // 
            this.puissance.HeaderText = "Puissance";
            this.puissance.Name = "puissance";
            // 
            // dateServ
            // 
            this.dateServ.HeaderText = "Date mise en service";
            this.dateServ.Name = "dateServ";
            // 
            // categ
            // 
            this.categ.HeaderText = "Catégorie";
            this.categ.Name = "categ";
            // 
            // louee
            // 
            this.louee.HeaderText = "Louée";
            this.louee.Name = "louee";
            // 
            // FAffichageDesVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 401);
            this.Controls.Add(this.DGV_FADV);
            this.Controls.Add(this.CB_FADV_Trier);
            this.Controls.Add(this.CB_FADV_Voiture);
            this.Controls.Add(this.BTN_FADV_Fermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAffichageDesVoiture";
            this.Text = "FAffichageDesVoiture";
            this.Load += new System.EventHandler(this.FAffichageDesVoiture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_FADV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_FADV_Trier;
        private System.Windows.Forms.ComboBox CB_FADV_Voiture;
        private System.Windows.Forms.Button BTN_FADV_Fermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_FADV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn immat;
        private System.Windows.Forms.DataGridViewTextBoxColumn puissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn categ;
        private System.Windows.Forms.DataGridViewTextBoxColumn louee;
    }
}