using System;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
    /*
       耦合与变化
           耦合是软件不能抵御变化灾难的根本性原因。
           不仅实体对象与实体之间存在耦合关系，
           实体对象与行为操作之间也存在耦合关系。
          
          行为请求者----->行为实现者
          ====================================================================
        动机（Motivation）
            在软件构建过程中，“行为请求者”与“行为实现者”通常呈现一种“紧耦合”。
            但在某些场合——比如需要对行为进行“记录、撤销\重做(undo\redo)、事务”
            等处理，这种无法抵御变化的紧耦合是不合适的。

           在这种情况下，如何将“行为请求者”与“行为实现者”解耦？将一组行为抽象为对象，可以实现
           二者之间的松耦合。

         意图（Intent）
             将一个请求封装为一个对象，从而使你可用不同的请求对客户（行为的请求者）进行参数化；
             对请求排队或记录请求日志，以及支持可撤销的操作。
                                    ——《设计模式》GoF
          ====================================================================
          Command模式的几个要点
              Command模式的根本目的在于将“行为请求者”与“行为实现者”解耦，
              在面向对象语言中，常见手段是“将行为抽象为对象”。

            实现Command接口的具体命令对象ConcreteCommand有时候根据需要可能会保存
            一些额外的状态信息。

            通过使用Composite模式，可以将多个“命令”封装为一个“复合命令”MacroCommand.


            Command模式与C#中的Delegate有些类似。但两者定义行为接口的规范有区别：
            Command以面向对象中的“接口-实现”来定义行为接口规范，更严格，更符合抽象
            原则：Delegate以函数签名来定义行为接口规范，更灵活，担抽象能力比较弱。


            
             

            
         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命令模式");


        }
    }


    public class Application
    {
        Stack<Command> Stack;
        Stack<Command> undoList;
        bool canUndo;
        bool canRedo;
        public void Show()
        {
            //
            //Document document = new Document();
            //document.ShowText(); //直接依赖行为实现

            //Graphics graphics = new Graphics();
            //graphics.ShowGraphics();

            foreach (Command command in Stack)
            {
                command.Show();
            }

        }

        public void Undo()
        {
            if (canUndo)
            {
                Command command = Stack.Pop();
                command.Undo();
                undoList.Push(command);
            }
        }

        public void Redo()
        {
            if (canRedo)
            {
                Command command = undoList.Pop();

            }
        }
    }

    public class Document : Command
    {
        public void Redo()
        {
            throw new NotImplementedException();
        }

        public virtual void Show()
        {
            throw new NotImplementedException();
        }

        public void ShowText() { }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }

    public class Graphics : Command
    {
        public void Redo()
        {
            throw new NotImplementedException();
        }

        public virtual void Show()
        {
            throw new NotImplementedException();
        }

        public void ShowGraphics() { }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }


    //===================
    public interface Command
    {
        void Show();
        void Undo();
        void Redo();
    }
}
