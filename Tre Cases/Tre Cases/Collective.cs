using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasser;

namespace Tre_Cases
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

            while (loop == true)
            {
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
                            Fodbold.Spil();
                            break;
                        }
                    case (ConsoleKey.P):
                        {
                            Password.Change();
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
