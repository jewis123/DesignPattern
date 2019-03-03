using System;

namespace CreationPattern.ProtoType
{
    public class Recipe:ICloneable
    {
        public string suager;
        public string milk;

        public Recipe(string suager,string milk)
        {
            this.suager = suager;
            this.milk = milk;
        }

        public void ChangeRecipe(string a,string b){
            suager  =a;
            milk = b;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShowProperty()
        {
            Console.WriteLine("My property is {0},{1}", suager,milk);
        }
    }
}