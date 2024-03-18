namespace excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> phoneBook = new Dictionary<string, string>()
            {
                {"Boris", "078/-721-666" },
                {"Sasho", "078/999-123"},
                {"Aleksandra", "078/123-888" },
                {"Maja", "078/766-444" },
                {"Slave", "078/123-127" }

            };

            while (true)
            {
                Console.WriteLine("Please enter a name to search ->");
                string input = Console.ReadLine();

                bool isItFound = phoneBook.TryGetValue(input, out string foundName);

                if (!isItFound)
                {
                    Console.WriteLine("The name was not found in the phone book");
                }
                else
                {
                    Console.WriteLine($"We found the phone number for {input}. The phone number is: {foundName}");
                }

                Console.Write("Enter Y if you want to search again-> ");
                string choice = Console.ReadLine();

                if (!string.Equals(choice,"y", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

            }
        }
    }
}