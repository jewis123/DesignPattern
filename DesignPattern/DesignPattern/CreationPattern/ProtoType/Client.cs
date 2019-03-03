using System;

namespace CreationPattern.ProtoType
{
    public class Client
    {
        public void Do()
        {
            Recipe recipe = new Recipe("sugar","milk");
            ProtoType proto = new ProtoType("001",recipe);
            proto.Show();

            Console.WriteLine("执行浅拷贝");
            ProtoType p = (ProtoType)proto.Clone();
            p.id = "002";
            p.recipe.ChangeRecipe("sugar2","milk2");
            Console.WriteLine("浅拷贝后原件：");
            proto.Show();
            Console.WriteLine("浅拷贝后副本：");
            p.Show();
            Console.WriteLine("执行深拷贝");
            ProtoType q = (ProtoType)proto.DeepClone();
            q.id = "003";
            q.recipe.ChangeRecipe("sugar3","milk3");
            Console.WriteLine("深拷贝后原件：");
            proto.Show();
            Console.WriteLine("深拷贝后副本：");
            q.Show();
        }
    }
}