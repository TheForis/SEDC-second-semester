namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;


            Console.WriteLine("Please enter the first number");
            string firstInput = Console.ReadLine();
            bool first = int.TryParse(firstInput, out firstNumber);

            Console.WriteLine("Please enter the second number");
            string secondInput = Console.ReadLine();
            bool second = int.TryParse(secondInput, out secondNumber);

            Console.WriteLine("Please enter the third number");
            string thirdInput = Console.ReadLine();
            bool third = int.TryParse(thirdInput, out thirdNumber);

            Console.WriteLine("Please enter the fourth number");
            string fourthInput = Console.ReadLine();
            bool fourth = int.TryParse(fourthInput, out fourthNumber);

            if(!first || !second || !third || !fourth)
            {
                Console.WriteLine("Please enter a valid number!");
                return;
            }


            int avgResult = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
            Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is {avgResult}!");
        }
    }
}
