using System;
using System.Collections.Generic;

namespace ProjetSilver
{

    public class Banque
    {
        public string NomBanque { get; set; }
        // Pour compte bancaire et les cartes, des dicos auraient pu être intéressants
        private List<CompteBancaire> _listeComptesBancaire;
        private List<CarteBancaire> _listeCartesBancaire;
        private List<Transaction> _listeTransactions;

        public Banque(string nomBanque)
        {
            Console.WriteLine($"La banque {nomBanque} arrive sur le marché");
            NomBanque = nomBanque;
            _listeComptesBancaire = new List<CompteBancaire>();
            _listeCartesBancaire = new List<CarteBancaire>();
            _listeTransactions = new List<Transaction>();
        }


        public void NouvelleCarte(int numeroCarte, double plafond = 500)
        {
            _listeCartesBancaire.Add(new CarteBancaire(numeroCarte, plafond));
        }

        public void NouveauCompte(int identifiant, int numeroCb, byte typeSolde, decimal Solde = 0)
        {
            CompteBancaire cb = new CompteBancaire(identifiant, numeroCb, typeSolde, Solde);
            _listeComptesBancaire.Add(cb);
            foreach (var item in _listeCartesBancaire)
            {
                if (item.NumeroCarte == numeroCb)
                {
                    item.AjoutCompteBancaire(cb);
                }
            }
        }

        public void NouvelleTransaction(int identifiant, DateTime horodatage, decimal montant, int expediteur, int destinataire)
        {
            if (RechercheSoldeCompte(expediteur, montant) && Plafond(expediteur, montant))
            {
                _listeTransactions.Add(new Transaction(identifiant, horodatage, montant, expediteur, destinataire));
                Transfert(expediteur, destinataire, montant);
                Console.WriteLine(" __Transfert OK__ ");
                SortieStatuts sortieStatuts = new SortieStatuts(identifiant, true);
            }
            else
            {
                SortieStatuts sortieStatuts = new SortieStatuts(identifiant, false);
                Console.WriteLine($"Le compte {expediteur} n'a pas de tal pour la transaction {identifiant}");
            }

        }

        public void Transfert(int expediteur, int destinataire, decimal montant)
        {
            foreach (var item in _listeComptesBancaire)
            {
                if (item.IdentifiantBancaire == expediteur)
                {
                    item.Virement(montant);
                }
                if (item.IdentifiantBancaire == destinataire)
                {
                    item.Prelevement(montant);
                }
            }
        }

        // Elle est bien cette méthode, mais pas utilisée - à supprimer 
        public void Depot(int compte, decimal montant)
        {
            if (montant > 0)
            {
                foreach (var item in _listeComptesBancaire)
                {
                    if (item.IdentifiantBancaire == compte)
                    {
                        item.Depot(montant);
                    }
                }
            }
            else
            {
                Console.WriteLine("Depot a tort, montant incorrecte");
            }

        }

        // Elle est bien cette méthode, mais pas utilisée - à supprimer 
        public void Retrait(int compte, decimal montant)
        {
            if (montant > 0)
            {
                foreach (var item in _listeComptesBancaire)
                {
                    if (item.IdentifiantBancaire == compte)
                    {
                        item.Retrait(montant);
                    }
                }
            }
            else
            {
                Console.WriteLine("Retrait a tort, montant incorrecte");
            }
        }


        public bool Plafond(int NumeroCompte, decimal montant)
        {
            decimal balance = 0;
            int nbreSeconde;
            int dixJours = 864000;
            TimeSpan compare;
            foreach (var item in _listeTransactions)
            {
                if (item.RetournerExpediteur() == NumeroCompte)

                {
                    // DateTime.AddDays(10) existe - TimeSpan n'est pas obligatoire, mais ok
                    compare = DateTime.Now - item.RetournerHorodatage();
                    nbreSeconde = Math.Abs((int)compare.TotalSeconds);
                    if (nbreSeconde < dixJours)
                    {
                        balance = balance + item.RetournerMontant();
                    }

                }
                if (item.RetournerDestinataire() == NumeroCompte)

                {
                    compare = DateTime.Now - item.RetournerHorodatage();
                    nbreSeconde = Math.Abs((int)compare.TotalSeconds);
                    if (nbreSeconde < dixJours)
                    {
                        balance = balance - item.RetournerMontant();
                    }

                }

            }

            foreach (var item in _listeCartesBancaire)
            {
                if (NumeroCompte == item.RetournerCompte())
                {
                    if (item.RetournerPlafond() >= (double)balance)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }
        public bool ChercheExistenceCarte(int NumeroCarte)
        {
            foreach (var item in _listeCartesBancaire)
            {
                if (item.NumeroCarte == NumeroCarte)
                {
                    return false;
                }
            }

            return true;
        }
        public bool ChercheExistenceCompte(int NumeroCompte)
        {
            foreach (var item in _listeComptesBancaire)
            {
                if (item.IdentifiantBancaire == NumeroCompte)
                {
                    return false;
                }
            }

            return true;
        }

        public bool ChercheExistenceTransaction(int NumeroTransaction)
        {
            foreach (var item in _listeTransactions)
            {
                if (item.NumeroTransaction == NumeroTransaction)
                {
                    return false;
                }
            }

            return true;
        }

        public bool RechercheSoldeCompte(int numeroCompte, decimal montant)
        {
            foreach (var item in _listeComptesBancaire)
            {
                if (item.IdentifiantBancaire == numeroCompte)
                {
                    if (item.SoldeCompte() >= montant)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }
        public void ListeDesComptes()
        {
            foreach (var item in _listeComptesBancaire)
            {
                item.AffichageCompte();
            }
        }

        public void ListeDesCartes()
        {
            foreach (var item in _listeCartesBancaire)
            {
                item.AffichageCarte();
            }
        }

        public void ListeDesTransactions()
        {
            foreach (var item in _listeTransactions)
            {
                item.AffichageTransaction();
            }
        }
    }

}
