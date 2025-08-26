using System.Text.RegularExpressions;

namespace SafeVault.Helpers
{
    public static class InputSanitizer
    {
        public static string Sanitize(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            input = Regex.Replace(input, "<.*?script.*?>.*?</.*?script.*?>", "", RegexOptions.IgnoreCase);
            input = Regex.Replace(input, @"('|--|;|/\*|\*/|xp_)", "", RegexOptions.IgnoreCase);
            input = Regex.Replace(input, "<.*?>", "");
            input = Regex.Replace(input, @"[^a-zA-Z0-9@.\-_]", "");
            return input.Trim();
        }
    }
}