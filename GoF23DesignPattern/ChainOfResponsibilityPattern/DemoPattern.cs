using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.DemoPattern
{
    public abstract class BaseHandler
    {

        public BaseHandler(BaseHandler next)
        {
            this.next = next;
        }
        protected abstract bool CanHandlerRequest();
        public virtual void HandlerRequest(Request request)
        {
            if (this.next != null)
            {
                this.next.HandlerRequest(request);
            }
        }

        BaseHandler next;
        public BaseHandler Next
        {
            get
            {
                return this.next;
            }
            set { this.next = value; }
        }
    }


    public class AHandler : BaseHandler
    {
        public AHandler(BaseHandler next) : base(next)
        {
        }

        protected override bool CanHandlerRequest()
        {
            //throw new NotImplementedException();
            //if (true)
            //{
            //    return true;
            //}
            return false;
        }

        public override void HandlerRequest(Request request)
        {

            if (this.CanHandlerRequest())
            {

            }
            else
            {
                base.HandlerRequest(request);
            }

        }
    }

    public class BHandler : BaseHandler
    {
        public BHandler(BaseHandler next) : base(next)
        {
        }

        protected override bool CanHandlerRequest()
        {
            //if (true)
            //{
            //    return true;
            //}
            return false;
        }

        public override void HandlerRequest(Request request)
        {
            if (this.CanHandlerRequest())
            {

            }
            else
            {
                base.HandlerRequest(request);
            }
        }
    }

    public class CHandler : BaseHandler
    {
        public CHandler(BaseHandler next) : base(next)
        {
        }

        protected override bool CanHandlerRequest()
        {
            throw new NotImplementedException();
        }
        public override void HandlerRequest(Request request)
        {
            if (this.CanHandlerRequest())
            {

            }
            else
            {
                base.HandlerRequest(request);
            }
        }

    }


    public class DHandler : BaseHandler
    {
        public DHandler(BaseHandler next) : base(next)
        {
        }

        protected override bool CanHandlerRequest()
        {
            throw new NotImplementedException();
        }
        public override void HandlerRequest(Request request)
        {
            if (this.CanHandlerRequest())
            {

            }
            else
            {
                base.HandlerRequest(request);
            }
        }

    }
    public class Request
    {
    }


    public class Sender
    {
        public void Process(BaseHandler handler)
        {
            Request request = new Request();
            handler.HandlerRequest(request);
        }
    }
}
