int budget = int.Parse(Console.ReadLine());
string season  = Console.ReadLine();
int fishermentCount = int.Parse(Console.ReadLine());

double price = 0;

if (season == "Spring")
{
    price = 3000;
    if (fishermentCount <= 6)
    {
        price *= 0.90;
    }
    else if (fishermentCount <= 11)
    {
        price *= 0.85;
    }
    else
    {
        price *= 0.75;
    }       
}
else if (season == "Winter")
{
    price = 2600;
    if (fishermentCount <= 6)
    {
        price *= 0.90;
    }
    else if (fishermentCount <= 11)
    {
        price *= 0.85;
    }
    else
    {
        price *= 0.75;
    }
}
else
{
    price = 4200;
    if (fishermentCount <= 6)
    {
        price *= 0.90;
    }
    else if (fishermentCount <= 11)
    {
        price *= 0.85;
    }
    else
    {
        price *= 0.75;
    }
}
if (season != "Autumn" && fishermentCount % 2 == 0)
    price *= 0.95;
if (budget >= price)
    Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");