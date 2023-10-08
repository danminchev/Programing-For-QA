int dayToStay = int.Parse(Console.ReadLine());
string typeOfRoom = Console.ReadLine();
string assessment = Console.ReadLine();

double priceNight = 0;

if (typeOfRoom == "apartment")
{
    priceNight = 155;
    if (dayToStay < 10)
    {
        priceNight *= 0.70;
    }
    else if (dayToStay >= 10 && dayToStay <= 15)
    {
        priceNight *= 0.65;
    }
    else
    {
        priceNight *= 0.50;
    }
}
else if (typeOfRoom == "president apartment")
{
    priceNight = 235;
    if (dayToStay < 10)
    {
        priceNight *= 0.90;
    }
    else if (dayToStay >= 10 && dayToStay <= 15)
    {
        priceNight *= 0.85;
    }
    else
    {
        priceNight *= 0.80;
    }
}
else
{
    priceNight = 118.0;
}
double totalPrice = (dayToStay - 1) * priceNight;
if (assessment == "positive")
{
    totalPrice *= 1.25;
}
else
{
    totalPrice *= 0.9;
}
Console.WriteLine($"{totalPrice:f2}");

