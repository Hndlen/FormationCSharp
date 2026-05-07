using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie4
{
    public static class Morpion
    {

        public static void MorpionGame()
        {
            //TODO
            int tour = 0, winner = 0;
            bool enJeu = true ,coupValide = false;
            string joueur1, joueur2,coup;
            char[,] grille =
            {
                { '_','_','_' },
                { '_','_','_' },
                { '_','_','_' }
            };
            Console.WriteLine("Début de partie de Morpion :");
            Console.WriteLine("Nom du joueur 1");
            joueur1 = Console.ReadLine();
            Console.WriteLine("Nom du joueur 2");
            joueur2 = Console.ReadLine();
            DisplayMorpion(grille);
            while (enJeu)
            {
                if(tour%2 ==0)
                {
                    Console.WriteLine("• Coup du joueur " + joueur1);
                    grille=PlayCheck(grille, 'X');
                }
                else
                {
                    Console.WriteLine("• Coup du joueur " + joueur2);
                    grille =PlayCheck(grille, 'O');
                }
                DisplayMorpion(grille);
                if(CheckMorpion(grille) == 1)
                {
                    Console.WriteLine($"Le joueur {joueur1} a gagné !");
                    enJeu = false;
                }
                else if (CheckMorpion(grille) == 2)
                {
                    Console.WriteLine($"Le joueur {joueur2} a gagné !");
                    enJeu = false;
                }
                    tour++;

            }


        }

        public static void DisplayMorpion(char[,] grille)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grille[i, j] + " ");
                }
                Console.Write("\n");
            }
            
        }

        public static int CheckMorpion(char[,] grille)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < 3; i++)
            {
                //ligne
                if (grille[i, 0] == 'X' && grille[i, 1] == 'X' && grille[i, 2] == 'X')
                {
                    // X win
                    return 1;
                }
                if (grille[i, 0] == 'O' && grille[i, 1] == 'O' && grille[i, 2] == 'O')
                {
                    // O win
                    return 2;
                }

                //colonne
                if (grille[0, i] == 'X' && grille[1, i] == 'X' && grille[2, i] == 'X')
                {
                    // X win
                    return 1;

                }

                if (grille[0, i] == 'O' && grille[1, i] == 'O' && grille[2, i] == 'O')
                {
                    // O win
                    return 2;
                }
            }
            //diago
            if (grille[0, 0] == 'X' && grille[1, 1] == 'X' && grille[2, 2] == 'X')
            {
                // X win
                return 1;
            }

            if (grille[0, 2] == 'X' && grille[1, 1] == 'X' && grille[2, 0] == 'X')
            {
                // X win
                return 1;
            }

            if (grille[0, 0] == 'O' && grille[1, 1] == 'O' && grille[2, 2] == 'O')
            {
                // O win
                return 2;
            }

            if (grille[0, 2] == 'O' && grille[1, 1] == 'O' && grille[2, 0] == 'O')
            {
                // O win
                return 2;
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grille[i, j] == '_')
                    {
                        return -1;
                    }

                }
            }

            Console.WriteLine(" ");
            return -1;
        }

        public static char[,] PlayForm(char[,] grille, char player,string coup)
        {
            //string coup;
            int col = 0; 
            
            
               
                if (coup.Length == 2)
                {
                    if (coup[0] == 'A' || coup[0] == 'B' || coup[0] == 'C')
                    {
                        if (coup[0] == 'A')
                        {
                            col = 0;
                        }
                        if (coup[0] == 'B')
                        {
                            col = 1;
                        }
                        if (coup[0] == 'C')
                        {
                            col = 2;
                        }
                       
                    }
                   
                } 
                    if (grille[col, Int32.Parse(coup[1].ToString()) - 1] == '_')
                    {
                        grille[col, Int32.Parse(coup[1].ToString()) - 1] = player;
                    }
            return grille;
        }
    


    public static char[,] PlayCheck (char[,] grille, char player)
        {
            string coup;
            int col = 0; ;
            bool coupValide=false;
            while (coupValide == false)
            {
                coup = Console.ReadLine();
                if(coup.Length == 2)
                {
                    if(coup[0] == 'A' || coup[0] == 'B' || coup[0] == 'C')
                    {
                        if(coup[0] == 'A')
                        {
                            col = 0;
                        }
                        if (coup[0] == 'B')
                        {
                            col = 1;
                        }
                        if (coup[0] == 'C')
                        {
                            col = 2;
                        }
                        coupValide = true;
                    }
                    else
                    {
                        coupValide = false;
                    }


                    if (coup[1] == '1' || coup[1] == '2' || coup[1] == '3')
                    {
                        coupValide = true;
                    }
                    else
                    {
                        coupValide = false;
                    }
                }
                //Console.WriteLine("test " + col + " " + coup[1] );
                //Console.WriteLine(grille[col, Int32.Parse(coup[1].ToString())]);
                if(coupValide == true)
                {
                    if(grille[col, Int32.Parse(coup[1].ToString())-1] == '_')
                    {
                        grille[col, Int32.Parse(coup[1].ToString()) - 1] = player;
                    }
                    else
                    {
                        Console.WriteLine("Case occupée, veuillez réesayer");
                        coupValide = false;
                    }
                }
                else
                {
                    Console.WriteLine("Coup incorrect, veuillez réesayer");
                }


            }
            return grille;
        }
    }
}
