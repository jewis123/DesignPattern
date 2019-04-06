namespace CreationPattern.AbstractFactory
{
    public class Client
    {
        public void CreateProducts()
        {
            AbstractFactory fac1 = new AbsSubFactoryA();
            fac1.CreateProduct1().SayHi();
            //fac1.CreateProduct2().SayHi();
            //。。。

            // AbstractFactory fac2 = new AbsSubFactoryB();
            // fac2.CreateProduct1().SayHi();
            //fac2.CreateProduct2().SayHi();
            //。。。

        }
    }
}