string product = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;

if (day == "Weekday")
{
    if (product == "Banana")
    {
        price = 2.50;
    }
}
else
{
    price = 2.70;
}

if (day == "Weekday")
{
    if (product == "Apple")
    {
        price = 1.30;
    }
}
else
{
    price = 1.60;
}

if (day == "Weekday")
{
    if (product == "Kiwi")
    {
        price = 2.20;
    }
}
else
{
    price = 3.00;
}


Console.WriteLine($"{price:f2}");
