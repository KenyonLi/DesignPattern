using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class GameManager
    {
        public static AbstractHouse CreateHouse(AbstractBuilder builder)
        {
            builder.BuilderDoor();
            builder.BuilderDoor();

            builder.BuilderWinodw();
            builder.BuilerHouseCeiling();
            return builder.GetHouse();
        }
    }
}
