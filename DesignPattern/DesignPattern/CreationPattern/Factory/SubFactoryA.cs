using System;

namespace CreationPattern.Factory
{
    public class SubFactoryA : Factory
    {
        public override void CreateSpecialGood()
        {
            obj = new GoodA(1001);
        }
        
    }

    public class SubFactoryB : Factory
    {
        public override void CreateSpecialGood()
        {
            obj = new GoodB(1002);
        }
    }
}