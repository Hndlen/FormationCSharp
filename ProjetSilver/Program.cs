using System;
using System.IO;
using System.Text;

namespace ProjetSilver
{
    enum TypeSolde : byte
    {
        Courant,
        Livret

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _ Debut _ \n");
            Directory.SetCurrentDirectory($"../../../FileSection");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Banque CreditMutuel = new Banque("Credit Mutuel");
            EntreeCarte fichiersEntreesCarte = new EntreeCarte(CreditMutuel);
            EntreeCompte fichiersEntreesCompte = new EntreeCompte(CreditMutuel);
            Console.WriteLine("\n\n\n\n\n Affichage Avant Transaction\n\n\n");
            CreditMutuel.ListeDesComptes();
            EntreeTransaction fichiersEntreesTransaction = new EntreeTransaction(CreditMutuel);
            Console.WriteLine("\n\n\n\n\n Affichage Apres Transaction\n\n\n");
            CreditMutuel.ListeDesComptes();

            Console.WriteLine("Affichage des Cartes :");
            CreditMutuel.ListeDesCartes();
            Console.WriteLine("Affichage des transactions :");
            CreditMutuel.ListeDesTransactions();


            

            EndPerform();

        }




        static void EndPerform()
        {
            Console.WriteLine("\n _ Fin _ \n");
            Console.WriteLine("\n\nAppuie sur une touche pour finir");
            Console.ReadKey();
        }


        
    }
}
