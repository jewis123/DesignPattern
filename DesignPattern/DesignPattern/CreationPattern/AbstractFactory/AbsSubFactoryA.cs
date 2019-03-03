namespace CreationPattern.AbstractFactory
{
    public class AbsSubFactoryA : AbstractFactory
    {
        public override AbstractProduct CreateProduct1()
        {
            return new TypeAProduct1("C");
        }

        // public override AbstractProduct CreateProduct2() 。。。。

        //public override AbstractProduct CreateProduct3() 。。。。
    }
}