using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib.BilletLib;

namespace UnitTestProject1
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void Bil_Pris()
        {
            //arange
            Bil bil= new Bil();

            //assert
            Assert.AreEqual(bil.Pris(),240);
        }
        [TestMethod]
        public void Køretøj()
        {
            //arrange
            Bil bil = new Bil();
            
            //assert
            Assert.AreEqual(bil.køretøj(), "Bil");
        }


    }
}
