using Serie4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Serie4
    {
        
        public void Serie4_2026()
        {
            Directory.SetCurrentDirectory($"../../FileSection");
            Console.WriteLine("Serie 4");
            //Exercice I  Conseil de classe
            Ex1();
            // Exercice II  Morpion partie II

            Ex2();

        }

        public void Ex1()
        {
            //ClassCouncil ex1 ;
            Console.WriteLine("Exo 1");
            string fileInput = "Ex1Input.txt";
            string fileOutput = "Ex1Output.txt";
            ClassCouncil.SchoolMeans(fileInput, fileOutput);

        }

        public void Ex2()
        {
            Console.WriteLine("Exo 2");
            Morpion.MorpionGame();
            
        }
    }
}
