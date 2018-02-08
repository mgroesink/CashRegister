using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaApp
{
    public class Program
    {
        public static void Main()
        {
            CashRegister k = new CashRegister();

            Console.Write("Te betalen bedrag: ");
            decimal tebetalen = Decimal.Parse(Console.ReadLine());

            Console.Write("Betaald: ");
            decimal betaald = Decimal.Parse(Console.ReadLine());

            try
            {
                decimal wisselgeld = k.Cashback(tebetalen, betaald);

                Console.WriteLine("Wisselgeld: " + wisselgeld + " euro");
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                ConsoleColor oldColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.BackgroundColor = oldColor;
                Console.WriteLine();
            }
            finally
            {
                Console.Write("Press any key to close the app");
                Console.ReadKey();

            }
        }
    }

}
