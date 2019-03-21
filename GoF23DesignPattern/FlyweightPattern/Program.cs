using System;
using System.Collections;
using System.Linq;

namespace FlyweightPattern
{
    /*
        面向对象的代价
          面向对象很好地解决了系统抽象性的问题,同时在大多数情况下
          ，也不会损及系统的性能。但是，在某些特殊的应用中下，由于对象的数量
          太大，采用面向对象也会给系统带来难以承受的内存开销。
          比如：图形应用中的图元等对象、字处理应用的字符对象等。
          ===================================================
          动机（Motvation）
            采用纯粹对象方案的问题在于大量细粒度的对象会很快充斥在系统中，
            从而带来很高的运行时代价——主要指内存需求方面的代价。

            如何在避免大量细粒度对象问题的同时，让外部客户程序仍然能够透明
            地使用面向对象的方式来进行操作？
         意图（Intent）
            运用共享技术有效地支持大量细粒度的对象。
                            ——《设计模式》GoF
        ==================================================
           Flyweight模式的几个要点
           面向对象很好地解决了抽象性的问题，但是作为一个运行在机器中
           的程序实体，我们需要考虑对象的代价问题。
           Flyweight设计模式主要解决面向对象的代价问题，一般不触及面向对象的抽象性问题。

           Flyweight 采用对象共享的做法来降低系统中对象的个数，从而降低细粒度对象给系统
           带来的内存压力。在具体实现方面，要注意对象状态的处理。

           对象的数量太大从而导致对象内存的开销加大——什么样的数量才算大？这需要
           我们仔细的根据具体应用情况进行评估，而不能凭空臆断。

         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("享元模式");
            /*
              36bytes *1000000=3600000btyes=3600k->3M
             */
            Color Read = new Color();
            Font font1 = new Font("宋体", 13, Read);
            Font font2 = new Font("宋体", 12, Read);
            ArrayList  list = new ArrayList(100000);
            for (int i = 0; i < 100000; i++)
            {
                Charator c = new Charator();
                c.cFont = font1;
                c.cFont = font2;
                list.Add(c);
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        public class Charator//(2+4+20+2)+8bytes=36bytes*n
        {
            char c;//2bytes
            Font f;
            private static Hashtable fontTable = new Hashtable();
            public Font cFont
            {
                get { return f; }
                set
                {
                    if (fontTable.Contains(value.GetHashCode()))
                    {
                        this.f = (Font)fontTable[value.GetHashCode()];
                    }
                    else
                    {
                        fontTable.Add(value.GetHashCode(), value);
                        this.f = value;
                    }
                }
            }//20 bytes
        }
    }
}
