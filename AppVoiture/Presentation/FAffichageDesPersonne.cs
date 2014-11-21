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
    public partial class FAffichageDesPersonne : Form
    {
        private Agence agence;
        public FAffichageDesPersonne()
        {
            InitializeComponent();
        }

        public FAffichageDesPersonne(Agence ag)
        {
            agence = ag;
            InitializeComponent();
        }
    }
}
