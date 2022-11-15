// See https://aka.ms/new-console-template for more information
using AutomationCources.Lecture_7.Homework;
using Homework6.Task1;
using Homework6.Task2;

//Car car = new Car("BMW X5", "Automatic", 3000, 50000);
//car.Ride(2);
//car.ShowInfo();

//Car car2 = new Car("Mercedes AMG63", "Manual", 2500, 80000);
//car2.Ride(4);
//car2.ShowInfo();

//Motorcicle motorcicle = new Motorcicle("Yamaha Drag Star", true, 400, 10000);
//motorcicle.Ride(3);
//motorcicle.ShowInfo();

//Cup cup = new Cup(1000, 100);

//cup.Fill(800);
//cup.Fill(200);
//cup.Fill(800);

//cup.Hit(20);
//cup.Hit(80);
//cup.Hit(90);

//Bucket bucket = new Bucket("Big Bucket", 10000);
//bucket.Fill(8000);
//bucket.Fill(1999);
//bucket.Fill(1);
//bucket.Fill(500);

MobilePhone mobile = new MobilePhone(10000, "Samsung S20", 800);
Console.WriteLine(mobile.Description);
mobile.TurnOn();
mobile.TurnOff();
mobile.TakePhoto();
Console.WriteLine();

Polaroid polaroid = new Polaroid(100, 120, 8000, "Polaris", 300);
Console.WriteLine(polaroid.Description);
polaroid.TurnOn();
polaroid.TurnOff();
polaroid.TakePhoto();
polaroid.Print();
Console.WriteLine();

Printer printer = new Printer("Xerox 2000", 400, 200, 300);
Console.WriteLine(printer.Description);
printer.TurnOn();
printer.TurnOff();
printer.Print();


