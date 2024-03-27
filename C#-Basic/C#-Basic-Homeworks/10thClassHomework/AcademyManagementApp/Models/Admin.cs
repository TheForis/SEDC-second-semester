namespace AcademyManagementApp.Models
{
    public class Admin
    {
        public string Name { get; set; }

        public Admin() { }
        public Admin (string name) 
        {
            Name = name;
        }

        public void AdminToAdmin(List<Admin> admins,int userLoggedIn)
        {
            Console.Write("Would you like to Add[1] or Remove[2] Admins? : ");
            string addOrRemoveAdminOption = Console.ReadLine();
            if (addOrRemoveAdminOption == "1")
            {
                Console.Write("Please enter the name of the new Admin: ");
                admins.Add(new Admin { Name = Console.ReadLine() });
            }
            else if (addOrRemoveAdminOption == "2")
            {
                Console.WriteLine("Who would you like to remove?");
                for (int i = 0; i < admins.Count; i++)
                {
                    Console.WriteLine($"{admins[i].Name} - {i + 1}");
                }
                string adminRemove = Console.ReadLine();
                if (int.TryParse(adminRemove, out int adminRemoveParsed))
                {
                    if (adminRemoveParsed == userLoggedIn)
                    {
                        Console.Clear();
                        Console.WriteLine("You cannot remove yourself!");
                    }
                    else if (adminRemoveParsed > admins.Count)
                    {
                        Console.Clear();
                        Console.WriteLine($"Please enter a number within the range of the list [{admins.Count}]!");
                        return;
                    }
                    else
                    {
                        admins.Remove(admins[adminRemoveParsed - 1]);
                    }
                }
            }
        }

        public void AdminToTrainer(List<Trainer> trainers)
        {
            Console.Write("Would you like to Add[1] or Remove[2] Trainers? : ");
            string addOrRemoveTrainerOption = Console.ReadLine();
            if (addOrRemoveTrainerOption == "1")
            {
                Console.Write("Please enter the name of the new Trainer: ");
                trainers.Add(new Trainer { Name = Console.ReadLine() });
            }
            else if (addOrRemoveTrainerOption == "2")
            {
                Console.WriteLine("Who would you like to remove?");
                for (int i = 0; i < trainers.Count; i++)
                {
                    Console.WriteLine($"{trainers[i].Name} - {i + 1}");
                }
                string trainerRemove = Console.ReadLine();
                if (int.TryParse(trainerRemove, out int trainerRemoveParsed))
                {
                    if (trainerRemoveParsed > trainers.Count)
                    {
                        Console.Clear();
                        Console.WriteLine($"Please enter a number within the range of the list [{trainers.Count}]!");
                    }
                    trainers.RemoveAt(trainerRemoveParsed - 1);
                }
            }
        }
        public void AdminToStudent(List<Student> students)
        {
            Console.Write("Would you like to Add[1] or Remove[2] Students? : ");
            string addOrRemoveStudentOption = Console.ReadLine();
            if (addOrRemoveStudentOption == "1")
            {
                Console.Write("Please enter the name of the new Student: ");
                string newStudentName = Console.ReadLine();
                Console.Write("Please enter the name of The current subject: ");
                string newStudentSubject = Console.ReadLine();
                Console.Write("Please enter the grade of the current subject: (A - F) ");
                string newStudentGrade = Console.ReadLine().ToUpper();
                if (char.TryParse(newStudentGrade, out char newStudentGradeParsed))
                {
                    if (newStudentGradeParsed == 'A' || newStudentGradeParsed == 'B' || newStudentGradeParsed == 'C' || newStudentGradeParsed == 'D' || newStudentGradeParsed == 'E' || newStudentGradeParsed == 'F')
                    {
                        students.Add(new Student(newStudentName, newStudentGradeParsed, newStudentSubject));

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid char");
                    }
                }


            }
            else if (addOrRemoveStudentOption == "2")
            {
                Console.WriteLine("Who would you like to remove?");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{students[i].Name} - {i + 1}");
                }
                string studentRemove = Console.ReadLine();
                if (int.TryParse(studentRemove, out int studentRemoveParsed))
                {
                    if (studentRemoveParsed > students.Count)
                    {
                        Console.Clear();
                        Console.WriteLine($"Please enter a number within the range of the list [{students.Count}]!");
                    }
                    students.RemoveAt(studentRemoveParsed - 1);
                }
            }
        }
    }
}
