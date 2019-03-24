using System;

namespace MementoPattern.DemoPatternOne

{


    /// <summary>
    /// 长方形
    /// </summary>
    [Serializable]
    public class Rectangle
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

        public RectangleMemento CreateMemento()
        {
            RectangleMemento rm = new RectangleMemento();
            rm.SetState(this.x, this.y, this.width, this.height);
            return rm;
        }

        public void SetMemento(RectangleMemento rm)
        {
            this.x = rm.x;
            this.y = rm.y;
            this.width = rm.width;
            this.height = rm.height;
        }
    }

    public class RectangleMemento
    {
        internal int x;
        internal int y;
        internal int width;
        internal int height;

        internal void SetState(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }

    public class GraphicsSystem
    {
        //原发器对象
        //有必要对象自身状态进行保存，然后在某个点处又需要恢复内部状态的对象

        Rectangle r = new Rectangle(0, 0, 10, 10);
        //备忘录对象一保存原发器对象的状态，但是不提供原发器对象支持的操作

        RectangleMemento rm = new RectangleMemento();

        public void Process()
        {
            r.SetMemento(rm);
        }

    }
}
