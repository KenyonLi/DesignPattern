﻿using System;

namespace ObserverPattern
{
    class Program
    {

        /*
          动机（Motivation）
              在软件构建过程中，我们需要为某些对象建立一种“通知依赖关系”
              ——一个对象（目标对象）的状态发生改变，所有的依赖对象（观察者对象）
              都将得到通知。如果这样的依赖关系过于紧密，将使软件不能很好地抵御变化。
          
            使用面向对象技术，可以将这种依赖关系弱化，并形成一种稳定的依赖关系。
            从而实现软件体系结构的松耦合。
             
             
            意图（Intent）
            定义对象间的一种一对多的依赖关系，以便当一个对象的状态发生改变时
            ，所有依赖于它的对象都得到通知并自动更新
                         ——《设计模式》GoF

             */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
