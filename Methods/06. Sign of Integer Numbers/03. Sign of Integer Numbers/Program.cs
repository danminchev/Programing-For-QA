static void PrintSignOfNumber(int number)
{
    if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {number} is positive.");
    }
}

int num = int.Parse(Console.ReadLine());

PrintSignOfNumber(num);
