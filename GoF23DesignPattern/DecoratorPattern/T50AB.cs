using System;

namespace DecoratorPattern
{
    public class T50AB : T50, IA, IB
    {
        public override void Run()
        {
            this.SatellitePositioning();
            Console.WriteLine("红外线、卫星定位 Run");
            base.Run();
        }

        public void SatellitePositioning()
        {
            Console.WriteLine("卫星定位");
        }

        public override void Shot()
        {
            Console.WriteLine("红外线、卫星定位 Shot");

            base.Shot();
            Console.WriteLine("红外线、卫星定位 end Shot");

        }
    }
}
