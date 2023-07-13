namespace Ex34.Test
{
    public class MyQueueTest : IDisposable
    {
        private readonly MyQueue<int> _queue;
        private readonly MyQueue<string> _strings;

        public MyQueueTest()
        {
            _queue = new MyQueue<int>();
            _strings = new MyQueue<string>();
        }

        [Fact]
        public void AddWorks()
        {
            _queue.Add(1);
            _queue.Add(2);
            _queue.Add(3);

            Assert.Equal(1, _queue.TakeALook());
        }

        [Fact]
        public void RemoveWorks()
        {
            _queue.Add(1);
            _queue.Add(2);
            _queue.Remove();

            Assert.Equal(2, _queue.TakeALook());
        }

        [Fact]
        public void RemoveThrowsError()
        {
            Action test = () => _queue.Remove();
            Assert.Throws<InvalidOperationException>(test);
        }

        [Fact]
        public void TakeALookWorks()
        {
            _strings.Add("Alice");
            _strings.Add("Tim");

            Assert.Equal("Alice", _strings.TakeALook());
        }

        [Fact]
        public void TakeALookThrowsError()
        {
            Action test = () => _strings.TakeALook();
            Assert.Throws<InvalidOperationException>(test);
            
        }

        public void Dispose()
        {
        }
    }
}