using System;
using System.Globalization;

namespace ProjetSilver
{
    /*enum TypeSolde : byte
    {
        Courant,
        Livret

    }*/
    public class CompteBancaire
    {
        public static int NbrComptes { get; private set; } = 0;
        public int IdentifiantBancaire { get; }
        private decimal Solde { get; set; }
        private byte typeSolde { get; set; }
        private int NumeroCb { get; set; }



        public CompteBancaire(int identifiant, int numeroCb, byte typeSolde, decimal solde)
        {

            NbrComptes++;
            IdentifiantBancaire = identifiant;
            NumeroCb = numeroCb;
            Solde = solde;
            Console.WriteLine($"Nouveau Compte {FormatTypeSolde} {FormatIdentifiantBancaire} avec un solde à {Solde.ToString("C", new CultureInfo("fr-FR"))} ");
            Console.WriteLine($"Associé à la carte {FormatNumeroCb}");
        }

        public string FormatIdentifiantBancaire
        {
            get { return IdentifiantBancaire.ToString("0###-####-####-####"); }
        }

        public string FormatTypeSolde
        {

            get
            {

                if (typeSolde == (byte)TypeSolde.Courant)
                {
                    return "Courant";
                }
                else if (typeSolde == (byte)TypeSolde.Livret)
                {
                    return "Livret";
                }
                else
                { return "???"; }
            }
        }

        public string FormatNumeroCb
        {
            get { return NumeroCb.ToString("0### #### #### ####"); }
        }

        public decimal SoldeCompte()
        {
            return Solde;
        }

        public void Retrait(decimal montant)
        {
            if (montant <= Solde)
            {
                Console.WriteLine($"{IdentifiantBancaire} a retiré {montant}");
                Solde = Solde - montant;
            }
            else
            {
                Console.WriteLine("Retrait pas possible, tu es pauvre");
            }

        }
        public void Depot(decimal montant)
        {
            // Eviter les Console.WriteLine qui fournissent des infos !
            Console.WriteLine($"{IdentifiantBancaire} a déposé {montant}");
            Solde = Solde + montant;
        }
        public void Virement(decimal montant)
        {
            Solde = Solde - montant;
        }
        public void Prelevement(decimal montant)
        {
            Solde = Solde + montant;
        }

        public void AffichageCompte()
        {
            Console.WriteLine("");
            Console.WriteLine($">>Compte {FormatTypeSolde} {FormatIdentifiantBancaire} avec un solde à {Solde.ToString("C", new CultureInfo("fr-FR"))} ");
            Console.WriteLine($"Associé à la carte {FormatNumeroCb}");
        }

    }
}
