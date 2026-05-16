using System;
using System.Globalization;

namespace ProjetSilver
{
    class Transaction
    {
        public static int NbrTransactions { get; private set; } = 0;
        public int NumeroTransaction { get; }
        private int IdentifiantExpediteur { get; }
        private int IdentifiantDestinataire { get; }
        
        private decimal Montant { get; }
        private DateTime Horodatage { get; }
        
        public Transaction(int numeroTransaction,DateTime horodatage, decimal montant,int expediteur, int destinataire)
        {
            NbrTransactions++;
            NumeroTransaction = numeroTransaction;
            Horodatage = horodatage;
            Montant = montant;
            IdentifiantExpediteur = expediteur;
            IdentifiantDestinataire = destinataire;

            Console.WriteLine($"Nouvelle transaction {NumeroTransaction} {Horodatage} {Montant.ToString("C", new CultureInfo("fr-FR"))}");
            Console.WriteLine($"    De {FormatExpediteur} à {FormatDestinataire}");
        }
        public int RetournerExpediteur()
        {
            return IdentifiantExpediteur;
        }
        public int RetournerDestinataire()
        {
            return IdentifiantDestinataire;
        }

        // Pourquoi tu fais des gets si tu as les propriétés ??
        public DateTime RetournerHorodatage()
        {
            return Horodatage;
        }
        public decimal RetournerMontant()
        {
            return Montant;
        }
        public string FormatExpediteur
        {
            get { return IdentifiantExpediteur.ToString("0###-####-####-####"); }
        }
        public string FormatDestinataire
        {
            get { return IdentifiantDestinataire.ToString("0###-####-####-####"); }
        }

        public void AffichageTransaction()
        {
            Console.WriteLine("");
            Console.WriteLine($">>>Transaction {NumeroTransaction} {Horodatage} {Montant.ToString("C", new CultureInfo("fr-FR"))}");
            Console.WriteLine($"    De {FormatExpediteur} à {FormatDestinataire}");

        }
    }
}
