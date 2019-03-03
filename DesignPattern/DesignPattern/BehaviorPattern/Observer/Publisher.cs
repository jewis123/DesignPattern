using System.Collections.Generic;

namespace BehaviorPattern.Observer
{
    public class Publisher
    {
        //不及时注销订阅者引用的话会发生“失效监听者”问题，即监听者本身已经不在了，但是因为没有注销引用，它就会僵死在内存中而不被回收，白白占据内存。极有可能导致内存泄漏
        protected IList<Subscriber> subscribers = new List<Subscriber>();

        //注册监听者
        public void Attach(Subscriber one) { 
            subscribers.Add(one);
        }

        //即时注销引用
        public void Remove(Subscriber one)  //面向抽象编程
        {
            subscribers.Remove(one);    
        }

        //状态改变后通知监听者
        public virtual void Notify() {
            foreach(var item in subscribers)
            {
                item.ChangeState();
            }
        }

        //删除发布者
        public void DeletePublisher()   
        {
            subscribers.Clear();    //释放引用，清理内存
        }
    }
}
