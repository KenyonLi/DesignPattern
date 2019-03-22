using System;

namespace TemplateMethodPattern
{
    /*
     无处不在的Template Method
         如果你只想掌握一种设计模式，那么它就是

           Template Method!
    ==================================================================
    变与不变
        变化——是软件设计的永恒主题，如何管理变化带来的复杂性？
        设计模式的艺术性和复杂度就在于如何分析
        ，并发现系统中的变化点和稳定点，
        并使用特定的设计方法来应对这种变化。
================================================================
   动机（Motivation）
      在软件构建过程中，对于某一项任务，它常常有稳定的整体操作结构，但各个
      步骤却有很多改变的需求，或者由于固有的原因（比如框架与应用之间的关系
      ）而无法和任务的整体结构同时实现。

        如何在确定稳定操作结构的前提下，
        来灵活应对各个子步骤的变化或者晚期实现需求？
         
    意图（Intent）
         定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。Template
         Method使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
            ——《设计模式》GoF
      ==================================================================
      
         Template Method模式的几个要点
              Template Method模式是一种非常基础性的设计模式，在面向
              对象系统中有着大量的应用。它用最简洁的机制（虚函数的多态性）
              为很多应用程序框架提供了灵活的扩展点，是代码复用方面的基本实现
              结构。

             除了可以灵活应对子步骤的变化外，“不要调用我，让我来调用你”的反向控制
             结构是Template Method的典型应用。
             
             在具体实现方面，被Template Mehtod调用的虚方法可以具有实现，也可以没有任何实现
             （抽象方法、纯虚方法），但一般推荐将它们设置为Protected方法。



         
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("模块方法模式");

            VehicalTestFramework.DoTest( new HongqiVehical());
        }
    }

    /// <summary>
    /// 汽车自动化测试开发商
    /// 
    /// 汽车
    /// 
    ///先开发 架构开发者
    /// </summary>
    public abstract class Vehical
    {
        protected abstract void Startup();

        protected abstract void Run();

        protected abstract void Turn(int degree);

        protected abstract void Stop();

        //
        public virtual void Test()
        {
            //晚绑定--留给应用程序开发人员：扩展点

            Startup();
            //测试数据记录
            Run();
            //测试数据记录

            Turn(5);
            //测试数据记录

            Stop();
            //测试数据记录
            //测试报表
        }


    }

    public class VehicalTestFramework
    {

        public static void DoTest(Vehical vehical)
        {
            vehical.Test();
            //......
            //......
            //......
        }

    }

    /// <summary>
    /// 应用程序开发人员
    /// 晚开发
    /// </summary>
    public class HongqiVehical : Vehical
    {
        protected override void Run()
        {
            throw new NotImplementedException();
        }

        protected override void Startup()
        {
            throw new NotImplementedException();
        }

        protected override void Stop()
        {
            throw new NotImplementedException();
        }

        protected override void Turn(int degree)
        {
            throw new NotImplementedException();
        }

        public override void Test()
        {
            base.Test();
        }
    }
}
