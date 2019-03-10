using System;
using System.Collections;

namespace AdapterPattern
{
    //对象适配器
    public class Abapter : Istack//适配器对象
    {
        ArrayList list;//被适配的对象
        public Abapter()
        {
            list = new ArrayList();
        }
        public object Peek()
        {
            return list[list.Count - 1];
        }

        public object Pop()
        {
            list.RemoveAt(list.Count - 1);
            return list;
        }

        public void Push(object item)
        {
            list.Add(item);
        }
    }
}
