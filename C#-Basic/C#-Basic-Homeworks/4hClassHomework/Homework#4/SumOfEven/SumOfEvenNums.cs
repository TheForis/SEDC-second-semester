namespace SumOfEven
{
    internal class SumOfEven
    {
        static void Main(string[] args)
        {
            string[] numberPlaceholders = new string[6] { "1st", "2nd", "3rd", "4th", "5th", "6th" };
            int[] numbers = new int[6];
            int[] evenNumbers = new int[0];
            int sumEvenNumbers = 0;

            for (int i=0; i<6;)
            {
                Console.WriteLine($"Please enter the {numberPlaceholders[i]} number!");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out numbers[i]))
                {
                    i++;
                    continue;
                }
                Console.WriteLine("Please enter a valid integer!");
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Array.Resize(ref evenNumbers, evenNumbers.Length+1);
                    evenNumbers[evenNumbers.Length - 1] = number;
                    sumEvenNumbers += number;
                }

                
            }

            Console.WriteLine($"The sum of the even numbers is: {sumEvenNumbers}");
            
        }
    }
}
