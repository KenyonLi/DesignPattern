using BridgePattern;
using System;

namespace BridegPatternEvolution
{
    /// <summary>
    /// 演示 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("桥接模式");

            TankPlatformImplementation tankImpl = new MobileTankImplementation();
            T50 t50 = new T50(tankImpl);
        }
    }
}
