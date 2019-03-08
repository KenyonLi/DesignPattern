using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class SingletionTwo
    {
        public static readonly SingletionTwo Instance = new SingletionTwo();
        private SingletionTwo() { }
    }

    public class SingletonTreet
    {

        public static readonly SingletonTreet Instance;
        static SingletonTreet()
        {
            Instance = new SingletonTreet();
        }
        private SingletonTreet() { }
    }
}
