using exercise04.Models;

namespace exercise04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog(1, "Dog1", "red");
            var dog2 = new Dog(1, "Dog2", "brown");
            var dog3 = new Dog(1, "Dog2", "black");
            var dog4 = new Dog(1, "D", "red");
            var dog5 = new Dog(-1, "Dog1", "red");
            try
            {
                DogShelter.AddDog(dog1);
                DogShelter.AddDog(dog2);
                DogShelter.AddDog(dog3);
                try
                {
                    DogShelter.AddDog(dog4);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                try
                {
                    DogShelter.AddDog(dog5);
                }
                catch (Exception ex){
                 Console.WriteLine(ex.ToString());
                }

                Console.WriteLine(DogShelter.GetAllDogs());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
