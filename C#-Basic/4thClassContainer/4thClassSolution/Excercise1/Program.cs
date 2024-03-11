namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation;
            int firstNumber;
            int secondNumber;

            while (true)
            {
                Console.WriteLine("Choose operation");
                operation = Console.ReadLine();

                if (operation != "+" && operation != "-")
                {
                    Console.WriteLine("Enter the valid operator + or - ");
                    continue;
                    
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Please enter first number");
                string firstUserInput = Console.ReadLine();
                if (int.TryParse(firstUserInput, out firstNumber))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid number");
            }
            while (true)
            {
                Console.WriteLine("Please enter second number");
                string firstUserInput = Console.ReadLine();
                if (int.TryParse(firstUserInput, out secondNumber))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid number");
            }
            int result = 0;

            switch(operation)
            {
                case "+":
                    result = Sum(firstNumber, secondNumber);
                    break;
                case "-":
                    result = Substract(firstNumber, secondNumber);
                    break;

            }

            Console.WriteLine($"The result is {result}");
        }

        static int Sum(int num1, int num2) 
        { 
            return num1 + num2;
        }
        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }


    }
}
