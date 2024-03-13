using System.Text;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student student1 = new Student("Petko", "Petkovski", "SEDC", "G1");
            Student student2 = new Student("Bob", "Bobsky", "SEDC", "G3");
            Student student3 = new Student("Krste", "Krstevski", "SEDC", "G3");
            Student student4 = new Student("Marko", "Markovski", "SEDC", "G3");
            Student student5 = new Student("Jane", "Janevski", "SEDC", "G6");

            Student[] students = new Student[5] { student1, student2, student3, student4, student5 };

            while(true)
            {
                Console.WriteLine("Внеси име за барање");
                string userInput = Console.ReadLine();

                Student[] result = new Student[0];
                foreach(Student student in students) 
                {
                    if (student.FullName.ToLower().Contains(userInput.ToLower()))
                    {
                        Array.Resize(ref result, result.Length + 1);
                        result[result.Length - 1] = student;
                    }
                }

                if ( result.Length == 0 ) {
                    Console.WriteLine("No records found");
                }
                else
                {
                    foreach(Student student in result )
                    {
                        Console.WriteLine(student.GetStudentInfo());
                    }
                }


                Console.WriteLine("Дали сакате да барате уште еднаш  Y / N ?");
                string choice = Console.ReadLine();
                if (choice != "y" && choice != "Y")
                {
                    break;
                }

            }
        }
    }
}
