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
        /// <summary>
        /// Calculates the cashback.
        /// </summary>
        /// <param name="topay">The money to pay.</param>
        /// <param name="paid">The amount of money payed.</param>
        /// <param name="round">if set to <c>true</c> [round].</param>
        /// <returns></returns>
        public decimal Cashback(decimal topay, decimal paid)
        {


            // Round the amount to pay to 5 cents
            topay = Math.Round(topay * 20) / 20;


            // Calculate the cashback
            decimal retour = paid - topay;

            if(retour < 0)
            {
                throw new ArgumentException("NotEnoughPaid");
            }

            return retour;
        }


    }
}
