using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7.Task1
{
    internal class LessonClass
    {
        public static void ShowMassiveElement()
        {
            int[] massive = { 8, 7, 1, 4, 2 };

            Console.WriteLine("Input index of element in massive:");
            string? inputedValue = Console.ReadLine();

            try
            {
                string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
                int inputtedNumber = int.Parse(checkedValue);
                int massiveElement = massive[inputtedNumber];
                Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("I don't how how you did it but you entered \"null\" value in Console.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid index format (not a number)");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Entered index is not fits in current array!");
            }
            finally
            {
                Console.WriteLine("Program finished whether it's correct or not");
            }
        }

    }
}
