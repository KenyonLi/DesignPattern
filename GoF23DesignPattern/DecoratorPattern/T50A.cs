using System;

namespace DecoratorPattern
{
    public class T50A : T50, IA
    {
        public override void Run()
        {
            Console.WriteLine("红外线Run");
            base.Run();
        }

        public override void Shot()
        {
            Console.WriteLine("红外线Run");
            base.Shot();
        }
    }
}
