using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class FacilitiesFactory
    {
        public abstract Road CreateRoad();
        public abstract Building CreateBuilding();

        public abstract Tunnel CreateTunnel();
        public abstract Jungle CreateJungle();
    }
}
