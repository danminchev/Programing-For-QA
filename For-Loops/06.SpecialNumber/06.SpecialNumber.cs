int number = int.Parse(Console.ReadLine());


while (true)
{
    int lastDigit = number % 10;

    if (number % lastDigit == 0)
    {
       
       Console.WriteLine($"{number} is special");

    }
    else
    {
        Console.WriteLine($"{number} is special not special");

    }
    number /= 10;
    number++;
}
