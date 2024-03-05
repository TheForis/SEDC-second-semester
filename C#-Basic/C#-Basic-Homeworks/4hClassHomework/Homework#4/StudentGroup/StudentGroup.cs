namespace StudentGroup
{
    internal class StudentGroup
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Olio", "Stanlio", "Aleksandar", "Sirma", "Sasho" };

            while (true)
            {
                Console.WriteLine("Enter student group to be shown ( There are 1 and 2 )");
                string userInput = Console.ReadLine();
                if (userInput == "1") 
                {
                    Console.WriteLine("The student's in G1 are:");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("The student's in G2 are:");
                    foreach(string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                }
                Console.WriteLine("Please enter the group number 1 or 2");
            }
        }
    }
}
