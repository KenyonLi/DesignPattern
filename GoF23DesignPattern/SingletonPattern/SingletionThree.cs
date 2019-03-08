using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class SingletionThree
    {
        //volatile 保证 
        private static volatile SingletionThree instance = null;
        private static object lockObje = new object();
        private SingletionThree() { }


        public static SingletionThree Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObje)
                    {
                        if (instance == null)
                        {
                            instance = new SingletionThree();
                        }
                    }
                }
                return instance;
            }
        }

       
    }
}
