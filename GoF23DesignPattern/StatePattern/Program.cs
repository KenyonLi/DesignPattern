using System;

namespace StatePattern
{
    /*
     
        对象状态影响对象行为
        对象拥有不同的状态，往往会行使不同的行为。。。

        ===========================================

        动机（Motivation）

          在软件构建过程中，某些对象的状态如果改变，其行为也会随之面发
          生变化，比如文档牌只读状态，其支持的行为和读写状态支持的行为
          就可能完全不同。


         如何在运行时根据对象的状态来透明地更改对象的行为？而不会为对象
         操作和状态转化之间引入紧耦合？

         意图（Intent）

           允许一个对象在其内部状态改变时改变它的行为。从而使对象看起来似乎修改了其
           行为。
              
                                    ——《设计模式》 GoF
         ====================================================
            State模式的几个要点
        
        State模式将所有与一个特定状态相关的行为都放入一个Sate的子类对象中，
        在对象状态切换时，切换相应的对象：但同时维持Sate的接口，这样实现了
        具体操作与状态转换之间的解耦。

        为不同的状态引入不同的对象使得状态转换变得更加明确，而且可以保证不会出现
        状态不一致的情况，因为转换是原子性的——即要么彻底转换过来要么不转换。

        如果Sate对象没有实例变量，那么各个上下文可以共享同一个State对象，
        从而节省对象开销。


         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("状态模式");
        }

    }



    //public enum DocumentState
    //{
    //    ReadOnly,
    //    Editable
    //}


    //public class Document
    //{
    //    DocumentState state;
    //    public void Handle()
    //    {
    //        if (state == DocumentState.ReadOnly)
    //        {

    //            //...
    //        }
    //        else if (state == DocumentState.Editable)
    //        {
    //            //...
    //        }

    //    }
    //}


    /// <summary>
    /// 抽象类----表达状态及依赖状态的行为
    /// </summary>
    public abstract class StateDocument
    {

        public abstract void Handle1();
        public abstract void Handle2();
        public abstract void Handle3();

        public abstract StateDocument Next
        {
            get; set;
        }
    }

    public class ConcreteStateA : StateDocument
    {
        public override StateDocument Next { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Handle1()
        {
            throw new NotImplementedException();
        }

        public override void Handle2()
        {
            throw new NotImplementedException();
        }

        public override void Handle3()
        {
            throw new NotImplementedException();
        }
    }

    public class Document
    {
        StateDocument stateDocument;

        public void SetStateDocument(StateDocument stateDocument)
        {
            this.stateDocument = stateDocument;
        }
        public void Handle1()
        {
            stateDocument.Handle1();
            stateDocument = stateDocument.Next;
        }

        public void Handle2()
        {

            stateDocument.Handle2();
        }
    }
}
