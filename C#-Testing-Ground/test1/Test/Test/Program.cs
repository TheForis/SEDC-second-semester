namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of trees");
            string userInput = Console.ReadLine();

            int numberOfTrees;
            bool input = int.TryParse(userInput, out numberOfTrees);
            if (!input)
            {
                Console.WriteLine("Please enter a valid number of trees");
                return;
            }

            int treeBranches = 12;
            int noOfApplesOnTree = treeBranches * 8;
            int totalApples = numberOfTrees * noOfApplesOnTree;
            double totalBaskets = totalApples / 5f;
            double totalBasketsNeeded = Math.Ceiling(totalBaskets);
            Console.WriteLine($"On {numberOfTrees} trees there are {totalApples} apples. You will need {totalBasketsNeeded} baskets to collect all apples.");


        }
    }
}
