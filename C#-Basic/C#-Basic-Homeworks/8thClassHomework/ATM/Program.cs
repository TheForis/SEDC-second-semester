using ATM.Models;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region list
            List<Customer> bankCustomers = new List<Customer>()
            {
                new Customer()
                {
                    FirstName="Bob",
                    LastName = "Bobsky",
                    CardNumber = 1234123412341234,
                    PinForCard = 1234,
                    CardBalance = 240
                },
                new Customer()
                {
                    FirstName = "Boris",
                    LastName = "Krstovski",
                    CardNumber = 9876987698769876,
                    PinForCard = 9876,
                    CardBalance = 9600
                },
                new Customer()
                {
                    FirstName = "Slave",
                    LastName = "Slavevski",
                    CardNumber = 1234567891011123,
                    PinForCard = 5678,
                    CardBalance = 24500
                }

            };
            #endregion



            while (true)
            {
                long userCardNum = UserWelcome();
                Customer user = searchByCard(userCardNum, bankCustomers);
                if (user != null)
                {
                    Console.WriteLine($"Hello {user.FirstName}. Please enter your PIN:");
                    if(int.Parse(Console.ReadLine()) == user.PinForCard)
                    {
                        optionChooser(user);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect PIN, please check your credentials");
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine($"Would you like to register with our bank? Y / N");
                    string userAnswer = Console.ReadLine().ToLower();
                    if ( userAnswer == "y")
                    {
                        RegisterNewUser(userCardNum,bankCustomers);
                        Console.Clear();
                        Console.WriteLine("Registered successfully!");
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }
                    
                }
            }
            
        }

        static long UserWelcome () 
        {
            while (true)
            {
                Console.WriteLine("Welcome to Bank ATM");
                Console.Write("Please enter your card number(XXXX-XXXX-XXXX-XXXX): ");
                string userInput = Console.ReadLine();
                string trimmedUserInput = userInput.Replace("-", "");
                if (trimmedUserInput.Length != 16)
                {
                    Console.Clear();
                    Console.WriteLine("Please check if you entered your card number correctly!");
                    continue;
                }
                else
                {
                    if (long.TryParse(trimmedUserInput, out long parsedUserCard))
                    {
                        return parsedUserCard;
                    }
                    else
                    {
                        Console.WriteLine("Please try again!");
                        continue;
                    }
                }
            }
        }
        static Customer searchByCard(long userCardNumber, List<Customer> bankCustomers)
        {
            
            foreach (Customer customer in bankCustomers)
            {
                if(customer.CardNumber == userCardNumber)
                {
                    return customer;
                }
            }
            Console.WriteLine(userCardNumber);
            return null;

        }

        static void RegisterNewUser(long userCardNumber,List<Customer> customers)
        {
            while (true)
            {
                Console.Write("Please enter your name: ");
                string userName = Console.ReadLine();
                Console.Write("Please enter your last name: ");
                string userLastName = Console.ReadLine();
                Console.Write("Please create new 4 digit PIN for your card: ");
                string userPin = Console.ReadLine();
                int parsedUserPin =0;
                if (userPin.Length != 4)
                {
                    Console.WriteLine("Please enter 4 digit Pin!");
                    continue;
                }
                else
                {
                    if (!int.TryParse(userPin, out parsedUserPin))
                    {
                        Console.WriteLine("Please try again!");
                        continue;
                    }
                    
                }
                
                Console.Write("Please enter your bank balance: ");
                string userBalance = Console.ReadLine();
                if(!int.TryParse(userBalance, out int parsedUserBalance))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }
                customers.Add(new Customer(userName, userLastName, userCardNumber, parsedUserPin, parsedUserBalance));
                break;
            }
        }

        static void optionChooser(Customer user)
        {
            while (true) {
                Console.WriteLine($"Hello {user.FirstName} {user.LastName}!");
                Console.WriteLine("What would you like to do? Enter (1 - To check the balance) (2 - To withdraw cash) (3 - To deposit cash)");
                switch (Console.ReadLine())
                {
                        case "1":
                        Console.WriteLine($"You have ${user.CardBalance}.");
                        break;

                        case "2": Console.WriteLine("How much money would you like to withdraw");
                        string withdrawAmount = Console.ReadLine();
                        if (int.TryParse(withdrawAmount, out int parsedWithdrawAmount))
                        {
                            if (parsedWithdrawAmount > user.CardBalance) {
                                Console.WriteLine("You dont have enough money on your account!");
                                break;
                            }
                            else
                            {
                                user.WithdrawMoney(parsedWithdrawAmount);
                                Console.WriteLine($"You withdrew ${parsedWithdrawAmount} and now you have ${user.CardBalance} on your account.");
                                break;
                            }
                        }
       
                        Console.WriteLine("Please enter a valid number!");
                        break;

                        case "3": Console.WriteLine("How much money would you like to deposit to your account?");
                        string depositAmount = Console.ReadLine();
                        if(int.TryParse(depositAmount, out int parsedDepositAmount))
                        {
                            user.DepositMoney(parsedDepositAmount);
                            Console.WriteLine($"You deposited ${parsedDepositAmount} and now you have ${user.CardBalance} on your account.");
                            break;
                        }
                        Console.WriteLine("Please enter a valid number!");
                        break;
                        default: Console.WriteLine("Please choose 1,2 or 3");
                        break;
                }
                Console.WriteLine("Would you like to do another action? Y / N");
                string userOption = Console.ReadLine();
                
                if(userOption.ToLower() != "y")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using our ATM. Please come back anytime!");
                    break;
                }
                Console.Clear();
            }
        }

    }
}
