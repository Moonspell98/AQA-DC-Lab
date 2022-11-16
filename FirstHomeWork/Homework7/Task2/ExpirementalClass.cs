using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Note: Better not use this class, stuck in infity loop is possible.
namespace Homework7.Task2
{
    public class ExpirementalClass
    {
        public static void ExpirementalMethod()
        {
            while (true)
            {
                Console.WriteLine("I warned you...");
                throw new InfinityLoopException();
            }
        }
        
    }
}
