using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    public class FodboldClass
    {
        public string Jubel(int afl, string mål)
        {
            
            string respons = "";
            if (afl < 10 && afl >= 1)
            {
                while (afl > 0)
                {
                    respons += "Huh!";
                    afl--;
                }
            }
            else if (afl < 1)
            {
                respons = "Shh";
            }
            else if (afl >= 10)
            {
                respons = "High Five - Jubel!!!";
            }
            if (mål == "MÅL")
            {
                respons = "Olé Olé Olé";
            }
            return respons;
        }
    }
}
