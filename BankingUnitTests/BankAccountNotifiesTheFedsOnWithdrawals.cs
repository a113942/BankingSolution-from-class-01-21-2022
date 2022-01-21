

namespace BankingUnitTests;
public class BankAccountNotifiesTheFedsOnWithdrawals
{
    [Fact]
    public void FedIsNotified()
    {
        // Given
        var mockFedNotifier = new Mock<INotifyTheFeds>();
        var account = new BankAccount(
            new Mock<ICalculateBonuses>().Object,
            mockFedNotifier.Object);

        // When
        account.Withdraw(100M);

        // Then
        mockFedNotifier.Verify(m => m.NotifyOfWithdrawal(account, 100M), Times.Once);
        
    }
}
