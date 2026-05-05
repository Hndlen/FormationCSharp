using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie4
{
    public static class ClassCouncil
    {
        public static void SchoolMeans(string input, string output)
        {
            Dictionary<string, float> Output = new Dictionary<string, float>();

            IEnumerable<String> Ligne = System.IO.File.ReadLines(input);
            string[] decompose;
            string newLine;
            int count = 0;
            float sommeNote = 0;
            float moyenne = 0;
            string rupture = "";
            foreach (var item in Ligne)
            {
                decompose = item.Split(';');
                if(rupture == "")
                {
                    rupture = decompose[1];
                }

                if(rupture == decompose[1])
                {
                    sommeNote = sommeNote + float.Parse(decompose[2],CultureInfo.InvariantCulture.NumberFormat);
                    count++;
                }
                else
                {
                    moyenne = sommeNote / count;
                    Output.Add(rupture, moyenne);

                    sommeNote = 0;
                    count = 0;
                    rupture = decompose[1];
                }

            }
            moyenne = sommeNote / count;
            Output.Add(rupture, moyenne);

            using (StreamWriter op = new StreamWriter(output))
            {
                foreach (var item in Output)
                {
                    newLine = item.Key + ";" + item.Value;
                    op.WriteLine(newLine);

                }
            }

        }
    }
    
}
