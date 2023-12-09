using System.Collections.Generic;
using static System.Console;

static void FirstToLast(List<int> list) {
    WriteLine("Wyświetlanie listy od pierwszego do ostatniego indeksu: ");
    foreach (int i in list) {
        Write($"{i} ");
    }
}

static void LastToFirst(List<int> list) {
    WriteLine("Wyświetlanie listy od ostatniego do pierwszego indeksu: ");

    for (int i = list.Count() - 1; i >= 0; i--) {
        Write($"{list[i]} ");
    }
}

static void Even(List<int> list) {
    WriteLine("Wyświetlanie parzystych elementów listy:");
    foreach (int i in list) {
        if (i % 2 == 0) {
            Write($"{i} ");
        }
    }
}

static void Odd(List<int> list) {
    WriteLine("Wyświetlanie nieparzystych elementów listy:");
    foreach (int i in list) {
        if (i % 2 != 0) {
            Write($"{i} ");
        }
    }
}

WriteLine("Podaj dziesięć elementów tablicy: ");

List<int> list = new List<int>();
for (int i = 0; i < 10; i++) {
    list.Add(Convert.ToInt32(ReadLine()));
}

while (true) {
    WriteLine("Wybierz opcję: ");
    WriteLine("1. Wyświetlanie listy od pierwszego do ostatniego indeksu.");
    WriteLine("2. Wyświetlanie listy od ostatniego do pierwszego indeksu.");
    WriteLine("3. Wyświetlanie parzystych elementów listy.");
    WriteLine("4. Wyświetlanie nieparzystych elementów listy.");
    WriteLine("5. Wyjście.");

    int choice = Convert.ToInt32(ReadLine());
    switch (choice) {
        case 1:
            FirstToLast(list);
            break;
        case 2:
            LastToFirst(list);
            break;
        case 3:
            Even(list);
            break;
        case 4:
            Odd(list);
            break;
        case 5:
            return;
        default:
            WriteLine("Wybierz prawidłową opcję.");
            break;
    }
    WriteLine();
}