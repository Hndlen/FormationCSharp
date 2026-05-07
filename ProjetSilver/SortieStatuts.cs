using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
                this.Identifiant = identifiant;
                this.Statut = statut;
            }
        }

       

        public List<Statuts> statut { get; private set; }

        public const string nomFichierStatut = "ExportStatuts.txt";

         public SortieStatuts(int identifiant,bool etat)
        {
            string[] decompose;
            string stat;


            statut = new List<Statuts>();
            Statuts st = new Statuts();
            if(etat)
            {
                stat = "Ok";
            }
            else
            {
                stat = "Ko";
            }
            st.nouveauStatut(identifiant, stat);

            using (StreamWriter w = File.AppendText(nomFichierStatut))
            {
                w.WriteLine($"{identifiant};{stat}");
            }

            /*using (StreamWriter op = new StreamWriter(output))
            {
                foreach (var item in Output)
                {
                    newLine = item.Key + ";" + item.Value;
                    op.WriteLine(newLine);

                }
            };*/

        }

        public void Archivage()
        {

        }
    }
}
