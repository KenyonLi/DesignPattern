using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternEnvent
{
    public class Moblie : IObserver
    {
        public void SendMobile(AccountChangeEventHandlerArgs args)
        {
            Console.WriteLine("通知短信");
        }

        public void Update(AccountChangeEventHandlerArgs args)
        {
            SendMobile(args);
        }
    }
}
