using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.CommandPattern
{
    class Master
    {
        List<Commond> commonds = new List<Commond>(); //存放命令的容器，可以根据业务需求使用栈或队列

        //添加命令
        public void AddCommond(Commond commond)
        {
            commonds.Add(commond);
        }

        //撤销命令
        public void RemoveCommond()
        {
            commonds.RemoveAt(commonds.Count-1);
        }

        //执行所有命令
        public void CallToExcute()
        {
            foreach(var item in commonds)
            {
                item.Excute();
            }
        }
    }
}
