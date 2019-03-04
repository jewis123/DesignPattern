namespace BehaviorPattern.CommandPattern
{
    class Client
    {
        public void Do()
        {
            Solider reciever = new Solider();

            Commond commondA = new ConcreteCommond(reciever);
            Commond commondB = new ConcreteCommondB(reciever);
            Commond commondC = new ConcreteCommondB(reciever);

            Master invoker = new Master();

            invoker.AddCommond(commondA);
            invoker.AddCommond(commondB);
            invoker.AddCommond(commondC);
            invoker.RemoveCommond();
            invoker.CallToExcute();
        }
    }
}
