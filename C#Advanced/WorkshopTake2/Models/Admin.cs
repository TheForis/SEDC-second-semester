namespace Models
{
    public class Admin : User
    {
        public Admin(string firstName, string lastName, string username) : base(firstName, lastName, username, Role.Administrator)
        {
        }
    }
}
