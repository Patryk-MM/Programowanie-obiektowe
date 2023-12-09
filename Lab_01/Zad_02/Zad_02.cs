using static System.Console;

static double DoubleInput()
{
    while (true)
    {
        Write("Podaj wartość: ");
        string input = ReadLine();

        if (Double.TryParse(input, out double value))
        {
            return value;
        }

        WriteLine("Niepoprawne dane, proszę podać prawidłową wartość.");
    }
}

static void Addition()
{
    WriteLine("Suma: ");
    double a = DoubleInput();
    double b = DoubleInput();
    WriteLine($"Wynik działania: {a + b}");
}

static void Subtraction()
{
    WriteLine("Różnica: ");
    double a = DoubleInput();
    double b = DoubleInput();
    WriteLine($"Wynik działania: {a - b}");
}

static void Multiplication()
{
    WriteLine("Mnożenie: ");
    double a = DoubleInput();
    double b = DoubleInput();
    WriteLine($"Wynik działania: {a * b}");
}

static void Division()
{
    WriteLine("Dzielenie: ");
    double a = DoubleInput();
    double b = DoubleInput();
    if (b == 0)
    {
        WriteLine("Nie można dzielić przez zero.");
        return;
    }

    WriteLine($"Wynik działania: {a / b}");
}

static void Exponentiation()
{
    WriteLine("Potęgowanie: ");
    double a = DoubleInput();
    double b = DoubleInput();
    WriteLine($"Wynik działania: {Math.Pow(a, b)}");
}

static void Root()
{
    WriteLine("Pierwiastkowanie: ");
    double a = DoubleInput();
    WriteLine($"Wynik działania: {Math.Sqrt(a)}");
}

static void Trygonometry()
{
    WriteLine("Trygonometria: ");
    double a = DoubleInput();
    double radians = (a * Math.PI) / 180;
    WriteLine($"sin({radians} = {Math.Sin(radians)}");
    WriteLine($"cos({radians} = {Math.Cos(radians)}");
    WriteLine($"tg({radians} = {Math.Tan(radians)}");
    WriteLine($"ctg({radians} = {Math.Cosh(radians)}");
}

static void Calc() {
    while (true)
    {
        WriteLine("Kalkulator");
        WriteLine("Wybierz opcję: ");
        WriteLine("1. Suma");
        WriteLine("2. Różnica");
        WriteLine("3. Mnożenie");
        WriteLine("4. Dzielenie");
        WriteLine("5. Potęgowanie");
        WriteLine("6. Pierwiastkowanie");
        WriteLine("7. Trygonometria");
        WriteLine("8. Wyjście");

        int choice = Convert.ToInt32(ReadLine());
        switch (choice)
        {
            case 1:
                Addition();
                break;
            case 2:
                Subtraction();
                break;
            case 3:
                Multiplication();
                break;
            case 4:
                Division();
                break;
            case 5:
                Exponentiation();
                break;
            case 6:
                Root();
                break;
            case 7:
                Trygonometry();
                break;
            case 8:
                WriteLine("Program zostanie zakończony."); 
                return;
            default:
                WriteLine("Wybierz prawidłową opcję.");
                break;
        }
        WriteLine();
    }
}

Calc();