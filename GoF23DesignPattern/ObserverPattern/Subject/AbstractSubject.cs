using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Subject
{
    public abstract class AbstractSubject
    {
        List<IAccountObserver> observersList = new List<IAccountObserver>();
        protected virtual void Notify(UserAccountArgs args)
        {
            Console.WriteLine("取钱");
            foreach (var observer in observersList)
            {
                observer.Update(args); //通知所有订阅用户
            }
        }

        public void AddObserver(IAccountObserver observer)
        {
            observersList.Add(observer);
        }

        public void RemoveObserver(IAccountObserver observer)
        {
            observersList.Remove(observer);
        }
    }
}
