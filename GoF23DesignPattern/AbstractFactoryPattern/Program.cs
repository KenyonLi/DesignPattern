using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        /*
         

            New 的问题

            常规的对象创建方法：
                //创建一个Road对象
                Road roa=new Road();

            new的问题
               -实现依赖，不能应对“具体实例化类型”的变化。

            解决思路：
               -封装变化点——哪里变化，封装哪里
               -潜台词：如果没有变化，当然不需要额外的封装。
           





             
             
             */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
