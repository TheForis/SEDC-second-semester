namespace ATM.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        public int PinForCard { get; set; }
        public int CardBalance { get; set; }
        public Customer()
        {
        }
        public Customer(string firstName, string lastName, long cardNumber, int pinForCard, int cardBalance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            PinForCard = pinForCard;
            CardBalance = cardBalance;
            
        }
        public int WithdrawMoney (int amount)
        {
            return CardBalance -= amount;
        }
        public int DepositMoney (int amount)
        {
            return CardBalance += amount;
        }
        
    }
}
