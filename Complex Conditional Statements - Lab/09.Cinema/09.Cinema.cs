string typeMovie = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double price = 0;
double totalPrice = 0;
if (typeMovie == "Premiere")
{
    price = 12.00;
}
else if (typeMovie == "Normal")
{
    price = 7.50;
}
else
    price = 5.00;
totalPrice = price * rows * seats;
Console.WriteLine($"{totalPrice:f2}");
