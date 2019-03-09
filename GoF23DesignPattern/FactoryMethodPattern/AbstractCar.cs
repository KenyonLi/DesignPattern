using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class AbstractCar
    {
        public abstract void Startup();
        public abstract void Run();
        public abstract void Turn(EnumDirection direction);
        public abstract void Stop();
    }
}
