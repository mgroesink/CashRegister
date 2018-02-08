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
            CashRegister k = new CashRegister(1000);
            int b500, b200, b100, b50, b20, b10, b5;
            int e2, e1;
            int ec50, ec20, ec10, ec5, ec2, ec1;

                decimal wisselgeld = k.Cashback(9.98m, 10, out b500, out b200, out b100, out b50, out b20, out b10, out b5,
                     out ec50, out ec20, out ec10, out ec5, out ec2, out ec1, out e2, out e1, true);

            Assert.AreEqual(wisselgeld, 0m);

            decimal wisselgeld2 = k.Cashback(9.96m, 10, out b500, out b200, out b100, out b50, out b20, out b10, out b5,
                out ec50, out ec20, out ec10, out ec5, out ec2, out ec1, out e2, out e1, true);

            Assert.AreEqual(wisselgeld2, 0.05m);

            decimal wisselgeld3 = k.Cashback(9.92m, 10, out b500, out b200, out b100, out b50, out b20, out b10, out b5,
                out ec50, out ec20, out ec10, out ec5, out ec2, out ec1, out e2, out e1, true);

            Assert.AreEqual(wisselgeld3, 0.1m);

            decimal wisselgeld4 = k.Cashback(9.93m, 10, out b500, out b200, out b100, out b50, out b20, out b10, out b5,
                out ec50, out ec20, out ec10, out ec5, out ec2, out ec1, out e2, out e1, true);

            Assert.AreEqual(wisselgeld4, 0.05m);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void NotEnoughPaidTest()
        {
            CashRegister k = new CashRegister(1000);
            int b500, b200, b100, b50, b20, b10, b5;
            int e2, e1;
            int ec50, ec20, ec10, ec5, ec2, ec1;

            decimal wisselgeld = k.Cashback(9.98m, 5, out b500, out b200, out b100, out b50, out b20, out b10, out b5,
                 out ec50, out ec20, out ec10, out ec5, out ec2, out ec1, out e2, out e1, true);
        }
    }
}