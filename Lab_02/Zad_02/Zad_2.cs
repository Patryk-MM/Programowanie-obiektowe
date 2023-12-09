using Zad_02;
using static System.Console;

Sumator tablica = new Sumator(new int[] {2,3,4,5,6});

WriteLine(tablica.Suma());  
WriteLine(tablica.SumaPodzielnych());
WriteLine(tablica.ElementCount());
tablica.PrintElements();
tablica.LowHighIndex(3, 7);