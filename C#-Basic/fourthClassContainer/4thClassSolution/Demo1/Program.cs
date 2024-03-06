namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mkdInput = 0;
            double eurInput=0;


            while (true)
            {
                Console.WriteLine("Choose currenct to be converted ( MKD or EUR )");
                string userChooser = Console.ReadLine();

                if (userChooser == "MKD" || userChooser == "mkd")
                {
                    Console.WriteLine("Please enter how much Denars you want to convert to Euros");
                    string firstUserInput = Console.ReadLine();
                    if (double.TryParse(firstUserInput, out mkdInput))
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a valid number");
                }
                else if (userChooser == "EUR" || userChooser == "eur")
                {
                    Console.WriteLine("Please enter how much Euros you want to convert to Denars");
                    string firstUserInput = Console.ReadLine();
                    if (double.TryParse(firstUserInput, out eurInput))
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a valid number");
                }
                Console.WriteLine("Please enter the currency MKD or EUR");
            }

            if (mkdInput != 0) {
                double eurResult = Program.ConversionToEur(mkdInput);
                Console.WriteLine($"{mkdInput} denars is {eurResult} EURO");
                return;
            }
            else if(eurInput != 0)
            {
                double mkdResult = ConversionToMkd(eurInput);
                Console.WriteLine($"{eurInput} EURO is {mkdResult} denars.");
            }

            

        }

        public static double ConversionToEur (double input)
        {
            double result = input * 0.016;
            return result;
        }
        public static double ConversionToMkd (double input)
        {
            double result = input * 61.63;
            return result;
        }


    }
}
