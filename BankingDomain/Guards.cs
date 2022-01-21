using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDomain;
public static class Guards
{
    public static void NoNegatives(decimal val)
    {
        if (val < 0) throw new NoNegativeNumbersException();
    }

    public static void NoOverdraft(decimal amountOfWithdrawl, decimal balance)
    {
        if (amountOfWithdrawl > balance)
        {
            throw new OverdraftException();
        }
    }
}

