using System;
using System.IO;

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
            Banque CreditMutuel = new Banque("Credit Mutuel");
            EntreeCarte fichiersEntreesCarte = new EntreeCarte(CreditMutuel);
            EntreeCompte fichiersEntreesCompte = new EntreeCompte(CreditMutuel);
            Console.WriteLine("\n\n\n\n\n Avant");
            CreditMutuel.ListeDesComptes();
            EntreeTransaction fichiersEntreesTransaction = new EntreeTransaction(CreditMutuel);
            Console.WriteLine("\n\n\n\n\n Apres");
            CreditMutuel.ListeDesComptes();
            //
            //CreditMutuel.ListeDesCartes();
            CreditMutuel.ListeDesTransactions();


            

            EndPerform();
        }




        static void EndPerform()
        {
            Console.WriteLine("\n\nAppuie sur une touche pour finir");
            Console.ReadKey();
        }


        
    }
}
