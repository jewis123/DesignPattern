namespace CreationPattern.Builder
{
    public class ConcreteBuildMachine : BuildMachine
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.AddPart("partA");
        }

        public override void BuildPartB()
        {
            product.AddPart("partB");
        }

        public override void BuildPartC()
        {
            product.AddPart("partC");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}