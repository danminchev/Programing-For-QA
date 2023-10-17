static int NumberPower(int number, int power)
{
    int outpud = number;
    for (int i = 1; i <= power - 1; i++)
    {
        outpud *= number;
    }
    return outpud;
}

int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result = NumberPower(number, power);

Console.WriteLine(result);



