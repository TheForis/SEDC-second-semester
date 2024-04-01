
namespace Helpers
{
    public static class StringHelper
    {
        public static string AddQuotes(this string a)
        {
            return "\"" + a + "\"";
        }
        public static string RemoveWordsFromBEgining(string text,int wordNumber)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("Empty string");
            }

            List<string> words = text.Split(" ").ToList();

            if (words.Count < wordNumber) {
                throw new Exception($"The text has less than {wordNumber} words");
            }
            List<string> restOfWords = words.Skip(wordNumber).Take(words.Count - wordNumber).ToList();
            return string.Join(" ", restOfWords);
        }
    }
}
