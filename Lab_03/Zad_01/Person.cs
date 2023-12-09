using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_01 {
    internal class Person {
        private int age;
        private string firstName;
        private string lastName;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age) {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void View() {
            Console.Write($"Imie:\t{FirstName}\tNazwisko:\t{LastName}\tWiek:\t{Age}\n");
        }
    }
}
