using Serie3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    enum PointCardinal : int
    {
        Nord,
        Sud,
        Est,
        Ouest
    }
    public struct QCM
    {
        public string Question;
        // public List<string> Answers = new List<string>();
        public string[] Answers;
        public int Solution;
        public int Weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Serie1_2026();
            //Serie1_2022();
            //Serie2_2026();
            //Serie2_2022();

            //Serie3_2026();

            //Serie4 S4 = new Serie4();
            //S4.Serie4_2026();

            //EXO 2

            test to;




            EndPerform();
        }
        static void EndPerform()
        {
            Console.WriteLine("\n\nAppuie sur une touche pour finir");
            Console.ReadKey();
        }
        static void Serie3_2026()
        {
            //Exercice I  Traitement administratif
            string phrase = "Bonjour, voici mon message de la plus haute importance";
            string[] censure = { "voici", "plus" };
            Console.WriteLine(phrase);
            Console.WriteLine(AdministrativeTasks.EliminateSeditiousThoughts(phrase, censure));
            Console.WriteLine(AdministrativeTasks.ControlFormat("M.   Dimitrov    Nikolai     25"));
            Console.WriteLine(AdministrativeTasks.ChangeDate("Nous somme le 2001-02-09 aujourd'hui"));


            //Exercice II  Code César
            //1) Il sert a faire le decalage de 3 char par intervention 
            Cesar ces = new Cesar();
            Console.WriteLine(ces.CesarCode("TOTORI"));
            Console.WriteLine(ces.DecryptCesarCode(ces.CesarCode("TOTORI")));

            Console.WriteLine(ces.GeneralCesarCode("TOTORI", 3)); 
            Console.WriteLine(ces.GeneralDecryptCesarCode((ces.GeneralCesarCode("TOTORI", 3)),3));

            //Exercice III  Code Morse
            //1) afin d'avoir un binome lettre + code
            Morse dic = new Morse();
            Console.WriteLine(dic.LettersCount("Totori Totora"));
            Console.WriteLine(dic.WordsCount("Totori Totora"));
            Console.WriteLine(   dic.MorseEncryption("TOTO RIGOLO LE GIGOLO"));
            Console.WriteLine(dic.MorseTranslation(dic.MorseEncryption("TOTO RIGOLO LE GIGOLO")));
        }
        static void Serie1_2026()
        {
            //Exercice I  Opérations élémentaires
            Console.WriteLine("Ex 1");
            BasicOperation(5, 2, '/');
            BasicOperation(5, 0, '/');
            IntegerDivision(12, -3);
            IntegerDivision(13, -3);
            Pow(2, 3);

            // Exercice II  Horloge parlante
            Console.WriteLine("Ex 2");
            Console.WriteLine(GoodDay(5));
            Console.WriteLine(GoodDay(15));
            Console.WriteLine(GoodDay(26));

            //Exercice III  Construction d'une pyramide
            //1)a  2J-1
            //1)b) 2N-1
            //2)a) N
            //2)b) etage +- j
            Console.WriteLine("Ex 3");
            PyramideLisse(10);
            PyramideStrillée(10);

            //Exercice IV  Factorielle
            //2)b) la version iterative ?

            Console.WriteLine("Ex 4");
            int n = 3;
            Console.WriteLine("La fatoriel de " + n + " est " + Factoria(n));
            Console.WriteLine("La fatoriel de " + n + " est " + FactoriaR(n));
        }
        static void BasicOperation(int a, int b, char ope)
        {
            double result;
            switch (ope)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine(a + " " + ope + " " + b + " = " + result);
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine(a + " " + ope + " " + b + " = " + result);
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine(a + " " + ope + " " + b + " = " + result);
                    break;
                case '/' when b != 0:
                    result = (double)a / (double)b;
                    Console.WriteLine(a + " " + ope + " " + b + " = " + result);
                    break;
                case '/' when b == 0:
                    Console.WriteLine(a + " " + ope + " " + b + " = Operation invalide");
                    break;
                default:
                    Console.WriteLine(a + " " + ope + " " + b + " = Operation invalide");
                    break;
            }
        }

        static void IntegerDivision(int a, int b)
        {
            int q, r;
            if (b == 0)
            {
                Console.WriteLine(a + " : " + b + " = Operation invalide");
            }
            else
            {
                r = a % b;
                q = a / b;
                Console.WriteLine(a + " = " + q + " * " + b + " + " + r);
            }
        }

        static void Pow(int a, int b)
        {
            for (int i = 1; i <= b; i++)
            {
                a = a * i;
            }

            Console.WriteLine("a = " + a);
        }


        static string GoodDay(int heure)
        {

            if (heure >= 0 && heure < 6)
            {
                return "Merveilleuse nuit !";
            }
            else if (heure >= 6 && heure < 12)
            {
                return "Bonne matinée !";
            }
            else if (heure == 12)
            {
                return "Bon appétit !";
            }
            else if (heure >= 13 && heure <= 18)
            {
                return "Profitez de votre après-midi !";
            }
            else if (heure > 18)
            {
                return "Passez une bonne soirée!";
            }
            else
            {
                return "Heure non reconue";
            }

        }

        static void PyramideLisse(int n)
        {
            for (int j = 0; j <= n; j++)
            {
                for (int k = 0; k < 2 * n; k++)
                {
                    if (k > n - j && k < n + j)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.Write("\n");
            }
        }

        static void PyramideStrillée(int n)
        {
            int str;
            for (int j = 0; j <= n; j++)
            {
                for (int k = 0; k < 2 * n; k++)
                {
                    str = j % 2;
                    if (j % 2 != 0)
                    {
                        if (k > n - j && k < n + j)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    else
                    {
                        if (k > n - j && k < n + j)
                        {
                            Console.Write('-');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }


                }
                Console.Write("\n");
            }
        }

        static int Factoria(int n)
        {
            int fact = 1;
            if (n == 0)
            {
                return fact;
            }
            else
            {
                for (int f = 1; f <= n; f++)
                {
                    fact = fact * f;
                }
                return fact;
            }

        }
        static int FactoriaR(int n)
        {
            int fact = 1;
            if (n == 0)
            {
                return fact;
            }
            else
            {
                return n * FactoriaR(n - 1);
            }
        }


        static void Serie1_2022()
        {
            //Exercice V  Les nombres premiers
            Console.WriteLine("Ex 5");
            int prime = 10;
            //Console.WriteLine(IsPrime(prime));

            DisplayPrimes();

            //Exercice VI  Algorithme d'Euclide
            Console.WriteLine("\n\n\nEx 6");
            int pa = 146;
            Console.WriteLine(IsPrime(pa));
            int pb = 73;
            Console.WriteLine(IsPrime(pb));
            int pgcd = Gcd(pa, pb);
            Console.WriteLine("PGCD de " + pa + " et " + pb + " est " + pgcd);

        }

        static bool IsPrime(int value)
        {
            double Racine = Math.Sqrt(value);
            for (int i = 0; i <= Racine; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    if (value == i * j)
                    {

                        return false;
                    }

                }
            }
            return true;
        }

        static void DisplayPrimes()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (IsPrime(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int Gcd(int a, int b)
        {
            int q, r;
            if (b == 0)
            {
                Console.WriteLine(" zero ");
                return 0;
            }
            else
            {
                q = a / b;
                r = a % b;
                //Console.WriteLine(a + " " + b + " " + q + " " + r);
                if (r == 0)
                {
                    return b;
                }
                else
                {
                    return Gcd(b, r);
                }
            }
        }

        static void Serie2_2026()
        {
            //Exercice I  Atelier autour des tableaux
            Console.WriteLine("Ex 1");
            int[] tab = { -1, 4, 7, 12, -6, 5 };

            AffTab(tab);
            Console.WriteLine("TT = " + SumTab(tab));
            tab = OpeTab(tab, '+', 1);
            AffTab(tab);
            Console.WriteLine("TT = " + SumTab(tab));
            tab = OpeTab(tab, '-', 1);
            AffTab(tab);
            Console.WriteLine("TT = " + SumTab(tab));
            tab = ConcatTab(tab, tab);
            AffTab(tab);
            Console.WriteLine("TT = " + SumTab(tab));



            //Exercice II  Morpion
            Console.WriteLine("Ex 2");
            //1) Un tableau multi en [3,3] ou un tableau en escalier [3][3], ici j'utilise le [3,3]
            // car toutes les cases de mon tab sont equitablement alimenté
            char[,] grille =
            {
                {'O','X','_' },
                {'_','O','X' },
                {'X','X','O' }
            };

            DisplayMorpion(grille);

            Console.WriteLine(CheckMorpion(grille));

            //Exercice III  Recherche d'un élément
            //2) dans le pire des cas: tab.Lenght
            //4) dans le pire des cas: tab.Lenght / 2
            Console.WriteLine("Ex 3");
            int[] tableau = { 1, -5, 10, 3, 0, 4, 2, -7 };
            int valeur = 4;
            Console.WriteLine(LinearSearch(tableau, valeur));
            int[] tableau2 = { 1, 2, 4, 6, 7, 9, 11, 16 };
            Console.WriteLine(BinarySearch(tableau2, valeur));


        }

        static void AffTab(int[] tab)
        {
            tab.ToList().ForEach(i => Console.Write(i.ToString() + " "));
            Console.WriteLine("");
        }
        static int SumTab(int[] tab)
        {
            int tt = 0;
            foreach (int i in tab)
            {
                tt += i;
            }
            return tt;
        }

        static int[] OpeTab(int[] tab, char ope, int b)
        {
            //int[] tablo = tab;
            if (tab == null)
            {
                return null;
            }

            if (ope == '+')
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = tab[i] + b;
                }
                return tab;
            }
            else if (ope == '-')
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = tab[i] - b;
                }
                return tab;
            }
            else if (ope == '*')
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = tab[i] * b;
                }
                return tab;
            }
            else
            {
                return null;
            }

        }

        static int[] ConcatTab(int[] tab1, int[] tab2)
        {
            int Taille1, Taille2, Taille3;
            if (tab1 == null)
            {
                Taille1 = 0;
            }
            else
            {
                Taille1 = tab1.Length;
            }
            if (tab2 == null)
            {
                Taille2 = 0;
            }
            else
            {
                Taille2 = tab2.Length;
            }


            Taille3 = Taille1 + Taille2;
            if (Taille3 == 0)
            {
                return null;
            }
            Console.WriteLine(Taille3);
            int count = 0;
            int[] tab3 = new int[Taille3];
            if (Taille1 > 0)
            {
                for (int i = 0; i < tab1.Length; i++)
                {
                    tab3[i] = tab1[i];
                    count++;
                }
            }
            if (Taille2 > 0)
            {
                for (int i = 0; i < tab2.Length; i++)
                {
                    tab3[i + count] = tab2[i];
                }
            }
            return tab3;
        }
        static void DisplayMorpion(char[,] grille)
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

        static int CheckMorpion(char[,] grille)
        {

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

            return 0;
        }

        static int LinearSearch(int[] tableau, int valeur)
        {
            int indice = 0;
            if (tableau == null)
            {
                return -1;
            }

            foreach (int i in tableau)
            {
                //Console.WriteLine(i);
                if (i == valeur)
                {
                    return indice;
                }
                indice++;
            }
            return -1;
        }

        static int BinarySearch(int[] tableau, int valeur)
        {
            int N = tableau.Length / 2;
            int dicho = N;
            for (int i = 0; i < N; i++)
            {
                if (valeur == tableau[dicho])
                {
                    return dicho;
                }
                else if (valeur > tableau[dicho])
                {
                    dicho = dicho + dicho / 2;
                }
                else if (valeur < tableau[dicho])
                {
                    dicho = dicho / 2;
                }

            }

            return -1;
        }

        static void Serie2_2022()
        {
            //Exercice II  Bases du calcul matriciel
            Console.WriteLine("Exo2");
            int[] left = { 1, 2, 3 };
            int[] right = { -1, -4, 0 };
            int[,] matrix;
            matrix = BuildingMatrix(left, right);
            DisplayMatrix(matrix, left.Length, right.Length);

            int[][] leftMatrix =
            {
               new int [] {1,2 },
               new int []  {4,6 },
               new int []  {-1,8 }
            };
            int[][] rightMatrix =
            {
               new int [] {-1,5 },
               new int []  {-4,0 },
               new int []  {0,2 }


            };
            int[,] matrix2;
            //Console.WriteLine("test " + leftMatrix.Length + " " + leftMatrix[1].Length);
            matrix2 = Addition(leftMatrix, rightMatrix);
            DisplayMatrix(matrix2, matrix2.GetLength(0), matrix2.GetLength(1));


            int[,] matrix3;
            int[][] leftMatrix2 =
            {
               new int [] {1,2 },
               new int []  {4,6 },
               new int []  {-1,8 }
            };
            int[][] rightMatrix2 =
            {
               new int [] {-1,5,0 },
               new int []  {-4,0,1 }
            };
            matrix3 = Multiplication(leftMatrix2, rightMatrix2);
            DisplayMatrix(matrix3, matrix3.GetLength(0), matrix3.GetLength(1));


            //Exercice III  Crible d'Eratosthène
            Console.WriteLine("Exo3");

            EratosthenesSieve(100);

            //Exercice IV  Questionnaire à choix multiple
            Console.WriteLine("Exo4");
            //1)b) Car il y a 1 question, plusieurs réponse possible,
            //la solition qui est un entier de l'indice du tableau réponse
            // et un entier pour le coef

            QCM Q1 = new QCM
            {
                Question = "Mais où est donc Ornicar ?",
                Answers = new string[]
                {
                    "Il est ici", "Il est par là", "C'est qui lahuisse ?"
                },
                Solution = 2,
                Weight = 67

            };
            QCM Q2 = new QCM
            {
                Question = "Qui suis-je ?",
                Answers = new string[]
                {
                    "Une chauve-souris chauve assis",
                    "Une chauve-souris chauve qui souris à un chauve",
                    "Une chauve-souris chauve assis qui souris à un chauve qui souris à une souris chauve"
                },
                Solution = 2,
                Weight = 69

            };

            QCM[] qcms = new QCM[] { Q1, Q2 };

            //QcmValidity(Q1);
            //Console.WriteLine(AskQuestion(Q1));

            //Console.WriteLine("taille " + qcms.Length);
            AskQuestions(qcms);





        }
        static void DisplayMatrix(int[,] grille, int ni, int nj)
        {
            for (int i = 0; i < ni; i++)
            {
                for (int j = 0; j < nj; j++)
                {
                    Console.Write(grille[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine(grille.GetLength(0));
        }

        static int[,] BuildingMatrix(int[] leftVector, int[] rightVector)
        {
            int taileLeftVector = leftVector.Length;
            int tailleRightVector = rightVector.Length;
            //int[][] tab = new int[taileLeftVector][tailleRightVector] ;
            int[,] tab = new int[taileLeftVector, tailleRightVector];


            for (int i = 0; i < taileLeftVector; i++)
            {
                for (int j = 0; j < tailleRightVector; j++)
                {
                    tab[i, j] = leftVector[i] * rightVector[j];
                }

            }

            return tab;
        }

        static int[,] Addition(int[][] leftMatrix, int[][] rightMatrix)
        {
            Console.WriteLine("Addition");
            int taileLeft = leftMatrix.Length;
            Console.WriteLine(taileLeft);
            int tailleRight = leftMatrix[1].Length;
            Console.WriteLine(tailleRight);
            //int[][] tab = new int[taileLeftVector][tailleRightVector] ;
            int[,] tab = new int[taileLeft, tailleRight];


            for (int i = 0; i < taileLeft; i++)
            {
                for (int j = 0; j < tailleRight; j++)
                {
                    tab[i, j] = leftMatrix[i][j] + rightMatrix[i][j];
                    //tab[i, j] = leftVector[i] * rightVector[j];
                }

            }

            return tab;
        }

        static int[,] Soustraction(int[][] leftMatrix, int[][] rightMatrix)
        {
            Console.WriteLine("Soustraction");
            int taileLeft = leftMatrix.Length;
            Console.WriteLine(taileLeft);
            int tailleRight = leftMatrix[1].Length;
            Console.WriteLine(tailleRight);
            //int[][] tab = new int[taileLeftVector][tailleRightVector] ;
            int[,] tab = new int[taileLeft, tailleRight];


            for (int i = 0; i < taileLeft; i++)
            {
                for (int j = 0; j < tailleRight; j++)
                {
                    tab[i, j] = leftMatrix[i][j] - rightMatrix[i][j];
                    //tab[i, j] = leftVector[i] * rightVector[j];
                }

            }

            return tab;
        }

        static int[,] Multiplication(int[][] leftMatrix, int[][] rightMatrix)
        {
            int Longueur = leftMatrix.Length; ;


            int Largeur = rightMatrix[1].Length; ;


            int[,] tab = new int[Longueur, Largeur];
            //C,L

            for (int i = 0; i < Longueur; i++)
            {
                for (int j = 0; j < Largeur; j++)
                {
                    for (int k = 0; k < leftMatrix[1].Length; k++)
                    {
                        tab[j, i] = tab[j, i] + leftMatrix[j][k] * rightMatrix[k][i];
                    }

                }

            }

            return tab;
        }


        static int[] EratosthenesSieve(int n)
        {
            int i;
            List<int> listeNumToN = new List<int>();
            for (i = 2; i <= n; i++)
            {
                listeNumToN.Add(i);
            }

            string maListe = string.Join(", ", listeNumToN);
            Console.WriteLine(maListe);
            Console.WriteLine("toto " + listeNumToN.Last());

            for (i = 2; i <= Math.Sqrt((double)listeNumToN.LastOrDefault()); i++)
            {

                for (int j = i * 2; j <= n; j = j + i)
                {

                    if (listeNumToN.Contains(j))
                    {
                        listeNumToN.Remove(j);
                    }

                }

            }

            string newListe = string.Join(", ", listeNumToN);
            Console.WriteLine("test => " + newListe);
            return null;
        }

        public static bool QcmValidity(QCM qcm)
        {
            try
            {
                if (qcm.Solution < 0 || qcm.Solution > qcm.Answers.Length)
                {
                    return false;
                }

                if (qcm.Weight <= 0)
                {
                    return false;
                }

                Console.Write("\n\nChoisir une réponse: ");
                int reponse = Int32.Parse(Console.ReadLine());

                do
                {
                    //Console.WriteLine(reponse + "_" + qcm.Solution);
                    if (reponse > qcm.Answers.Length || reponse <= 0)
                    {
                        Console.WriteLine("Réponse invalide");
                        Console.Write("\n\nChoisir une réponse: ");
                        reponse = Int32.Parse(Console.ReadLine());
                    }
                    else
                    {
                        //gg = QcmValidity(qcm);
                        //Console.WriteLine(reponse + "_" + qcm.Solution);
                        if (reponse - 1 == qcm.Solution)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                } while (reponse > qcm.Answers.Length || reponse <= 0);




                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }



        private static int AskQuestion(QCM qcm)
        {
            //Question
            //bool gg;
            Console.WriteLine("La question est la suivante: " + qcm.Question);
            int count = 1;
            int reponse;
            foreach (string i in qcm.Answers)
            {
                Console.Write(count + ". Réponse: " + i + " | ");
                count++;
            }

            if (QcmValidity(qcm) == true)
            {
                //Console.WriteLine();
                return qcm.Weight;
            }
            else
            {
                return 0;
            }

            

        }

        static void AskQuestions(QCM[] qcm)
        {
            //Questions
            int point = 0;
            Console.WriteLine("taille " + qcm.Length);
            for (int i = 0; i < qcm.Length; i++)
            {
                Console.WriteLine("La question est la suivante: " + qcm[i].Question);
                int count = 1;
                int reponse;
                foreach (string it in qcm[i].Answers)
                {
                    Console.Write(count + ". Réponse: " + it + " | ");
                    count++;
                }

                if (QcmValidity(qcm[i]) == true)
                {
                    point += qcm[i].Weight;
                    Console.WriteLine("Bonne réponse: +" + qcm[i].Weight+ " points");
                }
                else
                {
                    Console.WriteLine("Looser");
                }
            }

            Console.WriteLine("Voici tes points : " + point);            



        }







    }
}
