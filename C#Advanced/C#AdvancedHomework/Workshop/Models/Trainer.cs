namespace Models
{
    public class Trainer : BaseUser, IUser
    {

        public Trainer(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password, RoleEnum.Trainer)
        {
        }
    }
}
