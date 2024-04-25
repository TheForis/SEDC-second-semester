namespace Demo2JSON
{
    public class User
    {
        public string FirstName { get; set; }

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
