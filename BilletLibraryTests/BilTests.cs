using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTestBil240()
        {
            //Arrange
            var bil = new Bil();
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            //Arrange
            var bil = new Bil();
            //Act
            string køretøj = bil.Køretøj();
            //Assert
            Assert.AreEqual("Bil",køretøj);
        }
    }
}