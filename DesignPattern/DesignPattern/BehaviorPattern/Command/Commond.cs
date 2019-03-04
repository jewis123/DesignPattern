using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.CommandPattern
{
    abstract class Commond
    {
        protected Solider reciever;     //命令的执行对象
        public abstract void Excute();
        public Commond(Solider reciever)
        {
            this.reciever = reciever;
        }
    }
}
