using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    internal class Car : Vehicle
    {
        public string transmissionType;
        double cost;
        public Car(string modelName, string transmissionType, int mass, double cost)
        {
            ModelName = modelName;
            this.transmissionType = transmissionType;
            this.mass = mass;
            Cost = cost;
        }
        public override double Cost 
        {
            get
            {
                if (transmissionType == "Automatic")
                {
                    return cost * 1.1;
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
                Console.WriteLine("Br Br Br");
            }
        }
    }
}
