namespace CreationPattern.SimpleFactory
{
    public class SimpleFactory
    {
        public Product GetMyProduct(string name)
        {
            switch (name)
            {
                case "ProductA":
                    return new ProductA("ProductA");
                case "ProductB":
                    return new ProductB("ProductB");
                default:
                    return null;
            }
        }
    }
}
