using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class WaterActorA : WaterActor
    {
        public override WaterActor Clone()
        {
            return (WaterActorA)this.MemberwiseClone();
        }

        
    }
}
