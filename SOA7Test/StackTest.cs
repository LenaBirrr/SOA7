using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using SOA7;

namespace SOA7Test
{
    [TestClass]
    public class StackTest
    {
        Stack<int> stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<int>();
        }
        [TestMethod]
        public void PushWhenEmpty()
        {
            int q = 5;
            stack.Push(q);
            Assert.AreEqual(q, stack.Top.data);
        }
        [TestMethod]
        public void PushWhenNotEmpty()
        {
            int q = 6;
            stack.Push(5);
            stack.Push(q);
            Assert.AreEqual(q, stack.Top.data);
        }
        [TestMethod]
        public void PopWhenNotEmpty()
        {
            int q = 5;
            stack.Push(q);
            Assert.AreEqual(q,stack.Pop());
        }
        [TestMethod]
        [ExpectedException(typeof(StackException))]
        public void PopWhenEmpty()
        {
            stack.Pop();
        }
        [TestMethod]
        public void IsEmptyWhenEmpty()
        {
            int q = 5;
            stack.Push(q);
            Assert.IsFalse(stack.IsEmpty());
        }
        [TestMethod]
        public void IsEmptyWhenNotEmpty()
        {           
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}