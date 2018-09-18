using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTest
{
    [TestClass]
    public class McTest
    {
        [TestMethod]
        public void TestPris()
        {
            //Arrange
            MC m = new MC();// opretter objekttet bil
            //Act
            decimal p = m.Pris(); // metoden pris
            //Assert
            Assert.AreEqual(125, p);//pris skal give 125 decimal kr.
        }
        [TestMethod]
        public void TestKøretøj()
        {
            //Arrange
             MC mc = new MC();// opretter objekttet MC
            //Act
            string m = mc.Køretøj(); // metoden string 
            //Assert
            Assert.AreEqual("MC", m);//stringen skal give det forventet resultat "MC" af metoden kT
        }
    }
}
