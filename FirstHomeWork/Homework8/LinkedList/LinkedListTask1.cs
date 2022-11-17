using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.LinkedList
{
    public class LinkedListTask1
    {
        public static void InsetElements(int elementValueToInsertAfter, int elementToInsert, LinkedList<int> listToInsertTo)
        {
            var nodeInList = listToInsertTo.First;
            for (int i = 0; i < listToInsertTo.Count; i++)
            {
                if (nodeInList.Value == elementValueToInsertAfter)
                {
                    listToInsertTo.AddAfter(nodeInList, elementToInsert);
                }
                nodeInList = nodeInList.Next;
            }
        }
    }
}
