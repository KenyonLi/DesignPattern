﻿using System;

namespace OOPPattern
{
    class Program
    {
        /*
         *              C#面向对象设计模式纵横谈
         * 
         * 
         * 
             1、面向对象设计模式与原则

               人是一个经验性的动物

                每一个模式描述了一个在我们周围不断重复发生的问题，以及
                该问题的解决方案的核心。
                      ——Christopher Alexander
                设计模式描述了软件设计过程中某一类常见问题的一般性的解决方案。

            面向对象设计模式描述了面向对象设计过程中，特定场景下、类与相互通信
            的对象之间常见的组织关系。
             

                面向对象设计模式解决的是“类与相互通信的对象之间的组织关系，包括它们的角色、职责
            、协作方式几个方面。”

                面向对象设计模式是“好的面向对象设计”，所谓“好的面向对象设计”是那些
            可以满足“应对变化，提高复用”的设计。
                 
                面向对象设计模式描述的是软件设计，因此它是独立于编程语言的，但是面向对象设计
            模式的最终实现仍然要使用面向对象编程语言来表达，本课各基于C#语言，但实际上它适用
            于支持.Net框架的所有.NEt语言，如Visual Basic.Net、c++/CLI等。

                面向对象设计模式不像算法技巧，可以照搬照用，它是建立在对“面向对象”纯熟、深入
            的理解的基础上的经验性认识。掌握面向对象设计模式的前提是首先掌握面向对象“！
             ===========================================
             从编程语言直观了解面向对象

                  各种面向对象编程语言相互有别，但都能看到它们对面向对象三大机制
              的支持，即：”封装、继承、多态“
                  -封装，隐藏内部实现
                  -继承，复用现有代码
                  -多态，改写对象行为

              使用面向对象编程语言（如：C#）,可以推动程序员以面向对象的思维

            ====================================================
               但OOPL并非面向对象的全部
                    OOPL没有回答面向对象的根本性问题——我们为什么要使用面向对象？
                    我们应该怎么样使用三大机制来实现”好的面向对象“？我们应该遵循什么
                    样的面向对象原则？

                任何一个严肃的面向对象程序员，都需要系统地学习面向对象的知识，单纯从编程
                语言上获得的面向对象知识，不能够不胜任面向对象设计与开发。

            ===============================================================
            重新认识面向对象

            从微观层面来看，面向对象的方式更强调各个类的”责任“，新增员工类型不会

            对象是什么？
             -从概念层面讲，对象是某种拥有责任的抽象。
             -从规格层面讲，对象是一系列可以被其他对象使用的公共接口，
             -从语言对象实现层面来看，对象封装了代码和数据。

            有了这些认识之后，怎么才能设计”好的面向对象“？
              -遵循一定的面向对象设计原则
              -熟悉一些典型的面向对象设计模式



            ============================================================
            从设计原则到设计模式
                针对接口编程，而不是针对实现编程
                  -客户程序无需知道所使用对象的特定类型，只需要知道对象拥有客户所期望的接口

                优化使用对象组合，而不是类继承
                   -类继承通常为”白箱复用“，对象组合通常为”黑箱复用“。
                   继承在某种程序上破坏了封装性，子类父类耦合高；而对象组合
                   则只要求被组合的对象具有良好定义的接口，耦合度低。
                封装变化点
                   -使用封装来创建对象之间的分界层，让设计者可以在分界层的一侧进行
                   修改，而不会对另一侧产生不良的影响，从而实现层次间的松耦合。

               使用重构得到模式——设计模式的应用不宜先入为主，一上就使用设计模式
            是对设计模式的最大误用。没有一步到位的设计模式。敏捷软件开发实践提倡
            ”Refactoring to Patterns“是目前普遍公认的最好的使用设计模式的方法。
            =======================================
            几条更体的设计原则
              单一职责原则(SRP)
                  -一个类应该仅有一个引起它变化的原因。
              开放封闭原则（OCP）
                  -类模块应该是可扩展的，但是不可修改（对扩展开放，对更改封闭）
              Liskov替换原则（LSP）
                  -子类必须能够替换它们的基类
              依赖倒置原则（DIP）
                  -高层模块不应该依赖于低层模块，二者都应该依赖于抽象 
                  -抽象不应该依赖实现细节，实现细节应该依赖于抽象。
               接口隔离原则（ISP）
                 -不应该强迫客户程序依赖于它们不用的方法。


            讲座总结
               设计模式描述了软件设计过程中某一类常见问题的一般性的解决方案。
               面向对象设计模式描述了面向对象设计过程中，特定场景下、类与相互通信
               的对象之间
               =======================================================
                  模式分类

            从目的来看：
               -创建型（Creational）模式：负责对象创建。
               -结构型（Structural）模式：处理类与对象间的组合。
               -行为型（Behavionral）模式：类与对象交互中的职责分配。
            从范围来看：
                -类模式处理类与子类的静静关系。
                -对象模式处理对象间的动态关系。

            =======================================================
                有关创建性模式的讨论
                     Singleton模式解决的实体对象个数的问题。
                     除了Singleton之处，其他创建型模式解决的都是new所带来的
                     耦合关系。

                     Factory Method,Abstract Factory,Builder都需要一个额外
                     的工厂类负责实例化“易变对象”，而Prototype则通过原型（一个特殊的
                     工厂类）来克隆“易变对象”。

                      如果遇到“易变类”，起初的设计通常从Factory Method开始，当遇到
                      更多的复杂变化时，再考虑重构为其他三种工厂模式（Abstract Factory,Builder,Prototype）。

             */
        static void Main(string[] args) => Console.WriteLine("Hello World!");
    }
}
