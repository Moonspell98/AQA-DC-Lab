// See https://aka.ms/new-console-template for more information
Task7();

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
    var multiplOfArray = 1;

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
    var timesToDivide = 0;

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
    int[] numbers = { 5, 3, 2, 18, 56, 44 };
    var minIndex = 0;
    var minValue = numbers[0];
    var maxIndex = 0;
    var maxValue = numbers[0];
    for (var i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < minValue)
        {
            minValue = numbers[i];
            minIndex = i;
        }
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
            maxIndex = i;
        }
    }
    Console.WriteLine(minIndex + maxIndex);
}

static void Task8()
{
    int[] numbers = { 5, 3, 2, 18, 56, 44 };
    var minValue = numbers[0];
    var maxValue = numbers[0];
    for (var i = 0; i < numbers.Length; i++)
    {
        for (var j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] > numbers[j])
            {
                var storageVar = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = storageVar;
            }
        }
    }
    foreach (var num in numbers)
    {
        Console.WriteLine(num);
    }
}

static void Task9()
{
    for (var i = 1; i <= 10; i++)
    {
        for (var j = 1; j <= 10; j++)
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
    for (var i = 0; i < nums2.GetUpperBound(0) + 1; i++)
    {
        for (var j = 0; j < nums2.GetUpperBound(1) + 1; j++)
        {
            if (i == j)
            {
                sum += nums2[i, j];
            }
        }
    }
    Console.WriteLine(sum);
}