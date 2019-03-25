using System.Drawing;

namespace VisitorPattern.DemoPatternOne
{
    public abstract class Shagpe
    {
        public abstract void Draw();
        //public abstract void MoveTo(Point point);
        // 由于Shape中新增了MoveTo方法，其各个子类将不得不随着更改。
    }

    
    public class Rectangle : Shagpe
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Circle : Shagpe
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
    public class Line : Shagpe
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
