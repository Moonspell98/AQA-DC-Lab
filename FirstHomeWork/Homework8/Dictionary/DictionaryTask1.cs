using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Dictionary
{
    public class DictionaryTask1
    {
        public static void AddItemToDictionary(Dictionary<string, int> dictionary)
        {
            Console.WriteLine("Enter Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            var age = int.Parse(Console.ReadLine());
            dictionary.Add(name, age);
        }
        public static void AddItemToDictionaryByIndex(Dictionary<string, int> dictionary)
        {
            Console.WriteLine("Enter Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            var age = int.Parse(Console.ReadLine());
            dictionary[name] = age; 
        }
    }
}
