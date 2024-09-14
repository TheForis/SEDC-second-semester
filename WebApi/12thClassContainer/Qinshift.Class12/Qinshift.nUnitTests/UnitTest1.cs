using Services;

namespace Qinshift.nUnitTests
{
    public class BankAccountTests
    {
        private BankAccount _bankAccount;
        [SetUp]
        public void Setup()
        {
            _bankAccount = new BankAccount(1000);
        }

        [Test]
        public void BankAccount_AddAmountGreaterThanZero_ShouldIncreaseBalance()
        {
            //1.Arrange

            //2.Act

            _bankAccount.Add(500);

            //3.Assert

            //Assert.AreEqual(1500, _bankAccount.Balance);
            Assert.That(_bankAccount.Balance, Is.EqualTo(1500));
        }
        [Test]
        public void BankAccount_AddAmountLowerThanZero_ShouldThrowException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Add(-500));
        }
        [Test]
        public void BankAccount_WithdrawAmountLessThanBalance_ShouldDecreaseBalance()
        {

            _bankAccount.Withdraw(300);

            Assert.AreEqual(700, _bankAccount.Balance);
        }
        [Test]
        public void BankAccount_WithdrawAmountMoreThanBalance_ShouldThrowException()
        {
            var bankAccount = new BankAccount(1000);
            Assert.Throws<ArgumentOutOfRangeException>(() => bankAccount.Withdraw(1500));
        }
        [Test]
        public void BankAccount_WithdrawAmmountLowerThanZero_ShouldThrowException()
        {
            var _bankAccount = new BankAccount(1000);
            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Withdraw(-100));
        }
        [Test]
        public void BankAccount_TransferFundsToOtherNullAccount_ShouldThrowException()
        {
            var _bankAccount = new BankAccount(1000);
            Assert.Throws<ArgumentNullException>(() => _bankAccount.TransferFunds(null, 500));
        }
        [Test]
        public void BankAccount_TransferFundsToOtherAccount_ShouldIncreaseOtherAccountBalance()
        {
            var secondAccount = new BankAccount();

            _bankAccount.TransferFunds(secondAccount, 700);

            Assert.AreEqual(300, _bankAccount.Balance);
            Assert.AreEqual(700, secondAccount.Balance);
        }
        [Test]
        public void BankAccount_TransferFundsToOtherAccount_ShouldThrowException()
        {
            var secondAccount = new BankAccount();
            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.TransferFunds(secondAccount, -200));
        }
    }
}