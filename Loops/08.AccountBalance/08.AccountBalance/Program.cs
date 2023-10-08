using System;

class Program
{
    static void Main()
    {
        double balance = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            double amount = double.Parse(input);
            balance += amount;

            if (amount > 0)
            {
                Console.WriteLine($"Increase: {amount:f2}");
            }
            else if (amount < 0)
            {
                Console.WriteLine($"Decrease: {Math.Abs(amount):f2}");
            }
        }

        Console.WriteLine($"Balance: {balance:f2}");
    }
}










