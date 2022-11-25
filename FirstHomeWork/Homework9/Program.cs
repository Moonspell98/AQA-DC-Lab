// See https://aka.ms/new-console-template for more information

using Homework9.Task1;

static AllTypesInArrayClass<T> GenerateHumanBeings<T>() where T : Human, new()
{
    if (typeof(T) == typeof(Woman))
    {
        Console.WriteLine("How many womanov you want to add?");
    }
    else
    {
        Console.WriteLine("How many manov you want to add?");
    }
    AllTypesInArrayClass<T>.capacity = int.Parse(Console.ReadLine());
    AllTypesInArrayClass<T> humany = new AllTypesInArrayClass<T>();
    for (int i = 0; i < AllTypesInArrayClass<T>.capacity; i++)
    {
        var human = new T();
        Console.WriteLine($"Enter {i + 1}st person First Name");
        var firstName = Console.ReadLine();
        Console.WriteLine($"Enter {i + 1}st person Last Name");
        var lastName = Console.ReadLine();
        if (!firstName.Equals(string.Empty))
        {
            human.FirstName = firstName;
        }
        if (!lastName.Equals(string.Empty))
        {
            human.LastName = lastName;
        }
        humany.AddValueToArray(i, human);
    }

    return humany;
}

AllTypesInArrayClass<Woman> Womeny = GenerateHumanBeings<Woman>();
Womeny.ToString();

AllTypesInArrayClass<Man> Many = GenerateHumanBeings<Man>();
Many.ToString();