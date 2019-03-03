namespace BehaviorPattern.StatePattern
{
    class Client
    {
        public void Do() {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();

        }
    }
}
