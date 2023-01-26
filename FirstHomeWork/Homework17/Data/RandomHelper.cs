using System;
using System.Linq;

namespace Homework17.Data
{
    public class RandomHelper
    {
        public static string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int GetRandomInt(int max)
        {
            Random random = new Random();

            return random.Next(max);
        }
    }
}
