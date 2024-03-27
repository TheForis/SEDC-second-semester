namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool toPlay = true;
            int playerWins = 0;
            int compWins = 0;
            int timeGames = 0;
            int totalGames = 0;
            while (toPlay)
            {
                int userChooser = Menu();

                switch (userChooser)
                {
                    case 1:
                        string winner = Game(Play());
                        if(winner == "userWin") { playerWins++; }
                        else if(winner == "compWin") {  compWins++; }
                        else if(winner == null) { timeGames++; }
                        totalGames++;
                        break;
                    case 2:
                        GetStats(playerWins,compWins,totalGames);
                        break;
                    case 3:
                        toPlay = false;
                        break;
                }
            }
        }

        static int Menu()
        {
                while (true)
                {
                    Console.WriteLine("Welcome to Rock - Paper - Scissors");
                    Console.WriteLine("Select > 1 < to Play \nSelect >2< to check the Stats \nSelect >3< to Exit");
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        return 1;
                    }
                    else if (userInput == "2") {
                        return 2;
                    }
                    else if(userInput == "3")
                    {
                        Console.WriteLine("Thank you for playing!");
                    return 3;
                    }
                    Console.Clear();
                    Console.WriteLine("Please select from the menu!");
                }
        }

        static int Play()
        {
            while (true)
            {
                Console.WriteLine("Please select 1 - Rock , 2 - Paper or 3 - Scissors");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result))
                {
                    if (result > 3 || result < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Please choose between 1, 2 or 3!");
                        continue;
                    }
                    return result;
                }
                Console.WriteLine("Please enter a number");
            }
        }

        static string Game (int userInput)
        {
            string[] compPick = new string[] { "Rock", "Paper", "Scissors" };
            Random random = new Random();
            int compHand = random.Next(1,4);


            Console.Clear();
            Console.WriteLine($"The computer showed {compPick[compHand-1]}!");
            


            if(compHand == userInput)
            {
                Console.WriteLine("It's a Tie!");
                return null;
            }
            else if(compHand == 1 && userInput == 3) {
                Console.WriteLine("The Computer Wins!");
                return "compWin";
            }
            else if(compHand == 1 && userInput == 2)
            {
                Console.WriteLine("The user Wins!");
                return "userWin";
            }
            else if(compHand == 2 && userInput == 1)
            {
                Console.WriteLine("The computer Wins!");
                return "compWin";

            }
            else if (compHand == 2 && userInput == 3) {
                Console.WriteLine("The user Wins!");
                return "userWin";
            }
            else if(compHand == 3 && userInput == 1)
            {
                Console.WriteLine("The user Wins!");
                return "userWin";
            }
            else if(compHand == 3 && userInput == 2)
            {
                Console.WriteLine("The computer Wins!");
                return "compWin";
            }
            return null;
        }

        static void GetStats(int userWins, int compWins, int totalGames)
        {
            Console.Clear();
            if(userWins > compWins) {
                int percentageResultUser = userWins * 100;
                int percentageResultUserFinal = percentageResultUser / totalGames;
                Console.WriteLine($"The winner in the long run is the USER and the win percentage is: {percentageResultUserFinal}%");
            }
            else if (userWins < compWins)
            {
                int percentageResultComp = compWins * 100;
                int percentageResultCompFinal = percentageResultComp / totalGames;
                Console.WriteLine($"The winner in the long run is the COMPUTER and the win percentage is: {percentageResultCompFinal}%");
            }
            else
            {
                Console.WriteLine("It's a tie between the 2 players!");
            }
        }
    }
}
