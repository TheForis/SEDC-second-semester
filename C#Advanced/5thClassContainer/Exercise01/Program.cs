using Exercise01.Models;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DATA
            Dog firstDog = new Dog("Lara", 2, true, "Meat");
            Dog secondDog = new Dog("Jackie", 5, false, "Bubbles");
            Dog thirdDog = new Dog("Alice", 4, true, "Bread");
            List<Dog> dogList = new List<Dog>{ firstDog, secondDog,thirdDog };

            List<Cat> catList = new List<Cat>()
            {
                new Cat("Micky",1,true,7),
                new Cat("Furball", 10, false, 1),
                new Cat("Pancake", 2,true,9),
            };

            List<Fish> fishList = new List<Fish>()
            {
                new Fish("Goldy",1,"Gold", 7),
                new Fish("Bbble",2,"Rainbow",16),
                new Fish("Cleaner",3,"Black",12)
            };
            var dogStore = new PetStore<Dog>(dogList);
            var catStore = new PetStore<Cat>(catList);
            var fishStore = new PetStore<Fish>(fishList);
#endregion


            bool exit = !false;
            while (exit)
            {
                switch (UserChooser())
                {
                    case "1": 
                        if (!dogStore.PrintPets())
                        {
                            break;
                        };
                        dogStore.BuyPet(UserInput());
                        exit = BuyAgain();
                        break;
                    case "2":
                        catStore.PrintPets();
                        catStore.BuyPet(UserInput());
                        exit = BuyAgain();
                        break;
                    case "3":
                        fishStore.PrintPets();
                        fishStore.BuyPet(UserInput());
                        exit = BuyAgain();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a number 1,2 or 3!");
                        exit = true;
                        break;
                }
            }
        }
        static string UserChooser()
        {
            Console.WriteLine("Welcome to the pet store.\nWould you like to buy? \n1) Dog \n2) Cat \n3) Fish");
            return Console.ReadLine();
        }
        static string UserInput()
        {
            Console.WriteLine("Enter the name of the pet you want to purchase!");
            return Console.ReadLine();
        }
        static bool BuyAgain()
        {
            Console.WriteLine("Would you like to buy more? Enter Y or press any key to exit.");
            string userInput = Console.ReadLine();
            if(userInput.ToUpper() == "Y") {
                Console.Clear();
            return true;
            }
            Console.WriteLine("Thank you for visiting us!");
            return false;
        }

    }
}
