using System.Drawing;

namespace Task1
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public Color Color { get; set; }

        public Dog(string name, string breed, Color color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }
        public string DogInfo {get
            {
                return $"The dog of breed: {Breed}, name: {Name} and {Color}";
            }
    }
        public string Eat()
        {
            return $"{DogInfo} is now eating!";
        }
        public string Play() 
        {
            return $"{DogInfo} is now playing!";
        }
        public string ChaseTail()
        {
            return $"{DogInfo} is now chasing it's tail!";
        }
        
    }
}
