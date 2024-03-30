namespace Demo2.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        //private string Password { get; set; }
        public string Password { get; private set; }
        public string FullName { get => $"{FirstName} {LastName}"; }

        public User(string firstName, string lastName, string userName,string password)
        {
            Random random = new Random();
            Id = random.Next(1,int.MaxValue);
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            SetPassword(password);

        }
        public void SetPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password is required");
            }
            if(password.Length < 8) {
                throw new Exception("The password must be at least 8 characters!");
            }

            Password = password;
        }

        public virtual string GetData()
        {
            return $"{FullName} ({UserName})";
        }

    }
}
