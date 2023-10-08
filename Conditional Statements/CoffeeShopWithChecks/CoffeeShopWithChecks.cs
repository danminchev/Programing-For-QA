using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace CoffeeShopWithChecks
{
    internal class CoffeeShopWithChecks
    {
        static void Main(string[] args)
        {
           
            string order = Console.ReadLine();
            double priceDrink = 0;
            double priceExtra = 0;

            if (order == "coffee")
            {
                priceDrink = 1.00;
            }
            else if (order == "tea")
            {
                priceDrink = 0.60;
            }
            else
            {
                Console.WriteLine("Unknown drink");
                return; // Излизаме от програмата след изписването на съобщението
            }

            string extra = Console.ReadLine();

            if (extra == "sugar")
            {
                priceExtra = 0.40;
            }
            else if (extra == "no")
            {
                priceExtra = 0;
            }
            else
            {
                Console.WriteLine("Unknown extra");
                return; // Излизаме от програмата след изписването на съобщението
            }

            double finalPrice = priceDrink + priceExtra;
            Console.WriteLine($"Final price: ${finalPrice:f2}");

        }
    }
}