using System;

namespace ObserverPatternEnvent
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            Moblie moblie = new Moblie();
            Emailer emailer = new Emailer();
            AccountChangeEventHandlerArgs accountChangeEventHandlerArgs = new AccountChangeEventHandlerArgs();
            Action<AccountChangeEventHandlerArgs> action = (t) => { emailer.SendEmail(t); };
            bankAccount.AccountChange += action;
            bankAccount.AccountChange += (t) => { moblie.SendMobile(t); };
            bankAccount.Withdraw(3432432);
            Console.ReadKey();
        }
    }
}
