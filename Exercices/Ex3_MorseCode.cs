using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie3
{
    public class Morse
    {
        private const string Taah = "===";
        private const string Ti = "=";
        private const string Point = ".";
        private const string PointLetter = "...";
        private const string PointWord = ".....";

        private readonly Dictionary<string, char> _alphabet;

        public Morse()
        {
            _alphabet = new Dictionary<string, char>()
            {
                {$"{Ti}.{Taah}", 'A'},
                {$"{Taah}.{Ti}.{Ti}.{Ti}", 'B'},
                {$"{Taah}.{Ti}.{Taah}.{Ti}", 'C'},
                {$"{Taah}.{Ti}.{Ti}", 'D'},
                {$"{Ti}", 'E'},
                {$"{Ti}.{Ti}.{Taah}.{Ti}", 'F'},
                {$"{Taah}.{Taah}.{Ti}", 'G'},
                {$"{Ti}.{Ti}.{Ti}.{Ti}", 'H'},
                {$"{Ti}.{Ti}", 'I'},
                {$"{Ti}.{Taah}.{Taah}.{Taah}", 'J'},
                {$"{Taah}.{Ti}.{Taah}", 'K'},
                {$"{Ti}.{Taah}.{Ti}.{Ti}", 'L'},
                {$"{Taah}.{Taah}", 'M'},
                {$"{Taah}.{Ti}", 'N'},
                {$"{Taah}.{Taah}.{Taah}", 'O'},
                {$"{Ti}.{Taah}.{Taah}.{Ti}", 'P'},
                {$"{Taah}.{Taah}.{Ti}.{Taah}", 'Q'},
                {$"{Ti}.{Taah}.{Ti}", 'R'},
                {$"{Ti}.{Ti}.{Ti}", 'S'},
                {$"{Taah}", 'T'},
                {$"{Ti}.{Ti}.{Taah}", 'U'},
                {$"{Ti}.{Ti}.{Ti}.{Taah}", 'V'},
                {$"{Ti}.{Taah}.{Taah}", 'W'},
                {$"{Taah}.{Ti}.{Ti}.{Taah}", 'X'},
                {$"{Taah}.{Ti}.{Taah}.{Taah}", 'Y'},
                {$"{Taah}.{Taah}.{Ti}.{Ti}", 'Z'},
            };
        }

        public int LettersCount(string code)
        {
            //TODO
            if(code != null)
            {
                return code.Length;
            }
            else
            {
                return -1;
            }
            
        }

        public int WordsCount(string code)
        {
            int count = 1;
            if (code != null)
            {
                foreach (char i in code.Trim())
                {
                    if (i == ' ')
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return -1;
            }
   
        }

        

        public string MorseTranslation(string code)
        {
            int count=0;
            int cnt =0;
            string str = "";
            string mot = "";
            string lettre = "";
            string separator = PointWord + PointLetter;

            for( int i = 0; i < code.Length; i++)
            {
                
                count = code.IndexOf(separator, i);
                
                if(count != -1)
                {
                    mot = code.Substring(i, count-i);
                    i = count + separator.Length - 1;
                }
                else
                {
                    mot = code.Substring(i, code.Length - i);
                    i = code.Length;
                }
                    for (int j = 0; j < mot.Length; j++)
                    {
                        cnt = mot.IndexOf(PointLetter, j);

                        {
                            if (cnt != -1)
                            {
                                lettre = mot.Substring(j, cnt - j);
                                j = cnt + PointLetter.Length - 1;
                            }
                            else
                            {
                                lettre = mot.Substring(j, mot.Length - j);
                                j = mot.Length;
                            }

                            for (int k = 0; k < 26; k++)
                            {

                                if (lettre == _alphabet.Keys.ElementAt(k))
                                {

                                    str = str + _alphabet.Values.ElementAt(k) ;

                                }
                            }

                        }
   

                    }

                str = str + " ";

            }

            return str;

            
        }



        public string EfficientMorseTranslation(string code)
        {
            code.TrimStart(' ', '.');
            return code;
        }


        public string MorseEncryption(string sentence)
        {
            string str = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    //str = str + "_";
                    str = str + PointWord;
                }
                else
                {
                    for (int j = 0; j < 26; j++)
                    {
                        if (sentence[i] == _alphabet.Values.ElementAt(j))
                        {
                            str = str + _alphabet.Keys.ElementAt(j) + PointLetter;
                        }
                    }
                }
            }
            return str;

        }


    }
}
