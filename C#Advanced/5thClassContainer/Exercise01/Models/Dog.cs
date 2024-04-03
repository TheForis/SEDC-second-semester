namespace Exercise01.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public Dog(string name, int age,bool goodBoy, string favoriteFood) : base(name, "Dog", age)
        {
            FavoriteFood = favoriteFood;
            GoodBoy = goodBoy;
        }

        public override string PrintInfo()
        {
            return $"{Type} name: \"{Name}\";  Age: {Age};  Is a Good boy?: {GoodBoy};  Favorite food: {FavoriteFood}.";
        }
    }
}
