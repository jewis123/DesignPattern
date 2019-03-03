namespace CreationPattern.SimpleFactory
{
    class Client
    {
       public void Do()
        {
            SimpleFactory fac = new SimpleFactory();
            Product p = fac.GetMyProduct("ProductA");
            p.SayHi();
        }
    }
}
