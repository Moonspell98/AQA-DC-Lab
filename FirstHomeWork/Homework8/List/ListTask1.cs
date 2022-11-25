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
