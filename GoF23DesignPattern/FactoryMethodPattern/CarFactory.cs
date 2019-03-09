using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class CarFactory
    {
        public abstract AbstractCar CreateCar();
    }
}
