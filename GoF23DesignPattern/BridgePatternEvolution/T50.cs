using System;

namespace BridgePattern
{

    //各种实现
    public class T50 : Tank
    {
        public T50(TankPlatformImplementation tankTmpl) : base(tankTmpl)
        {
        }

        public override void Run()
        {
            base.tankTmpl.DoShot();
        }

        public override void Shot()
        {
            //base.tankTmpl;
        }

        public override void Trun()
        {
            //base.tankTmpl;
        }
    }
}
