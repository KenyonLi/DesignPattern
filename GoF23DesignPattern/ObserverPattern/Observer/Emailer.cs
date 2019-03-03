using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class Emailer : IAccountObserver
    {
        #region -演变：1-
        //public void SendEmail(string to)
        //{
        //    Console.WriteLine("通知");
        //}
        #endregion
        public void Update(UserAccountArgs args)
        {
            Console.WriteLine("邮件通知");
        }
    }
}
