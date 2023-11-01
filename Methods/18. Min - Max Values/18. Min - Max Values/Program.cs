int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int num = int.Parse(Console.ReadLine());

if (num <= numbers.Length)
{
    int maxNumber = int.MinValue;
    int minNumber = int.MaxValue;

    for (int i = 0; i < num; i++)
    {
        if (numbers[i] > maxNumber)
        {
            maxNumber = numbers[i];
        }
        if (numbers[i] < minNumber)
        {
            minNumber = numbers[i];
        }
    }
    Console.WriteLine(maxNumber);
    Console.WriteLine(minNumber);
}



