using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number >= 100 && number <= 200)
        {
            // Числото е в интервала [100...200]
            Console.WriteLine();
        }
        else if (number == 0)
        {
            // Числото е равно на 0
            Console.WriteLine();
        }
        else
        {
            // Числото не е валидно според задачата
            Console.WriteLine("invalid");
        }
    }
}


