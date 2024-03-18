namespace DemoStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string>   usersStack = new Stack<string>();

            usersStack.Push("Boris");
            usersStack.Push("Slave");

            string user1 = usersStack.Pop();
            string user2 = usersStack.Pop();
            string user3 = usersStack.Pop();

            Console.WriteLine(user1);
            Console.WriteLine(user2);
        }
    }
}
