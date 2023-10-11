int number = int.Parse(Console.ReadLine());

for (int row = 1; row <= number; row += 1)
{
    for (int column = 1; column <= row; column += 1)
    {
        Console.Write("*");
    }
    //string line = new string ('*', row);

    Console.WriteLine();
}
