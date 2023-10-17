
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int factFirstNumber = CalculateFactorial(num1);
int factSecondNumber = CalculateFactorial(num2);

Console.WriteLine(factFirstNumber / factSecondNumber);


static int CalculateFactorial (int number)
{
    int factoriel = 1;
    for (int i = 1; i <= number; i++)
    {
        factoriel *= i;
    }

    return factoriel;
}

