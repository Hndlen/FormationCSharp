using System.Collections.Generic;
using System.IO;

namespace ProjetSilver
{


    class SortieStatuts
    {
        public struct Statuts
        {
            public int Identifiant { get; set; }
            public string Statut { get; set; }
            public void nouveauStatut(int identifiant, string statut)
            {
                Identifiant = identifiant;
                Statut = statut;
            }
        }

        public List<Statuts> statut { get; private set; }

        public const string nomFichierStatut = "ExportStatuts.txt";

        public SortieStatuts(int identifiant, bool etat)
        {
            string stat;


            statut = new List<Statuts>();
            Statuts st = new Statuts();
            if (etat)
            {
                // Attention, c'est OK pas Ok
                stat = "OK";
            }
            else
            {
                stat = "KO";
            }
            st.nouveauStatut(identifiant, stat);

            using (StreamWriter w = File.AppendText(nomFichierStatut))
            {
                w.WriteLine($"{identifiant};{stat}");
            }
        }

        public void Archivage()
        {

        }
    }
}
