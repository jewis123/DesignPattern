using System;

namespace BehaviorPattern.Observer
{
    class Client
    {
        public void Do()
        {
            Publisher p = new ConcretePublisher();
            Subscriber s = new ConcreteSubscriber(p);
            p.Attach(s);
            p.Notify();
            Console.WriteLine("end");   //注意当Notify函数执行时间过长，那么很有可能输出语句会在函数还没结束时执行。因为这两行语句时同步执行的。

            //如果一定要让输出语句在Notify函数完成后再执行，那么就应该使用异步！
            //使用异步又会牵扯到线程安全和队列的问题。详情见MD文件
        }
    }
}
