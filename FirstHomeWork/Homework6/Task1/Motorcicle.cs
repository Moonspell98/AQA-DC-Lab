using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task1
{
    internal class Motorcicle : Vehicle
    {
        public bool isChopper;
        double cost;
        public Motorcicle(string modelName, bool isChopper, int mass, double cost)
        {
            ModelName = modelName;
            this.isChopper = isChopper;
            this.mass = mass;
            Cost = cost;
        }
        public override double Cost
        {
            get
            {
                if (isChopper)
                {
                    return cost * 1.05;
                }
                else
                {
                    return cost;
                }
            }
            set
            {
                cost = value;
            }
        }

        public override void Ride(int rideLong)
        {
            Console.WriteLine($"{ModelName} is doing:");
            for (int i = 0; i < rideLong; i++)
            {
                Console.WriteLine("Tr Tr Tr");
            }
        }
    }
}
