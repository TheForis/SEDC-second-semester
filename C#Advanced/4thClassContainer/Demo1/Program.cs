using ModelsDemo1;
namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "risto", "slave", "sasho", "boris" };
            List<int> numbers = new List<int>() { 2, 3, 6, 8, 10 };

            /*foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }*/

            ListHelper.PrintItems<int>(numbers);

            List<char> chars = new List<char>() { 'c', 'a', 'b' };

            ListHelper.PrintItems(chars);

            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string> ( 1,"Risto"),
                new KeyValuePair<int, string> ( 2,"Slave")
            };

            ListHelper.PrintItems<KeyValuePair<int,string>>(list);


            List<User> users = new List<User>()
            {
                new User("Risto", "Panchevski"),
                new User("Boris", "Krstovski")
            };
            ListHelper.PrintUserItem<User>(users);
        }
    }
}
