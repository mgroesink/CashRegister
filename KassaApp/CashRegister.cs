using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaApp
{

    /// <summary>
    /// A cash register
    /// </summary>
    public class CashRegister
    {
        public decimal Balance { get; private set; }
        private int[] cash = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        /// <summary>
        /// Initializes a new instance of the <see cref="CashRegister"/> class.
        /// </summary>
        /// <param name="startBalance">The beginsaldo.</param>
        public CashRegister(decimal startBalance)
        {
            this.Balance = startBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CashRegister"/> class.
        /// </summary>
        /// <param name="begin">The starting number of banknotes and coins in cash.</param>
        /// <exception cref="ArgumentException">Array should have 15 values</exception>
        public CashRegister(int[] begin)
        {
            if(begin.Length == 15)
            {
                cash = begin;
            }
            else
            {
                throw new ArgumentException("Array should have 15 values");
            }
        }

        /// <summary>
        /// Calculates the cash in register.
        /// </summary>
        /// <value>
        /// The cash in register.
        /// </value>
        public decimal CashInRegister
        {
            get

            {
                return 500 * cash[0] + 200 * cash[1] + 100 * cash[2] + 50 * cash[3] + 20 * cash[4] + 10 * cash[5] + 5 * cash[6] + 2 * cash[7] +
                    cash[8] + .5m * cash[9] + .2m * cash[10] + .1m * cash[11] + .05m * cash[12] + .02m * cash[13] + .01m * cash[14];
            }
        }

        /// <summary>
        /// Calculates the cashback.
        /// </summary>
        /// <param name="topay">The money to pay.</param>
        /// <param name="paid">The amount of money payed.</param>
        /// <param name="round">if set to <c>true</c> [round].</param>
        /// <returns></returns>
        //public decimal Cashback(decimal topay, decimal paid, bool round = false)
        //{

        //    // Check if the amount to pay has to be rounded
        //    if (round)
        //    {
        //        // Round the amount to pay to 5 cents
        //        topay = Math.Round(topay * 20) / 20;
        //    }

        //    // Calculate the cashback
        //    decimal retour = paid - topay;
        //    // Calculate the new balance
        //    this.Balance += topay;

        //    return retour;
        //}

        /// <summary>
        /// Cashbacks the specified topay.
        /// </summary>
        /// <param name="topay">The money to pay.</param>
        /// <param name="paid">The money paid.</param>
        /// <param name="b500">Number of 500 euro banknotes to return.</param>
        /// <param name="b200">Number of 200 euro banknotes to return.</param>
        /// <param name="b100">Number of 100 euro banknotes to return.</param>
        /// <param name="b50">Number of 50 euro banknotes to return.</param>
        /// <param name="b20">Number of 20 euro banknotes to return.</param>
        /// <param name="b10">Number of 10 euro banknotes to return.</param>
        /// <param name="b5">Number of 5 euro banknotes.</param>
        /// <param name="ec50">The number of 50 cent coins to return.</param>
        /// <param name="ec20">The number of 50 cent coins to return.</param>
        /// <param name="ec10">The number of 50 cent coins to return.</param>
        /// <param name="ec5">The number of 50 cent coins to return.</param>
        /// <param name="ec2">The number of 50 cent coins to return.</param>
        /// <param name="ec1">The number of 50 cent coins to return.</param>
        /// <param name="e2">The number of 2 euro coins to return.</param>
        /// <param name="e1">The number of 1 euro coins to return.</param>
        /// <param name="round">if set to <c>true</c> [round].</param>
        /// <returns></returns>
        public decimal Cashback(decimal topay , decimal paid ,out int b500 , out int b200, out int b100, out int b50, out int b20, out int b10,
            out int b5, out int ec50, out int ec20 , out int ec10, out int ec5, out int ec2, out int ec1 , out int e2, out int e1, bool round = false)
        {
            // Check if the amount to pay has to be rounded
            if (round)
            {
                // Round the amount to pay to 5 cents
                topay = Math.Round(topay * 20) / 20;
            }
            if(topay > paid)
            {
                throw new ArgumentException("Klant heeft te weing betaald");

            }

            // Calculate the cashback
            int retour = (int)((paid - topay) * 100);
            b500 = retour / 50000;
            int restant = retour % 50000;
            b200 = retour / 25000;
            restant = retour % 25000;
            b100 = restant / 10000;
            restant = restant % 10000;
            b50 = restant / 5000;
            restant %= 5000;
            b20 = restant / 2000;
            restant %= 2000;
            b10 = restant / 1000;
            restant %= 1000;
            b5 = restant / 500;
            restant %= 500;
            e2 = restant / 200;
            restant %= 200;
            e1 = restant / 100;
            restant %= 100;
            ec50 = restant / 50;
            restant %= 50;
            ec20 = restant / 20;
            restant %= 20;
            ec10 = restant / 10;
            restant %= 10;
            ec5 = restant / 5;
            restant %= 5;
            ec2 = restant / 2;
            restant %= 2;
            ec1 = restant;
            return paid - topay;
        }

    }
}
