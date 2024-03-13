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
        public string Eat()
        {
            return $"The dog of breed: {Breed}, name: {Name} and {Color} is now eating!";
        }
        public string Play() 
        {
            return $"The dog of breed: {Breed}, name: {Name} and {Color} is now playing!";
        }
        public string ChaseTail()
        {
            return $"The dog of breed: {Breed}, name: {Name} and {Color} is now chasing it's tail!";
        }
        
    }
}
