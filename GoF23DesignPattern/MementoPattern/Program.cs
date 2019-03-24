using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MementoPattern
{

    /*
     
        对象状态的回溯
           对象状态的变化无端，如何回溯/恢复对象在某个点的状态？
           =====================================================

        动机（Motivation）

           在软件构建过程中，某些对象的状态在转换过程中，可能由于某种
           需要，要求程序能够回溯到对象之前处于某个点时的状态。如果使用一些
           公有接口来让其他对象得到对象的状态，便会暴露对象的细节实现。

        如何实现对象状态的良好保存与恢复？但同时又不会因此而破坏对象本身的封装性。

        意图（Intent）
           在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
           这样以后就可以将该对象恢复到原先保存的状态。
                                 ——《设计模式》GoF
          ==========================================================

        Memento模式的几个要点
           备忘录（Memento）存储原发器（Originator）对象内部状态，在需要
           时恢复原发器状态。
           Memento模式适用于“由原发器管理，却又必须存储在原发器之外的信息“

           在实现Memento模式中，要防止原发器以外的对象访问备忘录对象。备忘录对象有两个
           接口，一个为原发器使用的宽接口：一个为其他对象使用的窄接口。


           在实现Memento模式是，要考虑拷贝对象状态的效率问题，如果对象开销比较
           大，可以采用某种增量改变来改进Memento模式。





         
         */
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle r = new Rectangle(0, 0, 10, 10);
            //GraphicsSystem.Process(r);
        }
    }


    /// <summary>
    /// 长方形
    /// </summary>
    [Serializable]
    public class Rectangle : ICloneable
    {
        int x;
        int y;
        int width;
        int height;
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void SetValue(Rectangle r)
        {
            this.x = r.x;
            this.y = r.y;
            this.width = r.width;
            this.height = r.height;
        }

        public void MoveTo(Point point) { }
        public void ChangeWidth(int width) { }
        public void ChangeHeight(int height) { }

        public void Draw(Graphic graphic) { }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public GeneralMemento CreateMemento()
        {
            Factory factory = new Factory();
            GeneralMemento gm = new GeneralMemento(factory);
            gm.SetState(this);
            return gm;
        }

        public void SetMemento(GeneralMemento memento)
        {
            Rectangle r = memento.GetState<Rectangle>();

            this.x = r.x;
            this.y = r.y;
            this.width = r.width;
            this.height = r.height;
        }
    }

    public class Graphic
    {
    }

    public class Point
    {
    }

    public class GraphicsSystem
    {
        //原发器对象
        //有必要对象自身状态进行保存，然后在某个点处又需要恢复内部状态的对象
        Rectangle r = new Rectangle(0, 0, 10, 10);
        //备忘录对象一保存原发器对象的状态，但是不提供原发器对象支持的操作
        //Rectangle rSaved = new Rectangle(0, 0, 10, 10);

        MemoryStream ms = new MemoryStream();
        public void Process()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(ms, r);

            //rSaved = (Rectangle)r.Clone();
        }

        public void Saved_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            ms.Seek(0, SeekOrigin.Begin);
            r = (Rectangle)bf.Deserialize(ms);
        }

    }
    /// <summary>
    /// 序列化 
    /// </summary>
    public class GeneralMemento
    {

        MemoryStream rSave;
        public GeneralMemento(Factory factory)
        {
            rSave = factory.CreateFactoy();

        }


        internal void SetState<T>(T obj)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(rSave, obj);
        }

        internal T GetState<T>()
        {
            BinaryFormatter bf = new BinaryFormatter();
            rSave.Seek(0, SeekOrigin.Begin);
            return (T)bf.Deserialize(rSave);
        }
    }

    public class Factory
    {
        public MemoryStream CreateFactoy()
        {
            //可以扩展很多方法：如文件流、对象等
            return new MemoryStream();
        }
    }
}
