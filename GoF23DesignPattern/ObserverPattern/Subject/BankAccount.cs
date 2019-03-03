using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Subject
{
    public class BankAccount : AbstractSubject
    {
        //Emailer emailer;//强依赖关系
        //Mobile mobile;//强依赖关系
        public void Withdraw(int data)
        {
            UserAccountArgs args = new UserAccountArgs();
            Notify(args);
        }
    }
}
