namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {


        public decimal GetBonusForDeposit(decimal balance, decimal amountToDeposit)
        {
            decimal bonus = 0;
            if (balance >= 4000)
            {
                bonus = amountToDeposit * .10M;
            }
            return bonus;
        }
    }
}