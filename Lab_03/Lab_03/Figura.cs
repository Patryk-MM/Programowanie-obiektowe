using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    abstract class Figura
    {
        public abstract double Pole();

        public void View()
        {
            Console.WriteLine("Zwykła figura klasy abs");
        }
    }
}
