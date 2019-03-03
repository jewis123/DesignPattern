namespace CreationPattern.Builder
{
    public abstract class BuildMachine
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        //。。。

        public abstract Product GetProduct();
    }
}