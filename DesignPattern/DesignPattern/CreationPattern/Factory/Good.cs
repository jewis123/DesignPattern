namespace CreationPattern.Factory
{
    public abstract class Good
    {
        public int type;
        public Good(int type)
        {
            this.type = type;
        }

        public abstract void SayType();
    }
}