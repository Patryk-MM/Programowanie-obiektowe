namespace Zad_01 {
    internal class Reviewer : Reader {
        public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age) {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void View() {
            Console.WriteLine($"Reviews by {FirstName} {LastName}:");
            Random random = new Random();

            foreach (var book in ReadBooks) {
                int rating = random.Next(1, 6);
                Console.WriteLine($"- {book.Title}: {rating}/5");
            }
        }
    }
}