using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 客户程序
    /// </summary>
    public interface Istack
    {
        void Push(object item);
        object Pop();
        object Peek();
    }
}
