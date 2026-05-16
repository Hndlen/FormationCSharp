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



        public CarteBancaire(double plafond)
        {
            
            NbrCartes++;
            NumeroCarte = NbrCartes;
            Plafond = plafond;
            Console.WriteLine($"Nouvelle carte {FormatNumeroCarte} avec un plafond à {plafond.ToString("C", new CultureInfo("fr-FR"))} ");
            
            
        }
        public double RetournerPlafond()
        {
            return Plafond;
        }

        public CarteBancaire(int numeroCarte, double plafond)
        {

            NbrCartes++;
            NumeroCarte = numeroCarte;
            Plafond = plafond;
            comptesBancaire = new List<CompteBancaire>();
            Console.WriteLine($"Nouvelle carte {FormatNumeroCarte} avec un plafond à {plafond.ToString("C", new CultureInfo("fr-FR"))} ");


        }

        public void AjoutCompteBancaire(CompteBancaire Compte)
        {
            comptesBancaire.Add(Compte);
        }

        public int RetournerCompte()
        {
            return comptesBancaire[0].IdentifiantBancaire;
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
