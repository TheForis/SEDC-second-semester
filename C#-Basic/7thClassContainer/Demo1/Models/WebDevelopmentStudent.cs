namespace Demo1.Models
{
    public class WebDevelopmentStudent : Student
    {
        public string FavoriteLanguage { get; set; }

        public WebDevelopmentStudent(string firstName, string lastName, string email, string phoneNumber, string group, string favoriteLanguage) : base(firstName, lastName, email, phoneNumber, group) 
        {
            FavoriteLanguage = favoriteLanguage;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Favorite language: \"{FavoriteLanguage}\"";  
        }
    }
}
