using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 客户程序
    /// </summary>
    public class GameManager
    {
        FacilitiesFactory _facilitiesFactory;
        Road road;
        Building building;
        Tunnel tunnel;
        Jungle jungle;
        public GameManager(FacilitiesFactory facilitiesFactory)
        {
            this._facilitiesFactory = facilitiesFactory;
        }

        public void BuildGameFacilities()
        {
            road = _facilitiesFactory.CreateRoad();
            building = _facilitiesFactory.CreateBuilding();
            tunnel = _facilitiesFactory.CreateTunnel();
            jungle = _facilitiesFactory.CreateJungle();
        }

        public void Run()
        {
            // road
        }
    }
}
