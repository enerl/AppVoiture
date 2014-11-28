using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Voiture
    {
        // Attributs
        private string categorie;
        private int puissance;
        private string dateMiseService;
        private string estLouee;
        private string immatriculation;
        private string loueur;
        private string nom;

        // Accesseurs & Mutateurs
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
       

        public string DateMiseService
        {
            get { return dateMiseService; }
            set { dateMiseService = value; }
        }
       

        public string EstLouee
        {
            get { return estLouee; }
            set { estLouee = value; }
        }
      

        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
      

        public string Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }
      

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
      

        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }

        // Constructeur
        public Voiture()
        {

        }
        public Voiture(string categorie,int puissance,string date,string estLouee,
            string immatriculation, string loueur, string nom)
        {
            this.categorie = categorie;
            this.puissance = puissance;
            this.dateMiseService = date;
            this.estLouee = estLouee;
            this.immatriculation = immatriculation;
            this.loueur = loueur;
            this.nom = nom;
        }

        override public String ToString()
        {
            return Nom;
        }

        
    }
}
