namespace BankingDomain
{
    public interface INotifyTheFeds
    {
        void NotifyOfWithdrawal(BankAccount bankAccount, decimal amountToWithdraw);
    }
}