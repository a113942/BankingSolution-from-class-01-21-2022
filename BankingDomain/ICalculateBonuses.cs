namespace BankingDomain
{
    public interface ICalculateBonuses
    {
        decimal GetBonusForDeposit(decimal balance, decimal amountToDeposit);
    }
}