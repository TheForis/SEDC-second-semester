using Demo2.Models;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer p1 = new FootballPlayer("Erling", "Haland", "erling", "asdas11d", "Left");
            BasketballPlayer p2 = new BasketballPlayer("Lebron", "James", "lebron", "Lebron123", 206);
            
                Console.WriteLine(p1.GetData());
                Console.WriteLine(p2.Password);

            Console.WriteLine( PlayerHelper.GetStats(p1));
            Console.WriteLine( PlayerHelper.GetStats(p2));
            Console.WriteLine( PlayerHelper.GetStats(p1,3));

           
            
        }
    }
}