using Demo1Polymorphism.Models;
using Models;

namespace Demo1Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter you domain name:");
            string input = Console.ReadLine();

            string userName = DomainNameHelper.GetUserName(input);
            string fullName = DomainNameHelper.GetFullName(input);

            Console.WriteLine(userName);
            Console.WriteLine(fullName);

            var manCity = new Team("Man. City", new List<string> { "W", "W", "W", "W", "W", "W", "D", "D" });
            var arsenal = new Team("Arsenal", new List<string> { "D", "W", "W", "L", "W", "W", "D", "W" });

            manCity.AddWin();
            manCity.AddWin();
            int manCityPoints = Team.GetTeamPoints(manCity);
            int arsenalPoints = Team.GetTeamPoints(arsenal);
            Console.WriteLine($"{manCity.Name} has {manCityPoints} points");
            Console.WriteLine($"{arsenal.Name} has {arsenalPoints} points");
            
            GetSomething( manCityPoints, arsenalPoints);
            GetSomething(manCityPoints, arsenalPoints, 10);


        }
        static void GetSomething(int number,int secondNumber)
        {
            Console.WriteLine($"{number} + {secondNumber} = {number + secondNumber}");
        }
        static void GetSomething(int number,int secondNumber, int thirdNumber)
        {
            Console.WriteLine($"{number} + {secondNumber} + {thirdNumber} = {number + secondNumber + thirdNumber}");
        }
    }
}