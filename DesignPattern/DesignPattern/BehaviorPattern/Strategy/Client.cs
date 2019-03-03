using BehaviorPattern.StrategyPattern;

namespace BehaviorPattern.StrategyPattern
{
    class Client
    {
        //维护一个上下文对象，以供更改策略或者执行策略
        Context context;

        public void Do()
        {
            //模块A
            Strategy a = new ConcreteStrategeA();
            context = new Context(a);
            context.ContextInterface();


            //模块B
            Strategy b = new ConcreteStrategeB();
            context = new Context(b);
            context.ContextInterface();

            //最基础的策略模式虽然容易扩展，但是上层业务需要知道你有哪些策略，违反迪米特法则（最小知道）
            //结合工厂模式 /享元模式 / 代理模式可以解决这一问题
        }

    }
}
