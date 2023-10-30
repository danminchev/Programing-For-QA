using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        List<int> topIntegers = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            bool isTopInteger = true;
            int currentNumber = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (currentNumber <= numbers[j])
                {
                    isTopInteger = false;
                    break;
                }
            }

            if (isTopInteger)
            {
                topIntegers.Add(currentNumber);
            }
        }

        Console.WriteLine(string.Join(" ", topIntegers));
    }
}

