using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    internal class Prostokat : IFigura2D
    {
        double a = 4, b = 5;
        public double Obwod()
        {
            return 2 * a + 2 * b;
        }
        public double Pole()
        {
            return a * b;
        }
       
    }
}
