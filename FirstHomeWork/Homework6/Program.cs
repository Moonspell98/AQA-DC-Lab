// See https://aka.ms/new-console-template for more information
using Homework6;

Car car = new Car("BMW X5", "Automatic", 3000, 50000);
Motorcicle motorcicle = new Motorcicle("Yamaha Drag Star", true, 400, 10000);

car.Ride(10);
motorcicle.Ride(3);

car.ShowInfo();
motorcicle.ShowInfo();


