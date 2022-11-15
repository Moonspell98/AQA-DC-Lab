using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task2
{
    internal interface IBreakable
    {
        public int Durability { get; set; }
        public bool IsBroken { get; set; }

        public void Hit(int hitStrenght);
    }
}
