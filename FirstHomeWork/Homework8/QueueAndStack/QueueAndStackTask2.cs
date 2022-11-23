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

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
