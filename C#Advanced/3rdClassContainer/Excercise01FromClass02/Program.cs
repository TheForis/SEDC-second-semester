using Models;

namespace Exercise01FromClass02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teacher1 = new Teacher("Risto","risto","123","C# Basic");
            Teacher teacher2 = new Teacher("Slave","slave","321","C# Advanced");

            Console.WriteLine(teacher1.GetUser());
            Console.WriteLine(teacher2.GetUser());

            var student1 = new Student("Boris", "boris", "boris123",new List<int> { 5,4,3,5});
            var student2 = new Student ("Sasho","sasho","sasho321", new List<int> { 5,5,5,5});

            Console.WriteLine (student1.GetUser());
            Console.WriteLine (student2.GetUser());

        }
    }
}