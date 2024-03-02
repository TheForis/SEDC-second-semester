namespace exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many trees do you have?");
            string input = Console.ReadLine();

            if(!int.TryParse(input, out int numbeOfTrees)) {
                Console.WriteLine("Please enter a number");
                return;
            }

            int numberOfBranchesPerTree = 12;
            int numberOfApplesPerBranch = 8;
            int basketCapacity = 5;

            int numberOfBasketsNeeded;

            int totalApples = numbeOfTrees * (numberOfBranchesPerTree * numberOfApplesPerBranch);
            numberOfBasketsNeeded = totalApples / basketCapacity;
            
            if((totalApples % basketCapacity) > 0)
            {
                numberOfBasketsNeeded = numberOfBasketsNeeded + 1;
            }
            Console.WriteLine($" You need: {numberOfBasketsNeeded} baskets");


            string carBrand = "Opel";

            if(carBrand == "Mitsubishi")
            {
                Console.WriteLine("Mak auto star");
            }
            else if(carBrand == "Peugeot" || carBrand == "Opel")
            {
                Console.WriteLine("Euroimpex");
            }





        }
    }
}
