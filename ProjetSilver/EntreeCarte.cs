
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ProjetSilver
    {


        class EntreeCarte
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




            public List<Cartes> carte { get; private set; }

            public const string nomFichierCarte = "ImportCartes.txt";


            public EntreeCarte(Banque nomBanque)
            {
            
            if (File.Exists(nomFichierCarte))
            {

            
                string[] decompose;
                IEnumerable<String> ligneCartes = System.IO.File.ReadLines(nomFichierCarte);

                carte = new List<Cartes>();

                Cartes ca = new Cartes();


                foreach (var item in ligneCartes)
                {
                    decompose = item.Split(';');
                    try
                    {

                    if(decompose[1] == null || decompose[1] == "")
                    {
                        decompose[1] = "500";
                    }

                    ca.nouvelleCarte(Int32.Parse(decompose[0]), Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat));
                    carte.Add(ca);
                    if (decompose[0].Length == 16 && Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat) >= 500 && Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat) <= 3000)
                    {

                        if (nomBanque.ChercheExistanceCarte(Int32.Parse(decompose[0])))
                        {
                            nomBanque.NouvelleCarte(Int32.Parse(decompose[0]), Convert.ToDouble(decompose[1], CultureInfo.InvariantCulture.NumberFormat));
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


