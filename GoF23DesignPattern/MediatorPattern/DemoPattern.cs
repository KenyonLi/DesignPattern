using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.DemoPattern
{

    public abstract class Mediator
    {
        public abstract void Notify();
        public virtual void AddElement(Element element)
        {
            list.Add(element);
        }

        public List<Element> list = new List<Element>();
    }

    public abstract class Element
    {
        Mediator mediator;
        public Element(Mediator mediator)
        {
            this.mediator = mediator;
            this.mediator.AddElement(this);
        }

        public virtual void OnChange()
        {
            mediator.Notify();
        }

    }

    #region -Element 子类-

    public class CutMenuTime : Element
    {
        public CutMenuTime(Mediator mediator) : base(mediator) { }

        public void Cilck()
        {
            OnChange();
        }

    }

    public class TextArea : Element
    {
        public TextArea(Mediator mediator) : base(mediator) { }
        public void Proccess()
        {
            OnChange();
        }
    }

    public class ClipBorad : Element
    {
        public ClipBorad(Mediator mediator) : base(mediator) { }

        public void Cilck()
        {
            OnChange();
        }
    }

    public class ToolarButton : Element
    {
        public ToolarButton(Mediator mediator) : base(mediator) { }

        public void Cilck()
        {
            OnChange();
        }
    }
    #endregion

    /// <summary>
    /// 具体 实现
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        public override void Notify()
        {
            foreach (var elem in list)
            {
                elem.OnChange();
            }
        }
    }
}
