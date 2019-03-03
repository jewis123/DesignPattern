using System;

namespace CreationPattern.Factory
{
    public class GoodA : Good
    {
        public GoodA(int type) : base(type) { }
        public override void SayType()
        {
            Console.WriteLine("My Type is {0}", type);
        }
    }

    public class GoodB : Good
    {
        public GoodB(int type) : base(type) { }
        public override void SayType()
        {
            Console.WriteLine("My Type is {0}", type);
        }
    }
}
