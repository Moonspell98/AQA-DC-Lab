using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.QueueAndStack
{
    public class QueueAndStackTask1
    {
        public static int GetMaxValue(Queue<int> queue)
        {
            return queue.Max();
        }

        public static void AppendQueue(Queue<int> userQueue)
        {
            while (true)
            {
                Console.WriteLine("Enter value to enqueue, if you want to stop enter n");

                var userInput = Console.ReadLine();
                if (userInput == "n")
                {
                    break;
                }
                else
                {
                    userQueue.Enqueue(int.Parse(userInput));
                }
            }
        }
    }
}
