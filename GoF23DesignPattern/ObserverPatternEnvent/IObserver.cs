using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternEnvent
{
    public interface IObserver
    {
        void Update(AccountChangeEventHandlerArgs args);
    }
}
