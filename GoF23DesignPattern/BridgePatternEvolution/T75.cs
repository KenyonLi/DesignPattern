using System;

namespace BridgePattern
{
    public class T75 : Tank
    {
        public T75(TankPlatformImplementation tankTmpl) : base(tankTmpl)
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
