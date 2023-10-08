using System.Runtime.ConstrainedExecution;

namespace CoffeeShop
{
    internal class CoffeeShop
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extra = Console.ReadLine();
            double priceDrink = 0;
            double priceExtra = 0;

            if (drink == "coffee")
            {
                priceDrink = 1.00;
            }
            else if (drink == "tea")
                priceDrink = 0.60;
            if (extra == "sugar")
            {
                priceExtra = 0.40;
            }
            else
                priceExtra = 0;

            Console.WriteLine($"Final price: ${priceDrink + priceExtra:F2}");


        }
    }
}