using System.Reflection.Metadata.Ecma335;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Func<int, int, int> sumFunc = (num1,num2) => 
            { 
                return num1 + num2;
            };*/

            Func<int, int, int> sumFunc = (num1, num2) => num1+num2;

            int result = sumFunc(1, 2);
            Console.WriteLine(result);

            Program.Sum("13", "7", sumFunc);

            int result2 = Sum("13", "8", sumFunc);
            Console.WriteLine(result2);

            Func<string> helloMessage = () =>
            {
                return "Hello Qinshift!";
            };
            Func<int> randomNumber = () =>
            {
                Random random = new Random();
                return random.Next(1, int.MaxValue);
            };
            Console.WriteLine(randomNumber());
            Console.WriteLine(randomNumber());
            Console.WriteLine(randomNumber());
            Console.WriteLine(randomNumber());
            Console.WriteLine(helloMessage());


            Action<string, string> printFullName = (firstName, lastName) =>
            {
                Console.WriteLine(firstName + " " + lastName);
            };

            printFullName("Boris", "Krstovski");

            List<string> studentsThatPassed = new List<string> { "Marko","Slave","Mitko"};
            List<string> studentsThatFailed = new List<string> { "Petko", "Mile" };
            Action<string, List<string>> printStudents = (message, list) =>
            {
                Console.Write(message);
                Console.WriteLine(string.Join(", ", list));
            };

            Console.ForegroundColor = ConsoleColor.Green;
            printStudents("Students that have passed: ", studentsThatPassed);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            printStudents("Students that have failed: ", studentsThatFailed);
            Console.ForegroundColor = ConsoleColor.White;

            Action<string, ConsoleColor> print = (message, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            };

            print("Passable", ConsoleColor.Green);
            print("Failed", ConsoleColor.Red);
            print("T-Home MAGENTA", ConsoleColor.Magenta);





        }

        static int Sum (string a,string b, Func<int,int,int> operation)
        {
            int parsedA = int.Parse(a);
            int parsedB = int.Parse(b);
            return operation(parsedA, parsedB);
        }
    }
}
