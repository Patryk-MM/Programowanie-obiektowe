using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Zad_04 {
    internal class Liczba {
        public int[] cyfry;
        public string liczba;

        public Liczba(string liczba) {
            this.liczba = liczba;
        }

        public void StringToArray() {
            cyfry = liczba.Select(c => c - '0').ToArray();
        }

        public void Cyfry() {
            foreach (int i in cyfry) {
                Write(i);
            }
        }
    }
}
