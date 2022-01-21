

namespace BankingUnitTests.BonusCalculation;

public class TimeBasedBonusCalculatorTests
{
    [Fact]
    public void DepositsDuringBusinessHoursGetBonus()
    {
        var clock = new Mock<ISystemTime>();
        clock.Setup(c => c.GetCurrent()).Returns(new System.DateTime(1969, 4, 20, 8, 0, 1));
        ICalculateBonuses tbc = new TimeBasedBonusCalculator(clock.Object);

        var bonus = tbc.GetBonusForDeposit(0, 100);

        Assert.Equal(12, bonus);
    }


    [Fact]
    public void DepositsAfterBusinessHoursDoNotGetBonus()
    {
        var clock = new Mock<ISystemTime>();
        clock.Setup(c => c.GetCurrent()).Returns(new System.DateTime(1969, 4, 20, 18, 0, 1));
        ICalculateBonuses tbc = new TimeBasedBonusCalculator(clock.Object);

        var bonus = tbc.GetBonusForDeposit(0, 100);

        Assert.Equal(0, bonus);
    }
}
