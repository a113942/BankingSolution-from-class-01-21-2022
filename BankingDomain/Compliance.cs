using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDomain
{
    public class Compliance : INotifyTheFeds
    {
        public void NotifyOfWithdrawal(BankAccount bankAccount, decimal amountToWithdraw)
        {
            // logic 
            if(amountToWithdraw > 50)
            {
                SendNotificationToIrs(9399, "pgr-bank", "they withdrew");
            }
        }

        // This is a big class that has all the logic in it about federal compliance
        // in banking.

        public void SendNotificationToIrs(int notificationCode, string source, string message)
        {
            // logic here 
        }
    }
}
