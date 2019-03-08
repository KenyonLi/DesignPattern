using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class AbstractBuilder
    {
        public abstract void BuilderDoor();
        public abstract void BuilderWall();
        public abstract void BuilderWinodw();
        public abstract void BuilderFloor();
        public abstract void BuilerHouseCeiling();

        public abstract AbstractHouse GetHouse();
    }
}
