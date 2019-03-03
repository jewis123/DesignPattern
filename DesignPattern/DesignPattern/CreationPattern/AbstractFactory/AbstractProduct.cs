namespace CreationPattern.AbstractFactory
{
    public abstract class AbstractProduct
    {
        protected string name;
        public AbstractProduct(string name){
            this.name = name;
        }

        public abstract void SayHi();
    }
}