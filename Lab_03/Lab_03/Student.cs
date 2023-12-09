using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_03
{
    internal class Student: Person
    {
        private string nrAlbumu;
        public string NrAlbumu { 
            get { return nrAlbumu; }
            set { nrAlbumu = value; }
        }

        public Student(string Name, int Pesel, string nrAlbumu) : base(Name, Pesel)
        {
            this.nrAlbumu= nrAlbumu;
        }

        public void ViewStudent()
        {
            View();
            WriteLine(NrAlbumu);
        }
    }
}
