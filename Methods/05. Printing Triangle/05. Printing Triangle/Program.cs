static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintTriangle(int num)
{
    for (int currentLine = 1; currentLine <= num; currentLine++)
    {
        PrintLine(1, currentLine);
    }

    for (int currentLine = num - 1; currentLine >= 1; currentLine--)
    {
        PrintLine(1, currentLine);
    }
}

int number = int.Parse(Console.ReadLine());

PrintTriangle(number);


//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    for (int currentLine = 1; currentLine <= i; currentLine++)
//    {
//        Console.Write(currentLine + " ");
//    }
//    Console.WriteLine();
//}
//for (int row = number - 1; row >= 1; row--)
//{
//    for (int col = 1; col <= row; col++)
//    {
//        Console.Write(col + " ");
//    }
//    Console.WriteLine();
//}


