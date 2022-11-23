namespace Homework8.Dictionary
{
    public class DictionaryTask2
    {
        public static Dictionary<int, string> SortAndTransformToDictionary(List<int> listOfInts, List<string>listOfStrings)
        {
            var sortedStrings = listOfStrings.OrderByDescending(x => x).ToList();
            var sortedInts = listOfInts.OrderBy(x => x).ToList();
            var resultIEnumarable = sortedInts.Join(sortedStrings, x => sortedInts.IndexOf(x), y => sortedStrings.IndexOf(y), (x, y) => new {Key = x, Value = y});
            
            return resultIEnumarable.ToDictionary(_=>_.Key, _=>_.Value);
        }
    }
}
