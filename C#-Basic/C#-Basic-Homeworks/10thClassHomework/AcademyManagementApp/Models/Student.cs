namespace AcademyManagementApp.Models
{
    public class Student
    {
        public string Name { get; set; }
        public Subject CurrentSubject { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public Student() { }
        public Student(string name, char grade, string subject)
        {
            Name = name;
            CurrentSubject = new Subject(subject,grade);
        }
        public void AddSubject(Subject subject, char grade) 
        {
            subject.Grade = grade;
            Subjects.Add(subject);
        }
        public string PrintCurrentSubject()
        {
            return $"The student: {Name} is currently attending {CurrentSubject.Name} with a projected grade of {CurrentSubject.Grade}.";
        }
        public void PrintSubjectsAndGrades()
        {
            if (Subjects.Count > 0)
            {
                Console.WriteLine($"The student has finished the next subjects:");
                foreach (Subject subject in Subjects)
                {
                    Console.WriteLine($"Grade: {subject.Grade} in {subject.Name}.");
                }
            }
            else
            {
                Console.WriteLine("This student doesn't have any other subjects!");
            }
        }

    }
}
