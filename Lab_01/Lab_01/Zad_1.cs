using static System.Console;

static void TrojmianKwadratowy(double a, double b, double c) {
    double delta = Math.Pow(b,2) - (4*a*c);
    WriteLine($"Delta: {delta}");
    if (delta >  0) {
        double x1, x2;
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        WriteLine($"Trójmian ma dwa pierwiastki: {x1:F3}, {x2:F3}");
    } else if (delta == 0) {
        double x = (-b - 2*a);
        WriteLine($"Trójmian ma jeden pierwiastek: {x:F3}");
    } else {
        WriteLine("Trójmian nie ma pierwiastków.");
    }

}

TrojmianKwadratowy(2, 10, 4);