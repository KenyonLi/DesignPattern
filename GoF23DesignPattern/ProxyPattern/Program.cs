using System;
using System.Text;

namespace ProxyPattern
{
    /*
     直接与间接
        人们对于复杂的软件系统常常有一种处理手法，即增加一层间接层，
        从而对系统获得一种更为灵活、满足特定需求的解决方案。
        ========================================================
        动机（Motivation）
           在面向对象系统中，有些对象由于某种原因（比如对象创建的开销很大，或者某些扣件需要安全控制
           ，或者需要进程外的访问等），直接访问会给使用者，或者系统结构带来很多麻烦。

           如何在不失去透明操作对象的同时管理/控制这些对象特有的复杂性？
           增加一层间接层是软件开发中常见的解决方式。

        意图（Intent）
           为其他对象提供一种代理以控制对这个对象的访问。
                                ——《设计模式》GoF
        ===============================================
        Proxy模式的几个要点
            “增加一层间接层”是软件系统中对许多复杂问题的一种常见解决方法。
            在面向对象系统中，直接使用某些对象全带来很多问题，作为间接层的Proxy对象
            便是解决这一问题的常用手段。

            具体proxy 设计模式的实现方法，实现粒度都相差很大，有些可能对单个
            对象做细粒度的控制，如copy-on-write技术，有些可能对组件模块提供抽象
            代理层，在架构层次对对象做proxy。
            
           Proxy并不一定要求保持接口一致性，只要能够实现间接控制，有时候
           损及一些透明性是可以接受的。
            
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("代理模式");

            //string s1 = "s";
            //string s2 = "s";

            //Console.WriteLine($"{ s1.GetHashCode() }=={s2.GetHashCode()}");
            //Console.WriteLine($"{s1 = "s1"}");
            //Console.WriteLine($"{s1}");
            //Console.WriteLine($"{s2}");

            //copy-on- write
            // copy-on-change
            StringBuilder sb = new StringBuilder("helllo");
            StringBuilder sb2 = new StringBuilder("helllo");
            StringBuilder sb3 = new StringBuilder("helllo");
            sb.Replace("l", "q");
            Console.ReadKey();
        }



    }
    /// <summary>
    /// v 1.0
    /// 运行在Internet 端
    /// </summary>
    public class Employee : IEmployee
    {
        public void GetSalary() { }
        public void Report() { }
        public void ApplyVacation() { }
    }

    public interface IEmployee
    {
        void GetSalary();
        void Report();
        void ApplyVacation();
    }

    /// <summary>
    /// 运行在本地的window Forms
    /// </summary>
    public class EmployeeProxy : IEmployee
    {

        public EmployeeProxy()
        {
            //对对象创建/访问的一种SOAP封装
        }
        public void ApplyVacation()
        {
            //对对象创建/访问的一种SOAP封装
            //发送SOAP
            //如果有返回值，接受返回值SOAP,解包，返回原生（raw）的C#数据

            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Report()
        {
            throw new NotImplementedException();
        }
    }

    public class HrSystem
    {
        public void Process()
        {
            IEmployee employee = new Employee();
            employee.Report();
            //....
            employee.ApplyVacation();
        }
    }


}
