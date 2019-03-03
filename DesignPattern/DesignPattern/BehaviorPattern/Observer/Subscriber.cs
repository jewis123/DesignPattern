using System;

namespace BehaviorPattern.Observer
{
    public abstract class Subscriber
    {
        protected Publisher p;

        public Subscriber(Publisher from) {  //面向抽象编程
            p = from;
        }

        public virtual void ChangeState() {
            Console.WriteLine("收到消息");
        }
       
    }
}
