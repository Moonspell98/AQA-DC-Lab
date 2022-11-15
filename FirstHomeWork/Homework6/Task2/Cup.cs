using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task2
{
    public class Cup : IFillable, IBreakable
    {
        private int capacity;
        private int currentVolume = 0;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < IFillable.minCapacity)
                {
                    Console.WriteLine("Capacity can not be negative");
                }
                else
                {
                    capacity = value;
                }
            }
        }
        public bool IsFullFilled { get; set; } = false;
        public int CurrentVolume { get; set; }
        public int Durability { get; set; }
        public bool IsBroken { get; set; } = false;

        public Cup(int capacity, int durability)
        {
            Capacity = capacity;
            Durability = durability;
        }

        public void Fill(int volume)
        {
            if (IsFullFilled)
            {
                Console.WriteLine($"Cup is already filled! {volume} milliliters were spilled");
            }
            else if (volume > capacity - currentVolume)
            {
                IsFullFilled = true;
                Console.WriteLine($"Cup was fullfilled. {volume - (capacity - currentVolume)} milliliters were spilled");
                currentVolume = capacity;
            }
            else if (volume == capacity - currentVolume)
            {
                IsFullFilled = true;
                Console.WriteLine("Exact match! Cup was fullfilled without losses");
                currentVolume = capacity;
            }
            else
            { 
                currentVolume += volume;
                Console.WriteLine($"Cup wasn't fullfilled, there is {capacity - currentVolume} free space in the cup");
            }
        }

        public void Hit(int hitStrenght)
        {
            if (IsBroken)
            {
                Console.WriteLine("Stop doing it, it's already broken!");
            }
            else if (hitStrenght < Durability)
            {
                Durability -= hitStrenght;
                Console.WriteLine($"Weakling, that's not enough! The durability is {Durability}");
            }
            else if (hitStrenght >= Durability)
            {
                IsBroken = true;
                Durability = 0;
                Console.WriteLine("Totally destroyed!");
            }
        }
    }
}
