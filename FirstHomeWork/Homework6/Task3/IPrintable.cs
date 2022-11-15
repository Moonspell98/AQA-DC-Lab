using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Task3
{
    internal interface IPrintable
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public void Print();

    }
}
