using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesCloture;
        public bool Riviere;

        public Terrain(string adresse, float superficie, int nbCotesCloture, bool riviere)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCotesCloture = nbCotesCloture;
            Riviere = riviere;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de pièces = {0}\n", this.NbCotesCloture);
            toString += String.Format("Présence d'un jardin = {0}\n", this.Riviere ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());
            return toString;
        }

        public int CoutFinirCloture()
        {
            int prix = 0;
            int prixCloture = 50;

            if (this.NbCotesCloture < 4)
            {
                prix += (4 - NbCotesCloture) * prixCloture;
            }
            return prix;

        }
        public float EvaluationValeur()
        {
            int facteur = 2000;

            if (this.Riviere) { facteur += 500; }
            facteur += CoutFinirCloture();

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 1500; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 500; }

            return this.Superficie * facteur;
        }

    }
}

