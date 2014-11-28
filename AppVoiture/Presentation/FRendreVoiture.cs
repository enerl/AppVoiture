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
    public partial class FRendreVoiture : Form
    {
        private Agence agence;

        public FRendreVoiture()
        {
            InitializeComponent();
        }
        public FRendreVoiture(Agence ag)
        {
            agence = ag;
            InitializeComponent();
        }

        private void BTN_FRV_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
