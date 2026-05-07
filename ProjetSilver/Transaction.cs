using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProjetSilver
{
    class Transaction
    {
        public static int NbrTransactions { get; private set; } = 0;
        public int NumeroTransaction { get; }
        private int IdentifiantExpediteur { get; set; }
        private int IdentifiantDestinataire { get; set; }
        
        private decimal Montant { get; set; }
        private DateTime Horodatage { get; set; }
        
        public Transaction(int numeroTransaction,DateTime horodatage, decimal montant,int expediteur, int destinataire)
        {
            NbrTransactions++;
            this.NumeroTransaction = numeroTransaction;
            this.Horodatage = horodatage;
            this.Montant = montant;
            this.IdentifiantExpediteur = expediteur;
            this.IdentifiantDestinataire = destinataire;

            Console.WriteLine($"Nouvelle transaction {NumeroTransaction} {Horodatage} {Montant.ToString("C", new CultureInfo("fr-FR"))}");
            Console.WriteLine($"    De {FormatExpediteur} à {FormatDestinataire}");
        }
        public int RetournerExpediteur()
        {
            return this.IdentifiantExpediteur;
        }
        public int RetournerDestinataire()
        {
            return this.IdentifiantDestinataire;
        }

        public DateTime RetournerHorodatage()
        {
            return this.Horodatage;
        }
        public decimal RetournerMontant()
        {
            return this.Montant;
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
