namespace Models
{
    public abstract class BaseUser : IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public RoleEnum Role { get; set; }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
        public BaseUser(string firstName, string lastName, string username, string password, RoleEnum role)
        {
            Random randomId = new Random();
            Id = randomId.Next(1, int.MaxValue);
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            Role = role;
        }
        public bool PasswordCheck(string password)
        {
            if (Password == password) return true;
            else throw new Exception("Incorrect password!");
        }

    }
}
