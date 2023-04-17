using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    public class DansClass
    {
        public string Point(string Danser1, string Danser2, int Danser1point, int Danser2point)
        {
            Danser1 = Danser1 + " & " + Danser2 + " scoret " + (Danser1point + Danser2point) + " point.";
            return Danser1;
        }
    }
}
