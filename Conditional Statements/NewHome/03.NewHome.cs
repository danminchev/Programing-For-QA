
using System;

class Program
{
    static void Main()
    {
        string flowersType = Console.ReadLine();
        int flowersCount = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double flowersPrice = 0;

        if (flowersType == "Roses")
        {
            flowersPrice = 5.0;

            if (flowersCount > 80)
            {
                flowersPrice *= 0.90;
            }
        }
        else if (flowersType == "Dahlias")
        {
            flowersPrice = 3.80;
            if (flowersCount > 90)
            {
                flowersPrice *= 0.85;
            }
        }
        else if (flowersType == "Tulips")
        {
            flowersPrice = 2.80;
            if (flowersCount > 80)
            {
                flowersPrice *= 0.85;
            }
        }
        else if (flowersType == "Narcissus")
        {
            flowersPrice = 3.0;
            if (flowersCount < 120)
            {
                flowersPrice *= 1.15;
            }
        }
        else if (flowersType == "Gladiolus")
        {
            flowersPrice = 2.50;
            if (flowersCount < 80)
            {
                flowersPrice *= 1.20;
            }
        }
        double totalPrice = flowersCount * flowersPrice;
        if (budget >= totalPrice)
        {
            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {(budget - totalPrice):F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {(totalPrice - budget):F2} leva more.");
        }
    }
}



