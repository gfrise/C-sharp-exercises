using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33
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
    }
}
