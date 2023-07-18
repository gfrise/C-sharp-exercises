namespace Ex39
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
    public interface ILogger
    {
        public void Log(string msg);
    }
    public class MyQueue<T> : IAdd<T>, IRemove, IPeek<T>, IGet<T>
    {
        private readonly Queue<T> _queue;
        private readonly ILogger _logger;

        public MyQueue(ILogger logger)
        {
            _queue = new Queue<T>();
            _logger = logger;
        }

        public void Add(T el)
        {
            _queue.Enqueue(el);
            //  Console.WriteLine($"{el} added");
            _logger.Log($"{el} added");
        }

        public void Remove()
        {
            if (_queue.Count != 0)
            {
                var x = _queue.Dequeue();
                //  Console.WriteLine($"{x} removed");
                _logger.Log($"{x} removed");

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
                var x = _queue.Peek();
                // Console.WriteLine($"{x} peeked");
                _logger.Log($"{x} peeked");

                return x;
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
        public IntQueue(ILogger logger) : base(logger)
        {
        }
    }

    public class StringQueue : MyQueue<string>
    {
        public StringQueue(ILogger logger) : base(logger)
        {
        }
    }

    public class ConsoleLog: ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}