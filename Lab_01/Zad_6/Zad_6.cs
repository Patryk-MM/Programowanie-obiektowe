using static System.Console;

static void NegativeNumber() {
    while (true) {
        WriteLine("Podaj liczbę: ");
        int number = Convert.ToInt32(ReadLine());
        if (number < 0) break;
    }
}

NegativeNumber();