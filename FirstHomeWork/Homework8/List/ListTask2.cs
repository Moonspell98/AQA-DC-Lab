using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.List
{
    public class ListTask2
    {
        public static void WriteFiveSymbolsStrings(List<string> listOfStrings)
        {
            foreach(string str in listOfStrings)
            {
                if(str.Length == 5)
                {
                    Console.WriteLine(str);
                }
            }
        }

        public static void WriteStringsAsUserWants(List<string> listOfStrings)
        {
            Console.WriteLine("Please, enter number of symbols");
            var stringLength = int.Parse(Console.ReadLine());
            var listOfStringsNeededLength = (from str in listOfStrings where str.Length == stringLength select str);
            foreach (var str in listOfStringsNeededLength)
            {
                Console.WriteLine(str);
            }
        }
    }
}
