namespace ModelsDemo1
{
    public class Trainer : User
    {
        public string PhoneNumber { get; set; }
        



        public Trainer(string firstName, string lastName,string phoneNumber) : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
