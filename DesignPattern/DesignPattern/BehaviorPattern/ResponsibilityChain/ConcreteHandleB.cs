using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.ResponsibilityChain
{
    class ConcreteHandleB : Handle
    {
        public ConcreteHandleB(Handle handle = null) : base(handle) { }
        public override void HandleRequest(Request request)
        {
            if (request.type == RequestType.Level2)
            {
                Console.WriteLine("Handle2 do the request");
            }
            else
            {
                if (nextHandle != null)
                    nextHandle.HandleRequest(request);
                else
                    Console.WriteLine("没有可以处理这个Request的Handle!");
            }
        }
    }
}
