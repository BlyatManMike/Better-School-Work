using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasser;

namespace Tre_Cases_2._0
{
    public class Fodbold : FodboldClass
    {
        public void BoldScore()
        {
           
            Console.Clear();
            Console.Write("Hvor mange afleveringer blev der spillet?: ");
            int afl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mål?: ");
            string mål = Console.ReadLine().ToUpper(); ;
            Console.Clear();
            var Svar = new FodboldClass();
            Console.Clear();
            Console.WriteLine(Svar.Jubel(afl, mål));
            Console.ReadKey();
        }
    }
}
