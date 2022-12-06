using System.Text.RegularExpressions;

namespace Homework10.Tools
{
    public class TextNormalizer
    {
        public static string Normalize(string stringToNormalize)
        {
            var normalizedString = stringToNormalize.ToLower();
            var pattern = @"\s|\W(\w*)";
            Regex regex = new Regex(pattern);
            normalizedString = regex.Replace(normalizedString, "");

            return normalizedString;
        }
    }
}
