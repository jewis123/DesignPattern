using System;

namespace CreationPattern.ProtoType
{
    //C#中可以直接继承ICloneable来明确可拷贝
    public class ProtoType : ICloneable
    {
        public string id;   //虽然string是引用类型但是MemberwiseClone把他当成值类型特殊拷贝，即实现深拷贝
        public Recipe recipe;
        public ProtoType(string a,Recipe b){
            id = a;
            recipe = b;
        }

        public Object Clone()
        {
           //MemberwiseClone是针对值和引用的浅拷贝，创建的副本。如果是值类型修改副本不会影响原件，如果是引用类型修改副本也会修改原件
           return MemberwiseClone();
        }

        public ProtoType DeepClone(){
            //创建一个内用相同的独立对象
            ProtoType p = (ProtoType)MemberwiseClone();
            p.id = this.id;
            p.recipe = new Recipe(this.recipe.suager, this.recipe.milk);
            return p;
        }

        public Object DeepClone2()
        {
            //如果想直接通过MemberwiseClone执行深拷贝，就要使引用类型也继承自ICloneable
            return MemberwiseClone();
        }

        public void Show(){
            Console.WriteLine("id:{0}    注意比较",id);
            recipe.ShowProperty();
        }
    }
}