// See https://aka.ms/new-console-template for more information
//Task1();
Task2();

static void Task1()
{
    var num = 20;
    num += 5;
    Console.WriteLine($"Variable: {num}");
}

static void Task2()
{
    Console.WriteLine("Please, enter days count");
    var inputDays = Convert.ToInt16(Console.ReadLine());
    var years = inputDays / 365;
    var months = (inputDays % 365) / 30;
    var days = (inputDays % 365) % 30;
    Console.WriteLine($"Years: {years}, Months: {months}, Days: {days}");
}