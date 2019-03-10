﻿using System;

namespace BridgePattern
{
    partial class Program
    {
        /*
         
            抽象与实现

             抽象不应该依赖于实现细节，实现细节应该依赖于抽象。

             抽象A--依赖->实现细节b

             抽象A---依赖->抽象B   <---依赖--实现细节b

             抽象B——稳定
             实现细节b——变化

              问题在于如果抽象B由于固有的原因，本身并不稳定，
              也有可能变化，怎么办？
              ==================================================

              举例来说
                
                 假如我们需要开发一个同时支持PC和手机的坦克游戏，游戏
                 在PC和手机上功能都一样，都有同样的类型，面临同样的功能
                 需求变化，比如坦克可能有多种不同的型号：T50,T75,T90....

                  对于其中的坦克设计，我们可能很容易设计出一个Tank抽象基类，
                  然后各种不同型号的Tank继承自该类：


              //抽象部分
                public abstract class Tank {
                    public abstract void Shot();
                    public abstract void Run();
                    public abstract void Trun();
                }

                //各种实现
                public class T50 : Tank { ....}
                public class T75 : Tank { ....}
                public class T90 : Tank { ....}

               =====================================
               另外的变化原因
                   但是PC和手机上的图形绘制、声效、操作等实现完成
                   不同...因此对于各种型号的坦克，都需要提供各种不同
                   平台上的坦克实现：
                   
               //PC平台实现
                public class PCT50 : T50  { ....}
                public class PCT75 : T75  { ....}
                public class PCT90 : T90  { ....}
                //手机平台实现
                public class MobileT50 : T50 { ....}
                public class MobileT75 : T75 { ....}
                public class MobileT90 : T90 { ....}

              这样的设计会带来很多问题：有很多重复的代码，类的结构过于
              复杂，难以维护，最致命的是引入任何新平台，比如在TV上的Tank游戏
              都会让整个类层级结构复杂化。

            =======================================================
            动机（Motivation）
                思考上述问题的症结:事实上由于Tank类型的固有逻辑，使得Tank类型
                具有了两个变化的维度——一个变化的维度为“平台的变化”，一个变化的维度
                为“型号的变化”。


                如何应对这种“多维度的变化”？如何利用面向对象技术来使得Tank类型可以
                轻松地沿着“平台”和“型号”两个方向变化，而不引入额外的复杂度？

            意图（Intent）
               将抽象部分与（将一个事物中多个维度的变化分离）实现部分分离，使它们都可以独立地变化。
                    ——《设计模式》GoF


            Bridge模式的几个要点
                Bridge模式使用“对象间的组合关系”解耦了抽象和实现之间固有
                的绑定关系，使得抽象（Tank的型号）和实现（不同平台）可以沿着各自的维度
                来变化。

                所谓抽象和实现沿着各自维度的变化，即“子类化”它们，比如不
                的Tank型号子类，和不同平台子类。得到各个子类之后便可以任意组合它们，从而
                获得不同平台上的不同型号。
                
                Bridge模式有时候类似于多继承方案，但是多继承方案往往违背
                单一职责原则（即一个类只有一个变化的原因），复用性比较差。Bridge
                模式是比多继承方案更好的解决方法。

                Bridge模式的应用一般在“两个非常强的变化维度”，有时候即使两个变化的维度，
                但是某个方向的变化维度并不剧烈——换言之两个变化不会导致纵横交错的结果，并不
                一定要使用Bridge模式。
              
             */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


}