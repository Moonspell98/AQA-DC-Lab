using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task2
{
    public class Bucket : IFillable
    {
        private int capacity;
        private int currentVolume;
        const int minCapacity = 1000;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < minCapacity)
                {
                    Console.WriteLine("Capacity can not be less than 1000 ml! It's a bucket!");
                }
                else
                {
                    capacity = value;
                }
            }
        }
        public bool IsFullFilled { get; set; } = false;
        public int CurrentVolume { get; set; }
        public string Model{ get; set; }

        public Bucket(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
        }

        public void Fill(int volume)
        {
            if (IsFullFilled)
            {
                Console.WriteLine($"Bucket is already filled! {volume} milliliters were spilled");
            }
            else if (volume > capacity - currentVolume)
            {
                IsFullFilled = true;
                Console.WriteLine($"Bucket was fullfilled. {volume - (capacity - currentVolume)} milliliters were spilled");
                currentVolume = capacity;
            }
            else if (volume == capacity - currentVolume)
            {
                IsFullFilled = true;
                Console.WriteLine("Exact match! Bucket was fullfilled without losses");
                currentVolume = capacity;
            }
            else
            {
                currentVolume += volume;
                Console.WriteLine($"Bucket wasn't fullfilled, there is {capacity - currentVolume} free space in the Bucket");
            }
        }
    }
}
