using System.Reflection.Metadata;

int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

//double result = Math.Pow(number, power);
int result = 1;

for (int i = 1; i <= power; i++)
{
    result = result * number;
}

Console.WriteLine(result);