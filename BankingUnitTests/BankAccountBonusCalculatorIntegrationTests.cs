
namespace BankingUnitTests;

public class BankAccountBonusCalculatorIntegrationTests
{
    [Fact]
    public void UsesTheBonusCalculator()
    {
        // Given
        var calculator = new Mock<ICalculateBonuses>();
        var account = new BankAccount(calculator.Object, new Mock<INotifyTheFeds>().Object);
        var openingBalance = account.GetBalance();
        calculator.Setup(c => c.GetBonusForDeposit(openingBalance, 100.23M)).Returns(12);

        // When
        account.Deposit(100.23M);


        // Then
        Assert.Equal(openingBalance + 100.23M + 12, account.GetBalance());

    }
}

