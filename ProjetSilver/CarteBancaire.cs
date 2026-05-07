using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetSilver
{
    class CarteBancaire
    {
        public static int NbrCartes { get; private set; } = 0;
        public int NumeroCarte { get; }
        public double Plafond { get; private set; }
        public List<CompteBancaire> comptesBancaire { get; private set; }
        //public List<Transaction> Transactions { get; private set; }


        public CarteBancaire(double plafond)
        {
            
            NbrCartes++;
            this.NumeroCarte = NbrCartes;
            this.Plafond = plafond;
            Console.WriteLine($"Nouvelle carte {FormatNumeroCarte} avec un plafond à {plafond.ToString("C", new CultureInfo("fr-FR"))} ");
            
            
        }
        public double RetournerPlafond()
        {
            return this.Plafond;
        }

        public CarteBancaire(int numeroCarte, double plafond)
        {

            NbrCartes++;
            this.NumeroCarte = numeroCarte;
            this.Plafond = plafond;
            comptesBancaire = new List<CompteBancaire>();
            Console.WriteLine($"Nouvelle carte {FormatNumeroCarte} avec un plafond à {plafond.ToString("C", new CultureInfo("fr-FR"))} ");


        }

        public void AjoutCompteBancaire(CompteBancaire Compte)
        {
            comptesBancaire.Add(Compte);
        }

        public int RetournerCompte()
        {
            return this.comptesBancaire[0].IdentifiantBancaire;
        }
        

        public string FormatNumeroCarte
        {
            get { return NumeroCarte.ToString("0### #### #### ####"); }
        }

        public void AffichageCarte()
        {
            Console.WriteLine("");
            Console.WriteLine($">Carte {FormatNumeroCarte} avec un plafond à {Plafond.ToString("C", new CultureInfo("fr-FR"))} ");
            
        }

    }
}
