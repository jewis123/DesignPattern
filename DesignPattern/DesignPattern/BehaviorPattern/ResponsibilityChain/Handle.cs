namespace BehaviorPattern.ResponsibilityChain
{
    public abstract class Handle
    {
        protected Handle nextHandle;
        public Handle(Handle handle) {
            nextHandle = handle;
        }
        public void SetSuccessor(Handle handle = null)
        {
            nextHandle = handle;
        }
        public abstract void HandleRequest(Request request);
    }
}
