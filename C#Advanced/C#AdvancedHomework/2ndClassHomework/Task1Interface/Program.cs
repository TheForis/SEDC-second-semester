using System.Reflection.Metadata;
using Service;
using Document = Service.Document;

namespace Task1Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DATA
            string documentText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            string webPageText = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
            #endregion

            ISearchable searchService;
            bool tryAgain = true;


            while (tryAgain)
            {
                string userChooser = UserChooser();
                switch (userChooser)
                {
                    case "1":
                        searchService = new Document(documentText);
                        break; 
                    case "2":
                        searchService = new WebPage(webPageText);
                        break;
                    default:
                        Console.WriteLine("Please choose between 1 or 2!");
                        continue;
                }

                Console.WriteLine(searchService.Search(UserWord()));
                tryAgain = SearchAgain();
            }
            


        }

        static string UserChooser()
        {
            Console.Write("Welcome to our search app. Would you like to search [1]Document or [2]WebPage: ");
            string userInput = Console.ReadLine();
            return userInput;
            
        }
                
        static string UserWord()
        {
            while (true)
            {
                Console.Write("Please enter a word to search: ");
                string wordInput = Console.ReadLine();
                if (wordInput != null)
                {
                    wordInput.Trim();
                    return wordInput;
                }
                else
                {
                    Console.WriteLine("Please enter a word!");
                }
            }
        }
        static bool SearchAgain ()
        {
            Console.Write("Would you like to search again? Enter \"Y\" if you want to search again or press any key to exit: ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                Console.Clear();    
                return true;
            }
            else
            {
                Console.WriteLine("Thank you for using our app!");
                return false;
            }
        }
    }
}
