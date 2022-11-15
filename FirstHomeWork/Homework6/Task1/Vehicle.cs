using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task1
{
    public abstract class Vehicle
    {
        public int mass;

        public string ModelName { get; set; }
        public abstract double Cost { get; set; }

        public abstract void Ride(int rideLong);

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{ModelName} mass is: {mass}\n Cost is: {Cost}");
        }
    }
}
