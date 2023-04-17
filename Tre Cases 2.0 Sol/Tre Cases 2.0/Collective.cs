using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_Cases_2._0
{
    internal class Collective
    {
        static void Main()
        {
            ConsoleKeyInfo Menuvalg;
            var Dans = new Dans();
            var Fodbold = new Fodbold();
            var Password = new Password();

            bool loop = true;

            Password.PassCheck();
            while (loop == true)
            {
                Console.Clear();
                Console.WriteLine("--Tryk forbogstavet for at vælge--");
                Console.WriteLine("\nDans\nFodbold\nPassword skift\nQuit");

                Menuvalg = Console.ReadKey(true);

                switch (Menuvalg.Key)
                {
                    case (ConsoleKey.D):
                        {
                            Dans.DansPoint();
                            break;
                        }
                    
                    case (ConsoleKey.F):
                        {
                            Fodbold.BoldScore();
                            break;
                        }
                    
                    case (ConsoleKey.P):
                        {
                            Password.PassChange();
                            break;
                        }
                    case (ConsoleKey.Q):
                        {
                            loop = false;
                            break;
                        }

                }

            }
        }
    }
}
