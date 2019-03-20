using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 红外线
    /// </summary>
    public class DecoratorA : Decorator
    {
        public DecoratorA(Tank tank) : base(tank)
        {
        }

        public override void Run()
        {
            Console.WriteLine("DecoratorA 红外线 Run");
            base.Run();
        }

        public override void Shot()
        {
            Console.WriteLine("DecoratorA 红外线 Shot");
            base.Shot();
        }
    }
}



