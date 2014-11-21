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
    public partial class FSupprPersonne : Form
    {
        private Agence agence;
        public FSupprPersonne()
        {
            InitializeComponent();
        }

        public FSupprPersonne(Agence ag)
        {
            agence = ag;
            InitializeComponent();
        }
    }
}
