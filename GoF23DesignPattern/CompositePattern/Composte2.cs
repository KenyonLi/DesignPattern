using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Composte2
{
    public interface IBox
    {
        void Process();
        IList list { get; set; }
        //void Add(IBox box);
        //void Remove(IBox box);
    }

    public class SingleBox : IBox
    {
        public IList list { get; set; }

        public void Process()
        {
            throw new NotImplementedException();
        }

        //public void Remove(IBox box)
        //{
        //    throw new UnauthorizedAccessException();
        //}
        //public void Add(IBox box)
        //{
        //    throw new UnauthorizedAccessException();
        //}
    }
    public class ContainerBox : IBox
    {
        public IList list { get; set; }

        //ArrayList list = null;

        //public void Add(IBox box)
        //{
        //    if (list == null)
        //    {
        //        list = new ArrayList();
        //    }
        //    list.Add(box);
        //}
        //public void Remove(IBox box)
        //{
        //    if (list == null)
        //    {
        //        throw new NotImplementedException();
        //    }
        //    list.Remove(box);
        //}
        public void Process()
        {
            //1. Do process for myself
            //2  Do process for the box the list
            if (list != null)
            {
                foreach (IBox box in list)
                {
                    box.Process();
                }
            }
        }
    }

    public class Factory
    {
        public static IBox GetBox()
        {
            return null;
        }
    }
    public class App
    {
        public static void Main()
        {
            IBox box = Factory.GetBox();
            box.list = null;
            box.Process();
        }
    }
}
