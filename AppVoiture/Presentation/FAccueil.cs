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
    public partial class FAccueil : Form
    {
        public FAccueil()
        {
            InitializeComponent();
        }
        Personne unePersonne;
        Voiture uneVoiture;
        Agence uneAgence = new Agence();
        
        private void ajouterUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uneVoiture = new Voiture();
            FAjoutVoiture unFAjoutV = new FAjoutVoiture(uneVoiture);
            unFAjoutV.ShowDialog();        
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSupprVoiture unFsupprV = new FSupprVoiture(uneAgence);
            unFsupprV.ShowDialog();
        }

        private void ajouterUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unePersonne = new Personne();
            FAjoutPersonne unFajoutP = new FAjoutPersonne(unePersonne,uneAgence);
            unFajoutP.ShowDialog();
        }

        private void supprimerUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSupprPersonne unFsupprP = new FSupprPersonne(uneAgence);
            unFsupprP.ShowDialog();
        }

        private void louerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLouerVoiture unFlouerV = new FLouerVoiture(uneAgence);
            unFlouerV.ShowDialog();
        }

        private void rendreUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRendreVoiture unFrendreV = new FRendreVoiture(uneAgence);
            unFrendreV.ShowDialog();
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAffichageDesVoiture unFAffichageV = new FAffichageDesVoiture(uneAgence);
            unFAffichageV.ShowDialog();
        }

        private void toutesLesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAffichageDesPersonne unFAffichageP = new FAffichageDesPersonne(uneAgence);
            unFAffichageP.ShowDialog();
        }
    }
}
