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
            var capacity = 10;
            var n = 3;
            var seed = 2;
            var stri = p.pakowanie(20, 2, 2);
            Assert.AreEqual(stri, "Summary weight: 8, summary value: 1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var n = 1;
            var b = 2;
            Assert.AreEqual(n, b);
        }
        //textbox1.Text = "2"


    }
}

