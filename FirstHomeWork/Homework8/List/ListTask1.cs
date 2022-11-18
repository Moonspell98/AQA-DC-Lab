using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.List
{
    public class ListTask1
    {
        public static int SumOfEvenNumberInList(List<int> listToSum)
        {
            var sumOfEvenElements = (from element in listToSum where element % 2 == 0 select element).Sum();

            return sumOfEvenElements;
        }
    }
}
