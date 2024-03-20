namespace AcademyManagementApp.Models
{
    public class Student : Subject
    {
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public Student() { }
        public Student(string name, string subject, int grade)
        {
            Name = name;
            Subject.Name = subject;
            Subject.Grade = grade;
        }
    }
}
