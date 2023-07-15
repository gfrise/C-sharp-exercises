namespace Ex38
{
    public interface IAdd<T>
    {
        void Add(T el);
    }

    public interface IRemove
    {
        void Remove();
    }

    public interface IPeek<T>
    {
        T TakeALook();
    }
    public interface IGet<T>
    {
        IEnumerable<T> Get();
    }
    public class MyQueue<T> : IAdd<T>, IRemove, IPeek<T>, IGet<T>
    {
        private readonly Queue<T> _queue;

        public MyQueue()
        {
            _queue = new Queue<T>();
        }

        public void Add(T el)
        {
            _queue.Enqueue(el);
        }

        public void Remove()
        {
            if (_queue.Count != 0)
            {
                _queue.Dequeue();

            }
            else
            {
                throw new InvalidOperationException("empty queue");
            }
        }

        public T TakeALook()
        {
            if (_queue.Count != 0)
            {
                return _queue.Peek();
            }
            else
            {
                throw new InvalidOperationException("empty queue");
            }
        }

        public IEnumerable<T> Get()
        {
            return _queue;
        }
    }

    public class IntQueue : MyQueue<int>
    {

    }

    public class StringQueue : MyQueue<string>
    {

    }
}