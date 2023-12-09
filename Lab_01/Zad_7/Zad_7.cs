using static System.Console;

Write("Podaj liczbę elementów tablicy: ");
int n = Convert.ToInt32(ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < n; i++) {
    Write("Wprowadź kolejny element: ");
    numbers[i] = Convert.ToInt32(ReadLine());
}

WriteLine("Elementy przed sortowaniem:");
PrintNumbers(numbers);

InsertionSort(numbers);

WriteLine("Elementy po sortowaniu:");
PrintNumbers(numbers);


static void InsertionSort(int[] arr) {
    for (int i = 1; i < arr.Length; i++) {
        int currentElement = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > currentElement) {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = currentElement;
    }
}

static void PrintNumbers(int[] arr) {
    foreach (int num in arr) {
        Write(num + " ");
    }
    WriteLine();
}