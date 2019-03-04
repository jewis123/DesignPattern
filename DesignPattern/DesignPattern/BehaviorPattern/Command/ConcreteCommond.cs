using System;

namespace BehaviorPattern.CommandPattern
{
    class ConcreteCommond : Commond
    {
        public ConcreteCommond(Solider reciever) : base(reciever) { }
        public override void Excute()
        {
            reciever.Shoot("士兵执行命令A。");
        }
    }

    class ConcreteCommondB : Commond
    {
        public ConcreteCommondB(Solider reciever) : base(reciever) { }
        public override void Excute()
        {
            reciever.Walk("士兵执行命令B。");
        }
    }

    class ConcreteCommondC : Commond
    {
        public ConcreteCommondC(Solider reciever) : base(reciever) { }
        public override void Excute()
        {
            reciever.Fight("士兵执行命令C。");
        }
    }
}
