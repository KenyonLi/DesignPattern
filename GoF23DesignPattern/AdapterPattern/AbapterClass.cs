using System.Collections;

namespace AdapterPattern
{
    //类适配器  不推荐使用
    public class AbapterClass : ArrayList, Istack//适配器对象
    {

        public object Peek()
        {
            return this[this.Count - 1];
        }

        public object Pop()
        {
            this.RemoveAt(this.Count - 1);
            return this;
        }

        public void Push(object item)
        {
            this.Add(item);
        }
    }
}
