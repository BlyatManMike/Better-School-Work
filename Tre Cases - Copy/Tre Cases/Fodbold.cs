using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasser;

namespace Tre_Cases
{
    public class Fodbold
    {
        public void Spil()
        {
            Console.Write("Hvor mange afleveringer blev der spillet?: ");
            int afl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mål?: ");
            string mål = Console.ReadLine().ToUpper();
            Console.Clear();
            if (afl < 10 && afl >= 1)
            {
                Console.WriteLine("Huh! Huh! Huh!");
            }
            else if (afl < 1)
            {
                Console.WriteLine("Shh");
            }
            else if (afl >= 10)
            {
                Console.WriteLine("High Five - Jubel!!!");
            }
            if (mål == "MÅL")
            {
                Console.WriteLine("Olé Olé Olé");
            }
            Console.ReadKey();
        }
    }
}
