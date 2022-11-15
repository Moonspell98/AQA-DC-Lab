using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4Library
{
    public class Person
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public int? Age { get; private set; }

        public Person() : this("Undefined", "Undefined") { }

        public Person(string firstName, string lastName) : this(firstName, lastName, 0)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void ShowFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        
        public void ShowAge()
        {
            Console.WriteLine(Age);
        }

        public virtual void ChangeData()
        {
            Console.WriteLine($"What data of {FirstName} {LastName} you want to change?");
            Console.WriteLine("1. First Name \n2. Last Name\n3. Age");
            var decision = int.Parse(Console.ReadLine());
            switch (decision)
            {
                case 1:
                    Console.WriteLine("Enter new First Name:");
                    FirstName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter new Last Name:");
                    LastName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter new Age:");
                    Age = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("No valid choice. Exit");
                    break;
            }
        }
    }
}
