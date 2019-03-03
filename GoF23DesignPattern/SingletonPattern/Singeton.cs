using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singeton
    {
        private static Singeton instance;
        private Singeton()
        {
            //私有构造器，外界调用者不能构造
        }

        public static Singeton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singeton();
                }
                return instance;
            }
        }
    }
}
