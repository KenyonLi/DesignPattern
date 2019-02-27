using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class Emailer
    {
        public void SendEmail(string to)
        {
            Console.WriteLine("通知");
        }
    }
}
