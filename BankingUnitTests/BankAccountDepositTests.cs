

namespace BankingUnitTests;

public class BankAccountDepositTests
{
    [Fact]
    public void MakingADepositIncreasesTheBalance()
    {
        // Given
        // set the account to a new bank account
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object, new Mock<INotifyTheFeds>().Object);
        decimal amountToDeposit = 100M;
        var openingBalance = account.GetBalance();
        // When
        account.Deposit(amountToDeposit);
        // Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}

