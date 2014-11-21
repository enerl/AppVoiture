using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Personne
    {
        // Attributs
        private string nom;
        private string prenom;
        private string ville;

        // Accesseurs & Mutateurs
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        // Constructeur

        public Personne(string nom, string prenom, string ville)
        {
        }
        public Personne(string nom, string prenom, string ville)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
        }
    }
}
