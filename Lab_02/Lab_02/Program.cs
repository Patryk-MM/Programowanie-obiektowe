using Lab_02;

Car car = new Car("marka", "model", "kolor", 2.0, 2023);

car.View();
car.rocznik = 1111;
car.View();

Car[] carArray = new Car[] {
    new Car("marka", "model", "kolor", 2.0, 2023),   
    new Car("marka1", "model1", "kolor1", 2.0, 2023),   
    new Car("marka2", "model2", "kolor2", 2.0, 2023),   
    new Car("marka3", "model3", "kolor3", 2.0, 2023),   
};

foreach (Car item in carArray)
{
    item.View();
}