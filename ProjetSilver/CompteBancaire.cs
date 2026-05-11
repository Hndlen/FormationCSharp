using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

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

     

        public CompteBancaire(int identifiant,int numeroCb, byte typeSolde, decimal solde )
        {

            NbrComptes++;
            this.IdentifiantBancaire = identifiant;
            this.NumeroCb = numeroCb;
            this.Solde = solde;
            this.typeSolde = typeSolde;
            this.NumeroCb = NumeroCb;
            Console.WriteLine($"Nouveau Compte {FormatTypeSolde} {FormatIdentifiantBancaire} avec un solde à {Solde.ToString("C", new CultureInfo("fr-FR"))} ");
            Console.WriteLine($"Associé à la carte {FormatNumeroCb}");
        }

        public string FormatIdentifiantBancaire
        {
            get { return IdentifiantBancaire.ToString("0###-####-####-####"); }
        }

        public string FormatTypeSolde
        {
            
            get {

                if (this.typeSolde == (byte)TypeSolde.Courant)
                {
                    return "Courant";
                }
                else if (this.typeSolde == (byte)TypeSolde.Livret)
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
            return this.Solde;
        }

        public void Retrait(decimal montant)
        {
            if(montant <= this.Solde)
            {
                Console.WriteLine($"{this.IdentifiantBancaire} a retiré {montant}");
                this.Solde = this.Solde - montant;
            }
            else
            {
                Console.WriteLine("Retrait pas possible, tu es pauvre");
            }
            
        }
        public void Depot(decimal montant)
        {
            Console.WriteLine($"{this.IdentifiantBancaire} a déposé {montant}");
            this.Solde = this.Solde + montant;
        }
        public void Virement(decimal montant)
        {
            this.Solde = this.Solde - montant;
        }
        public void Prelevement(decimal montant)
        {
            this.Solde = this.Solde + montant;
        }

        public void AffichageCompte()
        {
            Console.WriteLine("");
            Console.WriteLine($">>Compte {FormatTypeSolde} {FormatIdentifiantBancaire} avec un solde à {Solde.ToString("C", new CultureInfo("fr-FR"))} ");
            Console.WriteLine($"Associé à la carte {FormatNumeroCb}");
        }

    }
}
