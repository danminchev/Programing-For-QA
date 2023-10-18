static double CalculatePrice(string product, int guantity)
{
    double price = 0;
    if (product == "coffee")
    {
        price = guantity * 1.50;
    }
    else if (product == "water")
    {
        price = guantity * 1.00;
    }
    else if (product == "coke")
    {
        price = guantity * 1.40;
    }
    else if (product == "snacks")
    {
        price = guantity * 2.00;
    }

    return price;
}

string product = Console.ReadLine();
int guantity = int.Parse(Console.ReadLine());

double price = CalculatePrice(product, guantity);

Console.WriteLine($"{price:F2}");

