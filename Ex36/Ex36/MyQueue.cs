namespace Ex36
{
    // Cosa può essere cambiato?
    public interface IQueue<T>
    {
        void Add(T el);
        void Remove();
        T TakeALook();
    }
    public class MyQueue<T> : IQueue<T>
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
}