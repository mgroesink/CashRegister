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
        public string Cashback(decimal topay, decimal paid)
        {

            decimal[] eenheden = { 500 , 200 , 100 , 50 , 20 , 10 , 5 , 2 , 1 , 0.5m , 0.2m , 0.1m , 0.05m};
            // Round the amount to pay to 5 cents
            topay = Math.Round(topay * 20) / 20;


            // Calculate the cashback
            int retour = (int)((paid - topay) * 100) ;

            if(retour < 0)
            {
                throw new ArgumentException("NotEnoughPaid");
            }

            string wisselgeld = "Wisselgeld:\n";
            foreach(var e in eenheden)
            {
                int value = (int)(e * 100);
                wisselgeld += string.Format("{0} x euro {1} \n" , (retour) / value , e);
                retour %= value;

            }
            return wisselgeld;
        }


    }
}
