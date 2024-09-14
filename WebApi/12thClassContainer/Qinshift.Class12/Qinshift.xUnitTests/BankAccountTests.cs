using Services;

namespace Qinshift.xUnitTests
{
    public class BankAccountTests
    {
        private BankAccount _bankAccount;
        public BankAccountTests()
        {
            _bankAccount = new BankAccount(1000);
        }
        [Fact]
        public void BankAccount_AddAmountGreaterThanZero_ShouldIncreaseBalance()
        {
            //1.Arrange

            //2.Act

            _bankAccount.Add(500);

            //3.Assert

            Assert.Equal(1500, _bankAccount.Balance);
        }
        [Fact]
        public void BankAccount_AddAmountLowerThanZero_ShouldThrowException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Add(-500));
        }
        [Fact]
        public void BankAccount_WithdrawAmountLessThanBalance_ShouldDecreaseBalance()
        {

            _bankAccount.Withdraw(300);

            Assert.Equal(700,_bankAccount.Balance);
            Assert.InRange<double>(_bankAccount.Balance, 500, 800);
        }
        [Fact]
        public void BankAccount_WithdrawAmountMoreThanBalance_ShouldThrowException()
        {
            var bankAccount = new BankAccount(1000);
            Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.Withdraw(1500));
        }
        [Fact]
        public void BankAccount_WithdrawAmmountLowerThanZero_ShouldThrowException()
        {
            var _bankAccount = new BankAccount(1000);
            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Withdraw(-100));
        }
        [Fact]
        public void BankAccount_TransferFundsToOtherNullAccount_ShouldThrowException()
        {
            var _bankAccount = new BankAccount(1000);
            Assert.Throws<ArgumentNullException>(()=> _bankAccount.TransferFunds(null,500));
        }
        [Fact]
        public void BankAccount_TransferFundsToOtherAccount_ShouldIncreaseOtherAccountBalance()
        {
            var secondAccount = new BankAccount();

            _bankAccount.TransferFunds(secondAccount, 700);

            Assert.Equal(300, _bankAccount.Balance);
            Assert.Equal(700, secondAccount.Balance);
        }
        [Fact]
        public void BankAccount_TransferFundsToOtherAccount_ShouldThrowException()
        {
            var secondAccount = new BankAccount();
            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.TransferFunds(secondAccount, -200));
        }
        [Theory]
        [InlineData(10,20)]
        [InlineData(20,20)]
        [InlineData(30,60)]
        [InlineData(40,10)]
        [InlineData(50,30)]
        public void BankAccount_Sum_ShouldSumNumber(double num1,double num2)
        {
            var result =_bankAccount.Sum(num1,num2);
            Assert.Equal(num1+num2, result);

        }

    }
}