using ClassLibrary2;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order()
            {
                Street = "Bansko 1/2",
                PhoneNumber = "2/734-355"
            };
            Console.WriteLine(order1.Street);
        }
    }
}
