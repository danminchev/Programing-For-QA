using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int bestStart = 0;
        int bestLength = 1;
        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentLength++;

                if (currentLength > bestLength)
                {
                    bestStart = currentStart;
                    bestLength = currentLength;
                }
            }
            else
            {
                currentStart = i;
                currentLength = 1;
            }
        }

        int[] longestSequence = numbers
            .Skip(bestStart)
            .Take(bestLength)
            .ToArray();

        Console.WriteLine(string.Join(" ", longestSequence));
    }
}
