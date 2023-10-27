using System.Threading.Channels;

namespace _7.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int coins = 0;

            while (amount > 0)
            {

                switch (amount)
                {
                    case >= 2.00: amount -= 2.00; break;
                    case >= 1.00: amount -= 1.00; break;
                    case >= 0.50: amount -= 0.50; break;
                    case >= 0.20: amount -= 0.20; break;
                    case >= 0.10: amount -= 0.10; break;
                    case >= 0.05: amount -= 0.05; break;
                    case >= 0.02: amount -= 0.02; break;
                    default: amount -= 0.01; break;
                }
                coins++;
                amount = Math.Round(amount, 2);

            }
            Console.WriteLine(coins);
        }
    }
}