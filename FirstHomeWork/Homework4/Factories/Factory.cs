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
        private Worker[]? workers;
        private string name;

        public Factory(string name) : this(null, name)
        {
        }

        public Factory(Worker[] workers, string name)
        {
            this.workers = workers;
            this.name = name;
        }

        public void ShowFactoryName()
        {
            Console.WriteLine(name);
        }
        public void ShowNumberOfWorkers()
        {
            Console.WriteLine(workers.Length);
        }
        public void AddWorkers(int workersCount)
        {
            if (workers == null)
            {
                workers = new Worker[workersCount];
                for (int i = 0; i < workersCount; i++)
                {
                    Console.WriteLine("Enter worker's First Name:");
                    var workerFirstName = Console.ReadLine();
                    Console.WriteLine("Enter worker's First Name:");
                    var workerLastName = Console.ReadLine();
                    Console.WriteLine("Enter worker's age");
                    var worgerAge = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter worker's title");
                    var workerTitle = Console.ReadLine();
                    workers[i] = new Worker(workerFirstName, workerLastName, workerTitle, worgerAge);
                 }
            }
            else
            {
                Console.WriteLine("Workers already assigned.");
            }
        }
        public Worker GetWorker(int WorkerIndex)
        {
            if (workers != null)
            {
                return workers[WorkerIndex];
            }
            else
            {
                Console.WriteLine("There is no assigened workers on this factory");
                return null;
            }
        }
    }
}
