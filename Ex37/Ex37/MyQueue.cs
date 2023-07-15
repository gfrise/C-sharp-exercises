namespace Ex37
{
    public class MyQueue<T>
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