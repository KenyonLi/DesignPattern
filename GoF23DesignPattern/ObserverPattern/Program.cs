using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;

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

            Observer 模式的几个要点
                使用面向对象的抽象，Observer模式使得我们可以独立地改变目标与观察者，
           从而使二者之间的依赖关系达致松耦合。
               目标发送通知时，无需指定观察者，通知（可以携带通知信息作为参数
               ）会自动传播。观察者自己决定 是否需要订阅通知，目标对象对此一无所知。

            在C#的event中，委托充当了抽象的Observer接口，而提供事件的对象充当了目标对象。
            委托是比抽象Oberver接口更为松耦合的设计。
             
             */
        static void Main(string[] args)
        {
            //订阅

            BankAccount subject = new BankAccount();
            subject.AddObserver(new Emailer());
            subject.AddObserver(new Mobile());
            subject.Withdraw(2323);
            Console.ReadKey();
        }
    }
}
