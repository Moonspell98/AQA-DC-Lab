// See https://aka.ms/new-console-template for more information
//Task1();
//Task2();
//Task3();
Task9();

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

static void Task5()
{
    short a = short.Parse(Console.ReadLine());
    ulong b = ulong.Parse(Console.ReadLine());
    char c = char.Parse(Console.ReadLine());
    double d = double.Parse(Console.ReadLine());
    Console.WriteLine($"short: {a}, ulong: {b}, char: {c}, double: {d}");
}

static void Task6()
{
    var x = -5;
    x *= 7;
    Console.WriteLine(--x);
}

static void Task7()
{
    var x = int.Parse(Console.ReadLine());
    if (x % 2 == 0)
    {
        Console.WriteLine("Even number");
    }
    else
    {
        Console.WriteLine("Not even number");
    }
}

static void Task8()
{
    var a = int.Parse(Console.ReadLine());
    if (a < 50 && a != 37 && a > 32 || a == 0 || a == 15)
    {
        Console.WriteLine("Working");
    }
    else
    {
        Console.WriteLine("Not Working");
    }
}

static void Task9()
{
    Console.WriteLine("Enter first value");
    var a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second value");
    var b = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter operation");
    var action = Console.ReadLine();
    switch (action)
    {
        case "-":
            Console.WriteLine(a - b);
            break;
        case "+":
            Console.WriteLine(a + b);
            break;
        case "*":
            Console.WriteLine(a * b);
            break;
        case "/":
            Console.WriteLine(a/b);
            break;
    }
}
