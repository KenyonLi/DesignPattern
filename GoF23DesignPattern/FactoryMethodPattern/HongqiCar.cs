using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class HongqiCar : AbstractCar
    {
        //引擎
        // 轮子 
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
}
