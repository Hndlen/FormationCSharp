using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie3
{
    public class Cesar
    {
        private readonly char[,] _cesarTable;

        public Cesar()
        {
            _cesarTable = new char[,]
            {
                { 'A', 'D' },
                { 'B', 'E' },
                { 'C', 'F' },
                { 'D', 'G' },
                { 'E', 'H' },
                { 'F', 'I' },
                { 'G', 'J' },
                { 'H', 'K' },
                { 'I', 'L' },
                { 'J', 'M' },
                { 'K', 'N' },
                { 'L', 'O' },
                { 'M', 'P' },
                { 'N', 'Q' },
                { 'O', 'R' },
                { 'P', 'S' },
                { 'Q', 'T' },
                { 'R', 'U' },
                { 'S', 'V' },
                { 'T', 'W' },
                { 'U', 'X' },
                { 'V', 'Y' },
                { 'W', 'Z' },
                { 'X', 'A' },
                { 'Y', 'B' },
                { 'Z', 'C' }
            };
        }

        public string CesarCode(string line)
        {
            string str = "";
            char lettre =' ';
            for (int i = 0; i < line.Length; i++)
            {
 
                for (int j = 0; j < _cesarTable.GetLength(0); j++)
                {
                     if (_cesarTable[j, 0] == line[i])
                     {
                        lettre = _cesarTable[j, 1];
                         break;
                     }
                 }
                str = str + lettre;

            }
            return str; 
        }

        public string DecryptCesarCode(string line)
        {
            string str = "";
            char lettre = ' ';
            for (int i = 0; i < line.Length; i++)
            {

                for (int j = 0; j < _cesarTable.GetLength(0); j++)
                {
                    if (_cesarTable[j, 1] == line[i])
                    {
                        lettre = _cesarTable[j, 0];
                        break;
                    }
                }
                str = str + lettre;

            }
            return str;
        }

        public string GeneralCesarCode(string line, int x)
        {
            char[] alpha = new char[52];
            for (int i =0; i < alpha.Length/2; i++ )
            {
                alpha[i] = _cesarTable[i, 0];
                alpha[i+26] = _cesarTable[i, 0];

            }

            string str = "";
            char lettre = ' ';
            for (int i = 0; i < line.Length; i++)
            {

                for (int j = 0; j < alpha.Length/2; j++)
                {
                    if (alpha[j] == line[i])
                    {
                        lettre = alpha[j+x];
                        break;
                    }
                }
                str = str + lettre;

            }
            return str;
        }

        public string GeneralDecryptCesarCode(string line, int x)
        {
            char[] alpha = new char[52];
            for (int i = 0; i < alpha.Length / 2; i++)
            {
                alpha[i] = _cesarTable[i, 0];
                alpha[i + 26] = _cesarTable[i, 0];

            }

            string str = "";
            char lettre = ' ';
            for (int i = 0; i < line.Length; i++)
            {

                for (int j = 26; j < alpha.Length ; j++)
                {
                    if (alpha[j] == line[i])
                    {
                        lettre = alpha[j - x];
                        break;
                    }
                }
                str = str + lettre;

            }
            return str;
        }
    }
}
