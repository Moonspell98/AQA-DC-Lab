using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Dictionary
{
    public class DictionaryTask2
    {
        public static Dictionary<int, string> SortAndTransformToDictionary(List<int> listOfInts, List<string>listOfStrings)
        {
            var sortedStrings = listOfStrings.OrderBy(x => x).ToList();
            var sortedInts = listOfInts.OrderBy(x => x).ToList();
            var resultIEnumarable = sortedInts.OrderBy(_ => _).Join(sortedStrings, x => sortedInts.IndexOf(x), y => sortedStrings.IndexOf(y), (x, y) => new {Key = x, Value = y});
            
            return resultIEnumarable.ToDictionary(_=>_.Key, _=>_.Value);
        }
    }
}
