int num = int.Parse(Console.ReadLine());

for (int furstNum = 2; furstNum <= num; furstNum += 2)
{
    for (int secondNum = 1; secondNum <= num; secondNum += 2)
    {
        int result = furstNum * secondNum;

        Console.Write($"{furstNum}{secondNum}{result} ");
    }
}
Console.WriteLine();
