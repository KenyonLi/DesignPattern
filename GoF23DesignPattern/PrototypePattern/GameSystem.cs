using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class GameSystem
    {
        public static void Run(
            NormalActor normalActor,
            FlyActor flyActor,
            WaterActor waterActor)
        {
            //NormalActor normalActor1 = new NormalActor();
            //NormalActor normalActor2 = new NormalActor();
            //NormalActor normalActor3 = new NormalActor();

            //FlyActor flyActor1 = new FlyActor();
            //FlyActor flyActor2 = new FlyActor();


            NormalActor normalActor1 = normalActor.Clone(); ;
            NormalActor normalActor2 = normalActor.Clone(); ;
            NormalActor normalActor3 = normalActor.Clone(); ;

            FlyActor flyActor1 = flyActor.Clone();
            FlyActor flyActor2 = flyActor.Clone();

            WaterActor waterActor1 = waterActor.Clone();
            WaterActor waterActor2 = waterActor.Clone();
        }
    }

}
