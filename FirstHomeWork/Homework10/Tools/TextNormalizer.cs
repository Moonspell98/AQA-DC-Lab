namespace Homework10.Tools
{
    public class TextNormalizer
    {
        public static string Normalize(string stringToNormalize)
        {
            var normalizedString = stringToNormalize.ToLower();
            normalizedString = normalizedString.Trim().Replace(" ", "");
            normalizedString = normalizedString.Contains(".") ? normalizedString.Remove(normalizedString.IndexOf(".")) : normalizedString;
            
            return normalizedString;
        }
    }
}
