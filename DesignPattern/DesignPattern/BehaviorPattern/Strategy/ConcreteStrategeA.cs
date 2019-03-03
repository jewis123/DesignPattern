using System;

namespace BehaviorPattern.StrategyPattern
{
    public class ConcreteStrategeA : Strategy
    {
        public override void StrategesInterface()
        {
            Console.WriteLine("具体策略A");
        }
    }
    public class ConcreteStrategeB : Strategy
    {
        public override void StrategesInterface()
        {
            Console.WriteLine("具体策略B");
        }
    }
    public class ConcreteStrategeC : Strategy
    {
        public override void StrategesInterface()
        {
            Console.WriteLine("具体策略C");
        }
    }
}
