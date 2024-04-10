namespace ThrowsNullReferenceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var app = new Application() { MainPage = new Page() };
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}