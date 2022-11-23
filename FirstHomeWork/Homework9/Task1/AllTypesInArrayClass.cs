namespace Homework9.Task1
{
    public class AllTypesInArrayClass<T> where T : Human
    {
        public static int capacity = 1;
        public T[] array = new T[capacity];

        public void AddValueToArray(int index, T value)
        {
            array[index] = value;
        }

        public void RemoveValueFromArray(int index)
        {
            Array.Clear(array, index, array.Length);
        }

        public T GetValueFromArray(int index)
        {
            return array[index];
        }

        public int GetArrayLength()
        {
            return array.Length;
        }

        public void ToString()
        {
            foreach (var human in array)
            {
                Console.WriteLine($"{Array.IndexOf(array, human) + 1}st person's First Name is: {human.FirstName}, Last Name is: {human.LastName}");
            }
            if (typeof(T) == typeof(Woman))
            {
                Console.WriteLine("There is only women");
            }
            else
            {
                Console.WriteLine("There is only men");
            }
        }
    }
}
