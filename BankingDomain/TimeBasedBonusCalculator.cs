

namespace BankingDomain;
public class TimeBasedBonusCalculator : ICalculateBonuses
{

    private ISystemTime _systemTime;

    public TimeBasedBonusCalculator(ISystemTime systemTime)
    {
        _systemTime = systemTime;
    }

    public decimal GetBonusForDeposit(decimal balance, decimal amountToDeposit)
    {
        if (IsDuringBusinessHours())
        {
            return amountToDeposit * 0.12M;
        }
        else
        {
            return 0;
        }
    }

    private bool IsDuringBusinessHours()
    {
        return _systemTime.GetCurrent().Hour <= 17 && _systemTime.GetCurrent().Hour >= 8;
    }
}