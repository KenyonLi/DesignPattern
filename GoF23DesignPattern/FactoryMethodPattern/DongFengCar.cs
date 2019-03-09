using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class DongFengCar : AbstractCar
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }

        public override void Startup()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void Turn(EnumDirection direction)
        {
            throw new NotImplementedException();
        }
    }

    public class DongFengCarFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new DongFengCar();
        }
    }
}
