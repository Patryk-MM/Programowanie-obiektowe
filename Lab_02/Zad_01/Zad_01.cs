using Zad_01;
using static System.Console;

Licz liczba1 = new Licz(4);
Licz liczba2 = new Licz(10);
Licz liczba3 = new Licz(-32);

liczba1.Add(3);
liczba1.Subtract(6);
liczba2.Add(-12);
liczba2.Subtract(100);
liczba3.Add(43);
liczba3.Subtract(2);

liczba1.View();