int numbersCount = int.Parse(Console.ReadLine());

double numbersDivide2 = 0;
double numbersDivide3 = 0;
double numbersDivide4 = 0;

for (int i = 0; i < numbersCount; i++)
{
    int numbers = int.Parse(Console.ReadLine());

    if (numbers % 2 == 0)
    {
        numbersDivide2++;
    }
    if (numbers % 3 == 0)
    {
        numbersDivide3++;
    }
    if (numbers % 4 == 0)
    {
        numbersDivide4++;
    }
}
double pursent2 = numbersDivide2 / numbersCount * 100;
double pursent3 = numbersDivide3 / numbersCount * 100;
double pursent4 = numbersDivide4 / numbersCount * 100;

Console.WriteLine($"{pursent2:f2}%");
Console.WriteLine($"{pursent3:f2}%");
Console.WriteLine($"{pursent4:f2}%");


