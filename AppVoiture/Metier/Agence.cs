using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Agence
    {
        private List<Personne> lesPersonnes = new List<Personne>();
        private List<Voiture> parcVoitures = new List<Voiture>();
        private string nom;

        public List<Personne> LesPersonnes
        {
            get { return lesPersonnes; }
            set { lesPersonnes = value; }
        }
       

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        

        public List<Voiture> ParcVoitures
        {
            get { return parcVoitures; }
            set { parcVoitures = value; }
        }

        public void AjouterPersonne(Personne pers)
        {
            LesPersonnes.Add(pers);
        }
        public void AjouterVoiture(Voiture voiture)
        {
            ParcVoitures.Add(voiture);

        }
        public void SupprimerPersonne(Personne pers)
        {
            LesPersonnes.Remove(pers);
        }

        public void SupprimerVoiture(Voiture voiture)
        {
            ParcVoitures.Remove(voiture);
        }

        public Voiture RechercherVoiture(String nom)
        {
            Voiture voiture=null;
            foreach (Voiture voit in ParcVoitures)
            {
                if (voit.Nom==nom)
                {
                    voiture = voit;
                }
                
            }

            return voiture;
        }

        public void LouerVoiture(String nom)
        {
            foreach (Voiture voit in ParcVoitures)
            {
                if (voit.Nom == nom)
                {
                    voit.EstLouee="Oui";
                }

            }
        }

    }
}
