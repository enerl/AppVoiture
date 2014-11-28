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
    public partial class FSupprVoiture : Form
    {
        private Agence agence;
        public FSupprVoiture()
        {
            InitializeComponent();
        }

        public FSupprVoiture(Agence ag)
        {
            agence = ag;
            InitializeComponent();
        }

        private void BTN_FSV_Supprimer_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BTN_FSV_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
