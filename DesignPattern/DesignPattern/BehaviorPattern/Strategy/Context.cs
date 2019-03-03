namespace BehaviorPattern.StrategyPattern
{
    //它也叫做上下文角色，起承上启下封装作用，屏蔽高层模块对策略、算法的直接访问，封装可能存在的变化。
    public class Context
    {
        //用一个ConcreteStrategy来配置，维护一个对Strategy对象的引用
        Strategy strategy; 

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ChangeStrategy(Strategy other)
        {
            strategy = other;
        }

        //向外暴露的接口，更换策略后调用实际调用接口也更改
        public void ContextInterface() {
            strategy.StrategesInterface();
        }
    }
}
