using Or.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Or.Models
{
    public enum TypeCompte { Courant, Livret }

    public class Compte
    {
        public int Id { get; set; }
        public long IdentifiantCarte { get; set; }
        public TypeCompte TypeDuCompte { get; set; }
        public decimal Solde { get; private set; }


        public Compte(int id, long identifiantCarte, TypeCompte type, decimal soldeInitial)
        {
            Id = id;
            IdentifiantCarte = identifiantCarte;
            TypeDuCompte = type;
            Solde = soldeInitial;
        }

        /// <summary>
        /// Action de dépôt d'argent sur le compte bancaire
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>Statut du dépôt</returns>
        /// 

        public decimal SoldeCarteActuel(DateTime date, long numCarte)
        {
            Carte CartePorteur = SqlRequests.InfosCarte(numCarte);
            /*List<Transaction> retraitsHisto = CartePorteur.Historique.Where(x => (x.Horodatage > date.AddDays(-10)) && CartePorteur.ListComptesId.Contains(x.Expediteur)).Select(x => x).ToList();
            decimal sommeHisto = retraitsHisto.Sum(x => x.Montant);*/
            decimal sommeHisto = CartePorteur.PlafondActualise(date);

            foreach (var item in CartePorteur.Historique)
            {
                MessageBox.Show(item.Montant.ToString());
            }
            
            //decimal sommeHisto = CartePorteur.Historique.Sum(x => x.Montant);

            /*int dixJours = 864000;
            decimal balance = 0;
            int nbreSeconde;
            TimeSpan compare;
            foreach (var item in CartePorteur.Historique)
            {
                compare = date - item.Horodatage;
                nbreSeconde = Math.Abs((int)compare.TotalSeconds);
               // if (nbreSeconde < dixJours)
                {
                    balance = balance + item.Montant;
                }
            }*/

            if (sommeHisto > CartePorteur.Plafond)
            {
                return -10;
            }
            else
            {
                return sommeHisto;
               //return CartePorteur.Plafond - sommeHisto;

            }
            
        }


        public bool EstDepotValide(Transaction transaction)
        {
            if (transaction.Montant > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Action de retrait d'argent sur le compte bancaire
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>Statut du retrait</returns>
        public bool EstRetraitValide(Transaction transaction)
        {
            if (EstRetraitAutorise(transaction.Montant))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EstRetraitAutorise(decimal montant)
        {
            return Solde >= montant && montant > 0;
        }

    }
}
