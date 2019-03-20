namespace DecoratorPattern
{
    /// <summary>
    /// 装饰器
    /// </summary>
    public abstract class Decorator : Tank
    {
        protected Tank tank;
        public Decorator(Tank tank)
        {
            this.tank = tank;
        }
        public override void Run()
        {
            this.tank.Run();
        }
        public override void Shot()
        {
            this.tank.Shot();
        }
    }
}



