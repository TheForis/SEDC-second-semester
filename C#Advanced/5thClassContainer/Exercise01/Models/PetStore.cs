namespace Exercise01.Models
{
    public class PetStore <T> where T : Pet
    {
        public List<T> Pets { get; set; }
        public PetStore(List<T> petList)
        {
            Pets = petList;
        }
        public bool PrintPets()
        {
            if (Pets.Count > 0)
            {
                Console.WriteLine($"These are the pets for sale:");
                foreach (T pet in Pets)
                {
                    Console.WriteLine(pet.PrintInfo());
                }
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("There are no pets left in the pet store.");
                return false;
            }
        }
        public void BuyPet ( string name )
        {
            if (Pets.Count > 0)
            {
                if (Pets.Any(x => x.Name.ToLower() == name.ToLower()))
                {
                    var result = Pets.FirstOrDefault(x => x.Name.ToUpper() == name.ToUpper());
                    Pets.Remove(result);
                    Console.WriteLine("Successful purchase!");
                }
                else
                {
                    Console.WriteLine("There are no pets with that name!");
                }
            }
            return;
        }

    }
}
