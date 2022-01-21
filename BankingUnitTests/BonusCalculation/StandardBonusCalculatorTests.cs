using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingUnitTests.BonusCalculation;

public class StandardBonusCalculatorTests
{
    [Fact]
    public void AccountsMeetingMinimumGetBonus()
    {
        var calculator = new StandardBonusCalculator();
        decimal balance = 4000;
        decimal amountToDeposit = 100M;

        decimal bonus = calculator.GetBonusForDeposit(balance, amountToDeposit);

        Assert.Equal(10M, bonus);
    }

    [Fact]
    public void AccountsNotMeetingMinimumDoNotBonus()
    {
        var calculator = new StandardBonusCalculator();
        decimal balance = 3999.99M;
        decimal amountToDeposit = 100M;

        decimal bonus = calculator.GetBonusForDeposit(balance, amountToDeposit);

        Assert.Equal(0M, bonus);
    }
}

