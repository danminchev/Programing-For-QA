namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double moneyNeeded = double.Parse(Console.ReadLine());
           double moneyAvailable = double.Parse(Console.ReadLine());
           int daysCounter = 0;
           int spendingCounter = 0;

            while (moneyNeeded > moneyAvailable && spendingCounter < 5) 
            { 
                daysCounter++;
                string type = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());   

                if (type == "spend")
                {
                    moneyAvailable -= amount;
                    if (moneyAvailable < 0)
                        moneyAvailable = 0;
                    spendingCounter++;
                }
                else
                {
                    moneyAvailable += amount;
                    spendingCounter = 0;
                } 
                if (spendingCounter >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCounter}");
                }
                else if (moneyNeeded <= moneyAvailable)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                }
            }
        }
    }
}