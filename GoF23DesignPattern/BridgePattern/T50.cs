using System;

namespace BridgePattern
{
        //各种实现
        public class T50 : Tank
        {
            public override void Run()
            {
                throw new NotImplementedException();
            }

            public override void Shot()
            {
                throw new NotImplementedException();
            }

            public override void Trun()
            {
                throw new NotImplementedException();
            }
        }

    public class PCT50 : T50 { }
    public class PCT75 : T75 { }
    public class PCT90 : T90 { }

    public class MobileT50 : T50 { }
    public class MobileT75 : T75 { }
    public class MobileT90 : T90 { }
}
