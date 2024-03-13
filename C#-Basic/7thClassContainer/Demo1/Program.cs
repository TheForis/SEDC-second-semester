using Demo1.Models;
using System.Text;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student student1 = new Student("Boris","Krstovski", "boriskrstovski@gmail.com", "078/721-666","G3");
            Console.WriteLine(student1.GetInfo());

            Trainer trainer1 = new Trainer()
            {
                FirstName = "Jane",
                LastName = "Janevski",
                Email = "jane@gmail.com",
                PhoneNumber = "1234567890",
                YearsOfExperience = 5
            };

            Console.WriteLine(trainer1.GetInfo());

            WebDevelopmentStudent webStudent = new WebDevelopmentStudent("Sashko", "Petkovski", "sash@t-home.com", "070/670-530", "G7", "Македонски");
            Console.WriteLine(webStudent.GetInfo());

        }
    }
}
