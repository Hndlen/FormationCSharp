using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

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
                Identifiant = identifiant;
                Horodatage = horodatage;
                Montant = montant;
                Expediteur = expediteur;
                Destinataire = destinataire;
            }
        }



        public List<Transactions> transaction { get; private set; }

        public const string nomFichierTransaction = "ImportTransactions.txt";

        public EntreeTransaction(Banque nomBanque)
        {

            if (File.Exists(nomFichierTransaction))
            {


                string[] decompose;
                IEnumerable<string> ligneTransactions = File.ReadLines(nomFichierTransaction);


                transaction = new List<Transactions>();
                Transactions tr = new Transactions();

                foreach (var item in ligneTransactions)
                {

                    decompose = item.Split(';');
                    try
                    {
                        DateTime date = DateTime.ParseExact(
                            decompose[1],
                            "dd/MM/yyyy HH:mm:ss",
                            CultureInfo.InvariantCulture
                        );

                        if (decompose[0].Length == 16
                            // Les expéditeurs et destinataires ne sont pas forcément sur 16 chiffres (seule la carte a cette contrainte)
                        && decompose[3].Length == 16
                        && decompose[4].Length == 16)
                        {
                            if (nomBanque.ChercheExistenceTransaction(int.Parse(decompose[0])))
                            {
                                // pourquoi int.Parse et pas int.TryParse ? cela éviterait de lever une exception à chaque erreur de format
                                if (!nomBanque.ChercheExistenceCompte(int.Parse(decompose[3])) && !nomBanque.ChercheExistenceCompte(int.Parse(decompose[4])))
                                {
                                    // je ne suis pas fan de l'idée de traiter la transaction à l'intérieur de NouvelleTransaction, risque d'incompréhension d'un dev tiers
                                    // par contre traiter les transactions au fur et à mesure est une bonne idée par contre tu rates l'intérêt avec ReadAllLine()...
                                    // lire au fur et à mesure aurait éviter les pbms en PRD
                                    nomBanque.NouvelleTransaction(int.Parse(decompose[0]), date, Convert.ToDecimal(decompose[2], CultureInfo.InvariantCulture.NumberFormat), Int32.Parse(decompose[3]), Int32.Parse(decompose[4]));
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
        /// <summary>
        ///Creation d'archive pour avoir un historique du fichier 
        /// </summary>
        public void Archivage()
        {
            File.Move(nomFichierTransaction, $"{Directory.GetCurrentDirectory()}/Archive/{DateTime.Now.ToString("yyyy_MM_dd_HH_mm")}_{nomFichierTransaction}");
        }
    }
}
