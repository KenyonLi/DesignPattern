using System;

namespace DecoratorPattern
{
    class Program
    {
        /*
         
            子类复子类，子类何其多
                假如我们需要为游戏中开发一种坦克，除了各种不同型号的坦克
                外，我们还希望在不同场合中为其增加以下一种或多种功能：比如
                红外线夜视功能，如水陆两栖功能，如卫星定位功能等


              //抽象坦克
    public abstract class Tank {
        public abstract void Shot();
        public abstract void Run(); 
    }
    //各种型号
    public class T50 : Tank {//... }
    public class T75 : Tank {//... }
    public class T90 : Tank {//... }
                 

            //各种不同功能的组合
            
    public class T50A : T50,IA {//... }

    public class T50B : T50,IB {//... }
    public class T50C : T50,IC {//... }

    public class T50AB : T50,IA,IB{//... }
    public class T50BC : T50,IB,IC{//... }
    public class T50ABC : T50,IA,IB,IC{//... }
    ============================================================
    动机（Motivation）
       上述描述的问题根源在于我们“过渡地使用了继承来扩展对象的功能”，由于
       继承为类型引入的静态特质，使得这种扩展方式缺乏灵活性：并且随着子类
       的增多（扩展功能的增多），各种子类的组合（扩展功能的组合）会导致更多
       子类的膨胀（多继承）。

            如何使“对象功能的扩展”能够根据需要来动态地实现？同时避免“扩展功能”
            的增多带来的子类膨胀问题？从而使得任何“功能扩展变化”所导致的影响将为最
            低？



             */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }
}


