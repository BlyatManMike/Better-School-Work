﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klasser;

namespace Tre_Cases_2._0
{
    public class Dans : DansClass
    {
        public void DansPoint()
        {
            string Danser1, Danser2;
            int Danser1point, Danser2point;
            Console.Clear();
            Console.Write("Navn på danser nr. 1 :");
            Danser1 = Console.ReadLine();
            Console.Clear();
            Console.Write("Hvor mange point fik de: ");
            Danser1point = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Navn på danser nr. 2 :");
            Danser2 = Console.ReadLine();
            Console.Clear();
            Console.Write("Hvor mange point fik de: ");
            Danser2point = Convert.ToInt32(Console.ReadLine());
            var Svar = new DansClass();
            Console.Clear();

            Console.WriteLine(Svar.Point(Danser1, Danser2, Danser1point, Danser2point));
            Console.ReadKey();

        }
    }
}
