using ChainOfResponsibilityPattern.DemoPattern;
using System;
using System.Collections;

namespace ChainOfResponsibilityPattern
{
    /*
     

        请求的发送者与接受者

        某些对象请求的接受者可能多种多样，变化无常。。。

        动机（Motivation）

        在软件构建过程中，一个请求可能多个对象处理，但是每个请求在运行
        时只能有一个接受者，如果显式指定，将必不可少地带来请求发送者与接受
        者的紧耦合。

        如何使请求的发送者不需要指定具体的接受者？让请求的接受者自己在运行时
        决定来处理请求，从而使两者解耦。

        意图（Intent）
           使多个对象都有机会处理请求，从而避免请求的发送者和接收之间的
           耦合关系。将这些对象连成一条链，并沿着这条链接传递请求，直到有一个
           对象处理它为止。

                            ————《设计模式》GoF


        ========================================================

        Chain of Responsibility 模式的几个要点
           
        Chain of Responsibility模式的应用场合在于“一个请求可能有多个接受都，
        但是最后真正的接受者只有一个”，只有这时候请求发送者与接受者的耦合才有可能
        出现“变化脆弱”的症状，职责链的目的就是将二者解耦，从而更好地应对变化。

        应用了Chain of Responsibility模式后，对象的职责分派将更具灵活性。我们
        可以在运行时动态添加、修改请求的处理职责。

        如果请求传递到职责链的末尾仍得不到处理，应该有一个合理的缺省机制。这也是每一个
        接受对象的责任，而不是发出请求的对象的责任。

         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("职责链模式");

            Sender sender = new Sender();

            BaseHandler baseHandler = new AHandler(null);
            BaseHandler baseHandler2 = new BHandler(baseHandler);
            BaseHandler baseHandler3 = new CHandler(baseHandler2);


            BaseHandler baseHandler4 = new DHandler(null);
            baseHandler3.Next = baseHandler4;
            baseHandler4.Next = baseHandler2;

            sender.Process(baseHandler3); 
            // handle3--->handle4--> handle2--->handle1
        }
    }


}
