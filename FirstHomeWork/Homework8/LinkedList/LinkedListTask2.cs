using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.LinkedList
{
    public class LinkedListTask2
    {
        public static LinkedList<int> MergeLinkedLists(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedList<int> result = new LinkedList<int>();
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    result.AddLast(item);
                }
            }

            return result;
        }
    }
}
