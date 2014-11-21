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
    public partial class FAjoutPersonne : Form
    {
        private Personne unePersonne;
        public FAjoutPersonne()
        {
            InitializeComponent();
        }

        private void BTN_FAP_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_FAP_Ajouter_Click(object sender, EventArgs e)
        {
            if ((TB_FAP_Nom.Text != "") && (TB_FAP_Prenom.Text != "") && (TB_FAP_Ville.Text != ""))
            {
                String nom = TB_FAP_Nom.Text;
                String prenom = TB_FAP_Prenom.Text;
                String ville = TB_FAP_Ville.Text;
            }
        }
    }
}
