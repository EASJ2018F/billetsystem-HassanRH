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
            //arange
            MC mc = new MC();

            //assert
            Assert.AreEqual(mc.Pris(), 125);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //arange
            MC mc = new MC();

            //assert
            Assert.AreEqual(mc.køretøj(), "MC");
        }

        [TestMethod]
        public void Brobizz()
        {
            //arrange
            MC mc = new MC();
            mc.Brobizz = true;

            //assert
            Assert.AreEqual(mc.Pris(), 95);
        }
    }
}
