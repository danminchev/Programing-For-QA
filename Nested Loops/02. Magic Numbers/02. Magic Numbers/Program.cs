﻿int num = int.Parse(Console.ReadLine());

for (int num1 = 1; num1 <= 9; num1++)
{
    for (int num2 = 0; num2 < 9; num2++)
    {
        for (int num3 = 0; num3 < 9; num3++)
        {
            if (num1 * num2 * num3 == num)
            {
                Console.Write($"{num1} {num2} {num3} ");
            }
        }
    }
}
