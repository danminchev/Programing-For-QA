static int CalculateFactorials(int number)
{
    int result = 1;

    while (number > 0)
    {
        result = result * number;
        number -= 1;
    }

    return result;
}

int number = int.Parse(Console.ReadLine());

int totalResult = 0;

while (number != 0)
{
    int digit = number % 10;

    if (digit % 2 == 0)
    {
        int resultFactorial = CalculateFactorials(digit);
        totalResult += resultFactorial;
    }
    number = number / 10;
}
Console.WriteLine(totalResult);




