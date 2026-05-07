using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ProjetSilver
{


    class EntreeTransaction
    {
        


        public struct Transactions
        {
            public int Identifiant { get; set; }
            public DateTime Horodatage { get; set; }
            public decimal Montant { get; set; }
            public int Expediteur { get; set; }
            public int Destinataire { get; set; }
            public void nouvelleTransaction(int identifiant, DateTime horodatage, decimal montant, int expediteur, int destinataire)
            {
                this.Identifiant = identifiant;
                this.Horodatage = horodatage;
                this.Montant = montant;
                this.Expediteur = expediteur;
                this.Destinataire = destinataire;
            }
        }



        public List<Transactions> transaction { get; private set; }
    
        public const string nomFichierTransaction = "ImportTransactions.txt";
        
        public EntreeTransaction(Banque nomBanque)
        {
            if (File.Exists(nomFichierTransaction))
            {

            
                string[] decompose;
            IEnumerable<String> ligneTransactions = System.IO.File.ReadLines(nomFichierTransaction);


            transaction = new List<Transactions>();
            Transactions tr = new Transactions();

            foreach (var item in ligneTransactions)
            {
                
                decompose = item.Split(';');
                //Console.WriteLine(decompose[1]);
                try
                {
                    DateTime date = DateTime.ParseExact(
                        decompose[1],
                        "dd/MM/yyyy HH:mm:ss",
                        CultureInfo.InvariantCulture
                    );

                    if (decompose[0].Length == 16
                    && decompose[3].Length == 16
                    && decompose[4].Length == 16)
                    {
                        if(nomBanque.ChercheExistanceTransaction(Int32.Parse(decompose[0])))
                        {
                            if (nomBanque.ChercheExistanceCompte(Int32.Parse(decompose[3])) == false
                                && nomBanque.ChercheExistanceCompte(Int32.Parse(decompose[4])) == false)
                            {
                                nomBanque.NouvelleTransaction(Int32.Parse(decompose[0]),date,Convert.ToDecimal(decompose[2], CultureInfo.InvariantCulture.NumberFormat), Int32.Parse(decompose[3]),Int32.Parse(decompose[4]));
                            }

                            else
                            {
                                Console.WriteLine($"Creation de transaction {decompose[0]} {decompose[1]} {decompose[2]} {decompose[3]} {decompose[4]} a tort car compte inexistant");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Creation de transaction {decompose[0]} {decompose[1]} {decompose[2]} {decompose[3]} {decompose[4]} a tort car idTransaction existant");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Creation de transaction {decompose[0]} {decompose[1]} {decompose[2]} {decompose[3]} {decompose[4]} a tort car incorrecte");
                    }
                    Console.WriteLine(date);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Creation de transaction {decompose[0]} {decompose[1]} {decompose[2]} {decompose[3]} {decompose[4]} a tort car date incorrecte");
                }


            }

            Archivage();
            }
        }
        public void Archivage()
        {
            File.Move(nomFichierTransaction, $"{Directory.GetCurrentDirectory()}/Archive/{DateTime.Now.ToString("yyyy_MM_dd_HH_mm")}_{nomFichierTransaction}");
        }
    }
}
