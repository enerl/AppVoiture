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
        private Personne unePers;
        private Agence uneAg;

        public FAjoutPersonne()
        {
            InitializeComponent();
        }
        public FAjoutPersonne(Personne unePersonne,Agence uneAgence)
        {
            InitializeComponent();
            unePers = unePersonne;
            uneAg = uneAgence;

        }

        private void BTN_FAP_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_FAP_Ajouter_Click(object sender, EventArgs e)
        {
            // Verification que les ComboBox ne sont pas vident
            if ((TB_FAP_Nom.Text != "") && (TB_FAP_Prenom.Text != "") && (TB_FAP_Ville.Text != ""))
            {
                // Ajout des propriété du nouvel objet de type Personne
                unePers.Nom = TB_FAP_Nom.Text;
                unePers.Prenom = TB_FAP_Prenom.Text;
                unePers.Ville = TB_FAP_Ville.Text;

                // AJout de la nouvelle personne dans la liste "lesPersonnes" de l'objet Agence
                uneAg.AjouterPersonne(unePers);
            }
        }
    }
}
