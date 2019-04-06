using System;

namespace CreationPattern.ProtoType
{
    //C#中可以直接继承ICloneable来明确可拷贝
    public class ProtoType : ICloneable
    {
        public string id;   //虽然string是引用类型但是MemberwiseClone把他当成值类型特殊拷贝
        public Recipe recipe;
        public ProtoType(string a,Recipe b){
            id = a;
            recipe = b;
        }

        //第一种克隆，实现ICloneable，浅拷贝。
        public Object Clone()
        {
           //MemberwiseClone是针对值和引用的浅拷贝，创建的副本。如果是值类型修改副本不会影响原件，如果是引用类型修改副本也会修改原件
           return MemberwiseClone();
        }

        public ProtoType DeepClone(){
            //创建一个内容相同的独立对象
            ProtoType p = (ProtoType)MemberwiseClone();
            p.id = this.id;
            p.recipe = new Recipe(this.recipe.suager, this.recipe.milk);
            return p;
        }

        public void Show(){
            Console.WriteLine("id:{0}    注意比较",id);
            recipe.ShowProperty();
        }
    }
}