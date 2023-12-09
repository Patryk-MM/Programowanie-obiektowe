using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_01 {
    internal class Book {

        protected string title;
        protected Person author;
        protected DateTime datePublication;
        public string Title { get; set; }
        public Person Author { get; set; }
        public DateTime DatePublication { get; set; }

        public Book(string title, Person author, DateTime datePublication) {
            Title = title;
            Author = author;
            DatePublication = datePublication;
        }

        public void View() {
            Console.Write($"Tytul:\t{Title}\nAutor:\t");
            Author.View();
            Console.Write($"\tData publikacji: {DatePublication.ToShortDateString()}\n");

        }
    }
}
