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

    // valable pour la plupart des fichiers, les this ne sont pas nécessaire
    // à l'intérieur des définitions des classes si on fait référence à des membres d'une instance de cette classe

    class Program
    {
        // Bien ! Main ne contient pas de fonctionnel
        static void Main(string[] args)
        {
            Console.WriteLine(" _ Debut _ \n");
            Directory.SetCurrentDirectory($"../../../FileSection");
            Console.OutputEncoding = Encoding.UTF8;

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
