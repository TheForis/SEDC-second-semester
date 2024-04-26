namespace Models
{
    public class Trainer : BaseUser
    {

        public Trainer(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password, RoleEnum.Trainer)
        {
        }
    }
}
