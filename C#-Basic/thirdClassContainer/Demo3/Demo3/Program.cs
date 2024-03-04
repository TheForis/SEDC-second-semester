namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[10];

            Console.WriteLine(numbers[5]);

            numbers[1] = 7;
            Console.WriteLine(numbers[1]);


            string[] students = new string[20];
            students[0] = "Risto";
            students[1] = "Slave";
            students[2] = "Darko";



            string[] classes = new string[2] { "C# Basic", "C# Advanced" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i]);
            }

            Console.WriteLine();

            string[] reversedStudents = students.Reverse().ToArray();
            Array.Reverse(students);

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(students[i]);
            }

            Console.WriteLine();

            int studentRisto = Array.IndexOf(students, "Risto");
            Console.WriteLine(studentRisto);

            int[] marks = new [] { 5, 5, 7 };

            int[] marksCopy = marks;
            Array.Resize(ref marks, marks.Length+1);
            marks[3] = 8;
            Array.Resize(ref marks, marks.Length + 1);
            marks[marks.Length-1] = 9;
            Console.WriteLine($"The length of the array is: {marks.Length}");

            foreach (string student in students)
            {
                Console.Write(student+ " ");
            }

            
            



        }
    }
}
