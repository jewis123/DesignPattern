namespace CreationPattern.SimpleFactory
{
    public abstract class Product
    {
        public string name;

        public Product(string name)
        {
            this.name = name;
        }

        public abstract void SayHi();
    }
}
