using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace Presentation
{
    public partial class FAffichageDesVoitures : Form
    {
        private Agence agence;
        public FAffichageDesVoitures()
        {
            InitializeComponent();
        }

        public FAffichageDesVoitures(Agence ag)
        {
            agence = ag;
            InitializeComponent();
        }

        private void FAffichageDesVoiture_Load(object sender, EventArgs e)
        {
            List<Voiture> voitures = agence.ParcVoitures;
            foreach (Voiture voiture in voitures)
            {
                CB_FADV_Voiture.Items.Add(voiture).ToString();

                DGV_FADV.Rows.Add(voiture.Nom, voiture.Immatriculation, voiture.Puissance, voiture.DateMiseService, voiture.Categorie, voiture.EstLouee);

            }
        }

        private void BTN_FADV_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
