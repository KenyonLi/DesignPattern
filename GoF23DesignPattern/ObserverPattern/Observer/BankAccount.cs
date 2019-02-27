using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class BankAccount
    {
        public void Withdraw(int data)
        {
            Console.WriteLine("取钱");
        }
    }
}
