using System;

namespace SingletonPattern
{
    class Program
    {
        /*
            动机（Motivation）  
              在软件系统中，经常有这样一些特殊的类，必须保证它们
              在系统中只存在一个实例，才能确保它们的逻辑正确性、以及良好的
              效率。

            如何绕过常规的构造器，提供一种机制来保证一个类只有一个实例？
            
            这应该是类设计者的责任，而不是使用者的责任。

            意图（Intent）
             保证一个类仅有一个实例，并提供一个该实例的全局访问点。
                               -《设计械》GoF

            ===================================================
             单纯程Singteon模式的几个要点
               Singteon模式中的实例构造器可以设置为protected以允许子类派生。
            
               Singteon模式一般不要支持ICloneable接口，因为这可能会导致多个对象
               实例，与Singteon模式的初衷违背。

               Singteon模式只考虑到了对象创建的管理，没有考虑对象销毁的管理。
               就支持垃圾回收的平台和对象的开销来讲，我们一般没有必要对其销毁进行特殊的管理。
    
               不能应对多线程环境：在多线程环境下，使用Singteon模式仍然有可能
               得到Singteon类的多个实例对象。

             
             
             =======================================================

               Singteon 模式扩展

                 将一个实例扩展到n个实例，例如对象池的实现。
                 将new 构造器的调用转移到其他类中，例如多个类协同工作环境中，某个局部
                 环境只需要拥有某个类的一个实例。

                理解和扩展Singleton模式的核心是“如何控制用户使用new对一个类
                的实例构造器的任意调用”。

         
             
       */
        static void Main(string[] args)
        {
            Console.WriteLine("单例设计");
            Singeton t = Singeton.Instance;
            Singeton t2 = Singeton.Instance;
            Console.WriteLine(t.Equals(t2));

            var _t1 = t.GetType();
            var _t2 = t2.GetType();

            Console.WriteLine(_t1.Equals(_t2));

            Console.ReadKey();
        }
    }
}
