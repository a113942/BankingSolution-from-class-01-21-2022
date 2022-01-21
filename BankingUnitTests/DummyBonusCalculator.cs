using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingUnitTests
{
    public class DummyBonusCalculator : ICalculateBonuses
    {
        public decimal GetBonusForDeposit(decimal balance, decimal amountToDeposit)
        {
            return 0;
        }
    }

    public class StubbedBonusCalculator : ICalculateBonuses
    {
        public decimal GetBonusForDeposit(decimal balance, decimal amountToDeposit)
        {
            if(balance == 5000 && amountToDeposit== 100.23M)
            {
                return 12;
            } else
            {
                return 0;
            }
        }
    }
}
