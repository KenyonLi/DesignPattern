using StategyPattern.DemoPatternOne;
using System;
using System.Collections;
using System.Drawing;

namespace StategyPattern
{
    /*
     
        算法与对象的耦合

            对象可能经常需要使用多种不同的算法，但是如果变化频繁，会将
            类型变得脆弱。。。

        动机（Motivation）
        
        在软件构建过程中，某些对象使用的算法可能多种多样，经常改变，如果将
        这些算法都编码到对象中，将会使对象变得异常复杂；而且有时候支持不使
        用的算法也是一个性能负担。

        如何在运行时根据需要透明地更改对象的算法？将算法与对象本身解耦，
        从而避免上述问题？

        意图（Intent）

        定义一系列算法，把它们一个个封装起来，并且使它们可互相替换。
        该模式使得算法可独立于使用它的客户（客户代码）而变化。
                                    
                                        ——《设计模式》GoF
         ====================================================
         Strategy模式几个要点

           继承就是封装的实现的手段
            
            接口 virtual 

            Strategy及其子类为组件提供了一系列可重用的算法，从而可以
            使得类型在运行时方便地根据需要在各个算法之间进行时方便地根据
            需要在各个算法之间进行切换。所谓封装算法，支持算法的变化。

            Strategy模式提供了用条件判断语句以外的另一种选择，消除条件
            判断语句，就是在解耦合。含有许多条件判断语句的代码通常都需要
            Stragegy模式

            与State类似，如果Strategy对象没有实例变量，那么各个上下文可以共享
            同一个Strateg对象，从而节省对象开销。



         */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("策略模式");

            DemoPatternOne.Cart cart = new DemoPatternOne.Cart(new ProcessStrategyA());

        }
    }

    public enum CartType
    {
        A, B, C

    }

    public class Cart
    {
        public void Somemethod()
        {


        }

        public void Process(CartType cartType)
        {

            if (cartType == CartType.A)
            {
                ProcesssA();
            }
            else if (cartType == CartType.B)
            {
                ProcesssC();
            }
            else if (cartType == CartType.C)
            {
                ProcesssC();
            }
        }

        protected virtual void ProcesssA()
        {
        }

        protected void ProcesssB()
        {


        }

        protected void ProcesssC()
        {


        }

    }


    public class Point
    {

        int x;
        int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class PointComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }

    public class App
    {

        public void Ext()
        {

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Point(100, 200));
            arrayList.Add(new Point(34, 23));
            arrayList.Add(new Point(21, 55));
            arrayList.Add(new Point(6, 77));
            arrayList.Add(new Point(66, 44));
            arrayList.Add(new Point(77, 88));

            arrayList.Sort(new PointComparer());
        }
    }
}


