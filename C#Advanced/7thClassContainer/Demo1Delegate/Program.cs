using Demo1Delegate.Models;
using System.Text;

namespace Demo1Delegate
{
    internal class Program
    {
        public delegate void GreetingDekegate(string name);  // Podatochen tip shto pokazhuva kon funkcii   Sekogash pri povik na delegat se grizhime da ne e null

       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GreetingDekegate greeting1;
            greeting1 = SayHi;

            greeting1("Boris");

            GreetingDekegate greeting2;
            greeting2 = SayZdravo;
            greeting2("Борис");

            Console.WriteLine("");

            GreetingDekegate greetings;
            greetings = SayHi;
            greetings += SayZdravo;

            greetings += (x) => Console.WriteLine($"Чао {x}"); // x = name od delegatot

            greetings("Борис");
            WelcomeUser("Sasho",greetings);
        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
        static void SayZdravo(string name)
        {
            Console.WriteLine($"Здраво {name}");
        }
        static void WelcomeUser(string name, GreetingDekegate function)
        {
            function(name);
        }
    }
}
