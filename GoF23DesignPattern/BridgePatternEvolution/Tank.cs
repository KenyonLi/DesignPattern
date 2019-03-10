namespace BridgePattern
{
    //抽象部分
    public abstract class Tank
    {
        //组合
        protected TankPlatformImplementation tankTmpl;

        public Tank(TankPlatformImplementation tankTmpl)
        {
            this.tankTmpl = tankTmpl;
        }

        public TankPlatformImplementation TankTmpl
        {
            get
            {
                return this.tankTmpl;
            }
            set
            {
                TankTmpl = this.tankTmpl;
            }
        }
        public abstract void Shot();
        public abstract void Run();
        public abstract void Trun();
    }

}
