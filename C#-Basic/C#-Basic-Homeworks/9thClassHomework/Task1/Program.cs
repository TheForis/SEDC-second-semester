namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueList = new Queue<int>(UserInput());

            while (true)
            {
                if (queueList.TryDequeue(out int number))
                {
                    Console.WriteLine(number);
                    continue;
                }
                break;
            }
            
            
        }

        static Queue<int> UserInput()
        {
            Queue<int> integers = new Queue<int>();
            while (true)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput,out int parsedInput))
                {
                    integers.Enqueue(parsedInput);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }
                Console.Write("Would you like to add another number? Y / N : ");
                string userOption = Console.ReadLine();
                if (userOption.ToLower() != "y")
                {
                    return integers;
                }

            }
        }
    }
}
