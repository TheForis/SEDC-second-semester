namespace excercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[0];

            do
            {
                Console.WriteLine("Please enter a number:");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out int number))
                {
                    Console.WriteLine("Wrong input, please try again");
                    continue;
                }
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = number;

                Console.WriteLine("Do you want to enter another number? y / n");
                string input1 = Console.ReadLine();
                if (input1 != "y" && input1 != "Y")
                {
                    break;
                }
            }while (true);
            

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of all the numbers is: {sum}");
            
        }
    }
}
