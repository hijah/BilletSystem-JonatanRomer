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
    public class KøretøjerTests
    {
        [TestMethod()]
        public void nummerpladeTestForMangeBogstaver7()
        {
            //Arrange
            var bil = new Bil();
            //Act
            bil.Nummerplade = "ABCDEFG";
            bil.nummerpladeLimit();
        }

        [TestMethod()]
        public void nummerpladeTestForMangeBogstaver8()
        {
            //Arrange
            var bil = new Bil();
            //Act
            bil.Nummerplade = "ABCDEFGH";
            bil.nummerpladeLimit();
        }
    }
}