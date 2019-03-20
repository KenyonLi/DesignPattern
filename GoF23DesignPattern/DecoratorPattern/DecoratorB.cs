using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 卫星定位
    /// </summary>
    public class DecoratorB : Decorator
    {
        public DecoratorB(Tank tank) : base(tank)
        {
        }

        public override void Run()
        {
            Console.WriteLine("DecoratorB Run 卫星定位");
            base.Run();
        }

        public override void Shot()
        {
            Console.WriteLine("DecoratorB Shot 卫星定位");
            base.Shot();
        }
    }
}



