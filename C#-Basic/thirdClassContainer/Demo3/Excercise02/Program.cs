namespace Excercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] studentArray = new string[0];

            while (true)
            {
                Console.WriteLine("Would you like to enter a name? Enter Y (yes) or N (no)");
                string userNaswer = Console.ReadLine();
                if (userNaswer == "y")
                {
                    Console.WriteLine("Please enter the name");
                    string userInput = Console.ReadLine();
                    Array.Resize(ref studentArray, studentArray.Length + 1);
                    studentArray[studentArray.Length - 1] = userInput;
                    continue;
                }
                else if(userNaswer == "n")
                {
                    break;
                }
                Console.WriteLine("Please enter a valid answer > Y / N <");
                        
            }


            foreach (string student in studentArray)
            {
                Console.Write($" {student} ");
            }

        }
    }
}
