namespace Task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            string[] studentArray = new string[0];

            while (true)
            {
                Console.WriteLine("Would you like to enter a name? Enter Y (yes) or N (no)");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "y" || userAnswer == "Y")
                {
                    Console.WriteLine("Please enter the name");
                    string userInput = Console.ReadLine();
                    Array.Resize(ref studentArray, studentArray.Length + 1);
                    studentArray[studentArray.Length - 1] = userInput;
                    continue;
                }
                else if (userAnswer == "n" || userAnswer == "N")
                {
                    break;
                }
                Console.WriteLine("Please enter a valid answer > Y / N <");

            }

            if (studentArray.Length == 0) 
            {
                Console.WriteLine("There are no students!");
            }
            foreach (string student in studentArray)
            {
                Console.WriteLine(student);
            }
        }
    }
}
