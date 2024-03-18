namespace Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> usersStack = new Stack<string>();

            usersStack.Push("Boris");
            usersStack.Push("Slave");
            usersStack.Push("Sasho");

            string peekUser =usersStack.Peek();

            Console.WriteLine(peekUser);

            string user1 = usersStack.Pop();
            string user2 = usersStack.Pop();
            bool success = usersStack.TryPop(out string user3);
            bool success2 = usersStack.TryPop(out string user4);

            List<string> list = new List<string>()
            {
                "niza","od","stringovi"
            };

            foreach (string item in list) { 
                Console.Write($"{item} ");
            }

            Console.WriteLine(user1);
            Console.WriteLine(user2);
            Console.WriteLine(user3);
        }
    }
}