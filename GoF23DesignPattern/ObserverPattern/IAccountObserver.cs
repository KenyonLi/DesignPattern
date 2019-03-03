using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public interface IAccountObserver
    {
        void Update(UserAccountArgs args);
    }
}
