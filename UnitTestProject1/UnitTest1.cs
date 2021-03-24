using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new ConsoleApp3.Program();
            var stri = p.pakowanie(20, 2, 2);
            Assert.AreEqual(stri, "Summary weight: 8, summary value: 1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var p = new ConsoleApp3.Program();
            var stri = p.pakowanie(40, 3, 5);

            Assert.AreEqual(stri, "Summary weight: 32, summary value: 44");
        }
        [TestMethod]
        public void TestMethod3()
        {
            var p = new ConsoleApp3.Program();
            var stri = p.pakowanie(50, 100, 500);

            Assert.AreEqual(stri, "Summary weight: 47, summary value: 37");
        }

        [TestMethod]
        public void TestMethod4()
        {
            var p = new ConsoleApp3.Program();
            var stri = p.pakowanie(2, 200, 3);

            Assert.AreEqual(stri, "Summary weight: 0, summary value: 0");
        }


    }
}

