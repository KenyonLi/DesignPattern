using System;
using System.Collections;

namespace CompositePattern
{
    class Program
    {
        /*
           对象容器的问题
               在面向对象系统中，我们学会遇到一类具有”容器“特征的对象
               ——即它们在充当对象的同时，又是其他对象的容器。
              
            public class SingleBox : IBox {
                  public void Process() {..... }
            }
             public class ContainerBox : IBox {
                public void Process() { }
                public ArrayList GetBoxes() { }
            }

            如果我们要对这样的对象容器进行处理：
               IBox box= Factory.GetBox();
               if(box is ContainerBox){
                  box.Process();
                  ArrayList list=((ContrainerBox)box).GetBoxes();
                 ...  //将面临比较复杂的递归处理
               }else if(box is SingleBox){
                   box.Process();
               }
               ===================================================
               动机（Motivation）
                  上述描述的问题根源在于：客户代码过多地依赖于对象容器
                  复杂的内部实现结构，对象容器内部实现结构（而非抽象接口）的
                  变化将引起客户代码的频繁变化，带来了代码的维护性、扩展性等弊端。


                  如何将”客户代码与复杂的对象结构“解耦？让对象容器自己来实现自身
                  的复杂结构，从而使得客户代码就像处理简单对象一样来处理复杂的对象
                  容器？


               意图（Intent）
                  将对象组合成树形结构以表示”部分-整体“的层次结构。
                  Composite使得用户对单个对象和组合对象的使用有一致性。
                                 ——《设计模式》GoF
                ==================================================
                Composite模式的几个要点
                    Composite模式采用树形结构来实现普遍存在的对象容器，从
                    而将”一对多“的关系转化为”一对一“的关系，使得客户代码可以
                    一致地处理对象和对象容器，无需关心处理的是单个的对象，还是组合
                    的对象容器。

                  将”客户代码与复杂的对象结构容器“解耦是Composite模式的核心思想，
                  解耦之后，客户代码将与纯粹的抽象接口——而非对象容器的内部实现结构——
                  发生依赖关系，从而更能”应对变化“。

                  Composite模式中，是将"Add和Remove等和对象容器相关的方法”定义在
                  ”表示抽象对象的Component类“中，还是将其定义在”表示对象容器的Composite类“中
                  ，是一个关于”透明性“和”安全性“的两难问题，需要仔细权衡。这里有可能违背
                  面向对象的”单一职责原则“，但是对于这种特殊结构，这又是必须
                  付出代价。Asp.net 控件的实现在这方面为我们提供了一个很好的示范。

                 Composite模式在具体实现中，可以让父对象中的子类反向追溯；
                 如果父对象有频繁的遍历需求，可使用缓存技巧来改善效率。


                   
             */
        static void Main(string[] args)
        {
            Console.WriteLine("组合模式");
            //客户代码与对象内部结构发生耦合
            //IBox box = Factory.GetBox();
            //if (box is ContainerBox)
            //{
            //    box.Process();
            //    ArrayList list = ((ContrainerBox)box).GetBoxes();
            //     ...  //将面临比较复杂的递归处理
            //   }
            //else if (box is SingleBox)
            //{
            //    box.Process();
            //}
        }


    }

    public class SingleBox : IBox
    {
        public void Process() { }
    }

    public interface IBox
    {
        void Process();
    }

    public class ContrainerBox : IBox
    {
        ArrayList list = null;

        public void Process() { }
        public ArrayList GetBoxes()
        {
            return list;
        }
    }
}
