namespace Demo2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "Risto");
            students.Add(2, "Slave");
            students.Add(300, "Sasho");
            students.Remove(2);
            /*bool success = students.TryAdd(2,"Boris");
            if (!success)
            {
                Console.WriteLine("The key number already exists!");
            }*/

            if (!students.ContainsKey(2))   // se koristi za input od konzola
            {
                students.Add(2, "Boris");
            }
            Console.WriteLine(students[300]);

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key} - {student.Value} ");
            }

            bool isThereName = students.ContainsValue("Boris");
            



        }
    }
}
