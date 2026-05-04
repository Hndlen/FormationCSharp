using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie3
{
    public class AdministrativeTasks
    {
        public static string EliminateSeditiousThoughts(string text, string[] prohibitedTerms)
        {
            
            string str= text;
            string censure="";
            foreach( string i in prohibitedTerms)
            {
               // str =
                foreach (char j in i)
                {
                    censure = censure + "X";
                }
                str = str.Replace(i,censure);
                censure = "";
            }
            //return string.Empty;
            return str;
        }

        public static bool ControlFormat(string line)
        {
            string s = line;
            string[] titre = { "M.", "Mme.", "Mlle." };
            


           
            if (s.Substring(0, 5).CompareTo("M.   ") == 0
                || s.Substring(0, 5).CompareTo("Mme. ") == 0
                || s.Substring(0, 5).CompareTo("Mlle.") == 0)
            {
               
                if (s.Substring(5, 12).Trim().All(char.IsLetter)==true)
                {
                    
                    if (s.Substring(17, 12).Trim().All(char.IsLetter) == true)
                    {
                       
                        if (s.Substring(29, 2).All(char.IsDigit) == true)
                        {
                            
                            return true;
                        }
                        else
                        {
                            
                            return false;
                        }
                    }
                    else
                    {
                        
                        return false;
                    }
                }

                else
                {
                    
                    return false;
                }
            }
            else
            {
                
                return false;
            }
           

        }

        public static string ChangeDate(string report)
        {
            //TODO
            int count = 0;
            
            foreach( char i in report)
            {
                if (i.ToString().All(char.IsDigit) == true)
                {
                    break;
                }
                count++;
            }
            string newDate = $"{report.Substring(count+8,2)}-{report.Substring(count + 5, 2)}-{report.Substring(count + 2, 2)}";

            return report.Replace(report.Substring(count , 10),newDate);
        }
    }
}
