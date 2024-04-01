namespace Task1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name,int age)
        {
            Random random = new Random();
            Id = random.Next(1,int.MaxValue);
            Name = name;
            Age = age;
        }

    }
}
