using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_02
{
    internal class Car
    {
        string marka, model, kolor;
        protected double pojSilnika;
        public int rocznik;

        public void View()
        {
            WriteLine($"{marka}, {model}, {kolor}, {pojSilnika}, {rocznik}");
        }
        public Car(string marka, string model, string kolor, double pojSilnika, int rocznik)
        {
            this.marka = marka;
            this.model = model;
            this.kolor = kolor;
            this.pojSilnika = pojSilnika;
            this.rocznik = rocznik;
        }
    }
}
