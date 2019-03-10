using System.Drawing;

namespace BridgePattern
{
    public abstract class TankPlatformImplementation
    {
        public abstract void MoveTank(Point to);

        public abstract void DrawTank();
        public abstract void DoShot();
    }
}

