int n = int.Parse(Console.ReadLine());

bool foundMagicNumber = false;

for (int number = 1; number <= n; number++)
{
    int currentNumber = number;
    int sumOfDigits = 0;
    bool isMagic = true;

    while (currentNumber > 0)
    {
        int digit = currentNumber % 10;

        if (digit != 2 && digit != 3 && digit != 5 && digit != 7)
        {
            isMagic = false;
            break;  
        }

        sumOfDigits += digit;
        currentNumber /= 10;
    }

    if (isMagic && sumOfDigits % 2 == 0)
    {
        Console.Write(number + " ");
        foundMagicNumber = true;
    }
}

if (!foundMagicNumber)
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine();
}
