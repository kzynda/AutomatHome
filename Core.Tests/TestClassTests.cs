using NUnit.Framework;

namespace Core.Tests
{
    public class TestClassTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            TestClass tc = new TestClass();

            var actual = tc.Add(1, 4);
            var expected = 5;
            
            Assert.AreEqual(expected, actual);
        }
    }
}