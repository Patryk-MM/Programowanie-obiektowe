using Zad_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_01 {
    internal class Reader : Person {
        public Book[] ReadBooks { get; set; }

        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age) {
            ReadBooks = new Book[0];
        }

        public override void View() {
            base.View();
            Console.WriteLine($"Książki przeczytane przez {FirstName} {LastName}: ");
            ViewBook();
        }

        public void ViewBook() {
            Console.WriteLine($"");
            foreach (Book book in ReadBooks) {
                Console.WriteLine(book.Title);
            }
        }
    }
}
