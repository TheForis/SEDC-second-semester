namespace Models
{
    public class User : BaseEntity
    {
        public User(string firstName, string lastName, string username, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Role = role;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        protected string Password {get; set; } = string.Empty;
        public Role Role { get; set; }

        public void SetPassword(string password)
        {
            if (password.Length > 5 && password.Any(char.IsDigit))
            {
                Password = password;
            }
            else
            {
                Console.WriteLine("Please enter a password that contains at least 5 characters and 1 number!");
            }
            
        }
        public void UpdatePassword(string oldPassword, string password)
        {
            if (Password == oldPassword)
            {
                Console.WriteLine("Please enter new password!");
                SetPassword(password);
            }
            else { Console.WriteLine("The password mismatched!"); }
        }



    }
}
