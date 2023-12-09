// ============ main ==================

using Zad_01;

//tablica obiektow
Person[] persons = new Person[] {
    new Person("Jan", "Nowak",23),
    new Person("Janina", "Kowalska",23),
    new Person("Adam", "Kowalski",45),
    new Person("Franciszek", "Nowakowski",12),
    new Person("Jaroslaw", "Pietruszka",23)
};

Book[] books = new Book[] {
    new Book ("Ksiazka 1",persons[0], new DateTime(2023,11,26)),
    new Book ("Ksiazka 2",persons[1], new DateTime(2021,01,13)),
    new Book ("Ksiazka 3",persons[2], new DateTime(2015,02,25)),
    new Book ("Ksiazka 4",persons[3], new DateTime(1988,05,26)),
    new Book ("Ksiazka 5",persons[4], new DateTime(2021,12,06))
};

Reader[] readers = new Reader[persons.Length];
for (int i = 0; i < readers.Length; i++) {
    readers[i] = new Reader(persons[i].FirstName, persons[i].LastName, persons[i].Age);
    if (i == 0) {
        readers[i].ReadBooks = new Book[]
        {
            books[intRand()], books[intRand()]
        };
    } else if (i == 1) {
        readers[i].ReadBooks = new Book[]
        {
            books[intRand()], books[intRand()], books[intRand()]
        };
    } else {
        readers[i].ReadBooks = new Book[]
         {
            books[intRand()], books[intRand()], books[intRand()], books[intRand()]
         };
    };
}

Reviewer[] reviewers = new Reviewer[2];
for (int i = 0; i < reviewers.Length; i++) {
    reviewers[i] = new Reviewer(persons[i].FirstName, persons[i].LastName, persons[i].Age);
    reviewers[i].ReadBooks = new Book[] {
        books[intRand()], books[intRand()]
    };
}



//Losowanie
int intRand() {
    Random random = new Random();
    int index = random.Next(books.Length);
    return index;
}


//metoda View() dla person
foreach (Person item in persons) {
    item.View();
}

//metoda View() dla books
foreach (Book item in books) {
    item.View();
}

//metoda View() dla readers
foreach (Reader item in readers) {
    item.View();
}


Console.WriteLine("Reviewers:");
foreach (Reviewer item in reviewers) {
    item.View();
}

Console.WriteLine();
Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("Lista");

List<Person> list = new List<Person>();
for (int i = 0; i < readers.Length; i++) {
    list.Add(readers[i]);
}
for (int i = 0; i < reviewers.Length; i++) {
    list.Add(reviewers[i]);
}

foreach (var item in list) {
    item.View();
}

// =========== end main ===============