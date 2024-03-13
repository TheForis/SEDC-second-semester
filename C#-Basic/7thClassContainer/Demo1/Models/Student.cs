namespace Demo1.Models
{
    public class Student : Person
    {
        public string Group { get; set; }

        public Student(string firstName, string lastName, string email, string phoneNumber, string group) : base(firstName, lastName, email, phoneNumber)
        {
            Group = group;
        }
    }
}
