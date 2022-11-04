// See https://aka.ms/new-console-template for more information
ExtaTaskFromJenya();

static void Task1()
{
    Console.WriteLine("Enter number: ");
    var inputNumber = int.Parse(Console.ReadLine());
    var result = 0;
    for (var i = 0; i <= inputNumber; i++)
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

static void Task4()
{
    var number = 2048;
    var divider = 2;
    int timesToDivide = 0;

    do
    {
        number /= divider;
        timesToDivide++;
    } while (number > 10);
    Console.WriteLine(timesToDivide);
}

static void Task5()
{
    string[] strings = { "Privet", "Salut", "Czesc", "Labas", "Hello" };
    foreach (var str in strings)
    {
        if (str == "Hello")
        {
            Console.WriteLine("Labas!");
            break;
        }
        Console.WriteLine("Check iteration");
    }
}

static void Task6()
{
    int[] numbers = { 3, 5, 9, 18, 42, 44 };

    var sumOfFirstAndLastElements = numbers[0] + numbers[numbers.Length - 1];
    Console.WriteLine($"Sum of first and last elements of array is: {sumOfFirstAndLastElements}");
}

static void Task7()
{
    int[] numbers = { 3, 5, 2, 18, 56, 44 };

    var sumOfIndexes = Array.IndexOf(numbers, numbers.Min()) + Array.IndexOf(numbers, numbers.Max());
    Console.WriteLine($"Sum of indexes is {sumOfIndexes}");
}

static void Task8()
{
    int[] numbers = { 3, 5, 2, 18, 56, 44 };
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
    Array.Sort(numbers);    
    Console.WriteLine();
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
}

static void Task9()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.WriteLine($"{i} * {j} = {j * i}");
        }
        Console.WriteLine();
    }  
}

static void ExtaTaskFromJenya()
{
    int[,] nums2 = { { 0, 1, 2, 5 }, { 3, 4, 5, 5 }, { 6, 7, 8, 5 }, {5, 3, 12, 42 } };
    var sum = 0;
    for (int i = 0; i < nums2.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < nums2.GetUpperBound(1) + 1; j++)
        {
            if (i == j)
            {
                sum += nums2[i, j];
            }
        }
    }
    Console.WriteLine(sum);
}