namespace CreationPattern.Factory
{
    public abstract class Factory
    {
       protected Good obj  ;
       public void DoSomthing(){
           obj.SayType();
       }

       public abstract void CreateSpecialGood();

        public void Show()
        {
            obj.SayType();
        }
    }
}
