
using System.Drawing;

namespace VisitorPattern.DemoPatternTwo
{
    public abstract class Shape
    {
        public abstract void Draw();
        //预料到将来可能会引起新的操作
        public abstract void Accept(ShapeVisitor v, Context context);

    }

    public class Context
    {
    }

    public abstract class ShapeVisitor
    {
        public abstract void Visitor(Rectangle shape, Context context);
        public abstract void Visitor(Circle shape, Context context);
        public abstract void Visitor(Line shape, Context context);
    }

    public class MyShpeVistor : ShapeVisitor
    {
        public override void Visitor(Rectangle shape, Context context)
        {
            //增加对Rectangle的操作
            throw new System.NotImplementedException();
        }

        public override void Visitor(Circle shape, Context context)
        {
            //增加对Circle的操作

            throw new System.NotImplementedException();
        }

        public override void Visitor(Line shape, Context context)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Rectangle : Shape
    {
        public override void Accept(ShapeVisitor v, Context context)
        {
            //第二次多态辨析
            v.Visitor(this, context); //转发
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Circle : Shape
    {
        public override void Accept(ShapeVisitor v, Context context)
        {
            v.Visitor(this, context); //转发
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Line : Shape
    {
        public override void Accept(ShapeVisitor v, Context context)
        {
            v.Visitor(this, context); //转发
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }

    public class App
    {
        ShapeVisitor visitor;

        public App(ShapeVisitor visitor)
        {
            this.visitor = visitor;
        }

        public void Process(Shape shape, Context context)
        {
            //两处多态
            //1.Accept 方法的调用对象 Shape
            //2.Accept 方法的参数 visitor
            shape.Accept(visitor, context);//第一次多态辨析
        }
    }
}