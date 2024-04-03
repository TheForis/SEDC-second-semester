namespace Exercise01.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool lazy, int livesLeft) : base(name, "Cat", age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override string PrintInfo()
        {
            return $"{Type} name: \"{Name}\";  Age: {Age};  Is Lazy? {Lazy};  Lives left: {LivesLeft}. ";
        }
    }
}
