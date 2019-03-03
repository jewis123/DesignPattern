namespace CreationPattern.Factory
{
    public class Client
    {
        public void Do()
        {
            Factory fac1 = new SubFactoryA();
            Factory fac2 = new SubFactoryB();
            fac1.CreateSpecialGood();
            fac1.Show();
            fac2.CreateSpecialGood();
            fac2.Show();
        }
    }
}