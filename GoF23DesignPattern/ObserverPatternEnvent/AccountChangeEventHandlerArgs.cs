using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternEnvent
{
    public class AccountChangeEventHandlerArgs
    {
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
