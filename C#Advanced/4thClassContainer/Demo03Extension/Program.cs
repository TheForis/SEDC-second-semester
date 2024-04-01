using Helpers;

namespace Demo03Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string text = "we are students from SEDC";
            
            Console.WriteLine(StringHelper.AddQuotes(text));
            Console.WriteLine(StringHelper.RemoveWordsFromBEgining(text, 2));

            Console.WriteLine(text.AddQuotes());
            Console.WriteLine(text.RemoveWordsFromBeginning(2));
        }
    }
}
