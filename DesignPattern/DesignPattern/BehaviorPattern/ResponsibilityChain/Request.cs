using System;

namespace BehaviorPattern.ResponsibilityChain
{
    public enum RequestType
    {
        Level1,
        Level2,
    }
    public class Request
    {
        public RequestType type;
        public Request(RequestType type){
            this.type = type;
        }

        public void ShowDetail(){
            Console.Write(" My RequestType is {0}",type.ToString());
        }
    }
}
