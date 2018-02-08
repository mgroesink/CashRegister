using Microsoft.VisualStudio.TestTools.UnitTesting;
using KassaApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaApp.Tests
{
    [TestClass()]
    public class CashRegisterTests
    {
        [TestMethod()]
        public void CashbackTest()
        {
            CashRegister k = new CashRegister();

            decimal wisselgeld = k.Cashback(9.98m, 10);
            Assert.AreEqual(wisselgeld, 0m);

            decimal wisselgeld2 = k.Cashback(9.96m, 10);
            Assert.AreEqual(wisselgeld2, 0.05m);

            decimal wisselgeld3 = k.Cashback(9.92m, 10);
            Assert.AreEqual(wisselgeld3, 0.1m);

            decimal wisselgeld4 = k.Cashback(9.93m, 10);
            Assert.AreEqual(wisselgeld4, 0.05m);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void NotEnoughPaidTest()
        {
            CashRegister k = new CashRegister();
            decimal wisselgeld = k.Cashback(9.98m, 5);
        }
    }
}