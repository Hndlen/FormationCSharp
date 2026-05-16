using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ProjetSilver
{


    class EntreeCompte
    {

        // struct privée uniquement utilisée dans EntreeCompte, mais comme pour EntreeCarte, tu ne l'utilises pas vraiment
        public struct Comptes
        {
            public int Identifiant { get; set; }
            public int NumeroCarte { get; set; }
            public byte TypeCompte { get; set; }
            public decimal Solde { get; set; }

            public void nouveauCompte(int identifiant, int numeroCarte, byte typeCompte, decimal solde)
            {
                Identifiant = identifiant;
                NumeroCarte = numeroCarte;
                TypeCompte = typeCompte;
                Solde = solde;
            }
        }



        public List<Comptes> compte { get; private set; }


        public const string nomFichierCompte = "ImportComptes.txt";

        public EntreeCompte(Banque nomBanque)
        {
            if (File.Exists(nomFichierCompte))
            {
                string[] decompose;
                IEnumerable<string> ligneComptes = File.ReadLines(nomFichierCompte);

                compte = new List<Comptes>();
                Comptes co = new Comptes();


                foreach (var item in ligneComptes)
                {
                    decompose = item.Split(';');

                    try
                    {
                        if (string.IsNullOrEmpty(decompose[3]))//(decompose[3] == null || decompose[3] == "")
                        {
                            decompose[3] = "0.0";
                        }

                        co.nouveauCompte(int.Parse(decompose[0]), Int32.Parse(decompose[1]), Convert.ToByte(decompose[2]), Convert.ToDecimal(decompose[3], CultureInfo.InvariantCulture.NumberFormat));
                        compte.Add(co);
                        if (decompose[0].Length == 16
                            && decompose[1].Length == 16
                            // Le Type Compte n'est pas un byte... mais soit Livret, soit Courant
                            && (Convert.ToByte(decompose[2]) == 0 || Convert.ToByte(decompose[2]) == 1)
                            && Convert.ToDecimal(decompose[3], CultureInfo.InvariantCulture.NumberFormat) >= 0)
                        {
                            if (nomBanque.ChercheExistenceCompte(int.Parse(decompose[0])))
                            {

                                if (nomBanque.ChercheExistenceCarte(int.Parse(decompose[1])) == false)
                                {
                                    nomBanque.NouveauCompte(int.Parse(decompose[0]), int.Parse(decompose[1]), Convert.ToByte(decompose[2]), Convert.ToDecimal(decompose[3], CultureInfo.InvariantCulture.NumberFormat));
                                }

                                else
                                {
                                    Console.WriteLine($"    #Creation de compte {decompose[0]}  {decompose[1]} {decompose[2]} {decompose[3]} a tort car carte existe pas");
                                }

                            }
                            else
                            {
                                Console.WriteLine($"    #Creation de compte {decompose[0]}  {decompose[1]} {decompose[2]} {decompose[3]} a tort car compte déja existant");
                            }



                        }
                        else
                        {
                            Console.WriteLine($"    #Creation de compte {decompose[0]}  {decompose[1]} {decompose[2]} {decompose[3]} a tort car incorrecte");
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"    #Creation de compte {decompose[0]}  {decompose[1]} {decompose[2]} {decompose[3]} a tort");
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
            File.Move(nomFichierCompte, $"{Directory.GetCurrentDirectory()}/Archive/{DateTime.Now.ToString("yyyy_MM_dd_HH_mm")}_{nomFichierCompte}");
        }
    }
}
