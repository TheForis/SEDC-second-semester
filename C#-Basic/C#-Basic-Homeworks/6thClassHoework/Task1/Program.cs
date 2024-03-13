using System.Drawing;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] messages = new string[]{
                "Please enter the name of your Dog!",
                "Please enter the breed of your Dog!",
                "Please enter the color of your Dog!",
                "Please enter 1(Eat), 2(Play) or 3(To chase the Tail)"
                };

            Dog userDog = new Dog(GetUserInput(messages[0]), GetUserInput(messages[1]), Color.FromName(GetUserInput(messages[2])));

            while (true)
            {
                switch (GetUserInput(messages[3]))
                    {
                    case "1":
                        Console.WriteLine(userDog.Eat());
                        return;
                    case "2":
                        Console.WriteLine (userDog.Play());
                        return;
                    case "3":
                        Console.WriteLine(userDog.ChaseTail());
                        return;
                     }

            }

        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }  
}
