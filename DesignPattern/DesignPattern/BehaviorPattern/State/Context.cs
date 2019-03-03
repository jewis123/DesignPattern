using System;


namespace BehaviorPattern.StatePattern
{
    class Context
    {
        State state;
        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("当前状态：{0}\n", state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);  //对请求做处理，并设置下一状态。
        }
    }
}
