
namespace BankingUnitTests
{
    public class NewBankAccountTests
    {
        [Fact]
        public void NewAccountHasTheCorrectOpeningBalance()
        {
            // Given
            var account = new BankAccount(new Mock<ICalculateBonuses>().Object, new Mock<INotifyTheFeds>().Object);
            decimal expectedOpeningBalance = 5000M;
            // When
            decimal balance = account.GetBalance();
            // Then
            Assert.Equal(expectedOpeningBalance, balance);
        }
    }
}
