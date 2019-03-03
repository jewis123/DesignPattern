using System;

namespace CreationPattern.AbstractFactory
{
    public class TypeAProduct1 : AbstractProduct
    {
        public TypeAProduct1(string name):base(name){}
        public override void SayHi()
        {
            Console.WriteLine("Product Name is {0}",name);
        }
    }

    public class TypeBProduct1 : AbstractProduct
    {
        public TypeBProduct1(string name) : base(name) { }
        public override void SayHi()
        {
            Console.WriteLine("Product Name is {0}", name);
        }
    }
}