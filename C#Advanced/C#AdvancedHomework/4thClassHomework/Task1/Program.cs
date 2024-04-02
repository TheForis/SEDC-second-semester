using Task1.Models;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string singleString = "Hiiiiii!";
            int int1 = 23;
            PrintInConsole.Print(singleString);
            PrintInConsole.Print(int1);


            List<string> stringList = new List<string>() { "Hello","From","The","List"};
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            PrintInConsole.PrintCollection(stringList);
            PrintInConsole.PrintCollection(numbersList);


        }
    }
}
