
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ProjetSilver
{
    // Attention à l'indentation

    class EntreeCarte
    {
        public struct Cartes
        {
            public int NumeroCarte { get; set; }
            public double Plafond { get; set; }

            // C'est un constructeur ?!
            public void nouvelleCarte(int numeroCarte, double plafond)
            {
                NumeroCarte = numeroCarte;
                Plafond = plafond;
            }
        }




        public List<Cartes> carte { get; private set; }

        // J'aurais eu tendance à fournir ce nom de fichier en paramètre d'entrée de la méthode EntreeCarte
        public const string nomFichierCarte = "ImportCartes.txt";


        public EntreeCarte(Banque nomBanque)
        {

            if (File.Exists(nomFichierCarte))
            {
                string[] decompose;
                IEnumerable<string> ligneCartes = File.ReadLines(nomFichierCarte);

                carte = new List<Cartes>();

                Cartes ca = new Cartes();


                foreach (var item in ligneCartes)
                {
                    decompose = item.Split(';');
                    try
                    {

                        if (string.IsNullOrEmpty(decompose[1])) //(decompose[1] == null || decompose[1] == "") 
                        {
                            decompose[1] = "500";
                        }

                        // j'aurais eu tendance à plus utiliser double.TryParse() pour éviter la levée d'exception
                        ca.nouvelleCarte(int.Parse(decompose[0]), Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat));
                        carte.Add(ca);
                        // pourquoi tu n'utilises pas ca.Plafond ? 
                        if (decompose[0].Length == 16 && Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat) >= 500 && Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat) <= 3000)
                        {
                            // je me demande à quoi sert ca, tu ne l'utilises jamais
                            if (nomBanque.ChercheExistenceCarte(int.Parse(decompose[0])))
                            {
                                nomBanque.NouvelleCarte(int.Parse(decompose[0]), Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat));
                            }
                            else
                            {
                                Console.WriteLine($"    #Creation de carte {decompose[0]}  {decompose[1]} a tort car déjà existant");
                            }

                        }
                        else
                        {
                            Console.WriteLine($"    #Creation de carte {decompose[0]}  {decompose[1]} a tort car incorrecte");
                        }

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine($"    #Creation de carte {decompose[0]}  {decompose[1]} a tort");
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
            File.Move(nomFichierCarte, $"{Directory.GetCurrentDirectory()}/Archive/{DateTime.Now.ToString("yyyy_MM_dd_HH_mm")}_{nomFichierCarte}");
        }
    }
}


