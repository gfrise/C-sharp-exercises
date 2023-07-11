var intStack = new MyQueue<int>();
intStack.Add(1);
intStack.Add(2);
intStack.Add(3);
intStack.Remove();

var stringStack = new MyQueue<string>();
stringStack.Add("Bob");
stringStack.Add("Alice");
stringStack.Add("Tim");
stringStack.Remove();

class MyQueue<T>
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

        } else
        {
            throw new InvalidOperationException("empty queue");
        }
    }

    public T TakeALook()
    {
        if (_queue.Count != 0)
        {
            return _queue.Peek();
        } else
        {
            throw new InvalidOperationException("empty queue");
        }
    }
}
