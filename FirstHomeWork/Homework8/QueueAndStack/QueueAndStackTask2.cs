using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.QueueAndStack
{
    public class QueueAndStackTask2
    {
        public static void ReverseStringWithStack()
        {
            Console.WriteLine("Enter string to reverse");
            var userInput = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var letter in userInput)
            {
                stack.Push(letter);
            }
            for (int i = 0; i <= stack.Count + 1; i++)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
