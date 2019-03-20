using System;

namespace DecoratorPattern
{
    //各种型号
    public class T50 : Tank
    {
        public override void Run()
        {
            Console.WriteLine("原Run");
        }

        public override void Shot()
        {
            Console.WriteLine("原Shot");
        }
    }
}
