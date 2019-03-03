namespace BehaviorPattern.StatePattern
{
    abstract class State
    {
        //接口或抽象类， 负责对象状态定义， 并且封装环境角色以实现状态切换。
        public abstract void Handle(Context context);
    }
}
