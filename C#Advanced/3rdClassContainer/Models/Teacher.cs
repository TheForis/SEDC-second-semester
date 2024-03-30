namespace Models
{
    public class Teacher : User
    {
        public string Subject { get; set; }
        public Teacher(string name, string userName, string password, string subject) : base(name, userName, password)
        {
            Subject = subject;
        }

        public override string GetUser()
        {
            return base.GetUser() + $", Subject: {Subject}";
        }
    }
}
