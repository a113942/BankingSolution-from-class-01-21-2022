namespace BankingUnitTests;
public class TransactionsDoNotAllowNegativeValues
{


    [Fact]
    public void NewBehavior()
    {
        var account = new BankAccount(
            new Mock<ICalculateBonuses>().Object,
            new Mock<INotifyTheFeds>().Object);
        var openingBalance = account.GetBalance();


        Assert.Throws<NoNegativeNumbersException>(() => account.Deposit(-100));

        Assert.Equal(openingBalance, account.GetBalance());

       

    }

}

