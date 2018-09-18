using System;
using System.ComponentModel;
using BilletLibrary;
using Microsoft.Extensions.DependencyModel.Resolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestPrisBil()
        {
            Bil bil = new Bil();

            decimal resultat = bil.Pris(false);

            Assert.AreEqual(240, resultat);

        }

        [TestMethod]
        public void TestKøretøjBil()
        {
            Bil bil = new Bil();

            string resultat = bil.Køretøjet();

            Assert.AreEqual("Bil", resultat);



        }

        [TestMethod]
        public void TestPrisMC()
        {
            MC mc = new MC();

            decimal resultat = mc.Pris(false);

            Assert.AreEqual(125, resultat);

        }

        [TestMethod]
        public void TestKøretøjMC()
        {
            MC mc = new MC();

            string resultat = mc.Køretøjet();

            Assert.AreEqual("MC", resultat);



        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SortKaffeTest3()
        {
            Bil bil = new Bil();
            string nummerplade = bil.NummerPlade = "12345678";

            Assert.Fail();
        }

        [TestMethod]
        public void TestBrobizz()
        {
            MC mc = new MC();

            decimal pris = mc.Pris(true);
            decimal exp = (125m / 100m) * 95m;

            Assert.AreEqual(pris, exp);

        }

        [TestMethod]
        public void TestBrobizz2()
        {
            Bil bil = new Bil();

            decimal pris = bil.Pris(true);
            decimal exp = (240m / 100m) * 95m;

            Assert.AreEqual(pris, exp);

        }
    }
}
