using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Zad_02 {
    internal class Sumator {
        private int[] Liczby;
        public int Suma() {
            int wynik = 0;
            foreach (int item in Liczby) {
                wynik += item;
            }
            return wynik;
        }
        public int SumaPodzielnych() {
            int wynik = 0;
            foreach (int item in Liczby) {
                if (item % 2 == 0) {
                    wynik += item;
                }
            }
            return wynik;
        }

        public int ElementCount() {
            return Liczby.Length;
        }

        public void PrintElements() {
            foreach (int item in Liczby) {
                Write($"{item}, ");
            }
            WriteLine();
        }

        public void LowHighIndex(int lowIndex, int highIndex) {
            foreach (var item in Liczby) {
                if (item >= lowIndex && item <= highIndex) {
                    Write($"{item}, ");
                }
            }
            WriteLine();
        }

        public Sumator(int[] tablica) {
            this.Liczby = tablica;
        }
    }
}
