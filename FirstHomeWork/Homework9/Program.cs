// See https://aka.ms/new-console-template for more information

using Homework9.Task1;

static AllTypesInArrayClass<T> GenerateHumanBeings<T>(AllTypesInArrayClass<T> humany) where T : Human, new()
{
    int count;
    if (typeof(T) == typeof(Woman))
    {
        Console.WriteLine("How many womanov you want to add?");
    }
    else
    {
        Console.WriteLine("How many manov you want to add?");
    }
    count = int.Parse(Console.ReadLine());
    AllTypesInArrayClass<T>.capacity = count;

    for (int i = 0; i < AllTypesInArrayClass<T>.capacity; i++)
    {
        Console.WriteLine($"Enter {i}st person First Name");
        var firstName = Console.ReadLine();
        Console.WriteLine($"Enter {i}st person Last Name");
        var lastName = Console.ReadLine();
        var human = new T();
        human.FirstName = firstName;
        human.LastName = lastName;
        humany.AddValueToArray(human);
    }

    return humany;
}

AllTypesInArrayClass <Woman> Womeny = new AllTypesInArrayClass<Woman>();
GenerateHumanBeings<Woman>(Womeny);
for (int i = 0; i < Womeny.GetArrayLength(); i++)
{
    Console.WriteLine($"First Name: {Womeny.GetValueFromArray(i).FirstName}, Last Name: {Womeny.GetValueFromArray(i).FirstName}");
}