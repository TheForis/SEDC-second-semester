namespace Services
{
    public class BankAccount
    {
        private double _balance;
        public double Balance => _balance;
        public BankAccount(){}
        public BankAccount(double balance)
        {
            _balance = balance;
        }


        public void Add(double amount)
        {
            if(amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            if(amount > _balance)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _balance -= amount;
        }
        public void TransferFunds(BankAccount otherAccount, double amount)
        {
            if (otherAccount == null)
                throw new ArgumentNullException(nameof(otherAccount));
            if(amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            Withdraw(amount);
            otherAccount.Add(amount);
        }
        public double Sum (double num1, double num2)
        {
            return num1+ num2;
        }
    }
}
