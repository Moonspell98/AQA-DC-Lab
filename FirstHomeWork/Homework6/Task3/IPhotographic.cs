using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task3
{
    internal interface IPhotographic
    {
        public double NumberOfPixelsInCamera { get; set; }

        public void TakePhoto();
    }
}
