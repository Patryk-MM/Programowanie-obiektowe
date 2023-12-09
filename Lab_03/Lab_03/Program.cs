using Lab_03;

Student student= new Student("Jan", 1234567, "w12345");
student.ViewStudent();

student.NrAlbumu = "w34567";
student.ViewStudent();

Prostokat prostokat = new Prostokat();
Console.WriteLine(prostokat.Pole());