using static System.Console;

int[] numbers = new int[10];
for (int i = 0; i < 10; i++) {
    Write($"Wprowadź liczbę {i + 1}: ");
    if (int.TryParse(ReadLine(), out int num)) {
        numbers[i] = num;
    } else {
        WriteLine("Niepoprawna liczba. Wprowadź ją ponownie.");
        i--;
    }
}

// Suma
int sum = 0;
foreach (int num in numbers) {
    sum += num;
}

// Iloczyn
int product = 1;
foreach (int num in numbers) {
    product *= num;
}

// Średnia
double average = (double)sum / numbers.Length;

// Minimum i maksimum
int min = numbers[0];
int max = numbers[0];
foreach (int num in numbers) {
    if (num < min) {
        min = num;
    }
    if (num > max) {
        max = num;
    }
}

WriteLine("Suma: " + sum);
WriteLine("Iloczyn: " + product);
WriteLine("Średnia: " + average);
WriteLine("Minimum: " + min);
WriteLine("Maksimum: " + max);