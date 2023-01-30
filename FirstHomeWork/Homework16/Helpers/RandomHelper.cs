namespace Homework16.Helpers
{
    public class RandomHelper
    {
        public static int GetRandomIntExcludingList(int maxValue, List<int> numbersToExclude)
        {
            var range = Enumerable.Range(0, maxValue).Where(i => !numbersToExclude.Contains(i));

            var random = new Random();
            int index = random.Next(0, maxValue - numbersToExclude.Count);

            return range.ElementAt(index);
        }

        public static int GetRandomIntFromList(List<int> list)
        {
            Random random = new Random();
            var index = random.Next(0, list.Count - 1);

            return list[index];
        }

        public static string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int GetRandomInt(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max);
        }
    }
}
