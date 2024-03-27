using AcademyManagementApp.Models;

namespace AcademyManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DATA
            Student daniel = new Student("Daniel", 'A', "English");
            Student eva = new Student("Eva", 'C', "Biology");
            Student fiona = new Student("Fiona", 'D', "Chemistry");
            Student george = new Student("George", 'B', "English");
            Student hannah = new Student("Hannah", 'F', "English");
            Student ian = new Student("Ian", 'E', "Chemistry");
            Student jasmine = new Student("Jasmine", 'C', "English");
            Student kyle = new Student("Kyle", 'B', "Biology");
            Student luna = new Student("Luna", 'B', "Chemistry");
            Student miguel = new Student("Miguel", 'C', "English");

            List<Student> students = new List<Student> { daniel,eva,fiona,george, hannah, ian, jasmine, kyle, luna, miguel};

            Subject english = new Subject("English",'F');
            Subject biology = new Subject("Biology",'F');
            Subject chemistry = new Subject("Chemistry", 'F');

            List<Subject> subjects = new List<Subject>(){ english, biology, chemistry};

            daniel.AddSubject(biology, 'F');
            daniel.AddSubject(chemistry, 'D');
            eva.AddSubject(english, 'A');
            eva.AddSubject(chemistry, 'B');
            fiona.AddSubject(english, 'C');
            fiona.AddSubject(biology, 'E');
            george.AddSubject(biology, 'C');
            george.AddSubject(chemistry, 'A');
            hannah.AddSubject(biology, 'C');
            hannah.AddSubject(chemistry, 'D');
            ian.AddSubject(biology, 'C');
            ian.AddSubject(english, 'A');
            jasmine.AddSubject(biology, 'D');
            jasmine.AddSubject(chemistry, 'F');
            kyle.AddSubject(english, 'E');
            kyle.AddSubject(chemistry, 'A');
            luna.AddSubject(biology,'A');
            luna.AddSubject(english, 'B');
            miguel.AddSubject(biology, 'C');
            miguel.AddSubject(chemistry, 'B');

            Trainer trainer1 = new Trainer("Risto");
            Trainer trainer2 = new Trainer("Ilija");
            Trainer trainer3 = new Trainer("Slave");
            Trainer trainer4 = new Trainer("Aneta");

            List<Trainer> trainers = new List<Trainer>() { trainer1,trainer2,trainer3,trainer4};

            Admin admin1 = new Admin("Sara");
            Admin admin2 = new Admin("Veko");
            Admin admin3 = new Admin("Boris");

            List<Admin> admins = new List<Admin>() { admin1,admin2,admin3 };


            #endregion

            try
            {
                while (true)
                {
                    int userInput = LogIn();
                    Console.WriteLine(userInput);
                    ShowList(userInput,admins,trainers,students,subjects);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message);};
            }
        
        static int LogIn()
        {
            while (true)
            {
                Console.Write("Please enter 1(Admin), 2(Trainer) or 3(Student): ");
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out int result))
                {
                    if(result == 1 || result == 2 || result ==3)
                    {
                        return result;
                        
                    }
                    else
                    {
                        Console.WriteLine("Please choose between number 1, 2 or 3!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
            }

        }

        static void ShowList (int userChooser,List<Admin> admins, List<Trainer> trainers, List<Student> students, List<Subject> subjects)
        {
            switch (userChooser) { 
            case 1:
                    AdminLoggedIn(admins, trainers, students);
                    break;

            case 2:
                    TrainerLoggedIn(trainers, students);
                    break;

                case 3:
                    StudentLoggedIn(students);
                    break;
            }
        }
        static bool StayLoggedIn(bool stayLoggedIn)
        {
            Console.WriteLine("Would you like to do another operation? Y / N");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Clear();
                return stayLoggedIn=true;
            }
            Console.Clear();
            return stayLoggedIn= false;
        }

        static void AdminLoggedIn(List<Admin> admins, List<Trainer> trainers, List<Student> students) 
        { 
            bool loggedIn = true;
            Console.WriteLine("Who are you? Please choose from the list below!");
            for (int i = 0; i < admins.Count; i++)
            {
                Console.WriteLine($"{admins[i].Name} - {i + 1}");
            }
            string userInput = Console.ReadLine ();
            if (int.TryParse(userInput, out int userParsedInput))
            {
                if (userParsedInput > admins.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number within the range");
                }
                else
                {
                    Admin adminLoggedIn = admins[userParsedInput - 1];
                    while (loggedIn) { 
                        Console.Write($"Hello {adminLoggedIn.Name}! What would you like to do? [1] AddoRemovAdmins, [2] - Add or Remove Trainers, [3] - Add or Remove Students. :");
                        string adminChooser = Console.ReadLine();

                        #region AdminToAdmin
                    if (adminChooser == "1")
                    {
                        adminLoggedIn.AdminToAdmin(admins,userParsedInput);
                        loggedIn = StayLoggedIn(loggedIn);
                    }
                    #endregion

                        #region AdminToTrainer
                    else if (adminChooser == "2")
                    {
                        adminLoggedIn.AdminToTrainer(trainers);
                        loggedIn = StayLoggedIn(loggedIn);
                    }
                    #endregion

                        #region AdminToStudent
                    else if (adminChooser == "3")
                    {
                        adminLoggedIn.AdminToStudent(students);
                        loggedIn = StayLoggedIn(loggedIn);
                    }
                    #endregion
                    
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number");
            }
        }

        static void TrainerLoggedIn(List<Trainer> trainers, List<Student> students)
        {
            bool loggedIn = true;
            Console.WriteLine("Who are you? Please choose from the list below!");
            for (int i = 0; i < trainers.Count; i++)
            {
                Console.WriteLine(trainers[i].Name + " - " + (i + 1));
            }
            string userTrainerChooser = Console.ReadLine();
            if (int.TryParse(userTrainerChooser, out int userTrainerParsed))
            {
                if (userTrainerParsed > trainers.Count)
                {
                    Console.Clear();
                    Console.WriteLine($"Please enter a number that is in the trainers count range -> {trainers.Count}");
                }
                else
                {

                    string loggedTrainerName = trainers[userTrainerParsed - 1].Name;
                    while (loggedIn)
                    {
                        Console.Write($"Hello {loggedTrainerName}. What would you like to do? [1] - View a list of all Students, [2] - View Subjects and attendees: ");
                        string trainerOption = Console.ReadLine();
                        if (trainerOption == "1")
                        {
                            int counter = 1;
                            foreach (Student s in students)
                            {
                                Console.WriteLine($"{s.Name} - {counter}");
                                counter++;
                            }
                            Console.WriteLine("Choose a person by number or \"X\" to exit");
                            if (int.TryParse(Console.ReadLine(), out int parsedStudentSelection) && parsedStudentSelection <= students.Count)
                            {
                                Student selectedStudent = students[parsedStudentSelection - 1];
                                Console.WriteLine(selectedStudent.PrintCurrentSubject());
                                selectedStudent.PrintSubjectsAndGrades();

                            }

                        }
                        else if (trainerOption == "2")
                        {
                            int englishAttendees = 0;
                            int chemistyAttendees = 0;
                            int biologyAttendees = 0;


                            for (int i = 0; i < students.Count; i++)
                            {
                                if (students[i].CurrentSubject.Name == "English")
                                {
                                    englishAttendees++;
                                }
                                else if (students[i].CurrentSubject.Name == "Chemistry")
                                {
                                    chemistyAttendees++;
                                }
                                else if (students[i].CurrentSubject.Name == "Biology")
                                {
                                    biologyAttendees++;
                                }
                            }

                            Console.WriteLine($"There are {englishAttendees} people currently attending English.");
                            Console.WriteLine($"There are {chemistyAttendees} people currently attending Chemistry.");
                            Console.WriteLine($"There are {biologyAttendees} people currently attending Biology.");
                        }


                        loggedIn = StayLoggedIn(loggedIn);
                    }
                }

            }
        }

        static void StudentLoggedIn(List<Student> students)
        {
            Console.WriteLine("Who are you? Please choose from the list below!");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].Name} - {i + 1}");
            }
            string studentInput = Console.ReadLine();
            if (int.TryParse(studentInput, out int studentParsedInput))
            {
                if (studentParsedInput > students.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number within the range");
                }
                else
                {
                    Student studentLoggedIn = students[studentParsedInput - 1];
                    Console.WriteLine(studentLoggedIn.PrintCurrentSubject());
                    studentLoggedIn.PrintSubjectsAndGrades();
                    Console.WriteLine("Press any key to Log Off!");
                    if (Console.ReadLine() != "easter")
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Congrats you've found and easter egg!");
                        return;
                    }

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number");
            }
        }



    }
}
