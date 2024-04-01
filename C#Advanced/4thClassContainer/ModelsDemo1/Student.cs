namespace ModelsDemo1
{
    public class Student : User
    {
        public string Email { get; set; }
        public Student(string firstName, string lastName, string email) : base(firstName, lastName)
        {
            Email = email;
        }
    }
}
