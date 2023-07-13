namespace Ex33.test
{
    public class MyQueueTest
    {

        [Fact]
        public void AddWorks()
        {
            var ints = new MyQueue<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            Assert.Equal(1, ints.TakeALook());
        }

        [Fact]
        public void RemoveWorks() 
        {
            var ints = new MyQueue<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Remove();

            Assert.Equal(2, ints.TakeALook());
        }

        [Fact]
        public void RemoveThrowsError()
        {
            var ints = new MyQueue<int>();
            Assert.Throws<InvalidOperationException>(() => ints.Remove());
        }

        [Fact]
        public void TakeALookWorks()
        {
            var strings = new MyQueue<string>();
            strings.Add("Alice");
            strings.Add("Tim");

            Assert.Equal("Alice", strings.TakeALook());
        }

        [Fact]
        public void TakeALookThrowsError()
        {
            var strings = new MyQueue<string>();
            Assert.Throws<InvalidOperationException>(() => strings.TakeALook());

        }
    }
}