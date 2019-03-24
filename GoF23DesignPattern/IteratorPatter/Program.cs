using System;

namespace IteratorPatter
{
    /*
     
        动机（Motivation）

          在软件构建过程中，集合对象内部结构常常变化各异。
          但对于这些集合对象，我们希望在不暴露其内部结构的同时，
          可以让外部客户代码透明地访问其中包含的元素：同时这种“透明遍历”
          也为“同一种算法在多种集合对象上进行操作”提供了可能。

        使用面向对象技术将这种遍历机制抽象为“迭代器对象”为“应对变化中的集合对象
        ”提供了一种优雅的方式。

        意图（Intent）

          提供一种方法顺序访问一个聚合对象中的各个元素，而又不暴露该对象的内部表示。
                            ——《设计模式》GoF
       =========================================================

        Iterator 模式的几个要点
            迭代抽象：访问一个聚合对象的内容而无需暴露它的内部表示。

        迭代多态：为遍历不同的集合结构提供一个统一的接口，从而支持同样的算法
        在不同的集合结构上进行操作。

        迭代器的建壮考虑：遍历的同时更迭代器所在的集合结构，会导致问题。

         
         
   
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("迭代器模式");

            MyCollection col = new MyCollection();

            //完全抽象于（不依赖于）集合结构的访问操作
            IEnumerator ietor = col.GetEnumerator();

            while (ietor.MoveNext())
            {
                int i = (int)ietor.Current;

                //ietor.Current == 100; 可以，但是C#禁止 ----更改元素的值
                // col.Remvoe(i);绝对 禁止-----更改结构

                //i=100 没有更改的效果
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }



    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }

    public interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Reset();
    }

    public class MyCollection : IEnumerable
    {
        public int[] items;
        public MyCollection()
        {
            items = new int[5] { 12, 44, 33, 2, 50 };
        }
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }
    }

    public class MyEnumerator : IEnumerator
    {
        int nIndex;
        private MyCollection collection;

        public MyEnumerator(MyCollection myCollection)
        {
            this.collection = myCollection;
            nIndex = -1;

        }
        public bool MoveNext()
        {
            nIndex++;
            return (nIndex < collection.items.GetLength(0));
        }
        public object Current
        {
            get
            {
                return collection.items[nIndex];
            }
        }
        public void Reset()
        {
            nIndex = -1;
        }
    }

    public class SomeTyep
    {

        public int Sum(IEnumerable enumerable)
        {
            int sum = 0;
            IEnumerator ietor = enumerable.GetEnumerator();
            ietor.Reset();
            while (ietor.MoveNext())
            {
                int i = (int)ietor.Current;
                sum += i;
            }

            return sum;
        }
    }


    //public class MyCollection2 : IEnumerable
    //{
    //    int[] items;
    //    public MyCollection2() {
    //        items = new int[5] { 12, 44, 33, 2, 50};
    //    }

    //    public IEnumerator GetEnumerator()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            yield return items[i];
    //        }
    //    }
    //}
}
