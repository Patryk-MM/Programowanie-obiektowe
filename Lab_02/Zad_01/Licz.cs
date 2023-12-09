using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Zad_01
{
    internal class Licz
    {
        int value;

        public void Add(int number) {
            value += number;
            WriteLine(value);
        }

        public void Subtract(int number)
        {
            value -= number;
            WriteLine(value);
        }

        public void View()
        {
            WriteLine(value);
        }

        public Licz(int value)
        {
            this.value = value;
        }
    }
}
