using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class HongqiCarFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new HongqiCar();
        }
    }
}
