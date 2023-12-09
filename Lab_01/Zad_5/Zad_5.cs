using static System.Console;

static void SkipNumbers() {

    int[] numbersToSkip = { 2, 6, 9, 15, 19 };
    for (int i = 20; i >= 0; i--) {
        if (numbersToSkip.Contains(i)) continue;
        else WriteLine(i);
    }

}