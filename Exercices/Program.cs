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

    class Program
    {
        static void Main(string[] args)
        {
            //Serie2026();
            Serie2022();


            Console.WriteLine("\n\nAppuie sur une touche pour finir");
            Console.ReadKey();
        }
        static void Serie2026()
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
            //2)b).
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

        static void IntegerDivision(int a,int b)
        {
            int q,r;
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
            for(int i=1; i <= b; i++)
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
                for (int k = 0; k < 2*n; k++)
                {
                    if (k > n-j && k < n+j )
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
                    if (j%2 != 0)
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


        static void Serie2022()
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
            for (int i =0; i <= Racine; i++)
            {
                for (int j=0; j < value; j++)
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
            for(int i=0; i <= 100;i++)
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
                if (r==0)
                {
                    return b;
                }
                else
                {
                    return Gcd(b, r);
                }
            }
        }
    }
}
