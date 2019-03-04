using System;

namespace BehaviorPattern.StatePattern
{
    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            //处理事务
            Console.WriteLine("状态A处理，并转变状态");
            //设置ConcreteStateA的下一个状态,,由于只有两个状态，就相相互转变把
            context.State = new ConcreteStateB();
        }
    }


    class ConcreteStateB : State
    {
        //每一个具体状态必须完成两个职责： 本状态的行为管理以及趋向状态处理， 通俗地说就是本状态下要做的事情， 以及本状态如何过渡到其他状态。
        public override void Handle(Context context)
        {
            //处理事务
            Console.WriteLine("状态B处理，并转变状态");
            //设置ConcreteStateB的下一个状态
            context.State = new ConcreteStateA();
        }
    }
}
