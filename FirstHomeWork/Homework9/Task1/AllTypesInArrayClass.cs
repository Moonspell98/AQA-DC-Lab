using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddValueToArray(T value)
        {
            array.Append(value);
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
    }
}
