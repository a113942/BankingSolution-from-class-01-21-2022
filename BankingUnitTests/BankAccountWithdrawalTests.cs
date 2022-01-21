
namespace BankingUnitTests
{
    public class BankAccountWithdrawalTests
    {
        private BankAccount _account;
        public BankAccountWithdrawalTests()
        {
            _account = new BankAccount(new Mock<ICalculateBonuses>().Object,
                new Mock<INotifyTheFeds>().Object);
        }
        [Fact]
        public void WithdrawDecreasesTheBalance()
        {
            
            
  
            decimal amountToWithdraw = 100M;
            var openingBalance = _account.GetBalance();
            // When
            _account.Withdraw(amountToWithdraw);
            // Then
            Assert.Equal(openingBalance - amountToWithdraw, _account.GetBalance());

        }

        [Fact]
        public void CanWithdrawAllMoney()
        {


            _account.Withdraw(_account.GetBalance());

            Assert.Equal(0, _account.GetBalance());
        }

        [Fact]
        public void OverdraftNotAllowedThrowsAnException()
        {
          

            Assert.Throws<OverdraftException>(
                // Anonymous Function implemented with a Lambda
                () => _account.Withdraw(_account.GetBalance() + .01M)
                );

            // Assert.Throws<OverdraftException>(DoOverdraft);

        }

        // "Named Function" "A Method Group"
        //public void DoOverdraft()
        //{
        //    var account = new BankAccount();
        //    account.Withdraw(account.GetBalance() + .01M);
        //}
    }
}
