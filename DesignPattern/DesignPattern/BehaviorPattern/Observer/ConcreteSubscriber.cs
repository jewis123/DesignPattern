using System;

namespace BehaviorPattern.Observer
{
    public  class ConcreteSubscriber : Subscriber
    {
        public ConcreteSubscriber(Publisher p) : base(p) { }  //大多数情况下订阅者不需要知道发布者
        public override void ChangeState()
        {
            Console.WriteLine("订阅者A收到{0}的消息",p.ToString());
        }
    }
}
