namespace Demo2.Models
{
    public class FootballPlayer : User
    {
        public string StrongerFoot { get; set; }
        public FootballPlayer(string firstName, string lastName, string userName, string password, string strongerFoot) : base(firstName, lastName, userName, password)
        {
            StrongerFoot = strongerFoot;
        }
        public override string GetData()
        {
            return base.GetData() + $"Stronger foot: {StrongerFoot}";
        }
    }
}
