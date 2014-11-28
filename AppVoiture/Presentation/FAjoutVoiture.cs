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
    public partial class FAjoutVoiture : Form
    {
        Voiture uneVoit;
        Agence uneAg;
        public FAjoutVoiture()
        {
            InitializeComponent();
        }
        public FAjoutVoiture(Voiture uneVoiture,Agence uneAgence)
        {
            InitializeComponent();
            uneVoit = uneVoiture;
            uneAg = uneAgence;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_FAV_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_FAV_Ajouter_Click(object sender, EventArgs e)
        {
            // Verification que les ComboBox ne sont pas vident
            if((TB_FAV_Categorie.Text != "") && (TB_FAV_DateMiseService.Text != "") && (TB_FAV_Immatriculation.Text != "")
                && (TB_FAV_Nom.Text != "") && (TB_FAV_Puissance.Text != ""))
            {
                // Ajout des propriété du nouvel objet de type Voiture
                uneVoit.Categorie = TB_FAV_Categorie.Text;
                uneVoit.DateMiseService = TB_FAV_DateMiseService.Text;
                uneVoit.Immatriculation = TB_FAV_Immatriculation.Text;
                uneVoit.Nom = TB_FAV_Nom.Text;
                uneVoit.Puissance = Int32.Parse(TB_FAV_Puissance.Text);

                // Ajout de la nouvelle voiture dans la liste "parcVoitures" de l'objet Agence
                uneAg.AjouterVoiture(uneVoit);
                this.Close();


            }
        }
    }
}
