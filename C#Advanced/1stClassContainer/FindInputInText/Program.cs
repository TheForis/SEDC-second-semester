namespace FindInputInText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfWords = new List<string>();
            List<int> countOfWordIntext = new List<int>(listOfWords.Count);
            while (true)
            {
                EnterWords(listOfWords);
                string userText = EnterText();
                string[] splitUserText = userText.Split(' ');
                Console.WriteLine(userText);
                int wordCounter = 0;

                for (int i = 0; i < splitUserText.Length; i++)
                {

                    if (splitUserText[i] == listOfWords[wordCounter])
                    {
                        if (countOfWordIntext.Contains(wordCounter))
                        {
                            if()
                        }
                        countOfWordIntext[wordCounter]++;
                    }
                    wordCounter++;
                }

                for (int i = 0; i < listOfWords.Count; i++)
                {
                    Console.WriteLine($"{listOfWords[i]} is contained {countOfWordIntext[i]} times");
                }

            }
        }

        static void EnterWords(List<string> words)
        {
            while (true)
            {
                Console.WriteLine("Please enter a word or press \"X\" to continue");
                string userWord = Console.ReadLine().ToLower();
                if (userWord == "x")
                {
                    break;
                }
                words.Add(userWord);
            }
        }

        static string EnterText()
        {
            Console.WriteLine("Please enter text:");
            return Console.ReadLine().ToLower();
        }
    }
}
