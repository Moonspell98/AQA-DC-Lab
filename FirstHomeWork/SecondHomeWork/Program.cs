// See https://aka.ms/new-console-template for more information
//Task1();
//Task2();
Task3();

static void Task1()
{
    var num = 20;
    num += 5;
    Console.WriteLine($"Variable: {num}");
}

static void Task2()
{
    Console.WriteLine("Please, enter days count");
    var inputDays = int.Parse(Console.ReadLine());
    var years = inputDays / 365;
    var months = (inputDays % 365) / 30;
    var days = (inputDays % 365) % 30;
    Console.WriteLine($"Years: {years}, Months: {months}, Days: {days}");
}

static void Task3()
{
    Console.WriteLine("Please, enter number");
    var inputNumber = int.Parse(Console.ReadLine());
    inputNumber = inputNumber + inputNumber * 2;
    Console.WriteLine(inputNumber);
}

static void Task4()
{
    sbyte smallSigned = -34;
    byte smallUnsigned = 4;
    string textValue = "Hello";
    char oneSymbol = 'R';
    double bigValueAfterPoint = 23.093433222;
    ushort stillsmall = 40000;
    bool yesOrNot = true;
    sbyte zero = 0;
}