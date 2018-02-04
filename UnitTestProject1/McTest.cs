using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibb;

namespace UnitTestProject1
{
    [TestClass]
    public class McTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MC mc = new MC();

            //assert
            Assert.AreEqual(mc.Pris(), 125);
        }
        [TestMethod]
        public void TestMethod2()
        {

            MC mc = new MC();

            //assert
            Assert.AreEqual(mc.Køretøj(), "MC");
        }
    }
}
