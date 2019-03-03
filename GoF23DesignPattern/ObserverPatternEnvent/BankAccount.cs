using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternEnvent
{
    public class BankAccount
    {
        public event Action<AccountChangeEventHandlerArgs> AccountChange = null;
        public void Withdraw(int data)
        {

            Console.WriteLine("取钱");
            //通知
            AccountChangeEventHandlerArgs args = new AccountChangeEventHandlerArgs();
            OnAccountChange(args);

        }
        public virtual void OnAccountChange(AccountChangeEventHandlerArgs args)
        {
            if (AccountChange != null)
                AccountChange(args);
        }
    }
}
