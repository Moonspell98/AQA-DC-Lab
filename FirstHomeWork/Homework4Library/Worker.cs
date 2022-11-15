namespace Homework4Library
{
    public class Worker : Person
    {
        public string? Title { get; private set; }
        public int? Salary { get; private set; }

        public Worker() : base()
        {
        }

        public Worker(string firstName, string lastName, int age ,string title, int salary) : base(firstName, lastName, age)
        {
            Title = title;
            Salary = salary;
        }

        public void ShowTitle()
        {
            Console.WriteLine(Title);
        }

        public override void ChangeData()
        {
            Console.WriteLine("What type of data you want to change?\n1. Personal\n2. Professional");
            var decision = int.Parse(Console.ReadLine());
            if (decision == 1)
            {
                base.ChangeData();
            }
            else if (decision == 2)
            {
                Console.WriteLine($"Which professional data of {FirstName} {LastName} you want to change?\n1. Title\n2. Salary");
                decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Enter new title");
                        Title = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter new salary");
                        Salary = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("No valid choice. Exit");
                        break;
                }
            }
        }
    }
}