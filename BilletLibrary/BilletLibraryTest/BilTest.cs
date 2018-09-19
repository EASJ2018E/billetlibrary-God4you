using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTest
{
    [TestClass]
   public class BilTest
    {
        [TestMethod]
        public void TestPris() 
        {
            //Arrange
            Bil b = new Bil(); // opretter objekttet bil
            //Act
            decimal pris = b.Pris(); // metoden pris
            //Assert
            Assert.AreEqual(240, pris); //pris skal give 240 decimal kr.
        }
        [TestMethod]
        public void TestKøretøj()
        {
            //Arrange
            Bil b = new Bil(); // opretter objekttet bil
            //Act
            string kT = b.Køretøj(); // metoden string 
            //Assert
            Assert.AreEqual("Bil", kT); //stringen skal give det forventet resultat "Bil" af metoden kT
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerPlade()
        {
            Bil bilTest = new Bil();

            bilTest.Nummerplade = "AD12345678";

            
        }

        /// <summary>
        /// Test af Brobizz, *New* Method Brobiz() i BaseClass.cs
        /// </summary>
        [TestMethod]
        public void TestBrobizz()
        {
            //Arange
            Bil Lemmo = new Bil();
            //Act
            decimal pris = Lemmo.CalcBrobizz(Lemmo.Pris(), true);
            //Assert
            Assert.AreEqual(pris,228);
        }
    }
}
