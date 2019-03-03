using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ATM
    {
        //BankAccount bankAccount;  //强依赖关系

        //依赖倒置原则
        void Process(int data)
        {
            //bankAccount.Withdraw(data);
            //emailer.SendEmail("email");
            //mobile.SendNotification("fdsfsdf");

        }
    }
}
