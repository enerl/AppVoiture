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
    public partial class FLouerVoiture : Form
    {
        private Agence agence;
        public FLouerVoiture()
        {
            InitializeComponent();
        }

        public FLouerVoiture(Agence ag)
        {
            agence = ag;
            InitializeComponent();
        }

        private void FLouerVoiture_Load(object sender, EventArgs e)
        {
            List<Personne> lesPersonnes = agence.LesPersonnes;
            List<Voiture> lesVoitures = agence.ParcVoitures;

            foreach(Personne uneP in lesPersonnes)
            {
                CB_FLV_Personne.Items.Add(uneP).ToString();
            }

            foreach (Voiture uneV in lesVoitures)            {
                CB_FLV_Voiture.Items.Add(uneV.Nom);
            }
        }

        private void BTN_FLV_Valider_Click(object sender, EventArgs e)
        {
            String stringVoiture = CB_FLV_Voiture.SelectedText;
            agence.LouerVoiture(stringVoiture);
           

            this.Close();


            
        }

        private void CB_FLV_Voiture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
