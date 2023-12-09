using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_03
{
    internal class Person
    {
        private string name;
        private int pesel;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Pesel
        {
            get { return pesel; }
            set { pesel = value; }
        }

        public Person(string name, int pesel)
        {
            this.name = name;
            this.pesel = pesel;
        }

        public void View()
        {
            WriteLine($"Imię: {name}, pesel: {pesel}");
        }
    }
}
