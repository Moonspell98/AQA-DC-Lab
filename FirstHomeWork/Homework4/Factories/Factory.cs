using Homework4Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Factories
{
    internal class Factory
    {
        public Worker[]? Workers { get; private set; }
        public string Name { get; private set; }

        public Factory(string name) : this(null, name)
        {
        }

        public Factory(Worker[] workers, string name)
        {
            Workers = workers;
            Name = name;
        }

        public void ShowFactoryName()
        {
            Console.WriteLine(Name);
        }
        
        public void ShowNumberOfWorkers()
        {
            Console.WriteLine(Workers.Length);
        }
        
        public void AddWorkers(int workersCount)
        {
            if (Workers == null)
            {
                Workers = new Worker[workersCount];
                for (int i = 0; i < workersCount; i++)
                {
                    Console.WriteLine("Enter worker's First Name:");
                    var workerFirstName = Console.ReadLine();
                    Console.WriteLine("Enter worker's Last Name:");
                    var workerLastName = Console.ReadLine();
                    Console.WriteLine("Enter worker's age");
                    var worgerAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter worker's title");
                    var workerTitle = Console.ReadLine();
                    Console.WriteLine("Enter worker's salary");
                    var workerSalary = int.Parse(Console.ReadLine());
                    Workers[i] = new Worker(workerFirstName, workerLastName, worgerAge, workerTitle, workerSalary);
                }
            }
            else
            {
                Console.WriteLine("Workers already assigned.");
            }
        }
        
        public Worker GetWorker(int WorkerNumber)
        {
            if (Workers != null)
            {
                return Workers[WorkerNumber - 1];
            }
            else
            {
                Console.WriteLine("There is no assigened workers on this factory");
                
                return null;
            }
        }
    }
}
