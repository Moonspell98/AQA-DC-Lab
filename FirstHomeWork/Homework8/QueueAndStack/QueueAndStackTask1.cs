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

        public static Queue<int> RemoveMaxElement(Queue<int> userQueue)
        {
            Queue<int> queueWithoutMaxElement = new Queue<int>();
            foreach (var item in userQueue)
            {
                if (item != GetMaxValue(userQueue))
                {
                    queueWithoutMaxElement.Enqueue(item);
                }
            }
            return queueWithoutMaxElement;
        }
    }
}
