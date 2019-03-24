using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.DemoPatternOne
{
    public abstract class BaseHandler
    {
        public abstract void HandlerRequest(Request request);

        public abstract bool CanHandlerRequest();
    }

    public class AHandler : BaseHandler
    {
        public override bool CanHandlerRequest()
        {
            throw new NotImplementedException();
        }

        public override void HandlerRequest(Request request)
        {



        }
    }

    public class BHandler : BaseHandler
    {
        public override bool CanHandlerRequest()
        {
            throw new NotImplementedException();
        }

        public override void HandlerRequest(Request request)
        {

        }
    }

    public class Request
    {
    }


    public class Sender
    {
        public void Process()
        {

            Request request = new Request();

            ArrayList list = new ArrayList();
            list.Add(new AHandler());
            list.Add(new BHandler());

            foreach (BaseHandler handler in list)
            {
                if (handler.CanHandlerRequest())
                {
                    handler.HandlerRequest(request);
                }
            }
        }
    }
}
