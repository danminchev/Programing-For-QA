string season = Console.ReadLine();
string accommodation = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double total = 0;
double priceForDay = 0;

if (season == "Spring")
{
    if (accommodation == "Hotel")
    {
        priceForDay = 30 - (30 * 0.2);
        total = days * priceForDay;
    }
    else
    {
        priceForDay = 10 - (10 * 0.2);
        total = days * priceForDay;
    }
       
}
else if (season == "Summer")
{
    if (accommodation == "Hotel")
    {
        total = days * 50.0;
    }
    else
        total = days * 30.0;
}
else if (season == "Autumn")
{
    if (accommodation == "Hotel")
    {
        priceForDay = 20 - (20 * 0.3);
        total = days * priceForDay;
    }
    else
    {
        priceForDay = 15 - (15 * 0.3);
        total = days * priceForDay;
    }
}
else
{
    if (accommodation == "Hotel")
    {
        priceForDay = 40 - (40 * 0.1);
        total = days * priceForDay;
    }
    else
    {
        priceForDay = 10 - (10 * 0.1);
        total = days * priceForDay;
    }       
}
Console.WriteLine($"{total:f2}");

