using System.Text;

namespace RealCalculator
{
    internal class RealCalculator
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double firstNumber;
            double secondNumber;
            string chosenOperator;
            while (true)
            {
                Console.WriteLine("Внесете број");
                string firstUserInput = Console.ReadLine();
                if (double.TryParse(firstUserInput, out firstNumber))
                {
                    break; 
                }
                Console.WriteLine("↓ Внесовте невалиден број! Обидете се повторно ↓");
                Console.WriteLine();
            }

            /*while (true)
            {
                Console.WriteLine("Внесете математички оператор ( + - / *");
                chosenOperator = Console.ReadLine();
                if (chosenOperator == "+" || chosenOperator == "-" || chosenOperator == "/" || chosenOperator == "*")
                {
                    break;
                }
                Console.WriteLine("Внесовте невалиден математички оператор! Обидете се повторно");
            }*/

            while (true)
            {
                Console.WriteLine("Внесете втор број");
                string secondUserInput = Console.ReadLine();
                if (double.TryParse(secondUserInput, out secondNumber))
                {
                    break;
                }
                Console.WriteLine("↓ Внесовте невалиден број! Обидете се повторно ↓");
                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine("Внесете математички оператор ( '+' '-' '/' '*' )");
                chosenOperator = Console.ReadLine();

                switch (chosenOperator)
                {
                    case "-":
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case "+":
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case "*":
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case "/":
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        break;
                    default: Console.WriteLine("↓ Внесовте невалиден математички оператор! Обидете се повторно ↓");
                             Console.WriteLine();
                        continue;

                }
                break;

            }



        }
    }
}
