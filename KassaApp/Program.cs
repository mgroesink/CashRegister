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
            CashRegister k = new CashRegister(950.85m);
            int[] cash = { 0 , 0, 0, 4, 8, 12, 10, 25, 20, 8, 8, 12, 5, 0 ,0};
            try
            {
                CashRegister k2 = new CashRegister(cash);
                Console.WriteLine("Beginstand kassa: {0:0.00} euro", k2.CashInRegister);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Kassa niet correct gevuld");
            }

            Console.Write("Te betalen bedrag: ");
            decimal tebetalen = Decimal.Parse(Console.ReadLine());

            Console.Write("Betaald: ");
            decimal betaald = Decimal.Parse(Console.ReadLine());

            int b500 , b200 , b100, b50, b20 , b10, b5;
            int e2, e1;
            int ec50, ec20, ec10, ec5, ec2, ec1;
            try
            {
                decimal wisselgeld = k.Cashback(tebetalen, betaald, out b500, out b200, out b100, out b50, out b20, out b10, out b5,
                     out ec50, out ec20, out ec10, out ec5, out ec2, out ec1, out e2, out e1, true);

                Console.WriteLine("Wisselgeld: " + wisselgeld + " euro");
                Console.WriteLine("_".PadRight(50));
                Console.WriteLine("200 Euro: " + b200);
                Console.WriteLine("100 Euro: " + b100);
                Console.WriteLine("50 Euro: " + b50);
                Console.WriteLine("20 Euro: " + b20);
                Console.WriteLine("10 Euro: " + b100);
                Console.WriteLine("5 Euro: " + b5);
                Console.WriteLine("2 Euro: " + e2);
                Console.WriteLine("1 Euro: " + e1);
                Console.WriteLine("50 Eurocent : " + ec50);
                Console.WriteLine("20 Eurocent : " + ec20);
                Console.WriteLine("10 Eurocent : " + ec10);
                Console.WriteLine("5 Eurocent : " + ec5);
                Console.WriteLine("2 Eurocent : " + ec2);
                Console.WriteLine("1 Eurocent : " + ec1);
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
