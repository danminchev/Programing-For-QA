static int GetSumOfEvenDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 == 0)
        {
            sum += digit;
        }
    }
    return sum;
}
static int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 != 0)
        {
            sum += digit;
        }
    }
    return sum;
}
static int GetMultipleOfEvenAndOdds(int number)
{
    int evenDigit = GetSumOfEvenDigits(number);
    int oddDigit = GetSumOfOddDigits(number);

    int sumEvenAndOdd = evenDigit * oddDigit;

    return sumEvenAndOdd;
}

int num = int.Parse(Console.ReadLine());

int absoluteNum = Math.Abs(num);

int multipliesSum = GetMultipleOfEvenAndOdds(absoluteNum);

Console.WriteLine(multipliesSum);




