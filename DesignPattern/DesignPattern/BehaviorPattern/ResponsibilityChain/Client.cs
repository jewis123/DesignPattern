using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.ResponsibilityChain
{
    class Client
    {
        public void Do()
        {
            Request request = new Request(RequestType.Level2);
            Handle handle2 = new ConcreteHandleB();
            Handle handle1 = new ConcreteHandleA(handle2);
            handle1.HandleRequest(request);
        }
    }
}
