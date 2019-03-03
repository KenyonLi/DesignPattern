using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class Mobile : IAccountObserver
    {

        #region -演变：1-


        //public void SendNotification(string phoneNumber)
        //{
        //    //
        //    Console.WriteLine("短信通知");
        //}
        #endregion

        public void Update(UserAccountArgs args)
        {
            Console.WriteLine("短信通知");
        }
    }
}
