using System;

namespace BehaviorPattern.Observer
{
    public class ConcretePublisher:Publisher
    {
        public override void Notify()
        {
            Console.WriteLine("通知来了");
            foreach (var item in subscribers)
            {
                item.ChangeState();
            }
        }
    }
}
