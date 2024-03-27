using System.Runtime.InteropServices;

namespace AcademyManagementApp.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public char Grade { get; set; }
        public Subject() { }
        public Subject(string name, char grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
