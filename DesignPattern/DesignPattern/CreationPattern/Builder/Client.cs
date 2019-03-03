namespace CreationPattern.Builder
{
    public class Client
    {
        public void Do()
        {
            BuildMachine machine = new ConcreteBuildMachine();
            Builder worker = new Builder();

            worker.Build(machine);
            machine.GetProduct().Show();
        }
    }
}