using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.List
{
    public class Task1Class
    {
        public static int SumOfEvenNumberInList(List<int> listToSum)
        {
            var sumOfEvenElements = 0;
            var listOfEvenElements = from element in listToSum
                                 where element % 2 == 0
                                 select element;
            foreach (var element in listOfEvenElements)
            {
                sumOfEvenElements += element;
            }
            return sumOfEvenElements;
        }
    }
}
