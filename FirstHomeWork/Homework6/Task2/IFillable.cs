using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task2
{
    internal interface IFillable
    {
        const int minCapacity = 0;

        public int Capacity { get; set; }
        public bool IsFullFilled { get; set; }
        public int CurrentVolume { get;  set; }

        public void Fill(int volume);
    }
}
