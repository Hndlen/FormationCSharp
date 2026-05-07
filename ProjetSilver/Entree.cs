using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetSilver
{
    

    class Entree
    {
        public struct Cartes
        {
            public int NumeroCarte { get; set; }
            public double Plafond { get; set; }
            public void nouvelleCarte(int numeroCarte, double plafond)
            {
                this.NumeroCarte = numeroCarte;
                this.Plafond = plafond;
            }
        }

        public struct Comptes
        {
            public int Identifiant { get; set; }
            public int NumeroCarte { get; set; }
            public byte TypeCompte { get; set; }
            public decimal Solde { get; set; }
        }

        public struct Transactions
        {
            public int Identifiant { get; set; }
            public DateTime Horodatage { get; set; }
            public decimal Montant { get; set; }
            public int Expediteur { get; set; }
            public int Destinataire { get; set; }
        }

        public List<Cartes> carte { get; private set; }
        public List<Comptes> compte { get; private set; }
        public List<Transactions> transaction { get; private set; }
        public const string nomFichierCarte="ImportCartes.txt";
        public const string nomFichierCompte="ImportComptes.txt";
        public const string nomFichierTransaction="ImportTransactions.txt";
        //public Entree (IEnumerable<String> cartes, IEnumerable<String> comptes, IEnumerable<String> transcactions)
        public Entree (Banque nomBanque)
        {
            string[] decompose;
            IEnumerable<String> ligneCartes = System.IO.File.ReadLines(nomFichierCarte);
            //IEnumerable<String> ligneComptes = System.IO.File.ReadLines(nomFichierCompte);
            //IEnumerable<String> ligneTransaction = System.IO.File.ReadLines(nomFichierTransaction);

            carte = new List<Cartes>();
            compte = new List<Comptes>();
            transaction = new List<Transactions>();
            Cartes ca = new Cartes();
            Comptes co = new Comptes();
            Transactions tr = new Transactions();

            foreach (var item in ligneCartes)
            {
                decompose = item.Split(';');
                
                ca.nouvelleCarte(Int32.Parse(decompose[0]), Convert.ToDouble(decompose[1]));
                carte.Add(ca);
                if(decompose[0].Length == 16 && Convert.ToDouble(decompose[1]) >= 500 && Convert.ToDouble(decompose[1]) <= 3000)
                {
                    if(nomBanque.ChercheExistanceCarte(Int32.Parse(decompose[0])))
                    {
                        nomBanque.NouvelleCarte(Int32.Parse(decompose[0]), Convert.ToDouble(decompose[1]));
                    }
                    else
                    {
                        Console.WriteLine($"Creation de carte {decompose[0]}  {decompose[1]} a tort car déjà existant");
                    }

                    
                }
                else
                {
                    Console.WriteLine($"Creation de carte {decompose[0]}  {decompose[1]} a tort car incorrecte");
                }
                
            }

            /*foreach (var item in carte)
            {
                Console.WriteLine(item.NumeroCarte);
            }*/
        }
    }
}
