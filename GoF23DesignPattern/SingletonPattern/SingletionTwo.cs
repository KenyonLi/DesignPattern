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

    public class SingletonTree
    {

        public static readonly SingletionThree Instance;
        static SingletonTree() => Instance = new SingletonTree();
        private SingletonTree() { }
    }
}
