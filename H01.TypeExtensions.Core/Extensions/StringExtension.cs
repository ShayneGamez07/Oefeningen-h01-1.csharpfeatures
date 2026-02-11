namespace H01.TypeExtensions.Core.Extensions
{
    public static class StringExtensions
    {
        public static int CountChars(this string text)
            => text.Length;

        public static int CountSpaces(this string text)
            => text.Count(c => c == ' ');

        public static int CountSubstring(this string text, string search)
            => text.Split(search).Length - 1;
    }
}
