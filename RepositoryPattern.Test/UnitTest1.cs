using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryPattern.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            for (int i = 0; i >= 10000000; i++)
            {
                var test = i + 1;
            }

            Assert.AreEqual(1, 1);
        }

    }
}
