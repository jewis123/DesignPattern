namespace CreationPattern.Singleton
{
    public class Singleton
    {

        //懒汉式-线程不安全
        // 静态变量 instance 被延迟实例化，这样做的好处是，如果没有用到该类，那么就不会实例化 instance

        // 这个实现在多线程环境下是不安全的，如果多个线程能够同时进入 if (instance == null) ，
        // 并且此时 instance 为 null，那么会有多个线程执行 instance = new Singleton(); 语句，这将导致实例化多次 instance
        // private static Singleton instance;

        // public static Singleton GetInstance(){
        //     if(instance == null){
        //         instance = new Singleton();
        //     }
        //     return instance;
        // }


        //饿汉式-线程安全
        //线程不安全问题主要是由于 uniqueInstance 被实例化多次，采取直接实例化 uniqueInstance 的方式就不会产生线程不安全问题。
        // 但是直接实例化的方式也丢失了延迟实例化带来的节约资源的好处。

        // public static Singleton instance = new Singleton();

        //双重校验锁
        private static Singleton instance;
        private static object _lock=new object();
        public static  Singleton GetInstance()
        {
            if (instance == null)
            {
                lock(_lock)
                      {
                             if(instance==null)
                             {
                                     instance=new Singleton();
                             }
                      }
            }
            return instance;
        }

    }
}