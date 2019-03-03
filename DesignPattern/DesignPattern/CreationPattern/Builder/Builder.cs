namespace CreationPattern.Builder
{
    public class Builder
    {
        public void Build(BuildMachine machine){
            machine.BuildPartA();
            machine.BuildPartB();
            machine.BuildPartC();
        }
    }
}