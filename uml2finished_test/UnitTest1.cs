using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace uml2finished.test
{
    [TestClass]
    public class UnitTest1
    {
        private int depthCounter = 0;

        private void AddDepth(Random rand, Order target, int amount, int depth)
        {
            if (depth == 0)
                return;
            for (int i = 0; i < amount; i++)
            {
                var order = new Order(
                    rand.Next(0, 100),
                    rand.Next(0, 50) / 100.0,
                    depthCounter++,
                    rand.Next().ToString(),
                    rand.Next(0, 0xFFFF),
                    rand.Next().ToString(),
                    rand.Next().ToString());
                order._ItemsOrdered.Add(order._No, order);
                AddDepth(rand, order, amount, --depth);
            }
        }

        public List<Order> GenerateRandomSet(int depth, int amount)
        {
            var rand = new Random();
            List<Order> orders = new List<Order>();
            for(int i = 0; i < amount; i++)
            {
                var order = new Order(
                    rand.Next(0, 100),
                    rand.Next(0, 50) / 100.0,
                    rand.Next(),
                    rand.Next().ToString(),
                    rand.Next(0, 0xFFFF),
                    rand.Next().ToString(),
                    rand.Next().ToString());
                orders.Add(order);
                AddDepth(rand, order, amount, depth);
            }
            return orders;
        }

        [TestMethod]
        public void TestOurFunnyStuff()
        {
            Assert.IsTrue("".StartsWith(""));
            Assert.IsTrue("Hello".StartsWith(""));
        }

        [TestMethod]
        public void TestCanWeCreateOrders()
        {
            var orders = GenerateRandomSet(10, 512);
            Assert.IsTrue(true);
        }
    }
}
