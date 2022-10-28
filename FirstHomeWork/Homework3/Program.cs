// See https://aka.ms/new-console-template for more information
Task3();

static void Task1()
{
    Console.WriteLine("Enter number: ");
    var inputNumber = int.Parse(Console.ReadLine());
    var result = 0;
    for (int i = 0; i <= inputNumber; i++)
    {
        result += i;
    }
    Console.WriteLine($"The sum of numbers between 0 and {inputNumber} is: {result}");
}

static void Task2()
{
    var multiplicationTableForNumber = 3;
    var i = 0;
    while (i <= 10)
    {
        Console.WriteLine($"{multiplicationTableForNumber} * {i} = {multiplicationTableForNumber*i}");
        i++;
    }
}

static void Task3()
{
    int[] numbers = new int[5] { 3, 5, 9, 8, 15 };
    int multiplOfArray = 1;

    foreach (var num in numbers)
    {
        multiplOfArray *= num;
    }

    Console.WriteLine($"Multiplication of array is {multiplOfArray}");
}
