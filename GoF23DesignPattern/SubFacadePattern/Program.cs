using FacadePattern;
using System;

namespace SubFacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("外观模式-外部客户程序");
            TankFacade tankFacade = new TankFacade();

            tankFacade.Shot();
        }
    }
}
