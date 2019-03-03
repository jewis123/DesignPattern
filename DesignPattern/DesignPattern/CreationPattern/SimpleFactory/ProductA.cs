using System;

namespace CreationPattern.SimpleFactory
{
    public class ProductA : Product
    {
        public ProductA(string name) : base(name) { }
        public override void SayHi()
        {
            Console.WriteLine("Hi From {0}", name);
        }
    }

    public class ProductB : Product
    {
        public ProductB(string name) : base(name) { }

        public override void SayHi()
        {
            Console.WriteLine("Hi From {0}", name);
        }
    }
}
