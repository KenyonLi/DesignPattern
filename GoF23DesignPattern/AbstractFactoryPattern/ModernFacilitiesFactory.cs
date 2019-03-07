using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class ModernFacilitiesFactory : FacilitiesFactory
    {

        public override Building CreateBuilding()
        {
            return new ModernBuilding();
        }

        public override Jungle CreateJungle()
        {
            return new ModernJungle();
        }

        public override Road CreateRoad()
        {
            return new ModernRoad();
        }

        public override Tunnel CreateTunnel()
        {
            return new ModernTunnel();
        }
    }
}
