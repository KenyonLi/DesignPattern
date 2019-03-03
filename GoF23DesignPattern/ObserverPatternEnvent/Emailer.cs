using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternEnvent
{
    public class Emailer : IObserver
    {
        public void SendEmail(AccountChangeEventHandlerArgs args)
        {
            Console.WriteLine("邮件通知");
        }

        public void Update(AccountChangeEventHandlerArgs args)
        {
            SendEmail(args);
        }
    }
}
